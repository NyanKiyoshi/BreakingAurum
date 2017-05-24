using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Repositories
{
    static class PersonneRepository
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
                return this.nomPersonne;
            }
        }

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }
    }
}
