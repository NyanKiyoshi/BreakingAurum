using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Repositories
{
    static class PostePonctuelRepository
    {
        public const string TABLE_NAME = "PostePonctuel";

        public class PostePonctuel
        {
            public int codePoste { get; set; }
            public string commentaire { get; set; }

            override public string ToString()
            {
                return codePoste.ToString() + " -> " + this.commentaire;
            }
        }

        /// <summary>
        /// Creates a PostePonctuel entry in the database.
        /// </summary>
        /// 
        /// <param name="dbConn">
        /// The OleDB database instance.
        /// </param>
        /// 
        /// <param name="libPoste">
        /// The poste name (from the table 'Poste')
        /// </param>
        /// 
        /// <param name="comments">
        /// A short description about the entry
        /// </param>
        /// 
        /// <param name="deadLines">
        /// A Key Value Pair List of dates linked to an amount.
        /// </param>
        /// 
        /// <returns></returns>
        public static void
        Create(OleDbConnection dbConn, OleDbTransaction dbTransaction,
            string libPoste, string _comments,
            params KeyValuePair<DateTime, decimal>[] deadLines)
        {
            int transactionCodeType;

            // if there is no comments: put a DBNull value. Otherwise, the comment.
            object comments = _comments == null ? (object)DBNull.Value : _comments;

            // create the Poste
            int codePoste = PosteRepository.Create(dbConn, dbTransaction, libPoste);

            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    "INSERT INTO [{0}] (codePoste, commentaire) VALUES(@codePoste, @commentaire)", TABLE_NAME),
                dbConn, dbTransaction
            );

            cmd.Parameters.AddWithValue("@codePoste",   codePoste);
            cmd.Parameters.AddWithValue("@commentaire", comments);

            Console.WriteLine("<- INSERT INTO PostePonctuel: {0}, {1}", codePoste, comments);
            cmd.ExecuteNonQuery();

            // create the TransactionType
            transactionCodeType = 
                TypeTransactionRepository.CreateUsingIncrementalName(ref libPoste, dbConn, dbTransaction);

            foreach (KeyValuePair<DateTime, decimal> deadline in deadLines) {
                EcheanceRepository.Create(dbConn,
                    dbTransaction, ref codePoste, ref transactionCodeType,
                    ref libPoste, deadline.Key, deadline.Value > 0 ? deadline.Value * -1 : deadline.Value);
            }
        }

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static PostePonctuel[] List()
        {
            using (OleDbConnection conn = DatabaseManager.CreateConnection())
            {
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

                conn.Open();
                return DataAdapter.OleDbDataReaderToStruct<PostePonctuel>(cmd.ExecuteReader()).ToArray();
            }
        }
    }
}
