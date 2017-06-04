using System;
using System.Text;
using System.Diagnostics;
using MetroFramework.Forms;
using BreakingBudget.Services;
using BreakingBudget.Services.Lang;

namespace BreakingBudget.Views
{
    public partial class FatalErrorReporter : MetroForm
    {
        private const string APP_SUPPORT_WEBSITE = "https://breaking.kisune.com";
        private const string APP_SUPPORT_PHONE_NUMBER = "+33 6 15 95 11 64";

        public FatalErrorReporter(string errorData)
        {
            InitializeComponent();

            this.Text = Program.settings.localize.Translate(this.Text);
            Program.settings.localize.ControlerTranslator(this);

            this.errorDataTextBox.Text = errorData;
        }

        /// <summary>
        /// Sends a SMS of the base64 encoded error stack to one of the developers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendError_Click(object sender, EventArgs e)
        {
            SMSManager.SendSMS(new string[] { APP_SUPPORT_PHONE_NUMBER },
                Convert.ToBase64String(Encoding.UTF8.GetBytes(this.errorDataTextBox.Text)));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAskForSupport_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(APP_SUPPORT_WEBSITE);
            Process.Start(sInfo);
        }
    }
}
