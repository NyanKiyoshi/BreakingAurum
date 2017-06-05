using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakingBudget
{
    public partial class FrmAffichDetailsPoste : Form
    {
        public FrmAffichDetailsPoste(int numEcheance, string achat, string echeances)
        {
            InitializeComponent();
            this.lblPosteNum.Text += numEcheance;
            this.lblAchat.Text += achat;
            this.rtxtEch.Text += echeances;
        }
    }
}
