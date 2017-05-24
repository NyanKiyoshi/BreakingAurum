using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace BreakingBudget.Services.SQL
{
    // usefull link: https://msdn.microsoft.com/en-us/library/ms971481.aspx
    static class DatabaseManager
    {
        public const string CONNEXION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./../../Resources/budget1.mdb;Persist Security Info=True";

        private static DataSet _CachedSchemaTable;

        public static void GenerateDatabaseCache()
        {
            DatabaseManager._CachedSchemaTable = DatabaseManager.GetTableSchema();
        }

        private static DataTable GetFullTableSchema()
        {
            using (OleDbConnection db_conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING))
            {
                db_conn.Open();
                return db_conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            }
        }

        private static DataSet GetTableSchema()
        {
            using (OleDbConnection db_conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING))
            {
                db_conn.Open();

                DataSet tablesFromDB = new DataSet();
                DataTable Schemas = GetFullTableSchema();

                foreach (DataRow row in Schemas.Rows)
                {
                    DataTable dt = new DataTable();
                    OleDbCommand command = new OleDbCommand(String.Format(@"SELECT * FROM [" + row["TABLE_NAME"]) + "];", db_conn);
                    dt.Load(command.ExecuteReader(CommandBehavior.SchemaOnly));

                    dt.TableName = row["TABLE_NAME"] as String;
                    tablesFromDB.Tables.Add(dt);
                }
                // TODO: cache it and update it on table modification
                return tablesFromDB;
            }
        }

        public static DataTableCollection GetCachedTableSchema()
        {
            return DatabaseManager._CachedSchemaTable.Tables;
        }

        public static OleDbDataReader IterCommand(OleDbCommand Command)
        {
            using (OleDbConnection db_conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING))
            {
                Command.Connection = db_conn;

                db_conn.Open();

                // FIXME: should iter
                return Command.ExecuteReader();
            }
        }

        public static OleDbDataReader ExecuteRawSQL(string RawSQLCommand)
        {
            return DatabaseManager.IterCommand(new OleDbCommand(RawSQLCommand));
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
