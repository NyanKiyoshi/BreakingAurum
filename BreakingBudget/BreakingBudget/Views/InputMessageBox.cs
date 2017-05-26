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
    public partial class InputMessageBox : MetroForm
    {
        public string userInput
        {
            get
            {
                return this.textBoxInput.Text;
            }
        }

        private bool _userCancelled;
        public bool userCancelled {
            get
            {
                return this._userCancelled;
            }
        }

        public InputMessageBox(string caption, string text, string placeholder)
        {
            InitializeComponent();

            this.SubmitBtn.Text = Program.settings.localize.Translate("Cancel");
            this.cancelBtn.Text = Program.settings.localize.Translate("Submit");

            this.Text = caption;

            if (string.IsNullOrEmpty(text))
            {
                this.lblDescription.Visible = false;
            }
            else
            {
                this.lblDescription.Text = text;
            }

            if (placeholder != null)
            {
                this.textBoxInput.WaterMark = placeholder;
            }

            this.Refresh();
            this.textBoxInput.Focus();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this._userCancelled = true;
            this.Close();
        }
    }
}
