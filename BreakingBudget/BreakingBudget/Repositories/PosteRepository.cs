using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingBudget.Services;

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
                return String.Format("codePoste: {0}\nlibPoste: {1}", this.codePoste, this.libPoste);
            }
        }

        public static int CountRows()
        {
            return (int)DatabaseManager.GetFirstRaw("SELECT COUNT(*) FROM " + TABLE_NAME);
        }

        public static int IterList()
        {
            //return (int)DatabaseManager.ExecuteRawSQL("SELECT COUNT(*) FROM " + TABLE_NAME);
            return 0;
        }
    }
}
