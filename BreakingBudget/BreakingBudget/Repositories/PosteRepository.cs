using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
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

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static int BiggestID()
        {
            object biggestId = DatabaseManager.GetFirstRaw("SELECT MAX(codePoste) FROM " + TABLE_NAME);
            return (biggestId.GetType() != typeof(DBNull)) ? (int)biggestId : 0;
        }

        public static PosteModel[] List()
        {
            OleDbConnection conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING);
            OleDbCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

            conn.Open();
            PosteModel[] data = DataAdapter.OleDbDataReaderToStruct<PosteRepository.PosteModel>(cmd.ExecuteReader()).ToArray();
            conn.Close();

            return data;
        }
    }
}
