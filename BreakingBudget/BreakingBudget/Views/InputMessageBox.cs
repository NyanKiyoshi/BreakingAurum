using System;
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

        public void EnableStyling()
        {
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;

            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;

            this.Refresh();
        }

        public InputMessageBox(string caption, string text, string placeholder)
        {
            InitializeComponent();
            EnableStyling();

            this.cancelBtn.Text = Program.settings.localize.Translate("Cancel");
            this.SubmitBtn.Text = Program.settings.localize.Translate("Submit");

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
