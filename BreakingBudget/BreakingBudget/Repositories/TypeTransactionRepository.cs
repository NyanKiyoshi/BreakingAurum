using System;
using System.Data.OleDb;

namespace BreakingBudget.Repositories
{
    static class TypeTransactionRepository
    {
        public const string TABLE_NAME = "TypeTransaction";

        public class TypeTransaction
        {
            public int codeType { get; set; }
            public string libType { get; set; }

            override public string ToString()
            {
                return this.libType;
            }
        }

        /// <summary>
        /// Create a new type from a given libType. It is not mandatory to give a unique name.
        /// If the name (libType) is not unique, we append to it " ({tryNo})".
        /// </summary>
        /// <param name="dbConn"></param>
        /// <param name="dbTransaction"></param>
        /// <param name="_libType"></param>
        public static int CreateUsingIncrementalName(
            ref string _libType,
            OleDbConnection dbConn,
            OleDbTransaction dbTransaction
        )
        {
            // copy the base lib reference to an independant string
            string libType = _libType;
            int codeType;

            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    @"INSERT INTO [{0}] (codeType, libType) VALUES(@codeType,  @libType)",
                    TABLE_NAME
                ),
                dbConn, dbTransaction
            );

            // increment the number while the name is not available
            // TODO: async timeout?
            int i = 0;
            while (!IsUnique(libType, dbConn, dbTransaction))
            {
                libType = _libType + " (" + i + ")";
                ++i;
            }

            // get the biggest ID and increment it
            codeType = BiggestID(dbConn, dbTransaction) + 1;

            cmd.Parameters.AddWithValue("@codeType", codeType);
            cmd.Parameters.AddWithValue("@libType", libType);

            Console.WriteLine("<- INSERT INTO TypeTransaction");
            cmd.ExecuteNonQuery();

            return codeType;
        }

        // Gets the biggest codeType existing in the database
        public static int BiggestID(OleDbConnection dbConn, OleDbTransaction dbTransaction)
        {
            OleDbCommand cmd = dbConn.CreateCommand();
            cmd.Transaction = dbTransaction;
            cmd.CommandText = "SELECT MAX(codeType) FROM [" + TABLE_NAME + "]";

            object biggestId = cmd.ExecuteScalar();
            return (biggestId.GetType() != typeof(DBNull)) ? (int)biggestId : 0;
        }

        // Checks if the given title (libType) is unique or not
        public static bool IsUnique(string libType, OleDbConnection dbConn, OleDbTransaction dbTransaction)
        {
            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    "SELECT COUNT(*) FROM [{0}] WHERE libType = @libType", TABLE_NAME
                ),
                dbConn, dbTransaction
            );
            cmd.Parameters.AddWithValue("@libType", libType);

            return ((int)cmd.ExecuteScalar()) == 0;
        }
    }
}
