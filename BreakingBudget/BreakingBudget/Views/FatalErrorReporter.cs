using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            // TODO: open a web page
        }
    }
}
