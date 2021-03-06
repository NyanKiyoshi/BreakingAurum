﻿using System.Data.OleDb;
using System.Linq;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Repositories
{
    public static class PersonneRepository
    {
        public const string TABLE_NAME = "Personne";

        public class PersonneModel
        {
            public int codePersonne { get; set; }
            public string nomPersonne { get; set; }
            public string pnPersonne { get; set; }
            public string telMobile { get; set; }

            override public string ToString()
            {
                return this.nomPersonne + " " + this.pnPersonne;
            }
        }

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static PersonneModel[] List()
        {
            using (OleDbConnection conn = DatabaseManager.GetConnection())
            {
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

                conn.Open();
                return DataAdapter.OleDbDataReaderToStruct<PersonneModel>(cmd.ExecuteReader()).ToArray();
            }
        }
    }
}
