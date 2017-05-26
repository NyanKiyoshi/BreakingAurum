using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreakingBudget.Views.FrmMain;
using BreakingBudget.Repositories;
using BreakingBudget.Services.SQL;
using BreakingBudget.Services;

namespace BreakingBudget
{
    static class Program
    {
        public static Settings settings;

        static void RunApp()
        {
            FrmMain MainForm;
            UserCreation CreationForm;

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

            // run the Main form and restart it if it asks so
            do
            {
                MainForm = new FrmMain();
                Application.Run(MainForm);
            } while (MainForm.WaitsForRestart);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cache the database's scheme
            DatabaseManager.GenerateDatabaseCache();

            // load settings from saved data if available. Otherwise: create settings
            Program.settings = Settings.Load();
            if (Program.settings == null)
            {
                Program.settings = new Settings();
            }

            // if the DEBUG symbol is not defined (release or test mode),
            // we redirect the console output to "logs.txt"
#if !DEBUG
            using (FileStream fs = File.Open(@"logs.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.SetOut(sw);
                    RunApp();
                }
            }
#else
            RunApp();
#endif
        }
    }
}
