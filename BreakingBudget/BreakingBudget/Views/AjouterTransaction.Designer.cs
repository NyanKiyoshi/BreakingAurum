namespace BreakingBudget.Views
{
    partial class AjouterTransaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContainerAjouterTransaction = new System.Windows.Forms.Panel();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateT = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.calAjoutTransaction = new MetroFramework.Controls.MetroDateTime();
            this.ldlDesc = new MetroFramework.Controls.MetroLabel();
            this.FieldsContainerTxtDescr = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAjoutTransaction_desc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAjoutTransaction_montant = new MetroFramework.Controls.MetroTextBox();
            this.ckbAjoutTransaction_recette = new MetroFramework.Controls.MetroCheckBox();
            this.ckbAjoutTransaction_percu = new MetroFramework.Controls.MetroCheckBox();
            this.lbType = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboAjoutTransaction_Type = new MetroFramework.Controls.MetroComboBox();
            this.btnAjoutTransaction_AddType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAjoutTransaction_OK = new MetroFramework.Controls.MetroButton();
            this.btnAjoutTransaction_modif = new MetroFramework.Controls.MetroButton();
            this.btnAjoutTransaction_Annuler2 = new MetroFramework.Controls.MetroButton();
            this.panelAjoutTransac = new System.Windows.Forms.Panel();
            this.ckbTtSelect = new MetroFramework.Controls.MetroCheckBox();
            this.btnAddPers = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAjoutTransaction_Personne = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.ContainerAjouterTransaction.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.FieldsContainerTxtDescr.SuspendLayout();
            this.flowLayoutPanel19.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAjoutTransac.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ContainerAjouterTransaction);
            this.panel1.Controls.Add(this.panelAjoutTransac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 364);
            this.panel1.TabIndex = 1;
            // 
            // ContainerAjouterTransaction
            // 
            this.ContainerAjouterTransaction.Controls.Add(this.flowLayoutPanel15);
            this.ContainerAjouterTransaction.Controls.Add(this.panel3);
            this.ContainerAjouterTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerAjouterTransaction.Location = new System.Drawing.Point(0, 0);
            this.ContainerAjouterTransaction.Name = "ContainerAjouterTransaction";
            this.ContainerAjouterTransaction.Padding = new System.Windows.Forms.Padding(10);
            this.ContainerAjouterTransaction.Size = new System.Drawing.Size(623, 364);
            this.ContainerAjouterTransaction.TabIndex = 28;
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.AutoSize = true;
            this.flowLayoutPanel15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel15.Controls.Add(this.lblDateT);
            this.flowLayoutPanel15.Controls.Add(this.flowLayoutPanel16);
            this.flowLayoutPanel15.Controls.Add(this.ldlDesc);
            this.flowLayoutPanel15.Controls.Add(this.FieldsContainerTxtDescr);
            this.flowLayoutPanel15.Controls.Add(this.metroLabel5);
            this.flowLayoutPanel15.Controls.Add(this.flowLayoutPanel19);
            this.flowLayoutPanel15.Controls.Add(this.lbType);
            this.flowLayoutPanel15.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel15.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel15.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(603, 318);
            this.flowLayoutPanel15.TabIndex = 30;
            this.flowLayoutPanel15.WrapContents = false;
            // 
            // lblDateT
            // 
            this.lblDateT.AutoSize = true;
            this.lblDateT.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDateT.Location = new System.Drawing.Point(3, 0);
            this.lblDateT.Name = "lblDateT";
            this.lblDateT.Size = new System.Drawing.Size(143, 19);
            this.lblDateT.TabIndex = 7;
            this.lblDateT.Text = "Date de la transaction";
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.AutoSize = true;
            this.flowLayoutPanel16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel16.Controls.Add(this.calAjoutTransaction);
            this.flowLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel16.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(479, 35);
            this.flowLayoutPanel16.TabIndex = 4;
            this.flowLayoutPanel16.WrapContents = false;
            // 
            // calAjoutTransaction
            // 
            this.calAjoutTransaction.Location = new System.Drawing.Point(3, 3);
            this.calAjoutTransaction.MinimumSize = new System.Drawing.Size(0, 29);
            this.calAjoutTransaction.Name = "calAjoutTransaction";
            this.calAjoutTransaction.Size = new System.Drawing.Size(219, 29);
            this.calAjoutTransaction.TabIndex = 37;
            // 
            // ldlDesc
            // 
            this.ldlDesc.AutoSize = true;
            this.ldlDesc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ldlDesc.Location = new System.Drawing.Point(3, 72);
            this.ldlDesc.Name = "ldlDesc";
            this.ldlDesc.Size = new System.Drawing.Size(78, 19);
            this.ldlDesc.TabIndex = 7;
            this.ldlDesc.Text = "Description";
            // 
            // FieldsContainerTxtDescr
            // 
            this.FieldsContainerTxtDescr.AutoSize = true;
            this.FieldsContainerTxtDescr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FieldsContainerTxtDescr.Controls.Add(this.txtAjoutTransaction_desc);
            this.FieldsContainerTxtDescr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsContainerTxtDescr.Location = new System.Drawing.Point(3, 94);
            this.FieldsContainerTxtDescr.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.FieldsContainerTxtDescr.Name = "FieldsContainerTxtDescr";
            this.FieldsContainerTxtDescr.Size = new System.Drawing.Size(479, 26);
            this.FieldsContainerTxtDescr.TabIndex = 6;
            // 
            // txtAjoutTransaction_desc
            // 
            // 
            // 
            // 
            this.txtAjoutTransaction_desc.CustomButton.Image = null;
            this.txtAjoutTransaction_desc.CustomButton.Location = new System.Drawing.Point(328, 2);
            this.txtAjoutTransaction_desc.CustomButton.Name = "";
            this.txtAjoutTransaction_desc.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAjoutTransaction_desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAjoutTransaction_desc.CustomButton.TabIndex = 1;
            this.txtAjoutTransaction_desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAjoutTransaction_desc.CustomButton.UseSelectable = true;
            this.txtAjoutTransaction_desc.CustomButton.Visible = false;
            this.txtAjoutTransaction_desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAjoutTransaction_desc.Lines = new string[0];
            this.txtAjoutTransaction_desc.Location = new System.Drawing.Point(3, 3);
            this.txtAjoutTransaction_desc.MaxLength = 255;
            this.txtAjoutTransaction_desc.Name = "txtAjoutTransaction_desc";
            this.txtAjoutTransaction_desc.PasswordChar = '\0';
            this.txtAjoutTransaction_desc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAjoutTransaction_desc.SelectedText = "";
            this.txtAjoutTransaction_desc.SelectionLength = 0;
            this.txtAjoutTransaction_desc.SelectionStart = 0;
            this.txtAjoutTransaction_desc.ShortcutsEnabled = true;
            this.txtAjoutTransaction_desc.Size = new System.Drawing.Size(346, 20);
            this.txtAjoutTransaction_desc.TabIndex = 5;
            this.txtAjoutTransaction_desc.UseSelectable = true;
            this.txtAjoutTransaction_desc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAjoutTransaction_desc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(3, 135);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Montant";
            // 
            // flowLayoutPanel19
            // 
            this.flowLayoutPanel19.AutoSize = true;
            this.flowLayoutPanel19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel19.Controls.Add(this.txtAjoutTransaction_montant);
            this.flowLayoutPanel19.Controls.Add(this.ckbAjoutTransaction_recette);
            this.flowLayoutPanel19.Controls.Add(this.ckbAjoutTransaction_percu);
            this.flowLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel19.Location = new System.Drawing.Point(3, 157);
            this.flowLayoutPanel19.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.flowLayoutPanel19.Name = "flowLayoutPanel19";
            this.flowLayoutPanel19.Size = new System.Drawing.Size(479, 26);
            this.flowLayoutPanel19.TabIndex = 9;
            // 
            // txtAjoutTransaction_montant
            // 
            // 
            // 
            // 
            this.txtAjoutTransaction_montant.CustomButton.Image = null;
            this.txtAjoutTransaction_montant.CustomButton.Location = new System.Drawing.Point(328, 2);
            this.txtAjoutTransaction_montant.CustomButton.Name = "";
            this.txtAjoutTransaction_montant.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAjoutTransaction_montant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAjoutTransaction_montant.CustomButton.TabIndex = 1;
            this.txtAjoutTransaction_montant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAjoutTransaction_montant.CustomButton.UseSelectable = true;
            this.txtAjoutTransaction_montant.CustomButton.Visible = false;
            this.txtAjoutTransaction_montant.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAjoutTransaction_montant.Lines = new string[0];
            this.txtAjoutTransaction_montant.Location = new System.Drawing.Point(3, 3);
            this.txtAjoutTransaction_montant.MaxLength = 10;
            this.txtAjoutTransaction_montant.Name = "txtAjoutTransaction_montant";
            this.txtAjoutTransaction_montant.PasswordChar = '\0';
            this.txtAjoutTransaction_montant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAjoutTransaction_montant.SelectedText = "";
            this.txtAjoutTransaction_montant.SelectionLength = 0;
            this.txtAjoutTransaction_montant.SelectionStart = 0;
            this.txtAjoutTransaction_montant.ShortcutsEnabled = true;
            this.txtAjoutTransaction_montant.Size = new System.Drawing.Size(346, 20);
            this.txtAjoutTransaction_montant.TabIndex = 4;
            this.txtAjoutTransaction_montant.UseSelectable = true;
            this.txtAjoutTransaction_montant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAjoutTransaction_montant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAjoutTransaction_montant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            this.txtAjoutTransaction_montant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantAjoutTransaction_KeyPress);
            this.txtAjoutTransaction_montant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMontantAjoutTransaction_KeyUp);
            // 
            // ckbAjoutTransaction_recette
            // 
            this.ckbAjoutTransaction_recette.AutoSize = true;
            this.ckbAjoutTransaction_recette.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckbAjoutTransaction_recette.Location = new System.Drawing.Point(355, 3);
            this.ckbAjoutTransaction_recette.Name = "ckbAjoutTransaction_recette";
            this.ckbAjoutTransaction_recette.Size = new System.Drawing.Size(62, 20);
            this.ckbAjoutTransaction_recette.TabIndex = 5;
            this.ckbAjoutTransaction_recette.Text = "Recette";
            this.ckbAjoutTransaction_recette.UseSelectable = true;
            this.ckbAjoutTransaction_recette.Click += new System.EventHandler(this.ckbRecetteAjoutTransaction_Click);
            // 
            // ckbAjoutTransaction_percu
            // 
            this.ckbAjoutTransaction_percu.AutoSize = true;
            this.ckbAjoutTransaction_percu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckbAjoutTransaction_percu.Location = new System.Drawing.Point(423, 3);
            this.ckbAjoutTransaction_percu.Name = "ckbAjoutTransaction_percu";
            this.ckbAjoutTransaction_percu.Size = new System.Drawing.Size(53, 20);
            this.ckbAjoutTransaction_percu.TabIndex = 6;
            this.ckbAjoutTransaction_percu.Text = "Perçu";
            this.ckbAjoutTransaction_percu.UseSelectable = true;
            this.ckbAjoutTransaction_percu.Click += new System.EventHandler(this.ckbPercuAjoutTransaction_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbType.Location = new System.Drawing.Point(3, 198);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(38, 19);
            this.lbType.TabIndex = 35;
            this.lbType.Text = "Type";
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.AutoSize = true;
            this.flowLayoutPanel14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel14.Controls.Add(this.cboAjoutTransaction_Type);
            this.flowLayoutPanel14.Controls.Add(this.btnAjoutTransaction_AddType);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(3, 220);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(383, 35);
            this.flowLayoutPanel14.TabIndex = 34;
            // 
            // cboAjoutTransaction_Type
            // 
            this.cboAjoutTransaction_Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboAjoutTransaction_Type.FormattingEnabled = true;
            this.cboAjoutTransaction_Type.ItemHeight = 23;
            this.cboAjoutTransaction_Type.Location = new System.Drawing.Point(3, 3);
            this.cboAjoutTransaction_Type.Name = "cboAjoutTransaction_Type";
            this.cboAjoutTransaction_Type.Size = new System.Drawing.Size(346, 29);
            this.cboAjoutTransaction_Type.TabIndex = 7;
            this.cboAjoutTransaction_Type.UseSelectable = true;
            // 
            // btnAjoutTransaction_AddType
            // 
            this.btnAjoutTransaction_AddType.AutoSize = true;
            this.btnAjoutTransaction_AddType.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAjoutTransaction_AddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutTransaction_AddType.Location = new System.Drawing.Point(355, 3);
            this.btnAjoutTransaction_AddType.Margin = new System.Windows.Forms.Padding(3);
            this.btnAjoutTransaction_AddType.Name = "btnAjoutTransaction_AddType";
            this.btnAjoutTransaction_AddType.Size = new System.Drawing.Size(25, 29);
            this.btnAjoutTransaction_AddType.TabIndex = 8;
            this.btnAjoutTransaction_AddType.Text = "";
            this.btnAjoutTransaction_AddType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjoutTransaction_AddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAjoutTransaction_OK);
            this.panel3.Controls.Add(this.btnAjoutTransaction_modif);
            this.panel3.Controls.Add(this.btnAjoutTransaction_Annuler2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 26);
            this.panel3.TabIndex = 0;
            // 
            // btnAjoutTransaction_OK
            // 
            this.btnAjoutTransaction_OK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAjoutTransaction_OK.Location = new System.Drawing.Point(150, 0);
            this.btnAjoutTransaction_OK.Name = "btnAjoutTransaction_OK";
            this.btnAjoutTransaction_OK.Size = new System.Drawing.Size(75, 26);
            this.btnAjoutTransaction_OK.TabIndex = 1;
            this.btnAjoutTransaction_OK.Text = "Valider";
            this.btnAjoutTransaction_OK.UseSelectable = true;
            this.btnAjoutTransaction_OK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAjoutTransaction_modif
            // 
            this.btnAjoutTransaction_modif.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAjoutTransaction_modif.Location = new System.Drawing.Point(75, 0);
            this.btnAjoutTransaction_modif.Name = "btnAjoutTransaction_modif";
            this.btnAjoutTransaction_modif.Size = new System.Drawing.Size(75, 26);
            this.btnAjoutTransaction_modif.TabIndex = 1;
            this.btnAjoutTransaction_modif.Text = "Modifier";
            this.btnAjoutTransaction_modif.UseSelectable = true;
            this.btnAjoutTransaction_modif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAjoutTransaction_Annuler2
            // 
            this.btnAjoutTransaction_Annuler2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAjoutTransaction_Annuler2.Location = new System.Drawing.Point(0, 0);
            this.btnAjoutTransaction_Annuler2.Name = "btnAjoutTransaction_Annuler2";
            this.btnAjoutTransaction_Annuler2.Size = new System.Drawing.Size(75, 26);
            this.btnAjoutTransaction_Annuler2.TabIndex = 2;
            this.btnAjoutTransaction_Annuler2.Text = "Annuler";
            this.btnAjoutTransaction_Annuler2.UseSelectable = true;
            this.btnAjoutTransaction_Annuler2.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // panelAjoutTransac
            // 
            this.panelAjoutTransac.AutoSize = true;
            this.panelAjoutTransac.Controls.Add(this.ckbTtSelect);
            this.panelAjoutTransac.Controls.Add(this.btnAddPers);
            this.panelAjoutTransac.Controls.Add(this.btnClear);
            this.panelAjoutTransac.Controls.Add(this.label2);
            this.panelAjoutTransac.Controls.Add(this.listBoxAjoutTransaction_Personne);
            this.panelAjoutTransac.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAjoutTransac.Location = new System.Drawing.Point(623, 0);
            this.panelAjoutTransac.Name = "panelAjoutTransac";
            this.panelAjoutTransac.Size = new System.Drawing.Size(201, 364);
            this.panelAjoutTransac.TabIndex = 27;
            // 
            // ckbTtSelect
            // 
            this.ckbTtSelect.AutoSize = true;
            this.ckbTtSelect.Location = new System.Drawing.Point(9, 54);
            this.ckbTtSelect.Name = "ckbTtSelect";
            this.ckbTtSelect.Size = new System.Drawing.Size(115, 15);
            this.ckbTtSelect.TabIndex = 29;
            this.ckbTtSelect.Text = "Tout sélectionner";
            this.ckbTtSelect.UseSelectable = true;
            this.ckbTtSelect.Click += new System.EventHandler(this.ckbTtSelect_Click);
            // 
            // btnAddPers
            // 
            this.btnAddPers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPers.Location = new System.Drawing.Point(59, 225);
            this.btnAddPers.Name = "btnAddPers";
            this.btnAddPers.Size = new System.Drawing.Size(139, 23);
            this.btnAddPers.TabIndex = 28;
            this.btnAddPers.Text = "Ajouter une personne";
            this.btnAddPers.UseSelectable = true;
            this.btnAddPers.Click += new System.EventHandler(this.btnAddPers_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(138, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearAjoutTransaction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Personne(s) concernées : ";
            // 
            // listBoxAjoutTransaction_Personne
            // 
            this.listBoxAjoutTransaction_Personne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxAjoutTransaction_Personne.FormattingEnabled = true;
            this.listBoxAjoutTransaction_Personne.Location = new System.Drawing.Point(9, 72);
            this.listBoxAjoutTransaction_Personne.Name = "listBoxAjoutTransaction_Personne";
            this.listBoxAjoutTransaction_Personne.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAjoutTransaction_Personne.Size = new System.Drawing.Size(189, 147);
            this.listBoxAjoutTransaction_Personne.Sorted = true;
            this.listBoxAjoutTransaction_Personne.TabIndex = 24;
            this.listBoxAjoutTransaction_Personne.TabStop = false;
            this.listBoxAjoutTransaction_Personne.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonneAjoutTransaction_SelectedIndexChanged);
            // 
            // AjouterTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 444);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(864, 444);
            this.Name = "AjouterTransaction";
            this.Text = "AjouterTransaction";
            this.Load += new System.EventHandler(this.AjoutTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ContainerAjouterTransaction.ResumeLayout(false);
            this.ContainerAjouterTransaction.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.FieldsContainerTxtDescr.ResumeLayout(false);
            this.flowLayoutPanel19.ResumeLayout(false);
            this.flowLayoutPanel19.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelAjoutTransac.ResumeLayout(false);
            this.panelAjoutTransac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ContainerAjouterTransaction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel15;
        private MetroFramework.Controls.MetroLabel lblDateT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel16;
        private MetroFramework.Controls.MetroDateTime calAjoutTransaction;
        private MetroFramework.Controls.MetroLabel ldlDesc;
        private System.Windows.Forms.FlowLayoutPanel FieldsContainerTxtDescr;
        private MetroFramework.Controls.MetroTextBox txtAjoutTransaction_desc;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel19;
        private MetroFramework.Controls.MetroTextBox txtAjoutTransaction_montant;
        private MetroFramework.Controls.MetroCheckBox ckbAjoutTransaction_recette;
        private MetroFramework.Controls.MetroCheckBox ckbAjoutTransaction_percu;
        private MetroFramework.Controls.MetroLabel lbType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private MetroFramework.Controls.MetroComboBox cboAjoutTransaction_Type;
        private System.Windows.Forms.Label btnAjoutTransaction_AddType;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton btnAjoutTransaction_OK;
        private MetroFramework.Controls.MetroButton btnAjoutTransaction_modif;
        private MetroFramework.Controls.MetroButton btnAjoutTransaction_Annuler2;
        private System.Windows.Forms.Panel panelAjoutTransac;
        private MetroFramework.Controls.MetroCheckBox ckbTtSelect;
        private MetroFramework.Controls.MetroButton btnAddPers;
        private MetroFramework.Controls.MetroButton btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAjoutTransaction_Personne;
    }
}