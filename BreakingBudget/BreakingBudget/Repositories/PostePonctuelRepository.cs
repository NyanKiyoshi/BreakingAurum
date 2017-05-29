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

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static PostePonctuel[] List()
        {
            OleDbConnection conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING);
            OleDbCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

            conn.Open();
            PostePonctuel[] data = DataAdapter.OleDbDataReaderToStruct<PostePonctuel>(cmd.ExecuteReader()).ToArray();
            conn.Close();

            return data;
        }
    }
}
