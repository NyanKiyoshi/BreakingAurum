using System;
using System.Data.OleDb;

namespace BreakingBudget.Repositories
{
    static class PostePeriodiqueRepositoryRepository
    {
        public const string TABLE_NAME = "PostePeriodiqueRepository";

        public class PostePeriodiqueRepository
        {
            public int      codePoste     { get; set; }
            public decimal  typePer       { get; set; }
            public decimal  montant       { get; set; }
            public int      jourDuMois    { get; set; }

            public string   libPoste_s    { get; set; }

            override public string ToString()
            {
                return codePoste.ToString() + " -> " + this.libPoste_s ;
            }
        }

        public static void
        Update(OleDbConnection dbConn, OleDbTransaction dbTransaction,
            PostePeriodiqueRepository originalEntry, PostePeriodiqueRepository newEntry)
        {
            OleDbCommand cmd;

            // if the day is invalid, throw ArgumentException
            PosteRepository.CheckDayRangeOrThrow(newEntry.jourDuMois);

            // if the poste title changed, update it
            if (originalEntry.libPoste_s != null
                && newEntry.libPoste_s != null
                && !originalEntry.libPoste_s.Equals(newEntry.libPoste_s))
            {
                PosteRepository.Update(dbConn, dbTransaction, newEntry.codePoste, newEntry.libPoste_s);
            }

            cmd = new OleDbCommand("UPDATE " + TABLE_NAME + "SET montant = @amount, typePer = @typePer, jourDuMois = @jourDuMois"
                                     + "WHERE codePoste = @codePoste");
            cmd.Parameters.AddWithValue("@amount",      newEntry.montant);
            cmd.Parameters.AddWithValue("@typePer",     newEntry.typePer);
            cmd.Parameters.AddWithValue("@jourDuMois",  originalEntry.jourDuMois);
            cmd.Parameters.AddWithValue("@codePoste",   originalEntry.codePoste);

            cmd.ExecuteNonQuery();
        }
    }
}
