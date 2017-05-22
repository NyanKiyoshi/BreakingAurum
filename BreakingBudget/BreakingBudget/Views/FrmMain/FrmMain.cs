using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Kerido.Controls;
using BreakingBudget.Services;
using BreakingBudget.Structural;

namespace BreakingBudget.Views.FrmMain
{
    public partial class FrmMain : MetroForm
    {
        private readonly SidebarEntry[] TopSidebarEntries;
        private readonly SidebarEntry[] BottomSidebarEntries;

        public readonly string BaseName;
        public readonly MultiPanePage DefaultPage;

        public FrmMain()
        {
            InitializeComponent();

            this.TopSidebarEntries = new SidebarEntry[]
            {
                // To have a parent that do nothing: pass as first parameter: `(MultiPanePage)null`
                new SidebarEntry(this.HomePage, new byte[] { 0xEE, 0xA2, 0x8A }, "Accueil"),
                new SidebarEntry((MultiPanePage)null, new byte[] { 0xEE, 0xA2, 0x8A }, "Budget Prévisionnel", new SidebarEntry[] {
                    new SidebarEntry(this.PagePostesFixes, "Postes Fixes"),
                    new SidebarEntry(this.PagePostesPonctuels, "Postes Ponctuels"),
                    new SidebarEntry(this.PageRevenus, "Revenus"),
                }),
            };

            this.BottomSidebarEntries = new SidebarEntry[]
            {
                //new SidebarEntry("http://github.com", new byte[] { 0xEE, 0xA1, 0xA8 }, "Tracker"),
                new SidebarEntry(this.SettingsPage, new byte[] { 0xEE, 0xA1, 0xA9 }, "Paramètres"),
                new SidebarEntry(this.LicensesPage, new byte[] { 0xEE, 0x90, 0xA0 }, "Licences")
            };

            // set the base name (used later to rename the form)
            this.BaseName = this.Text;

            // set the default page and switch to it
            this.DefaultPage = this.HomePage;

            this.Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel);

            AutoCompleter.ImplementCompleter(textBox1, 2);
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
                    "Êtes-vous sûr de vouloir quitter ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
