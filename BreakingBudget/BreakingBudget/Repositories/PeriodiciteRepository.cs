﻿using System.Linq;
using System.Data.OleDb;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Repositories
{
    static class PeriodiciteRepository
    {
        public const string TABLE_NAME = "Periodicite";

        public class PeriodiciteModel
        {
            public int codePer { get; set; }
            public string libPer { get; set; }

            override public string ToString()
            {
                return this.libPer;
            }
        }

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static PeriodiciteModel[] List()
        {
            using (OleDbConnection conn = DatabaseManager.GetConnection())
            {
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM " + TABLE_NAME;

                conn.Open();
                return DataAdapter.OleDbDataReaderToStruct<PeriodiciteModel>(cmd.ExecuteReader()).ToArray();
            }
        }
    }
}
