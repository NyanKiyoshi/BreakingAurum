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
            public string   dateTransaction { get; set; }
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

        // Counts the number of rows of the table
        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static TransactionModel[] GetByMonth(int month)
        {
            return TransactionRepository.GetByMonth(month, DateTime.Now.Year);
        }

        public static TransactionModel[] GetByMonth(int month, int year)
        {
            OleDbConnection conn = DatabaseManager.CreateConnection();
            OleDbCommand cmd = conn.CreateCommand();

            cmd.CommandText = string.Format(
                @"SELECT [transac.codeTransaction], [transac.dateTransaction], 
                         [transac.description],     [transac.montant],
                         [transac.recetteON],       [transac.percuON],
                         [transac.type],
                         [typeTransac.libType] AS typeTransaction_s

                  FROM [{0}] transac, [{1}] typeTransac

                  WHERE Month(dateTransaction) = {2}
                          AND Year(dateTransaction) = {3}
                          AND typeTransac.codeType = transac.type",
                
                TABLE_NAME, TypeTransactionRepository.TABLE_NAME, month, year
            );

            conn.Open();
            TransactionModel[] data = DataAdapter.OleDbDataReaderToStruct<TransactionRepository.TransactionModel>(cmd.ExecuteReader()).ToArray();
            conn.Close();

            return data;
        }
    }
}
