using System.Data.OleDb;

namespace BreakingBudget.Repositories
{
    public static class PostePeriodiqueRepository
    {
        public const string TABLE_NAME = "PostePeriodique";

        public class PostePeriodiqueModel
        {
            public int codePoste { get; set; }
            public int typePer { get; set; }
            public decimal montant { get; set; }
            public int jourDuMois { get; set; }

            public string libPer_s   { get; set; }
            public string libPoste_s { get; set; }

            override public string ToString()
            {
                return codePoste.ToString() + " -> " + this.libPoste_s;
            }
        }

        public static void
        Update(OleDbConnection dbConn, OleDbTransaction dbTransaction,
            PostePeriodiqueModel originalEntry, PostePeriodiqueModel newEntry)
        {
            OleDbCommand cmd;

            // if the day is invalid, throw ArgumentException
            PosteRepository.CheckDayRangeOrThrow(newEntry.jourDuMois);

            cmd = new OleDbCommand("UPDATE " + TABLE_NAME + " SET montant = @amount, typePer = @typePer, jourDuMois = @jourDuMois"
                                     + " WHERE codePoste = @codePoste", dbConn, dbTransaction);
            cmd.Parameters.AddWithValue("@amount", (newEntry.montant > 0 ? newEntry.montant * -1 : newEntry.montant).ToString());
            cmd.Parameters.AddWithValue("@typePer", newEntry.typePer);
            cmd.Parameters.AddWithValue("@jourDuMois", newEntry.jourDuMois);
            cmd.Parameters.AddWithValue("@codePoste", originalEntry.codePoste);

            cmd.ExecuteNonQuery();

            // if the poste title changed, update it
            if (originalEntry.libPoste_s != null
                && newEntry.libPoste_s != null
                && !originalEntry.libPoste_s.Equals(newEntry.libPoste_s))
            {
                PosteRepository.Update(dbConn, dbTransaction, originalEntry.codePoste, newEntry.libPoste_s);
            }
        }
    }
}
