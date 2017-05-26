using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using Kerido.Controls;
using BreakingBudget.Services;
using BreakingBudget.Services.Lang;
using BreakingBudget.Services.SQL;
using BreakingBudget.Structural;
using BreakingBudget.Repositories;
using System.Data;
using System.Data.OleDb;

namespace BreakingBudget.Views.FrmMain
{
    public partial class FrmMain : MetroForm
    {
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

        public FrmMain()
        {
            InitializeComponent();

            // set the form's style manager to the control `metroStyleManager`
            // it will allow to propagate the theme selection
            this.StyleManager = this.metroStyleManager;

            // Create the fonts icons collection & set the default one (MaterialIcons)
            this.IconFontManager = (new IconFonts());
            this.IconFont = this.IconFontManager.GetFont(IconFonts.FONT_FAMILY.MaterialIcons, 17.0f);

            // set the base name (used later to rename the form)
            this.BaseName = this.Text;

            // set the default page and switch to it
            this.DefaultPage = this.HomePage;

            this.Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel);

            AutoCompleter.ImplementCompleter(textBox1, 2);

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
                // To have a parent that do nothing: pass as first parameter: `(MultiPanePage)null`
                new SidebarEntry(this.HomePage, new byte[] { 0xEE, 0xA2, 0x8A }, Program.settings.localize.Translate("sidebar_page_home")),

                // budget previsonnel
                new SidebarEntry((MultiPanePage)null, new byte[] { 0xEE, 0xA2, 0xA1 },
                    Program.settings.localize.Translate("sidebar_page_budget_previsionnel"),
                    
                    new SidebarEntry[] {
                        new SidebarEntry(this.PagePostesFixes,     Program.settings.localize.Translate("sidebar_page_poste_fixe")),
                        new SidebarEntry(this.PagePostesPonctuel,  Program.settings.localize.Translate("sidebar_page_poste_ponctuel")),
                        new SidebarEntry(this.PageRevenus,         Program.settings.localize.Translate("sidebar_page_revenu")),
                    }
                ),

                // budget du mois
                new SidebarEntry((MultiPanePage)null, new byte[] { 0xEE, 0xA1, 0xAC },
                    Program.settings.localize.Translate("sidebar_page_budget_mois"),
                    
                    new SidebarEntry[] {
                        new SidebarEntry((MultiPanePage)null,      Program.settings.localize.Translate("sidebar_page_ajouter_transaction")),
                        new SidebarEntry((MultiPanePage)null,      Program.settings.localize.Translate("sidebar_page_lister_transactions")),
                }),
            };

            // create the sidebar's bottom entries
            this.BottomSidebarEntries = new SidebarEntry[]
            {
                new SidebarEntry(this.SettingsPage, new byte[] { 0xEE, 0xA1, 0xA9 }, Program.settings.localize.Translate("sidebar_page_settings")),
                new SidebarEntry(this.LicensesPage, new byte[] { 0xEE, 0x90, 0xA0 }, Program.settings.localize.Translate("sidebar_page_licenses"))
            };

            InitializePostesFixes();
            InitSettingsPage();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(DatabaseManager.CONNEXION_STRING);
            OleDbCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM Poste;";

            //DataAdapter.OleDbDataReaderToStruct<PosteRepository.PosteModel>(DatabaseManager.ExecuteRawSQL("SELECT * FROM Poste;"));

            conn.Open();
            foreach (PosteRepository.PosteModel p in DataAdapter.OleDbDataReaderToStruct<PosteRepository.PosteModel>(cmd.ExecuteReader()))
            {
                MessageBox.Show(p.ToString());
            }
            conn.Close();

            return;

            foreach (DataColumn dc in DatabaseManager.GetCachedTableSchema()["Poste"].Columns)
            {
                MessageBox.Show(dc.ColumnName.ToString());
                MessageBox.Show(dc.DataType.ToString());
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

        private void button1_Click_1(object sender, EventArgs ___e)
        {
            SelectBuilder sql = new SelectBuilder(
                // Table "Personne" (required)
                PersonneRepository.TABLE_NAME,

                // The selected fields (optional)
                new string[] { "codePersonne", "nomPersonne", "pnPersonne"}
            );

            sql.AddClause(E_SQL_CLAUSE_SEP.AND, "codePersonne", E_SQL_OPERATION.GREATER_THAN,   3);
            sql.Or ("codePersonne", E_SQL_OPERATION.EQUAL_TO,  1).
                And("pnPersonne",   E_SQL_OPERATION.LIKE,      "%iche%");


            MessageBox.Show(sql.ToRawSQL());

            OleDbCommand cmd = sql.GetCommand(new OleDbConnection(DatabaseManager.CONNEXION_STRING));
            cmd.Connection.Open();

            foreach (PersonneRepository.PersonneModel e
                        in DataAdapter.OleDbDataReaderToStruct<PersonneRepository.PersonneModel>(cmd.ExecuteReader()))
            {
                MessageBox.Show(e.codePersonne.ToString());
            }

            cmd.Connection.Close();
        }

        private bool IsTextBoxKeyPressNumber(MetroTextBox sender, char KeyChar)
        {
            if (
                (
                    // is the char (not) a number?
                    char.IsNumber(KeyChar)

                    // or (not) a backspace?
                    || KeyChar == (char)Keys.Back

                    // or (not) a unique dot?
                    || (KeyChar == '.' && (!sender.Text.Contains(".")))

                    // ...or (not) a unique minus at the beginning of the line? (is the cursor not at the beginning)
                    || (KeyChar == '-' && (!sender.Text.Contains("-")) && sender.SelectionStart == 0)
                )
            )
            {
                return true;
            }
            return false;
        }

        private void TxtBoxTousLesXMois_KeyPress(object _s, KeyPressEventArgs e)
        {
            int val;
            MetroTextBox sender = (MetroTextBox)_s;

            if (!IsTextBoxKeyPressNumber(sender, e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
