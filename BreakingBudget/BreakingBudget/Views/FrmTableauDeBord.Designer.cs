namespace BreakingBudget
{
    partial class FrmTableauDeBord
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
            this.grbRecherche = new System.Windows.Forms.GroupBox();
            this.txtMontant = new MetroFramework.Controls.MetroTextBox();
            this.txtLib = new MetroFramework.Controls.MetroTextBox();
            this.ckbMontant = new MetroFramework.Controls.MetroCheckBox();
            this.ckbLib = new MetroFramework.Controls.MetroCheckBox();
            this.ckbDate = new MetroFramework.Controls.MetroCheckBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.ckbPercu = new MetroFramework.Controls.MetroCheckBox();
            this.ckbRecette = new MetroFramework.Controls.MetroCheckBox();
            this.rdbPlage = new MetroFramework.Controls.MetroRadioButton();
            this.rdbDateUnique = new MetroFramework.Controls.MetroRadioButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateDeb = new MetroFramework.Controls.MetroLabel();
            this.dtpDeb = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateA = new MetroFramework.Controls.MetroLabel();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dgvTransac = new System.Windows.Forms.DataGridView();
            this.cmsDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbRecherche.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransac)).BeginInit();
            this.cmsDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRecherche
            // 
            this.grbRecherche.Controls.Add(this.txtMontant);
            this.grbRecherche.Controls.Add(this.txtLib);
            this.grbRecherche.Controls.Add(this.ckbMontant);
            this.grbRecherche.Controls.Add(this.ckbLib);
            this.grbRecherche.Controls.Add(this.ckbDate);
            this.grbRecherche.Controls.Add(this.btnClear);
            this.grbRecherche.Controls.Add(this.btnSearch);
            this.grbRecherche.Controls.Add(this.ckbPercu);
            this.grbRecherche.Controls.Add(this.ckbRecette);
            this.grbRecherche.Controls.Add(this.rdbPlage);
            this.grbRecherche.Controls.Add(this.rdbDateUnique);
            this.grbRecherche.Controls.Add(this.flowLayoutPanel3);
            this.grbRecherche.Location = new System.Drawing.Point(12, 11);
            this.grbRecherche.Name = "grbRecherche";
            this.grbRecherche.Size = new System.Drawing.Size(642, 134);
            this.grbRecherche.TabIndex = 0;
            this.grbRecherche.TabStop = false;
            this.grbRecherche.Text = "Recherche";
            // 
            // txtMontant
            // 
            // 
            // 
            // 
            this.txtMontant.CustomButton.Image = null;
            this.txtMontant.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.txtMontant.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontant.CustomButton.Name = "";
            this.txtMontant.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontant.CustomButton.TabIndex = 1;
            this.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontant.CustomButton.UseSelectable = true;
            this.txtMontant.CustomButton.Visible = false;
            this.txtMontant.Lines = new string[0];
            this.txtMontant.Location = new System.Drawing.Point(395, 49);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontant.MaxLength = 32767;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontant.SelectedText = "";
            this.txtMontant.SelectionLength = 0;
            this.txtMontant.SelectionStart = 0;
            this.txtMontant.ShortcutsEnabled = true;
            this.txtMontant.Size = new System.Drawing.Size(112, 20);
            this.txtMontant.TabIndex = 6;
            this.txtMontant.UseSelectable = true;
            this.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            this.txtMontant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMontant_KeyUp);
            // 
            // txtLib
            // 
            // 
            // 
            // 
            this.txtLib.CustomButton.Image = null;
            this.txtLib.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtLib.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLib.CustomButton.Name = "";
            this.txtLib.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtLib.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLib.CustomButton.TabIndex = 1;
            this.txtLib.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLib.CustomButton.UseSelectable = true;
            this.txtLib.CustomButton.Visible = false;
            this.txtLib.Lines = new string[0];
            this.txtLib.Location = new System.Drawing.Point(380, 23);
            this.txtLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLib.MaxLength = 32767;
            this.txtLib.Name = "txtLib";
            this.txtLib.PasswordChar = '\0';
            this.txtLib.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLib.SelectedText = "";
            this.txtLib.SelectionLength = 0;
            this.txtLib.SelectionStart = 0;
            this.txtLib.ShortcutsEnabled = true;
            this.txtLib.Size = new System.Drawing.Size(184, 20);
            this.txtLib.TabIndex = 5;
            this.txtLib.UseSelectable = true;
            this.txtLib.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLib.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLib_KeyPress);
            // 
            // ckbMontant
            // 
            this.ckbMontant.AutoSize = true;
            this.ckbMontant.Location = new System.Drawing.Point(304, 50);
            this.ckbMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbMontant.Name = "ckbMontant";
            this.ckbMontant.Size = new System.Drawing.Size(78, 15);
            this.ckbMontant.TabIndex = 33;
            this.ckbMontant.Text = "Montant : ";
            this.ckbMontant.UseSelectable = true;
            this.ckbMontant.Click += new System.EventHandler(this.ckbMontant_Click);
            // 
            // ckbLib
            // 
            this.ckbLib.Location = new System.Drawing.Point(304, 21);
            this.ckbLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbLib.Name = "ckbLib";
            this.ckbLib.Size = new System.Drawing.Size(85, 21);
            this.ckbLib.TabIndex = 32;
            this.ckbLib.Text = "Libellé : ";
            this.ckbLib.UseSelectable = true;
            this.ckbLib.Click += new System.EventHandler(this.ckbLib_Click);
            // 
            // ckbDate
            // 
            this.ckbDate.AutoSize = true;
            this.ckbDate.Location = new System.Drawing.Point(6, 22);
            this.ckbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbDate.Name = "ckbDate";
            this.ckbDate.Size = new System.Drawing.Size(56, 15);
            this.ckbDate.TabIndex = 31;
            this.ckbDate.Text = "Date : ";
            this.ckbDate.UseSelectable = true;
            this.ckbDate.Click += new System.EventHandler(this.ckbDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(477, 106);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(541, 106);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ckbPercu
            // 
            this.ckbPercu.AutoSize = true;
            this.ckbPercu.Location = new System.Drawing.Point(513, 65);
            this.ckbPercu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbPercu.Name = "ckbPercu";
            this.ckbPercu.Size = new System.Drawing.Size(53, 15);
            this.ckbPercu.TabIndex = 8;
            this.ckbPercu.Text = "Perçu";
            this.ckbPercu.UseSelectable = true;
            this.ckbPercu.Click += new System.EventHandler(this.ckbPercu_Click);
            // 
            // ckbRecette
            // 
            this.ckbRecette.AutoSize = true;
            this.ckbRecette.Location = new System.Drawing.Point(513, 47);
            this.ckbRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbRecette.Name = "ckbRecette";
            this.ckbRecette.Size = new System.Drawing.Size(62, 15);
            this.ckbRecette.TabIndex = 7;
            this.ckbRecette.Text = "Recette";
            this.ckbRecette.UseSelectable = true;
            this.ckbRecette.Click += new System.EventHandler(this.ckbRecette_Click);
            // 
            // rdbPlage
            // 
            this.rdbPlage.AutoSize = true;
            this.rdbPlage.Location = new System.Drawing.Point(176, 23);
            this.rdbPlage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPlage.Name = "rdbPlage";
            this.rdbPlage.Size = new System.Drawing.Size(52, 15);
            this.rdbPlage.TabIndex = 2;
            this.rdbPlage.Text = "Plage";
            this.rdbPlage.UseSelectable = true;
            this.rdbPlage.Click += new System.EventHandler(this.rdbPlage_Click);
            // 
            // rdbDateUnique
            // 
            this.rdbDateUnique.AutoSize = true;
            this.rdbDateUnique.Checked = true;
            this.rdbDateUnique.Location = new System.Drawing.Point(83, 23);
            this.rdbDateUnique.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDateUnique.Name = "rdbDateUnique";
            this.rdbDateUnique.Size = new System.Drawing.Size(61, 15);
            this.rdbDateUnique.TabIndex = 1;
            this.rdbDateUnique.TabStop = true;
            this.rdbDateUnique.Text = "Unique";
            this.rdbDateUnique.UseSelectable = true;
            this.rdbDateUnique.Click += new System.EventHandler(this.rdbDateUnique_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.panel);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(23, 43);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(263, 80);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblDateDeb);
            this.flowLayoutPanel1.Controls.Add(this.dtpDeb);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 24);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lblDateDeb
            // 
            this.lblDateDeb.AutoSize = true;
            this.lblDateDeb.Location = new System.Drawing.Point(3, 0);
            this.lblDateDeb.Name = "lblDateDeb";
            this.lblDateDeb.Size = new System.Drawing.Size(36, 19);
            this.lblDateDeb.TabIndex = 54;
            this.lblDateDeb.Text = "De : ";
            this.lblDateDeb.Visible = false;
            // 
            // dtpDeb
            // 
            this.dtpDeb.Location = new System.Drawing.Point(45, 2);
            this.dtpDeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDeb.Name = "dtpDeb";
            this.dtpDeb.Size = new System.Drawing.Size(200, 20);
            this.dtpDeb.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblDateA);
            this.panel.Controls.Add(this.dtpFin);
            this.panel.Location = new System.Drawing.Point(3, 30);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(260, 32);
            this.panel.TabIndex = 9;
            // 
            // lblDateA
            // 
            this.lblDateA.Location = new System.Drawing.Point(3, 0);
            this.lblDateA.Name = "lblDateA";
            this.lblDateA.Size = new System.Drawing.Size(40, 18);
            this.lblDateA.TabIndex = 70;
            this.lblDateA.Text = "A : ";
            this.lblDateA.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(49, 2);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 4;
            this.dtpFin.Visible = false;
            // 
            // dgvTransac
            // 
            this.dgvTransac.AllowUserToAddRows = false;
            this.dgvTransac.AllowUserToDeleteRows = false;
            this.dgvTransac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTransac.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTransac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransac.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTransac.Location = new System.Drawing.Point(13, 150);
            this.dgvTransac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTransac.MultiSelect = false;
            this.dgvTransac.Name = "dgvTransac";
            this.dgvTransac.ReadOnly = true;
            this.dgvTransac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransac.Size = new System.Drawing.Size(641, 176);
            this.dgvTransac.TabIndex = 1;
            this.dgvTransac.TabStop = false;
            this.dgvTransac.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTransac_CellMouseClick);
            // 
            // cmsDgv
            // 
            this.cmsDgv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.cmsDgv.Name = "cmsDgv";
            this.cmsDgv.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 340);
            this.Controls.Add(this.dgvTransac);
            this.Controls.Add(this.grbRecherche);
            this.MaximizeBox = false;
            this.Name = "FrmTableauDeBord";
            this.Padding = new System.Windows.Forms.Padding(20, 49, 20, 16);
            this.Text = "FrmTableauDeBord";
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.grbRecherche.ResumeLayout(false);
            this.grbRecherche.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransac)).EndInit();
            this.cmsDgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRecherche;
        private System.Windows.Forms.DataGridView dgvTransac;
        private System.Windows.Forms.ContextMenuStrip cmsDgv;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDeb;
        private MetroFramework.Controls.MetroLabel lblDateDeb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private MetroFramework.Controls.MetroLabel lblDateA;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private MetroFramework.Controls.MetroRadioButton rdbPlage;
        private MetroFramework.Controls.MetroRadioButton rdbDateUnique;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroCheckBox ckbPercu;
        private MetroFramework.Controls.MetroCheckBox ckbRecette;
        private MetroFramework.Controls.MetroTextBox txtMontant;
        private MetroFramework.Controls.MetroTextBox txtLib;
        private MetroFramework.Controls.MetroCheckBox ckbDate;
        private MetroFramework.Controls.MetroCheckBox ckbMontant;
        private MetroFramework.Controls.MetroCheckBox ckbLib;
    }
}