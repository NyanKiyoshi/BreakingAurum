using System;
using System.Linq;
using System.Data.OleDb;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Repositories
{
    public static class PosteRevenuRepository
    {
        public const string TABLE_NAME = "PosteRevenu";

        public class PosteRevenu
        {
            public int      codePoste     { get; set; }
            public int      codePersonne  { get; set; }
            public decimal  montant       { get; set; }
            public int      jourDuMois    { get; set; }

            public string   libPoste_s    { get; set; }
            public string   personne_s    { get; set; }

            override public string ToString()
            {
                return codePoste.ToString() + " -> " + this.libPoste_s ;
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
            string poste, PersonneRepository.PersonneModel beneficiary,
            decimal amount, int everyXOfTheMonth)
        {
            // create the Poste
            int codePoste = PosteRepository.Create(dbConn, transaction, poste);

            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    @"INSERT INTO [{0}] ( codePoste,  codePersonne,  montant,  jourDuMois)
                                 VALUES (@codePoste, @codePersonne, @montant, @jourDuMois)", TABLE_NAME),
                dbConn, transaction
            );

            cmd.Parameters.AddWithValue("@codePoste",     codePoste);
            cmd.Parameters.AddWithValue("@codePersonne",  beneficiary.codePersonne);
            cmd.Parameters.AddWithValue("@montant",       amount.ToString());
            cmd.Parameters.AddWithValue("@jourDuMois",    everyXOfTheMonth);

            Console.WriteLine("<- INSERT INTO PosteRevenu: {0}, {1}, {2}, {3}",
                codePoste, beneficiary.codePersonne, amount, everyXOfTheMonth);
            cmd.ExecuteNonQuery();
        }

        public static void
        Update(OleDbConnection dbConn, OleDbTransaction dbTransaction,
            PosteRevenu originalEntry, PosteRevenu newEntry)
        {
            OleDbCommand cmd;

            // if the day is invalid, throw ArgumentException
            PosteRepository.CheckDayRangeOrThrow(newEntry.jourDuMois);

            cmd = new OleDbCommand("UPDATE " + TABLE_NAME
                                     + " SET montant = @amount, codePersonne = @codePer, jourDuMois = @jourDuMois"
                                     + " WHERE codePoste = @codePoste", dbConn, dbTransaction);
            cmd.Parameters.AddWithValue("@amount",        newEntry.montant.ToString());
            cmd.Parameters.AddWithValue("@codePersonne",  newEntry.codePersonne);
            cmd.Parameters.AddWithValue("@jourDuMois",    newEntry.jourDuMois);
            cmd.Parameters.AddWithValue("@codePoste",     originalEntry.codePoste);

            cmd.ExecuteNonQuery();

            // if the poste title changed, update it
            if (originalEntry.libPoste_s != null
                && newEntry.libPoste_s != null
                && !originalEntry.libPoste_s.Equals(newEntry.libPoste_s))
            {
                PosteRepository.Update(dbConn, dbTransaction, originalEntry.codePoste, newEntry.libPoste_s);
            }
        }

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static PosteRevenu[] List()
        {
            using (OleDbConnection conn = DatabaseManager.GetConnection())
            {
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

                conn.Open();
                return DataAdapter.OleDbDataReaderToStruct<PosteRevenu>(cmd.ExecuteReader()).ToArray();
            }
        }
    }
}
