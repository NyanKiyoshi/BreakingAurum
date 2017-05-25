using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MetroFramework.Controls;
using MetroFramework;

namespace BreakingBudget.Views.FrmMain
{
    partial class FrmMain
    {
        void InitSettingsPage() {
            FillLanguageComboBox();
        }

        void FillLanguageComboBox() {
            this.LanguageComboBox.Items.Clear();
            this.LanguageComboBox.ResetText();

            this.LanguageComboBox.DisplayMember = "NativeName";

            // TODO: set selected to the current one
            this.LanguageComboBox.Items.AddRange(
                this.Localize.RetrieveAvailableLanguages()
                .Select(
                    s => {
                        // convert the two letter ISO language name's to a CultureInfo object
                        return new CultureInfo(s);
                    }
                ).ToArray()
            );
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroComboBox comboBox = (MetroComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                MessageBox.Show(((CultureInfo)comboBox.SelectedItem).TwoLetterISOLanguageName);
                if (MetroMessageBox.Show(this, this.Localize.Translate("requires_restart"), this.Localize.Translate("requires_confirmation"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.WaitsForRestart = true;
                    this.Close();
                }
            }
        }
    }
}
