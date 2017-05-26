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
            this.VariantStyleComboBox.DisplayMember = 
                this.ThemeStyleComboBox.DisplayMember = "Key";

            FillLanguageComboBox();

            this.FillSettingsThemingComoboxes();

            this.ThemeStyleComboBox.SelectedIndex = (int)Program.settings.MetroTheme;
            this.VariantStyleComboBox.SelectedIndex = (int)Program.settings.MetroColorStyle;
        }

        void FillSettingsThemingComoboxes()
        {
            foreach (MetroThemeStyle e in Enum.GetValues(typeof(MetroThemeStyle)))
            {
                this.ThemeStyleComboBox.Items.Add(
                    new KeyValuePair<string, MetroThemeStyle>(
                        Program.settings.localize.Translate(e.ToString()), e)
                );
            }
            foreach (MetroColorStyle e in Enum.GetValues(typeof(MetroColorStyle)))
            {
                this.VariantStyleComboBox.Items.Add(
                    new KeyValuePair<string, MetroColorStyle>(
                        Program.settings.localize.Translate(e.ToString()), e)
                );
            }
        }

        void FillLanguageComboBox() {
            CultureInfo c;
            string[] availableLangs = Program.settings.localize.RetrieveAvailableLanguages();

            this.LanguageComboBox.Items.Clear();
            this.LanguageComboBox.ResetText();

            this.LanguageComboBox.DisplayMember = "NativeName";

            for (int i = 0; i < availableLangs.Length; ++i)
            {
                c = new CultureInfo(availableLangs[i]);
                this.LanguageComboBox.Items.Add(c);

                if (c.TwoLetterISOLanguageName == Program.settings.localize.currentLanguage)
                {
                    this.LanguageComboBox.SelectedItem = c;
                }
            }
        }

        private void ThemeStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ThemeStyleComboBox.SelectedItem != null)
            {
                Program.settings.MetroTheme = this.metroStyleManager.Theme = 
                    ((KeyValuePair<string, MetroThemeStyle>)ThemeStyleComboBox.SelectedItem).Value;
            }
            FrmMain_StyleChanged(null, null);
        }

        private void VariantStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (VariantStyleComboBox.SelectedItem != null)
            {
                Program.settings.MetroColorStyle =  this.metroStyleManager.Style =
                    ((KeyValuePair<string, MetroColorStyle>)VariantStyleComboBox.SelectedItem).Value;
            }
            FrmMain_StyleChanged(null, null);
        }

        private void LanguageComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MetroComboBox comboBox = (MetroComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                Program.settings.TwoLetterISOLanguage = ((CultureInfo)comboBox.SelectedItem).TwoLetterISOLanguageName;
                if (MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("requires_restart"), Program.settings.localize.Translate("requires_confirmation"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.WaitsForRestart = true;
                    this.Close();
                }
            }
        }
    }
}
