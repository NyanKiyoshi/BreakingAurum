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
        Create(OleDbConnection dbConn, OleDbTransaction transaction,
            string libPoste, string comments,
            params KeyValuePair<DateTime, decimal>[] deadLines)
        {
            // create the Poste
            int codePoste = PosteRepository.Create(dbConn, transaction, libPoste);

            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    "INSERT INTO [{0}] (codePoste, commentaire) VALUES(@codePoste, @commentaire)", TABLE_NAME),
                dbConn, transaction
            );

            cmd.Parameters.AddWithValue("@codePoste",   codePoste);
            cmd.Parameters.AddWithValue("@commentaire", comments == null ? (object)DBNull.Value : comments);

            Console.WriteLine("<- INSERT INTO PostePonctuel: {0}, {1}", codePoste, comments);
            cmd.ExecuteNonQuery();

            foreach (KeyValuePair<DateTime, decimal> deadline in deadLines) {
                EcheanceRepository.Create(dbConn, transaction, codePoste, deadline.Key, deadline.Value);
            }
        }

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static PostePonctuel[] List()
        {
            OleDbConnection conn = DatabaseManager.CreateConnection();
            OleDbCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

            conn.Open();
            PostePonctuel[] data = DataAdapter.OleDbDataReaderToStruct<PostePonctuel>(cmd.ExecuteReader()).ToArray();
            conn.Close();

            return data;
        }
    }
}
