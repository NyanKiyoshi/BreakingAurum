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

            this.ThemeStyleComboBox.DataSource = Enum.GetValues(typeof(MetroThemeStyle));
            this.VariantStyleComboBox.DataSource = Enum.GetValues(typeof(MetroColorStyle));

            this.ThemeStyleComboBox.SelectedIndex = (int)settings.MetroTheme;
            this.VariantStyleComboBox.SelectedIndex = (int)settings.MetroColorStyle;
        }

        void FillLanguageComboBox() {
            CultureInfo c;
            string[] availableLangs = this.Localize.RetrieveAvailableLanguages();

            this.LanguageComboBox.Items.Clear();
            this.LanguageComboBox.ResetText();

            this.LanguageComboBox.DisplayMember = "NativeName";

            for (int i = 0; i < availableLangs.Length; ++i)
            {
                c = new CultureInfo(availableLangs[i]);
                this.LanguageComboBox.Items.Add(c);

                if (c.TwoLetterISOLanguageName == this.Localize.currentLanguage)
                {
                    this.LanguageComboBox.SelectedItem = c;
                }
            }
        }

        private void ThemeStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MetroThemeStyle selectedTheme;
            if (Enum.TryParse(ThemeStyleComboBox.SelectedItem.ToString(), out selectedTheme))
            {
                this.settings.MetroTheme = this.metroStyleManager.Theme = selectedTheme;
            }
            FrmMain_StyleChanged(null, null);
        }

        private void VariantStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MetroColorStyle selectedColor;
            if (Enum.TryParse(VariantStyleComboBox.SelectedItem.ToString(), out selectedColor))
            {
                this.settings.MetroColorStyle =  this.metroStyleManager.Style = selectedColor;
            }
            FrmMain_StyleChanged(null, null);
        }

        private void LanguageComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MetroComboBox comboBox = (MetroComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                this.settings.TwoLetterISOLanguage = ((CultureInfo)comboBox.SelectedItem).TwoLetterISOLanguageName;
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
