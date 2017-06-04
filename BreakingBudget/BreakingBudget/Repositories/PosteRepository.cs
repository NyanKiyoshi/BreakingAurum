using System;
using System.Linq;
using System.Data.OleDb;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Repositories
{
    static class PosteRepository
    {
        public const string TABLE_NAME = "Poste";

        public class PosteModel
        {
            public int codePoste { get; set; }
            public string libPoste { get; set; }

            override public string ToString()
            {
                return this.libPoste;
            }
        }

        public static int
            Create(OleDbConnection dbConn, OleDbTransaction transaction,
                   int codePoste, string libPoste)
        {
            OleDbCommand cmd = new OleDbCommand(
                "INSERT INTO Poste (codePoste, libPoste) VALUES(@codePoste, @libPoste)",
                dbConn, transaction);

            cmd.Parameters.AddWithValue("@codePoste", codePoste);
            cmd.Parameters.AddWithValue("@libPoste", libPoste);

            cmd.ExecuteNonQuery();

            // + TODO: DatabaseManager.HandleError(e)
            return codePoste;
        }

        public static int
            Create(OleDbConnection dbConn, OleDbTransaction transaction, string libPoste)
        {
            return Create(
                dbConn,
                transaction,

                // retrieves the biggest identifier in the table and increment it
                BiggestID() + 1,
                libPoste
            );
        }

        // Counts the number of rows of the table
        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        // Gets the biggest codePoste existing in the database
        public static int BiggestID()
        {
            object biggestId = DatabaseManager.GetFirstRaw("SELECT MAX(codePoste) FROM " + TABLE_NAME);
            return (biggestId.GetType() != typeof(DBNull)) ? (int)biggestId : 0;
        }

        // Checks if the given title (libPoste) is unique or not
        public static bool IsUnique(string libPoste)
        {
            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    "SELECT COUNT(*) FROM [{0}] WHERE libPoste = @libPoste", TABLE_NAME
                )
            );
            cmd.Parameters.AddWithValue("@libPoste", libPoste);

            return ((int)DatabaseManager.GetFirst(cmd)) == 0;
        }

        /// <summary>
        /// Is the "poste" not used yet?
        /// </summary>
        /// <param name="codePoste"></param>
        /// <returns></returns>
        public static bool IsAvailable(int codePoste)
        {
            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    @"SELECT COUNT(*) FROM [{0}] a, [{1}] b, [{2}] c 
                        WHERE a.codePoste = @codePoste
                                OR b.codePoste = @codePoste
                                OR c.codePoste = @codePoste",
                    PostePonctuelRepository.TABLE_NAME, "PostePeriodique", PosteRevenuRepository.TABLE_NAME)
                );
            cmd.Parameters.AddWithValue("@codePoste", codePoste);

            return ((int)DatabaseManager.GetFirst(cmd)) == 0;
        }

        public static PosteModel[] ListAvailableToUse()
        {
            using (OleDbConnection conn = DatabaseManager.CreateConnection())
            {
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format(
                    @"SELECT codePoste, libPoste FROM [{0}]
                      WHERE   codePoste NOT IN (SELECT codePoste FROM [{1}])
                          AND codePoste NOT IN (SELECT codePoste FROM [{2}])
                          AND codePoste NOT IN (SELECT codePoste FROM [{3}])",
                    PosteRepository.TABLE_NAME,
                    PostePonctuelRepository.TABLE_NAME,
                    "PostePeriodique",
                    PosteRevenuRepository.TABLE_NAME
                );

                conn.Open();
                return DataAdapter.OleDbDataReaderToStruct<PosteRepository.PosteModel>(cmd.ExecuteReader()).ToArray();
            }
        }

        public static PosteModel[] List()
        {
            using (OleDbConnection conn = DatabaseManager.CreateConnection())
            {
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

                conn.Open();
                return DataAdapter.OleDbDataReaderToStruct<PosteRepository.PosteModel>(cmd.ExecuteReader()).ToArray();
            }
        }
    }
}
