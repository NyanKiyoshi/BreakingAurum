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

namespace BreakingBudget
{
    public partial class FrmAffichDetailsPoste : MetroForm
    {
        public FrmAffichDetailsPoste(int numEcheance, string achat, string echeances)
        {
            InitializeComponent();

            this.Text = Program.settings.localize.Translate(this.Name);
            this.Refresh();

            Program.settings.localize.ControlerTranslator(this);

            // inherit theme from settings
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;
            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;

            this.lblPosteNum.Text += numEcheance;
            this.lblAchat.Text += achat;
            this.rtxtEch.Text += echeances;
        }
    }
}
