using System;
using System.Linq;
using System.Data.OleDb;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Repositories
{
    static class TransactionRepository
    {
        public const string TABLE_NAME = "Transaction";

        public class TransactionModel
        {
            public int      codeTransaction { get; set; }
            public DateTime dateTransaction { get; set; }
            public string   description     { get; set; }
            public double   montant         { get; set; }
            public bool     recetteON       { get; set; }
            public bool     percuON         { get; set; }
            public int      type            { get; set; }

            // from the table TypeTransaction
            public string typeTransaction_s { get; set; }

            override public string ToString()
            {
                return this.description;
            }
        }

        public static void Create(
            OleDbConnection dbConn,
            OleDbTransaction dbTransaction,
            ref int transactionTypeCode,
            ref string title,
            DateTime dt,
            ref decimal amount
        )
        {
            int codeTransaction = BiggestID(dbConn, dbTransaction) + 1;

            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    @"INSERT INTO [{0}] (
                                codeTransaction,   dateTransaction,  description,
                                montant,           recetteON,        percuON,
                                type
                      ) VALUES(@codeTransaction,  @dateTransaction, @description,
                               @montant,          @recetteON,       @percuON,
                               @type)", TABLE_NAME),
                dbConn, dbTransaction
            );

            cmd.Parameters.AddWithValue("@codeTransaction",   codeTransaction);
            cmd.Parameters.AddWithValue("@dateTransaction",   OleDbType.Date).Value = dt.Date;
            cmd.Parameters.AddWithValue("@description",       title);
            cmd.Parameters.AddWithValue("@montant",           amount);
            cmd.Parameters.AddWithValue("@recetteON",         false);
            cmd.Parameters.AddWithValue("@percuON",           false);
            cmd.Parameters.AddWithValue("@type",              transactionTypeCode);

            Console.WriteLine("<- INSERT INTO Transaction");
            cmd.ExecuteNonQuery();
        }

        // Counts the number of rows of the table
        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        // Gets the biggest codeTransaction existing in the database
        public static int BiggestID(OleDbConnection dbConn, OleDbTransaction dbTransaction)
        {
            OleDbCommand cmd = dbConn.CreateCommand();
            cmd.Transaction = dbTransaction;
            cmd.CommandText = "SELECT MAX(codeTransaction) FROM [" + TABLE_NAME + "]";

            object biggestId = cmd.ExecuteScalar();
            return (biggestId.GetType() != typeof(DBNull)) ? (int)biggestId : 0;
        }

        public static TransactionModel[] GetByMonth(int month)
        {
            return TransactionRepository.GetByMonth(month, DateTime.Now.Year);
        }

        public static TransactionModel[] GetByMonth(int month, int year)
        {
            using (OleDbConnection conn = DatabaseManager.CreateConnection())
            {
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format(
                    @"SELECT [transac.codeTransaction]  AS codeTransaction,
                         [transac.dateTransaction]  AS dateTransaction, 
                         [transac.description]      AS description,
                         [transac.montant]          AS montant,
                         [transac.recetteON]        AS recetteON,
                         [transac.percuON]          AS percuON,
                         [transac.type]             AS [type],
                         [typeTransac.libType]      AS typeTransaction_s

                      FROM [{0}] transac, [{1}] typeTransac

                      WHERE Month(dateTransaction) = {2}
                              AND Year(dateTransaction) = {3}
                              AND typeTransac.codeType = transac.type",

                    TABLE_NAME, TypeTransactionRepository.TABLE_NAME, month, year
                );

                conn.Open();
                return DataAdapter.OleDbDataReaderToStruct<TransactionRepository.TransactionModel>(cmd.ExecuteReader()).ToArray();
            }
        }
    }
}
