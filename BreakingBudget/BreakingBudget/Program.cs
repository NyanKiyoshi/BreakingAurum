using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreakingBudget.Views.FrmMain;
using BreakingBudget.Repositories;
using BreakingBudget.Services.SQL;

namespace BreakingBudget
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserCreation CreationForm;

            // Cache the database's scheme
            DatabaseManager.GenerateDatabaseCache();

            // If there is nobody in the database, open the creation form
            while (PersonneRepository.CountRows() == 0)
            {
                CreationForm = new UserCreation();
                Application.Run(CreationForm);

                // Stop user cancelled the user creation, close the program
                if (CreationForm.UserCancelled)
                {
                    return;
                }
            }

            Application.Run(new FrmMain());
        }
    }
}
