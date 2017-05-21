using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingBudget.Services;

namespace BreakingBudget.Repositories
{
    static class PersonneRepository
    {
        public const string TABLE_NAME = "Personne";

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }
    }
}
