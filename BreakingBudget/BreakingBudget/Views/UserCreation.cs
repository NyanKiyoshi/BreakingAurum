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

namespace BreakingBudget.Views.FrmMain
{
    public partial class UserCreation : MetroForm
    {
        public UserCreation()
        {
            InitializeComponent();
        }

        private bool _UserCancelled;
        public bool UserCancelled { get { return this._UserCancelled;  } }

        // TODO: Implement Me
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            MessageBox.Show("Implement Me!");

            if (!error)
            {
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this._UserCancelled = true;
            this.Close();
        }
    }
}
