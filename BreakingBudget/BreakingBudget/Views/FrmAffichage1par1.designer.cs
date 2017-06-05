namespace BreakingBudget
{
    partial class FrmAffichage1par1
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
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblTitreDescription = new MetroFramework.Controls.MetroLabel();
            this.lblTitreMontant = new MetroFramework.Controls.MetroLabel();
            this.lblMontant = new MetroFramework.Controls.MetroLabel();
            this.btnSuivant = new MetroFramework.Controls.MetroButton();
            this.btnPrecedent = new MetroFramework.Controls.MetroButton();
            this.btnDernier = new MetroFramework.Controls.MetroButton();
            this.btnPremier = new MetroFramework.Controls.MetroButton();
            this.lblTitreDate = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblTitreType = new MetroFramework.Controls.MetroLabel();
            this.lblType = new MetroFramework.Controls.MetroLabel();
            this.lstPersonnes = new System.Windows.Forms.ListBox();
            this.lblTitrePersonnes = new MetroFramework.Controls.MetroLabel();
            this.chkPercu = new MetroFramework.Controls.MetroCheckBox();
            this.chkRecette = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Location = new System.Drawing.Point(116, 158);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(302, 77);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "";
            // 
            // lblTitreDescription
            // 
            this.lblTitreDescription.AutoSize = true;
            this.lblTitreDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreDescription.Location = new System.Drawing.Point(25, 158);
            this.lblTitreDescription.Name = "lblTitreDescription";
            this.lblTitreDescription.Size = new System.Drawing.Size(85, 19);
            this.lblTitreDescription.TabIndex = 1;
            this.lblTitreDescription.Text = "Description :";
            // 
            // lblTitreMontant
            // 
            this.lblTitreMontant.AutoSize = true;
            this.lblTitreMontant.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreMontant.Location = new System.Drawing.Point(40, 103);
            this.lblTitreMontant.Name = "lblTitreMontant";
            this.lblTitreMontant.Size = new System.Drawing.Size(70, 19);
            this.lblTitreMontant.TabIndex = 2;
            this.lblTitreMontant.Text = "Montant :";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMontant.Location = new System.Drawing.Point(117, 103);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(45, 19);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "label1";
            this.lblMontant.TextChanged += new System.EventHandler(this.lblMontant_TextChanged);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(187, 449);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(64, 19);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseSelectable = true;
            this.btnSuivant.Click += new System.EventHandler(this.afficherRes);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(117, 449);
            this.btnPrecedent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(64, 19);
            this.btnPrecedent.TabIndex = 5;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseSelectable = true;
            this.btnPrecedent.Click += new System.EventHandler(this.afficherRes);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(256, 449);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(64, 19);
            this.btnDernier.TabIndex = 6;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseSelectable = true;
            this.btnDernier.Click += new System.EventHandler(this.afficherRes);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(48, 449);
            this.btnPremier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(64, 19);
            this.btnPremier.TabIndex = 7;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseSelectable = true;
            this.btnPremier.Click += new System.EventHandler(this.afficherRes);
            // 
            // lblTitreDate
            // 
            this.lblTitreDate.AutoSize = true;
            this.lblTitreDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreDate.Location = new System.Drawing.Point(40, 83);
            this.lblTitreDate.Name = "lblTitreDate";
            this.lblTitreDate.Size = new System.Drawing.Size(45, 19);
            this.lblTitreDate.TabIndex = 8;
            this.lblTitreDate.Text = "Date :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(117, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "label1";
            this.lblDate.TextChanged += new System.EventHandler(this.lblDate_TextChanged);
            // 
            // lblTitreType
            // 
            this.lblTitreType.AutoSize = true;
            this.lblTitreType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreType.Location = new System.Drawing.Point(40, 125);
            this.lblTitreType.Name = "lblTitreType";
            this.lblTitreType.Size = new System.Drawing.Size(45, 19);
            this.lblTitreType.TabIndex = 10;
            this.lblTitreType.Text = "Type :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblType.Location = new System.Drawing.Point(117, 126);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(23, 19);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "lbl";
            // 
            // lstPersonnes
            // 
            this.lstPersonnes.FormattingEnabled = true;
            this.lstPersonnes.Location = new System.Drawing.Point(117, 279);
            this.lstPersonnes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPersonnes.Name = "lstPersonnes";
            this.lstPersonnes.Size = new System.Drawing.Size(301, 134);
            this.lstPersonnes.TabIndex = 12;
            // 
            // lblTitrePersonnes
            // 
            this.lblTitrePersonnes.AutoSize = true;
            this.lblTitrePersonnes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitrePersonnes.Location = new System.Drawing.Point(32, 279);
            this.lblTitrePersonnes.Name = "lblTitrePersonnes";
            this.lblTitrePersonnes.Size = new System.Drawing.Size(79, 19);
            this.lblTitrePersonnes.TabIndex = 13;
            this.lblTitrePersonnes.Text = "Personnes :";
            // 
            // chkPercu
            // 
            this.chkPercu.AutoSize = true;
            this.chkPercu.Enabled = false;
            this.chkPercu.Location = new System.Drawing.Point(177, 108);
            this.chkPercu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPercu.Name = "chkPercu";
            this.chkPercu.Size = new System.Drawing.Size(53, 15);
            this.chkPercu.TabIndex = 14;
            this.chkPercu.Text = "Percu";
            this.chkPercu.UseSelectable = true;
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Enabled = false;
            this.chkRecette.Location = new System.Drawing.Point(236, 108);
            this.chkRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(62, 15);
            this.chkRecette.TabIndex = 15;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseSelectable = true;
            // 
            // FrmAffichage1par1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 493);
            this.Controls.Add(this.chkRecette);
            this.Controls.Add(this.chkPercu);
            this.Controls.Add(this.lblTitrePersonnes);
            this.Controls.Add(this.lstPersonnes);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitreType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitreDate);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblTitreMontant);
            this.Controls.Add(this.lblTitreDescription);
            this.Controls.Add(this.rtxtDescription);
            this.MaximizeBox = false;
            this.Name = "FrmAffichage1par1";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 16);
            this.Resizable = false;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.FrmAffichage1par1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDescription;
        private MetroFramework.Controls.MetroLabel lblTitreDescription;
        private MetroFramework.Controls.MetroLabel lblTitreMontant;
        private MetroFramework.Controls.MetroLabel lblMontant;
        private MetroFramework.Controls.MetroButton btnSuivant;
        private MetroFramework.Controls.MetroButton btnPrecedent;
        private MetroFramework.Controls.MetroButton btnDernier;
        private MetroFramework.Controls.MetroButton btnPremier;
        private MetroFramework.Controls.MetroLabel lblTitreDate;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblTitreType;
        private MetroFramework.Controls.MetroLabel lblType;
        private System.Windows.Forms.ListBox lstPersonnes;
        private MetroFramework.Controls.MetroLabel lblTitrePersonnes;
        private MetroFramework.Controls.MetroCheckBox chkPercu;
        private MetroFramework.Controls.MetroCheckBox chkRecette;
    }
}