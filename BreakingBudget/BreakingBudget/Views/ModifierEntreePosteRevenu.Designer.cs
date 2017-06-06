namespace BreakingBudget.Views
{
    partial class ModifierEntreePosteRevenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Submit = new MetroFramework.Controls.MetroButton();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCmbPostes = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBoxLibPoste = new MetroFramework.Controls.MetroTextBox();
            this.lblBeneficiaireRevenu = new MetroFramework.Controls.MetroLabel();
            this.PanelPeriodicite = new System.Windows.Forms.FlowLayoutPanel();
            this.listBeneficiairesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.PanelTousLesXMois = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTousLes = new MetroFramework.Controls.MetroLabel();
            this.TxtBoxTousLesXMois = new MetroFramework.Controls.MetroTextBox();
            this.lblDuMois = new MetroFramework.Controls.MetroLabel();
            this.lblMontant = new MetroFramework.Controls.MetroLabel();
            this.PanelMontant = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtBoxMontantPosteFixe = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.PanelPeriodicite.SuspendLayout();
            this.PanelTousLesXMois.SuspendLayout();
            this.PanelMontant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 318);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.Submit);
            this.flowLayoutPanel2.Controls.Add(this.Cancel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 286);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(358, 29);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.Location = new System.Drawing.Point(280, 3);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseSelectable = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new System.Drawing.Point(199, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseSelectable = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCmbPostes);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.lblBeneficiaireRevenu);
            this.flowLayoutPanel1.Controls.Add(this.PanelPeriodicite);
            this.flowLayoutPanel1.Controls.Add(this.PanelTousLesXMois);
            this.flowLayoutPanel1.Controls.Add(this.lblMontant);
            this.flowLayoutPanel1.Controls.Add(this.PanelMontant);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 277);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lblCmbPostes
            // 
            this.lblCmbPostes.AutoSize = true;
            this.lblCmbPostes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCmbPostes.Location = new System.Drawing.Point(3, 0);
            this.lblCmbPostes.Name = "lblCmbPostes";
            this.lblCmbPostes.Size = new System.Drawing.Size(43, 19);
            this.lblCmbPostes.TabIndex = 0;
            this.lblCmbPostes.Text = "Poste";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.txtBoxLibPoste);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(352, 26);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // txtBoxLibPoste
            // 
            // 
            // 
            // 
            this.txtBoxLibPoste.CustomButton.Image = null;
            this.txtBoxLibPoste.CustomButton.Location = new System.Drawing.Point(328, 2);
            this.txtBoxLibPoste.CustomButton.Name = "";
            this.txtBoxLibPoste.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBoxLibPoste.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxLibPoste.CustomButton.TabIndex = 1;
            this.txtBoxLibPoste.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxLibPoste.CustomButton.UseSelectable = true;
            this.txtBoxLibPoste.CustomButton.Visible = false;
            this.txtBoxLibPoste.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxLibPoste.Lines = new string[0];
            this.txtBoxLibPoste.Location = new System.Drawing.Point(3, 3);
            this.txtBoxLibPoste.MaxLength = 30;
            this.txtBoxLibPoste.Name = "txtBoxLibPoste";
            this.txtBoxLibPoste.PasswordChar = '\0';
            this.txtBoxLibPoste.PromptText = "placeholder_intitule";
            this.txtBoxLibPoste.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxLibPoste.SelectedText = "";
            this.txtBoxLibPoste.SelectionLength = 0;
            this.txtBoxLibPoste.SelectionStart = 0;
            this.txtBoxLibPoste.ShortcutsEnabled = true;
            this.txtBoxLibPoste.Size = new System.Drawing.Size(346, 20);
            this.txtBoxLibPoste.TabIndex = 1;
            this.txtBoxLibPoste.UseSelectable = true;
            this.txtBoxLibPoste.WaterMark = "placeholder_intitule";
            this.txtBoxLibPoste.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxLibPoste.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBeneficiaireRevenu
            // 
            this.lblBeneficiaireRevenu.AutoSize = true;
            this.lblBeneficiaireRevenu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBeneficiaireRevenu.Location = new System.Drawing.Point(3, 63);
            this.lblBeneficiaireRevenu.Name = "lblBeneficiaireRevenu";
            this.lblBeneficiaireRevenu.Size = new System.Drawing.Size(77, 19);
            this.lblBeneficiaireRevenu.TabIndex = 8;
            this.lblBeneficiaireRevenu.Text = "Bénéficiaire";
            // 
            // PanelPeriodicite
            // 
            this.PanelPeriodicite.AutoSize = true;
            this.PanelPeriodicite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelPeriodicite.Controls.Add(this.listBeneficiairesComboBox);
            this.PanelPeriodicite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPeriodicite.Location = new System.Drawing.Point(3, 85);
            this.PanelPeriodicite.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.PanelPeriodicite.Name = "PanelPeriodicite";
            this.PanelPeriodicite.Size = new System.Drawing.Size(352, 35);
            this.PanelPeriodicite.TabIndex = 10;
            // 
            // listBeneficiairesComboBox
            // 
            this.listBeneficiairesComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBeneficiairesComboBox.FormattingEnabled = true;
            this.listBeneficiairesComboBox.ItemHeight = 23;
            this.listBeneficiairesComboBox.Location = new System.Drawing.Point(3, 3);
            this.listBeneficiairesComboBox.Name = "listBeneficiairesComboBox";
            this.listBeneficiairesComboBox.Size = new System.Drawing.Size(346, 29);
            this.listBeneficiairesComboBox.Sorted = true;
            this.listBeneficiairesComboBox.TabIndex = 3;
            this.listBeneficiairesComboBox.UseSelectable = true;
            // 
            // PanelTousLesXMois
            // 
            this.PanelTousLesXMois.AutoSize = true;
            this.PanelTousLesXMois.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelTousLesXMois.Controls.Add(this.lblTousLes);
            this.PanelTousLesXMois.Controls.Add(this.TxtBoxTousLesXMois);
            this.PanelTousLesXMois.Controls.Add(this.lblDuMois);
            this.PanelTousLesXMois.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTousLesXMois.Location = new System.Drawing.Point(3, 138);
            this.PanelTousLesXMois.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.PanelTousLesXMois.Name = "PanelTousLesXMois";
            this.PanelTousLesXMois.Size = new System.Drawing.Size(352, 26);
            this.PanelTousLesXMois.TabIndex = 11;
            // 
            // lblTousLes
            // 
            this.lblTousLes.AutoSize = true;
            this.lblTousLes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTousLes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTousLes.Location = new System.Drawing.Point(0, 0);
            this.lblTousLes.Margin = new System.Windows.Forms.Padding(0);
            this.lblTousLes.Name = "lblTousLes";
            this.lblTousLes.Size = new System.Drawing.Size(58, 26);
            this.lblTousLes.TabIndex = 9;
            this.lblTousLes.Text = "Tous les";
            this.lblTousLes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBoxTousLesXMois
            // 
            // 
            // 
            // 
            this.TxtBoxTousLesXMois.CustomButton.Image = null;
            this.TxtBoxTousLesXMois.CustomButton.Location = new System.Drawing.Point(22, 2);
            this.TxtBoxTousLesXMois.CustomButton.Name = "";
            this.TxtBoxTousLesXMois.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtBoxTousLesXMois.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBoxTousLesXMois.CustomButton.TabIndex = 1;
            this.TxtBoxTousLesXMois.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBoxTousLesXMois.CustomButton.UseSelectable = true;
            this.TxtBoxTousLesXMois.CustomButton.Visible = false;
            this.TxtBoxTousLesXMois.Lines = new string[0];
            this.TxtBoxTousLesXMois.Location = new System.Drawing.Point(61, 3);
            this.TxtBoxTousLesXMois.MaxLength = 2;
            this.TxtBoxTousLesXMois.MinimumSize = new System.Drawing.Size(29, 0);
            this.TxtBoxTousLesXMois.Name = "TxtBoxTousLesXMois";
            this.TxtBoxTousLesXMois.PasswordChar = '\0';
            this.TxtBoxTousLesXMois.PromptText = "...";
            this.TxtBoxTousLesXMois.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBoxTousLesXMois.SelectedText = "";
            this.TxtBoxTousLesXMois.SelectionLength = 0;
            this.TxtBoxTousLesXMois.SelectionStart = 0;
            this.TxtBoxTousLesXMois.ShortcutsEnabled = true;
            this.TxtBoxTousLesXMois.Size = new System.Drawing.Size(40, 20);
            this.TxtBoxTousLesXMois.TabIndex = 11;
            this.TxtBoxTousLesXMois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxTousLesXMois.UseSelectable = true;
            this.TxtBoxTousLesXMois.WaterMark = "...";
            this.TxtBoxTousLesXMois.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBoxTousLesXMois.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDuMois
            // 
            this.lblDuMois.AutoSize = true;
            this.lblDuMois.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDuMois.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDuMois.Location = new System.Drawing.Point(104, 0);
            this.lblDuMois.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblDuMois.Name = "lblDuMois";
            this.lblDuMois.Size = new System.Drawing.Size(58, 26);
            this.lblDuMois.TabIndex = 12;
            this.lblDuMois.Text = "du mois";
            this.lblDuMois.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMontant.Location = new System.Drawing.Point(3, 179);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(63, 19);
            this.lblMontant.TabIndex = 15;
            this.lblMontant.Text = "Montant";
            // 
            // PanelMontant
            // 
            this.PanelMontant.AutoSize = true;
            this.PanelMontant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelMontant.Controls.Add(this.TxtBoxMontantPosteFixe);
            this.PanelMontant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMontant.Location = new System.Drawing.Point(3, 201);
            this.PanelMontant.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.PanelMontant.Name = "PanelMontant";
            this.PanelMontant.Size = new System.Drawing.Size(352, 26);
            this.PanelMontant.TabIndex = 12;
            // 
            // TxtBoxMontantPosteFixe
            // 
            // 
            // 
            // 
            this.TxtBoxMontantPosteFixe.CustomButton.Image = null;
            this.TxtBoxMontantPosteFixe.CustomButton.Location = new System.Drawing.Point(328, 2);
            this.TxtBoxMontantPosteFixe.CustomButton.Name = "";
            this.TxtBoxMontantPosteFixe.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtBoxMontantPosteFixe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBoxMontantPosteFixe.CustomButton.TabIndex = 1;
            this.TxtBoxMontantPosteFixe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBoxMontantPosteFixe.CustomButton.UseSelectable = true;
            this.TxtBoxMontantPosteFixe.CustomButton.Visible = false;
            this.TxtBoxMontantPosteFixe.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBoxMontantPosteFixe.Lines = new string[0];
            this.TxtBoxMontantPosteFixe.Location = new System.Drawing.Point(3, 3);
            this.TxtBoxMontantPosteFixe.MaxLength = 10;
            this.TxtBoxMontantPosteFixe.Name = "TxtBoxMontantPosteFixe";
            this.TxtBoxMontantPosteFixe.PasswordChar = '\0';
            this.TxtBoxMontantPosteFixe.PromptText = "placeholder_amount_to_pay_monthly";
            this.TxtBoxMontantPosteFixe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBoxMontantPosteFixe.SelectedText = "";
            this.TxtBoxMontantPosteFixe.SelectionLength = 0;
            this.TxtBoxMontantPosteFixe.SelectionStart = 0;
            this.TxtBoxMontantPosteFixe.ShortcutsEnabled = true;
            this.TxtBoxMontantPosteFixe.Size = new System.Drawing.Size(346, 20);
            this.TxtBoxMontantPosteFixe.TabIndex = 4;
            this.TxtBoxMontantPosteFixe.UseSelectable = true;
            this.TxtBoxMontantPosteFixe.WaterMark = "placeholder_amount_to_pay_monthly";
            this.TxtBoxMontantPosteFixe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBoxMontantPosteFixe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ModifierEntreePosteRevenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "ModifierEntreePosteRevenu";
            this.Resizable = false;
            this.Text = "ModifierEntreePosteRevenu";
            this.Load += new System.EventHandler(this.ModifierEntreePosteFixe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.PanelPeriodicite.ResumeLayout(false);
            this.PanelTousLesXMois.ResumeLayout(false);
            this.PanelTousLesXMois.PerformLayout();
            this.PanelMontant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton Submit;
        private MetroFramework.Controls.MetroButton Cancel;
        private MetroFramework.Controls.MetroLabel lblCmbPostes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MetroFramework.Controls.MetroTextBox txtBoxLibPoste;
        private System.Windows.Forms.FlowLayoutPanel PanelPeriodicite;
        private MetroFramework.Controls.MetroComboBox listBeneficiairesComboBox;
        private System.Windows.Forms.FlowLayoutPanel PanelTousLesXMois;
        private MetroFramework.Controls.MetroLabel lblTousLes;
        private MetroFramework.Controls.MetroTextBox TxtBoxTousLesXMois;
        private MetroFramework.Controls.MetroLabel lblDuMois;
        private System.Windows.Forms.FlowLayoutPanel PanelMontant;
        private MetroFramework.Controls.MetroTextBox TxtBoxMontantPosteFixe;
        private MetroFramework.Controls.MetroLabel lblMontant;
        private MetroFramework.Controls.MetroLabel lblBeneficiaireRevenu;
    }
}