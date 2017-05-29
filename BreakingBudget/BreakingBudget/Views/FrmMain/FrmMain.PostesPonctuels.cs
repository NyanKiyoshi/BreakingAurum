using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using MetroFramework.Controls;
using MetroFramework;
using BreakingBudget.Repositories;

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
        List<MetroTextBox> txtBoxesEchancePonctuels;

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
            this.txtBoxesEchancePonctuels = new List<MetroTextBox>();
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

			// append the newly created amount field to the list
            this.txtBoxesEchancePonctuels.Add(txtAmount);

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
                this.txtBoxesEchancePonctuels[i].Text = str_amount;
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
                ShowMissingFieldsError();
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

        private void btnValiderBudgetPonctuel_Click(object sender, EventArgs e)
        {
            // Retrieve the budget's title and remove any leading whitespacess
            string budgetTitle = this.txtBoxIntitulePonctuel.Text.Trim();

            // TODO: if set, check if the sum of the fields is equal to the input sum
            //		 if not, put a warning & ask for confirmation
            //    string.IsNullOrEmpty(this.txtBoxMontantPonctuel.Text)
            //    && float.TryParse(this.txtBoxMontantPonctuel.Text, out montantTotal)

            // - if the budget's title is null/empty or only has spaces:
            //     -> show missing fields error and stop proceeding
            //
            // - otherwise: proceed and insert the data (if the title does not exist yet)

            // TODO: check if every deadline is filled
            if (string.IsNullOrWhiteSpace(budgetTitle)
                || this.numberOfDeadlines < 1)
            {
                ShowMissingFieldsError();
                return;
            }

            // check if the budgetTitle is unique in the database
            // if not unique: show an error saying that it already exists and stop proceeding
            if (!PosteRepository.IsUnique(budgetTitle))
            {
                MetroMessageBox.Show(this,
                    Program.settings.localize.Translate("err_duplicate_value"),
                    Program.settings.localize.Translate("err_duplicate_value_caption"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            
            // otherwise: continue and insert the data
            ////// TODO
            // Insert the data to the data base
            ////// TODO
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
            if (this.txtBoxesEchancePonctuels.Count < newDeadlineCount)
            {
                // put the main container visible
                this.echancesContainer.Visible = true;

                for (int c = this.txtBoxesEchancePonctuels.Count + 1; c <= newDeadlineCount; ++c)
                {
                    // generate a (visible) deadline container
                    newDeadlineContainer = this.CreateDeadlineContainer(c);

                    // Append the newly created deadline container to the container list
                    this.containerEchancesPonctuelles.Controls.Add(newDeadlineContainer);
                }
            }

			// XXX: I should refactor that ugly pill of crap
            for (int i = newDeadlineCount; i < this.txtBoxesEchancePonctuels.Count; ++i)
            {
                this.txtBoxesEchancePonctuels[i].Parent.Visible = false;
            }
            for (int i = 0; i < newDeadlineCount; ++i)
            {
                this.txtBoxesEchancePonctuels[i].Parent.Visible = true;
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
