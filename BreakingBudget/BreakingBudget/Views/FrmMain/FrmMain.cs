using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using Kerido.Controls;
using BreakingBudget.Services;
using BreakingBudget.Repositories;
using BreakingBudget.Services.SQL;
using System.Data.OleDb;
using BreakingBudget.Structural;

namespace BreakingBudget.Views.FrmMain
{
    public partial class FrmMain : MetroForm
    {
        delegate bool CustomCondition();

        private readonly IconFonts IconFontManager;
        private readonly Font IconFont;

        private readonly SidebarEntry[] TopSidebarEntries;
        private readonly SidebarEntry[] BottomSidebarEntries;

        private readonly string BaseName;
        private readonly MultiPanePage DefaultPage;

        // used by Program.cs to know if it must restart the form or not
        public bool WaitsForRestart
        {
            get;
            set;
        }

        readonly byte[] ICON_HELP_MARK = new byte[] { 0xEE, 0xA3, 0xBD };

        // used to change temporary the title (see `FrmMain_ResizeBegin(...)`)
        string oldFormTitle;

        public FrmMain()
        {
            // set the base name (used later to rename the form)
            this.BaseName = "Breaking Budget";

            InitializeComponent();

            // set the form's style manager to the control `metroStyleManager`
            // it will allow to propagate the theme selection
            this.StyleManager = this.metroStyleManager;

            // Create the fonts icons collection & set the default one (MaterialIcons)
            this.IconFontManager = (new IconFonts());
            this.IconFont = this.IconFontManager.GetFont(IconFonts.FONT_FAMILY.MaterialIcons, 17.0f);

            // set the default page and switch to it
            this.DefaultPage = this.HomePage;

            this.Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel);

            // ----
            // Load the user's preferences
            LoadSettings();

            // Load the LocalizationManager that will provide the localization system
            Program.settings.localize.ImportResourceLocalization(this.Name);  // load the form's localization data
            Program.settings.localize.ImportResourceLocalization("Sidebar");  // load the sidebar's localization data

            // try to localize every sub-control
            Program.settings.localize.ControlerTranslator(this);

            // create the sidebar's top entries
            this.TopSidebarEntries = new SidebarEntry[]
            {
                // (To have a parent that do nothing: pass as first parameter: `(MultiPanePage)null`)
                new SidebarEntry(this.HomePage,
                                 new byte[] { 0xEE, 0xA2, 0x8A },  // little "house" icon
                                 Program.settings.localize.Translate("sidebar_page_home")),

                // budget previsonnel
                new SidebarEntry((MultiPanePage)null, new byte[] { 0xEE, 0xA2, 0xA1 },  // credit card icon
                    Program.settings.localize.Translate("sidebar_page_budget_previsionnel"),
                    
                    new SidebarEntry[] {
                        new SidebarEntry(this.PagePostesFixes,
                                         Program.settings.localize.Translate("sidebar_page_poste_fixe")),

                        new SidebarEntry(this.PagePostesPonctuel,
                                         Program.settings.localize.Translate("sidebar_page_poste_ponctuel")),

                        new SidebarEntry(this.PageRevenus,         
                                         Program.settings.localize.Translate("sidebar_page_revenu")),
                    }
                ),

                // budget du mois
                new SidebarEntry((MultiPanePage)null, new byte[] { 0xEE, 0xA1, 0xAC },  // "validate/ check" icon
                    Program.settings.localize.Translate("sidebar_page_budget_mois"),
                    
                    new SidebarEntry[] {
                        new SidebarEntry(
                            PageBudgetMoisAjouterTransaction,
                            Program.settings.localize.Translate("sidebar_page_ajouter_transaction")
                        ),

                        new SidebarEntry(
                            (MultiPanePage)null,
                            Program.settings.localize.Translate("sidebar_page_lister_transactions")
                        ),

                        new SidebarEntry(
                            this.PageDashboard,
                            Program.settings.localize.Translate("sidebar_page_dashboard")
                        ),

                        new SidebarEntry(
                            () => {
                                (new TransactionsToPDF()).ShowDialog();
                            },
                            Program.settings.localize.Translate("sidebar_page_exporter_transactions")
                        ),
                }),
            };

            // create the sidebar's bottom entries
            this.BottomSidebarEntries = new SidebarEntry[]
            {
                new SidebarEntry(this.SettingsPage,
                                 new byte[] { 0xEE, 0xA1, 0xA9 },  // gear icon
                                 Program.settings.localize.Translate("sidebar_page_settings")),

                new SidebarEntry(this.LicensesPage,
                                 new byte[] { 0xEE, 0x90, 0xA0 },  // smiling icon
                                 Program.settings.localize.Translate("sidebar_page_licenses"))
            };

            // initialize sub panels
            InitializePostesFixes();
            InitializePostesPonctuels(echancesContainer);
            InitiliazePosteRevenu();

            InitializeDashboard();
            InitializeAjouterTransactionBudgetDuMois();

            InitiliazeSettingsPage();
        }

        private void LoadSettings()
        {
            MetroFramework.Localization.MetroLocalize.CurrentLanguage = Program.settings.TwoLetterISOLanguage;

            this.StyleManager.Theme = Program.settings.MetroTheme;
            this.StyleManager.Style = Program.settings.MetroColorStyle;

            Program.settings.styleManager = this.metroStyleManager;

            FrmMain_StyleChanged(null, null);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GenerateSidebar(new SidebarEntry[][] { this.TopSidebarEntries, this.BottomSidebarEntries });
            this.SwitchPanel(this.DefaultPage);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: replace this by a check if data were edited or not
            if (
                MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("quit_confirmation"),
                    Program.settings.localize.Translate("requires_confirmation"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            Program.settings.Save();
        }

        /// <summary>
        /// Takes a control and make it blink until Condition is false.
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="Condition"></param>
        private async void BlinkControl(Control[] ctrls, CustomCondition Condition)
        {
            while (Condition())
            {
                foreach (Control ctrl in ctrls)
                {
                    ctrl.ForeColor = ctrl.ForeColor == Color.Red ? Color.LimeGreen : Color.Red;
                }
                await Task.Delay(500);
            }
            foreach (Control ctrl in ctrls)
            {
                ctrl.ForeColor = Color.LimeGreen;
            }
        }

        private void HelpPosteLabel_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
                "Choisissez un poste existant ou tapez-le directement à l'intérieur du champ pour en créer un nouveau.",
                "Aide sur les postes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void PagePostesFixes_AutoSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.PagePostesFixes.Size.Width.ToString());
        }

        private void AllowKeyPressAFloat(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                this.IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar)
            );
        }

        private void AllowKeyPressAPositiveFloat(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                this.IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar, true, false)
            );
        }

        private void AllowKeyPressAInteger(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                this.IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar, false)
            );
        }

        private void AllowKeyPressANonNegativeInteger(object s, KeyPressEventArgs e)
        {
            e.Handled = !(
                this.IsTextBoxKeyPressNumber((MetroTextBox)s, e.KeyChar, false, false)
            );
        }

        private bool IsTextBoxKeyPressNumber(MetroTextBox sender, char KeyChar,
            bool allowFloat = true,
            bool allowNegatives = true)
        {
            return (
                // is the char (not) a number?
                char.IsNumber(KeyChar)

                // or (not) a backspace?
                || KeyChar == (char)Keys.Back

                // or (not) a unique dot?
                || (allowFloat && (KeyChar == '.' || KeyChar == ',')
                                && (!sender.Text.Contains(".") && !sender.Text.Contains(",")))

                // ...or (not) a unique minus at the beginning of the line? (is the cursor not at the beginning)
                || (allowNegatives && KeyChar == '-' && (!sender.Text.Contains("-")) && sender.SelectionStart == 0)
            );
        }

        private void FrmMain_StyleChanged(object sender, EventArgs e)
        {
            this.ContentPanel.BackColor = this.BackColor;
            if (this.isSidebarInitialized)
            {
                InitializeSidebarColors();
                ContentPanel_SelectedPageChanged(this.ContentPanel, null);
            }

            if (this.Theme != MetroThemeStyle.Dark)
            {
                this.BaseContainer.BackColor = Color.Silver;
            }
            else
            {
                this.BaseContainer.BackColor = Color.FromArgb(0x45, 0x45, 0x45);
            }
        }

        private void FrmMain_ResizeBegin(object sender, EventArgs e)
        {
            this.oldFormTitle = this.Text;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}x{1}", this.Width, this.Height);
        }

        private void FrmMain_ResizeEnd(object sender, EventArgs e)
        {
            this.Text = this.oldFormTitle;
            this.Refresh();
        }

        private void echancesContainer_Paint_OR_ControlAdded(object sender, object e)
        {
            ((FlowLayoutPanel)sender).Visible = (this.numberOfDeadlines > 0);
        }

        /// <summary>
        /// Tries to convert a given string to a int and compares the result to check
        /// if the value is valid day.
        /// </summary>
        /// <param name="value">The day to parse</param>
        /// <param name="output">The parsed day</param>
        /// <returns></returns>
        private bool isDayOfTheMonth(string value, out int output)
        {
            return int.TryParse(value, out output) 
                && output > 0 
                && output < 29;
        }

        // button for test purposes only
        private void button1_Click(object sender, EventArgs _ev)
        {
            (new TransactionsToPDF()).ShowDialog();
        }
    }
}
