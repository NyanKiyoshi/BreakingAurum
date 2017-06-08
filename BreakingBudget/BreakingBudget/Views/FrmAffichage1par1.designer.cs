namespace BreakingBudget.Views
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
            this.components = new System.ComponentModel.Container();
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
            this.lblPage = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtDescription
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.rtxtDescription, true);
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Location = new System.Drawing.Point(122, 176);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(302, 77);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "";
            // 
            // lblTitreDescription
            // 
            this.lblTitreDescription.AutoSize = true;
            this.lblTitreDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreDescription.Location = new System.Drawing.Point(25, 176);
            this.lblTitreDescription.Name = "lblTitreDescription";
            this.lblTitreDescription.Size = new System.Drawing.Size(85, 19);
            this.lblTitreDescription.TabIndex = 1;
            this.lblTitreDescription.Text = "Description :";
            // 
            // lblTitreMontant
            // 
            this.lblTitreMontant.AutoSize = true;
            this.lblTitreMontant.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreMontant.Location = new System.Drawing.Point(40, 121);
            this.lblTitreMontant.Name = "lblTitreMontant";
            this.lblTitreMontant.Size = new System.Drawing.Size(70, 19);
            this.lblTitreMontant.TabIndex = 2;
            this.lblTitreMontant.Text = "Montant :";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMontant.Location = new System.Drawing.Point(0, 0);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(65, 19);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "{amount}";
            this.lblMontant.TextChanged += new System.EventHandler(this.lblMontant_TextChanged);
            // 
            // btnSuivant
            // 
            this.btnSuivant.AutoSize = true;
            this.btnSuivant.Location = new System.Drawing.Point(3, 2);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(64, 23);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseSelectable = true;
            this.btnSuivant.Click += new System.EventHandler(this.afficherRes);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.AutoSize = true;
            this.btnPrecedent.Location = new System.Drawing.Point(73, 2);
            this.btnPrecedent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(66, 23);
            this.btnPrecedent.TabIndex = 5;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseSelectable = true;
            this.btnPrecedent.Click += new System.EventHandler(this.afficherRes);
            // 
            // btnDernier
            // 
            this.btnDernier.AutoSize = true;
            this.btnDernier.Location = new System.Drawing.Point(73, 2);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(64, 23);
            this.btnDernier.TabIndex = 6;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseSelectable = true;
            this.btnDernier.Click += new System.EventHandler(this.afficherRes);
            // 
            // btnPremier
            // 
            this.btnPremier.AutoSize = true;
            this.btnPremier.Location = new System.Drawing.Point(3, 2);
            this.btnPremier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(64, 23);
            this.btnPremier.TabIndex = 7;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseSelectable = true;
            this.btnPremier.Click += new System.EventHandler(this.afficherRes);
            // 
            // lblTitreDate
            // 
            this.lblTitreDate.AutoSize = true;
            this.lblTitreDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreDate.Location = new System.Drawing.Point(40, 101);
            this.lblTitreDate.Name = "lblTitreDate";
            this.lblTitreDate.Size = new System.Drawing.Size(45, 19);
            this.lblTitreDate.TabIndex = 8;
            this.lblTitreDate.Text = "Date :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 19);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "{date}";
            // 
            // lblTitreType
            // 
            this.lblTitreType.AutoSize = true;
            this.lblTitreType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitreType.Location = new System.Drawing.Point(40, 143);
            this.lblTitreType.Name = "lblTitreType";
            this.lblTitreType.Size = new System.Drawing.Size(45, 19);
            this.lblTitreType.TabIndex = 10;
            this.lblTitreType.Text = "Type :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblType.Location = new System.Drawing.Point(0, 0);
            this.lblType.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 19);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "{type}";
            // 
            // lstPersonnes
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.lstPersonnes, true);
            this.lstPersonnes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPersonnes.FormattingEnabled = true;
            this.lstPersonnes.Location = new System.Drawing.Point(123, 297);
            this.lstPersonnes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPersonnes.Name = "lstPersonnes";
            this.lstPersonnes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPersonnes.Size = new System.Drawing.Size(301, 130);
            this.lstPersonnes.TabIndex = 12;
            // 
            // lblTitrePersonnes
            // 
            this.lblTitrePersonnes.AutoSize = true;
            this.lblTitrePersonnes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitrePersonnes.Location = new System.Drawing.Point(32, 297);
            this.lblTitrePersonnes.Name = "lblTitrePersonnes";
            this.lblTitrePersonnes.Size = new System.Drawing.Size(79, 19);
            this.lblTitrePersonnes.TabIndex = 13;
            this.lblTitrePersonnes.Text = "Personnes :";
            // 
            // chkPercu
            // 
            this.chkPercu.AutoSize = true;
            this.chkPercu.Enabled = false;
            this.chkPercu.Location = new System.Drawing.Point(71, 2);
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
            this.chkRecette.Location = new System.Drawing.Point(130, 2);
            this.chkRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(62, 15);
            this.chkRecette.TabIndex = 15;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseSelectable = true;
            // 
            // lblPage
            // 
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPage.Location = new System.Drawing.Point(17, 60);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(426, 19);
            this.lblPage.TabIndex = 16;
            this.lblPage.Text = "page x of n";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 444);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 33);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnPrecedent);
            this.flowLayoutPanel2.Controls.Add(this.btnPremier);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(68, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(142, 27);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnSuivant);
            this.flowLayoutPanel1.Controls.Add(this.btnDernier);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(216, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.lblMontant);
            this.flowLayoutPanel3.Controls.Add(this.chkPercu);
            this.flowLayoutPanel3.Controls.Add(this.chkRecette);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(119, 124);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(195, 19);
            this.flowLayoutPanel3.TabIndex = 18;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.lblDate);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(119, 103);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(47, 19);
            this.flowLayoutPanel4.TabIndex = 19;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.lblType);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(119, 145);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(47, 19);
            this.flowLayoutPanel5.TabIndex = 20;
            this.flowLayoutPanel5.WrapContents = false;
            // 
            // FrmAffichage1par1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 493);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblTitrePersonnes);
            this.Controls.Add(this.lstPersonnes);
            this.Controls.Add(this.lblTitreType);
            this.Controls.Add(this.lblTitreDate);
            this.Controls.Add(this.lblTitreMontant);
            this.Controls.Add(this.lblTitreDescription);
            this.Controls.Add(this.rtxtDescription);
            this.MaximizeBox = false;
            this.Name = "FrmAffichage1par1";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 16);
            this.Resizable = false;
            this.Text = "Transactions";
            this.Icon = global::BreakingBudget.Properties.Resources.icon;
            this.Load += new System.EventHandler(this.FrmAffichage1par1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel lblPage;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}