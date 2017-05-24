using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Threading.Tasks;
using BreakingBudget.Repositories;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

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

        private void BtnValiderBudgetFixe_Click(object sender, EventArgs e)
        {
            PosteRepository.PosteModel SelectedPoste;
            PeriodiciteRepository.PeriodiciteModel SelectedPeriode;
            decimal montant;
            int TousLesXDuMois;

            // Check if every field was filled
            if (
                this.ComboxBoxListePeriodicites.SelectedItem == null
                || this.ComboxBoxListePostes.SelectedItem == null
                || this.TxtBoxTousLesXMois.Text.Length < 1
                || this.TxtBoxMontantPosteFixe.Text.Length < 1
                )
            {
                MetroMessageBox.Show(this,
                    "Veuillez remplir et selectionner tous les champs.",
                    "Données manquantes",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // try to convert the decimals and integers
            if (!(decimal.TryParse(TxtBoxMontantPosteFixe.Text, out montant)
                  && int.TryParse(TxtBoxTousLesXMois.Text, out TousLesXDuMois)))
            {
                MetroMessageBox.Show(this,
                    "Le jour du mois et le montant doivent être un nombre.",
                    "Uh oh.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // retrieve the selected items
            SelectedPoste = (PosteRepository.PosteModel)this.ComboxBoxListePostes.SelectedItem;
            SelectedPeriode = (PeriodiciteRepository.PeriodiciteModel)this.ComboxBoxListePeriodicites.SelectedItem;

            // insert the data to the database
            MessageBox.Show(
                SelectedPoste.ToString()
                + " *** " + SelectedPeriode.ToString()
                + " *** " + montant
                + " *** " + TousLesXDuMois
            );

            // update the panel's data
            this.FillPostesComboBox();
        }

        private void btnGererPostes_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxMontantPosteFixe_KeyPress(object _s, KeyPressEventArgs e)
        {
            if (!IsTextBoxKeyPressNumber((MetroTextBox)_s, e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxTousLesXMois_KeyUp(object _s, KeyEventArgs e)
        {

            int val;
            MetroTextBox sender = (MetroTextBox)_s;
            if (!int.TryParse(sender.Text, out val))
            {
                errorProvider.SetError(lblDuMois, "Ouch ! Bien essayé ! Mais ce n'est pas un nombre.");
            }
            else
            {
                errorProvider.SetError(lblDuMois, (val > 0 && val < 32) ? null : "La valeur doit être entre 1 et 31");
            }
        }
    }
}
