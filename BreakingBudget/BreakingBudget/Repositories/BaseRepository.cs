using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingBudget.Services;

namespace BreakingBudget.Repositories
{
    abstract class BaseRepository
    {
        //public static readonly string TABLE_NAME = null;
        public const string TABLE_NAME = "???";

        public static int CountRows()
        {
            MessageBox.Show("SELECT COUNT(*) FROM " + TABLE_NAME);
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }
    }
}
