using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using MetroFramework.Controls;
using MetroFramework;
using BreakingBudget.Repositories;
using BreakingBudget.Services.Lang;
using BreakingBudget.Services.SQL;

namespace BreakingBudget.Views.FrmMain
{
    delegate void ObjectEvent(object s, object e);

    partial class FrmMain
    {
		// the stop condition for the validation label's waiting mode
        bool stopBlinkingPunctualAmount = true;

		// the base container of the whole deadline inputs
        FlowLayoutPanel containerEchancesPonctuelles;

        // the list of deadlines generated inputs
        List<KeyValuePair<DateTimePicker, MetroTextBox>> txtEchancePonctuelsEntries;

        int numberOfDeadlines;

		void InitializePostesPonctuels(FlowLayoutPanel echancesContainer)
        {
            this.lblHelpMontantPonctuel.Font = this.IconFont;
            this.lblHelpMontantPonctuel.Text = Encoding.UTF8.GetString(ICON_HELP_MARK);

            this.lblConfirmNbDeadLines.Font =
				this.lblConfirmMontantPonctuel.Font = this.IconFont;
            this.lblConfirmNbDeadLines.Text =
                this.lblConfirmMontantPonctuel.Text = Encoding.UTF8.GetString(new byte[] { 0xEE, 0x85, 0xA3 });

            // initialize data
            this.containerEchancesPonctuelles = echancesContainer;
            this.txtEchancePonctuelsEntries = new List<KeyValuePair<DateTimePicker, MetroTextBox>>();
            this.numberOfDeadlines = 0;
        }

        // creates a single container (FlowLayoutPanel) 
        // contaning a deadline number {deadlineNo} and its fields.
        //
        //        Generates the following FlowLayoutPanel container and its fields
        // +-----------------+---------------------------------------+------------------+
        // +  Deadline no    #         Datetime Picker               #  Amount TextBox  +
        // +  {deadlineNo}   #  {currentDate + {deadlineNo} months}  #         -        +
        // +-----------------+---------------------------------------+------------------+
        FlowLayoutPanel CreateDeadlineContainer(int deadlineNo)
        {
			// create the fields's container
            FlowLayoutPanel fieldsContainer = new FlowLayoutPanel();

			// create the container's future fields
            MetroLabel lblDeadline = new MetroLabel();
            DateTimePicker datePicker = new DateTimePicker();
            MetroTextBox txtAmount = new MetroTextBox();

            // params the StyleExtender to adapt the WindowsForms fields's visual on theme switch
            // TODO: what if we destroy the field and switch theme? Does it crash?
            this.metroStyleExtender.SetApplyMetroTheme(fieldsContainer, true);
            this.metroStyleExtender.SetApplyMetroTheme(datePicker, true);

            // params the fields's container
            fieldsContainer.AutoSize = true;
            fieldsContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fieldsContainer.WrapContents = false;

            // params the deadline no {x}'s label
            lblDeadline.AutoSize = true;
            lblDeadline.Dock = DockStyle.Left;
            lblDeadline.FontWeight = MetroLabelWeight.Regular;
            lblDeadline.Text = string.Format(Program.settings.localize.Translate("deadline_no_{0:00}"), deadlineNo);
            lblDeadline.TextAlign = ContentAlignment.MiddleLeft;

            // params the deadline no {x}'s DatePicker
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Size = new Size(100, 20);
            datePicker.Value = datePicker.Value.AddMonths(1 * deadlineNo);

			// params the amount input field
            txtAmount.Dock = DockStyle.Right;
            txtAmount.Text = "";
            txtAmount.MaxLength = 5;
            txtAmount.Size = new Size(74, 20);
            txtAmount.WaterMark = lblDeadline.Text;

			// create a KeyPress event for txtAmount that checks if the input is a number or not
            txtAmount.KeyPress += new KeyPressEventHandler(
				(object _s, KeyPressEventArgs _ev) =>
					_ev.Handled = !(this.IsTextBoxKeyPressNumber(_s as MetroTextBox, _ev.KeyChar))
            );

			// append the newly created date picker and amount fields to the list
            this.txtEchancePonctuelsEntries.Add(
                new KeyValuePair<DateTimePicker, MetroTextBox>(datePicker, txtAmount)
            );

			// add the fields to the container before returning it
            fieldsContainer.Controls.Add(lblDeadline);
            fieldsContainer.Controls.Add(datePicker);
            fieldsContainer.Controls.Add(txtAmount);
            return fieldsContainer;
        }

        private void lblHelpMontantPonctuel_Click(object sender, EventArgs e)
        {
            // TODO: translate it
            MetroMessageBox.Show(this,
                Program.settings.localize.Translate("help_montant_ponctuel_optionnel"),
                Program.settings.localize.Translate("help_montant_ponctuel_optionnel_caption"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

		private void ActivateNeedUpdateMode(Control ctrl)
        {
            // if the amount it changed,
            // check if the blinking function is not already running
            // if not already running, blink the label to tell the user to update.
            if (stopBlinkingPunctualAmount == true)
            {
                this.stopBlinkingPunctualAmount = false;
                this.BlinkControl(ctrl, () => !stopBlinkingPunctualAmount);
            }
        }

        private void txtBoxNbPrelevementsPonctuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(this.IsTextBoxKeyPressNumber(sender as MetroTextBox, e.KeyChar, false, false));
        }

        private void txtBoxMontantPonctuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(this.IsTextBoxKeyPressNumber(sender as MetroTextBox, e.KeyChar, true, false));
        }

        private void txtBoxMontantPonctuel_TextChanged(object sender, EventArgs e)
        {
            ActivateNeedUpdateMode(this.lblConfirmMontantPonctuel);
        }

        private bool ArePonctuelAmountFieldsInvalid()
        {
            return string.IsNullOrWhiteSpace(this.txtBoxNbPrelevementsPonctuel.Text)
                   || string.IsNullOrWhiteSpace(this.txtBoxMontantPonctuel.Text);
        }

        private void FillDeadlines(decimal f_amount, int startPoint, int endPoint)
        {
            string str_amount = f_amount.ToString("#.##");
            for (int i = startPoint; i < endPoint; ++i)
            {
                this.txtEchancePonctuelsEntries[i].Value.Text = str_amount;
            }
        }

		private void AskToUpdateDeadLinesFromAmount(decimal montantTotal, int nbDeadLines)
        {
            decimal dividedAmount = montantTotal / nbDeadLines;

            // stop blinking the label "updated needed"
            this.stopBlinkingPunctualAmount = true;

            dividedAmount = montantTotal / nbDeadLines;
            // otherwise, procceed it
            if (MetroMessageBox.Show(this,
                string.Format(Program.settings.localize.Translate("should_I_override_the_deadlines_to_{0}"),
                    dividedAmount.ToString("#.##")),
                Program.settings.localize.Translate("requires_confirmation"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
            {
                // it the user said he don't want to override the deadlines, stop here.
                return;
            };

            // if the user said yes
            FillDeadlines(dividedAmount, 0, nbDeadLines);
        }

        private void lblConfirmMontantPonctuel_Click(object sender, EventArgs e)
        {
            int nbPrelevements;
            decimal montantTotal;

            // FIXME: refactor to only one click event
            // generates deadlines
            lblConfirmNbDeadLines_Click(sender, e);

            //lblConfirmMontantPonctuel
            // TODO: clear all button
            //// TODO: ask if we need to override or not the fields
            if (ArePonctuelAmountFieldsInvalid())
            {
                ErrorManager.ShowMissingFieldsError(this);
                return;
            }

            // else if the values are not number: show error
            if (!int.TryParse(this.txtBoxNbPrelevementsPonctuel.Text, out nbPrelevements)
                || !decimal.TryParse(this.txtBoxMontantPonctuel.Text, out montantTotal))
            {
                MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("err_not_a_number"),
                    Program.settings.localize.Translate("err_uh_oh_caption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AskToUpdateDeadLinesFromAmount(montantTotal, nbPrelevements);
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// Returns false if there was a missing data.
        /// </returns>
        private bool CheckAndConvertDeadLinesToList(out List<KeyValuePair<DateTime, decimal>> deadLines_list)
        {
            decimal amount;
            KeyValuePair<DateTimePicker, MetroTextBox> e;
            deadLines_list = new List<KeyValuePair<DateTime, decimal>>();

            // go through every deadlines
            // (we don't use a foreach(...) because, we don't remove every deadline if the user
            // edit the deadline count to a lower value as before.
            // We only hide them for performance issues. But we don't proceed them.)
            int i = 0;
            while (i < this.numberOfDeadlines)
            {
                // retrieve the entry (DatePicker & TextBox)
                e = this.txtEchancePonctuelsEntries[i];
                
                // try to convert the textbox value to decimal
                // if we fail, we log it
                // then we return false and stop proceeding
                if (!decimal.TryParse(e.Value.Text, out amount))
                {
                    Console.WriteLine("F :: Unable to convert {0} ;; {1} to decimal", e.Value, e.Value.Name);
                    return false;
                }

                // otherwise, we append it to the deadline list
                deadLines_list.Add(new KeyValuePair<DateTime, decimal>(
                    e.Key.Value,  // datetime
                    amount
                ));

                ++i;
            }
            return true;
        }

        private void btnValiderBudgetPonctuel_Click(object sender, EventArgs _ev)
        {
            OleDbConnection dbConn;
            OleDbTransaction dbTransaction;

            // Retrieve the budget's title + comments and remove any leading whitespacess
            string budgetTitle = this.txtBoxIntitulePonctuel.Text.Trim();
            string budgetComments = this.txtBoxCommentairePonctuel.Text.Trim();

            // Will store the deadlines
            List<KeyValuePair<DateTime, decimal>> deadLines;

            // TODO: if set, check if the sum of the fields is equal to the input sum
            //		 if not, put a warning & ask for confirmation
            //    string.IsNullOrEmpty(this.txtBoxMontantPonctuel.Text)
            //    && float.TryParse(this.txtBoxMontantPonctuel.Text, out montantTotal)

            // - if: 
            //     - the budget's title is null/empty
            //     - or only has spaces:
            //     - or if not every deadline is filled
            //   ---> show missing fields error and stop proceeding
            //
            // - otherwise: proceed and insert the data (if the title does not exist yet)

            if (string.IsNullOrWhiteSpace(budgetTitle)
                || this.numberOfDeadlines < 1

                // try to retrieve every deadlines, store it to `deadLines` and return false
                // if there was a missing value
                || !CheckAndConvertDeadLinesToList(out deadLines))
            {
                ErrorManager.ShowMissingFieldsError(this);
                return;
            }

            // check if the budgetTitle is unique in the database
            // if not unique: show an error saying that it already exists and stop proceeding
            if (!PosteRepository.IsUnique(budgetTitle))
            {
                // show a duplicate value error and specify the field
                ErrorManager.ShowDuplicateError(this,
                    Program.settings.localize.Translate(this.lblIntitulePonctuel.Name));
                return;
            }

            // otherwise: continue and insert the data
            dbConn = DatabaseManager.CreateConnection();

            dbConn.Open();

            dbTransaction = dbConn.BeginTransaction();

            // Insert the data to the data base
            try {
                PostePonctuelRepository.Create(dbConn, dbTransaction,
                    budgetTitle,
                    budgetComments
                );
            } catch (OleDbException e)
            {
                ErrorManager.HandleOleDBError(e);
            }
            finally
            {
                dbConn.Close();
            }
        }


        /*
		 * Is called when the value of the input field of the number of deductions is changed.
		 * 
		 * - If the input number is greater than the previously generated one:
		 *	 we create more input fields.
		 *
		 * - If the number of visible fields is less than the number of deadlines:
		 *   toggle the needed ones to visible.
		 * - Else (greater), toggle them to invisible.
		 */
        private void lblConfirmNbDeadLines_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel newDeadlineContainer;
            int newDeadlineCount;
            decimal montantTotal;

			if (!int.TryParse(this.txtBoxNbPrelevementsPonctuel.Text, out newDeadlineCount) || newDeadlineCount < 1)
            {
                // TODO: not a number -> not a VALID number (whole project)
                this.errorProvider.SetError(this.txtBoxNbPrelevementsPonctuel, 
					Program.settings.localize.Translate("err_not_a_number"));
                return;
            }

            // if the number of the alrady created deadlines is less than the entered count,
            // create them.
            if (this.txtEchancePonctuelsEntries.Count < newDeadlineCount)
            {
                // put the main container visible
                this.echancesContainer.Visible = true;

                for (int c = this.txtEchancePonctuelsEntries.Count + 1; c <= newDeadlineCount; ++c)
                {
                    // generate a (visible) deadline container
                    newDeadlineContainer = this.CreateDeadlineContainer(c);

                    // Append the newly created deadline container to the container list
                    this.containerEchancesPonctuelles.Controls.Add(newDeadlineContainer);
                }
            }

			// XXX: I should refactor that ugly pill of crap
            for (int i = newDeadlineCount; i < this.txtEchancePonctuelsEntries.Count; ++i)
            {
                this.txtEchancePonctuelsEntries[i].Value.Parent.Visible = false;
            }
            for (int i = 0; i < newDeadlineCount; ++i)
            {
                this.txtEchancePonctuelsEntries[i].Value.Parent.Visible = true;
            }

            // Unset the error provider and tell the async blinker
            // to stop blinking the confirmation labels
            this.errorProvider.SetError(this.txtBoxNbPrelevementsPonctuel, "");
            this.stopBlinkingPunctualAmount = true;

            // update the number of deadlines
            this.numberOfDeadlines = newDeadlineCount;

            // If there was a amount entered:
            //   ask if the user wants to override the deadlines
            //   with the amount divided the deadlines number.
			if (!string.IsNullOrWhiteSpace(this.txtBoxMontantPonctuel.Text)
				&& decimal.TryParse(this.txtBoxMontantPonctuel.Text, out montantTotal))
            {
                AskToUpdateDeadLinesFromAmount(montantTotal, newDeadlineCount);
            }
        }

        private void txtBoxNbPrelevementsPonctuel_TextChanged(object sender, EventArgs e)
        {
            ActivateNeedUpdateMode(this.lblConfirmNbDeadLines);
        }

        private void txtBoxNbPrelevementsPonctuel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lblConfirmNbDeadLines_Click(sender, null);
            }
        }

        private void txtBoxMontantPonctuel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lblConfirmMontantPonctuel_Click(sender, null);
            }
        }
    }
}
