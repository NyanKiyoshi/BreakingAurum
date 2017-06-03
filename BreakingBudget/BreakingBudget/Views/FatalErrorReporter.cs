using System;
using System.Diagnostics;
using MetroFramework.Forms;

namespace BreakingBudget.Views
{
    public partial class FatalErrorReporter : MetroForm
    {
        public FatalErrorReporter(string errorData)
        {
            InitializeComponent();

            this.Text = Program.settings.localize.Translate(this.Text);
            Program.settings.localize.ControlerTranslator(this);

            this.errorDataTextBox.Text = errorData;
        }

        private void btnSendError_Click(object sender, EventArgs e)
        {
            // TODO: implement this: send me a SMS
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAskForSupport_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://breaking.kisune.com");
            Process.Start(sInfo);
        }
    }
}
