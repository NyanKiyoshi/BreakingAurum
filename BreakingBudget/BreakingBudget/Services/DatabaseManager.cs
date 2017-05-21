using System.Data.OleDb;


namespace BreakingBudget.Services
{
    // usefull link: https://msdn.microsoft.com/en-us/library/ms971481.aspx
    static class DatabaseManager
    {
        public const string CONNEXION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./../../Resources/budget1.mdb;Persist Security Info=True";


        public static OleDbDataReader ExecuteCommand(OleDbCommand Command)
        {
            using (OleDbConnection db_conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING))
            {
                Command.Connection = db_conn;

                db_conn.Open();

                return Command.ExecuteReader();
            }
        }

        public static OleDbDataReader ExecuteRawSQL(string RawSQLCommand)
        {
            return DatabaseManager.ExecuteCommand(new OleDbCommand(RawSQLCommand));
        }

        public static object GetFirst(OleDbCommand Command)
        {
            using (OleDbConnection db_conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING))
            {
                Command.Connection = db_conn;

                db_conn.Open();

                return Command.ExecuteScalar();
            }
        }

        public static object GetFirstRaw(string RawSQLCommand)
        {
            return DatabaseManager.GetFirst(new OleDbCommand(RawSQLCommand));
        }
    }
}
