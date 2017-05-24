using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Threading.Tasks;
using BreakingBudget.Repositories;

namespace BreakingBudget.Views.FrmMain
{
    partial class FrmMain
    {
        readonly byte[] ICON_HELP_MARK = new byte[] { 0xEE, 0xA3, 0xBD };

        private void InitializePostesFixes()
        {
            FillPostesComboBox();
            FillePeriodicitesComboBox();
            this.HelpPosteLabel.Font = this.IconFont;
            this.HelpPosteLabel.Text = Encoding.UTF8.GetString(ICON_HELP_MARK);
        }

        private void FillPostesComboBox()
        {
            this.ComboxBoxListePostes.Items.Clear();
            this.ComboxBoxListePostes.Items.AddRange(PosteRepository.List());
        }

        private void FillePeriodicitesComboBox()
        {
            this.ComboxBoxListePeriodicites.Items.Clear();
            this.ComboxBoxListePeriodicites.Items.AddRange(PeriodiciteRepository.List());
        }
    }
}
