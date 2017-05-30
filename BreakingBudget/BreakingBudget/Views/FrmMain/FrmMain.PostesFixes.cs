using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Drawing.Text;
using System.Threading.Tasks;
using BreakingBudget.Repositories;
using BreakingBudget.Services.SQL;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace BreakingBudget.Views.FrmMain
{
    partial class FrmMain
    {
        private void InitializePostesFixes()
        {
            FillPostesComboBox();
            FillePeriodicitesComboBox();
            this.HelpPosteLabel.Font = this.IconFont;
            this.HelpPosteLabel.Text = Encoding.UTF8.GetString(ICON_HELP_MARK);
        }

        private void FillPostesComboBox()
        {
            // empty the ComboBox
            this.ComboxBoxListePostes.Items.Clear();

            // Reset the selection
            this.ComboxBoxListePostes.ResetText();

            // Add every item that is not already used by PostePeriodique
            OleDbCommand cmd = DatabaseManager.CmdFromRawSQL(
                "SELECT * FROM Poste WHERE codePoste NOT IN (SELECT codePoste FROM PostePeriodique WHERE codePoste IS NOT NULL)"
            );

            cmd.Connection.Open();
            foreach (PosteRepository.PosteModel e in
                DataAdapter.OleDbDataReaderToStruct<PosteRepository.PosteModel>(cmd.ExecuteReader()))
            {
                this.ComboxBoxListePostes.Items.Add(e);
            }
            cmd.Connection.Close();
        }

        private void FillePeriodicitesComboBox()
        {
            // empty the ComboBox
            this.ComboxBoxListePeriodicites.Items.Clear();

            // Translate and add every item
            foreach (PeriodiciteRepository.PeriodiciteModel e in
                PeriodiciteRepository.List())
            {
                e.libPer = Program.settings.localize.Translate(e.libPer);
                this.ComboxBoxListePeriodicites.Items.Add(e);
            }
        }

        private void BtnValiderBudgetFixe_Click(object _s, EventArgs e)
        {
            MetroButton sender = (MetroButton)_s;
            PosteRepository.PosteModel SelectedPoste;
            PeriodiciteRepository.PeriodiciteModel SelectedPeriode;
            decimal montant;
            int TousLesXDuMois;

            // disable submit button
            sender.Enabled = false;

            // Check if every field was filled
            if (
                this.ComboxBoxListePeriodicites.SelectedItem == null
                || this.ComboxBoxListePostes.SelectedItem == null
                || this.TxtBoxTousLesXMois.Text.Length < 1
                || this.TxtBoxMontantPosteFixe.Text.Length < 1
                )
            {
                MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("err_missing_fields_msg"),
                    Program.settings.localize.Translate("err_missing_fields_caption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // try to convert the decimals and integers
            else if (!(decimal.TryParse(TxtBoxMontantPosteFixe.Text, out montant)
                  && int.TryParse(TxtBoxTousLesXMois.Text, out TousLesXDuMois)))
            {
                MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("err_day_of_month_and_sum_not_number"),
                    Program.settings.localize.Translate("err_uh_oh_caption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // retrieve the selected items
                SelectedPoste = (PosteRepository.PosteModel)this.ComboxBoxListePostes.SelectedItem;
                SelectedPeriode = (PeriodiciteRepository.PeriodiciteModel)this.ComboxBoxListePeriodicites.SelectedItem;

                OleDbCommand cmd = DatabaseManager.InsertInto("PostePeriodique",
                    new OleDbConnection(DatabaseManager.CONNEXION_STRING),
                    new KeyValuePair<string, object>("codePoste", SelectedPoste.codePoste),
                    new KeyValuePair<string, object>("typePer", SelectedPeriode.codePer),
                    new KeyValuePair<string, object>("montant", montant),
                    new KeyValuePair<string, object>("jourDuMois", TousLesXDuMois)
                );

                // TODO: try-catch
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();  // insert data
                cmd.Connection.Close();

                this.FillPostesComboBox();
            }

            // re-enable the submit button
            sender.Enabled = true;
        }

        private void btnGererPostes_Click(object sender, EventArgs e)
        {
            GererPostes InstanceGererPostes = new GererPostes();
            InstanceGererPostes.ShowDialog();

            // update the postes's ComboBox
            this.FillPostesComboBox();
        }

        private void TxtBoxTousLesXMois_KeyUp(object _s, KeyEventArgs e)
        {

            int val;
            MetroTextBox sender = (MetroTextBox)_s;
            if (!int.TryParse(sender.Text, out val))
            {
                errorProvider.SetError(lblDuMois, Program.settings.localize.Translate("err_not_a_valid_number"));
            }
            else
            {
                errorProvider.SetError(lblDuMois, (val > 0 && val < 29) ? null : Program.settings.localize.Translate("err_must_be_between_1_and_31"));
            }
        }
    }
}
