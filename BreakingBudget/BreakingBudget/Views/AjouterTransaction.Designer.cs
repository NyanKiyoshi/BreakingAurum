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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContainerAjouterTransaction = new System.Windows.Forms.Panel();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateT = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.calAjoutTransaction = new MetroFramework.Controls.MetroDateTime();
            this.ldlDesc = new MetroFramework.Controls.MetroLabel();
            this.FieldsContainerTxtDescr = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.lblMontant = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMontant = new MetroFramework.Controls.MetroTextBox();
            this.ckbRecette = new MetroFramework.Controls.MetroCheckBox();
            this.ckbPercu = new MetroFramework.Controls.MetroCheckBox();
            this.lbType = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboType = new MetroFramework.Controls.MetroComboBox();
            this.IconBtnAjoutTransaction_AddType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.panelAjoutTransac = new System.Windows.Forms.Panel();
            this.ListPersonneContainer = new System.Windows.Forms.Panel();
            this.listBoxAjoutTransaction_Personne = new System.Windows.Forms.ListBox();
            this.ckbTtSelect = new MetroFramework.Controls.MetroCheckBox();
            this.btnAddPers = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.lblPersonnesConcernees = new System.Windows.Forms.Label();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel1.SuspendLayout();
            this.ContainerAjouterTransaction.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.FieldsContainerTxtDescr.SuspendLayout();
            this.flowLayoutPanel19.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAjoutTransac.SuspendLayout();
            this.ListPersonneContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
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
            this.ContainerAjouterTransaction.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ContainerAjouterTransaction.Size = new System.Drawing.Size(615, 364);
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
            this.flowLayoutPanel15.Controls.Add(this.lblMontant);
            this.flowLayoutPanel15.Controls.Add(this.flowLayoutPanel19);
            this.flowLayoutPanel15.Controls.Add(this.lbType);
            this.flowLayoutPanel15.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel15.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel15.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(595, 318);
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
            this.flowLayoutPanel16.Size = new System.Drawing.Size(479, 36);
            this.flowLayoutPanel16.TabIndex = 4;
            this.flowLayoutPanel16.WrapContents = false;
            // 
            // calAjoutTransaction
            // 
            this.calAjoutTransaction.Location = new System.Drawing.Point(3, 3);
            this.calAjoutTransaction.MinimumSize = new System.Drawing.Size(0, 29);
            this.calAjoutTransaction.Name = "calAjoutTransaction";
            this.calAjoutTransaction.Size = new System.Drawing.Size(219, 30);
            this.calAjoutTransaction.TabIndex = 37;
            // 
            // ldlDesc
            // 
            this.ldlDesc.AutoSize = true;
            this.ldlDesc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ldlDesc.Location = new System.Drawing.Point(3, 73);
            this.ldlDesc.Name = "ldlDesc";
            this.ldlDesc.Size = new System.Drawing.Size(142, 19);
            this.ldlDesc.TabIndex = 7;
            this.ldlDesc.Text = "Description (facultatif)";
            // 
            // FieldsContainerTxtDescr
            // 
            this.FieldsContainerTxtDescr.AutoSize = true;
            this.FieldsContainerTxtDescr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FieldsContainerTxtDescr.Controls.Add(this.txtDesc);
            this.FieldsContainerTxtDescr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsContainerTxtDescr.Location = new System.Drawing.Point(3, 95);
            this.FieldsContainerTxtDescr.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.FieldsContainerTxtDescr.Name = "FieldsContainerTxtDescr";
            this.FieldsContainerTxtDescr.Size = new System.Drawing.Size(479, 26);
            this.FieldsContainerTxtDescr.TabIndex = 6;
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(246, 2);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(3, 3);
            this.txtDesc.MaxLength = 30;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(346, 20);
            this.txtDesc.TabIndex = 5;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMontant.Location = new System.Drawing.Point(3, 136);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(63, 19);
            this.lblMontant.TabIndex = 10;
            this.lblMontant.Text = "Montant";
            // 
            // flowLayoutPanel19
            // 
            this.flowLayoutPanel19.AutoSize = true;
            this.flowLayoutPanel19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel19.Controls.Add(this.txtMontant);
            this.flowLayoutPanel19.Controls.Add(this.ckbRecette);
            this.flowLayoutPanel19.Controls.Add(this.ckbPercu);
            this.flowLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel19.Location = new System.Drawing.Point(3, 158);
            this.flowLayoutPanel19.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.flowLayoutPanel19.Name = "flowLayoutPanel19";
            this.flowLayoutPanel19.Size = new System.Drawing.Size(479, 26);
            this.flowLayoutPanel19.TabIndex = 9;
            // 
            // txtMontant
            // 
            // 
            // 
            // 
            this.txtMontant.CustomButton.Image = null;
            this.txtMontant.CustomButton.Location = new System.Drawing.Point(246, 2);
            this.txtMontant.CustomButton.Name = "";
            this.txtMontant.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontant.CustomButton.TabIndex = 1;
            this.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontant.CustomButton.UseSelectable = true;
            this.txtMontant.CustomButton.Visible = false;
            this.txtMontant.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMontant.Lines = new string[0];
            this.txtMontant.Location = new System.Drawing.Point(3, 3);
            this.txtMontant.MaxLength = 10;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontant.SelectedText = "";
            this.txtMontant.SelectionLength = 0;
            this.txtMontant.SelectionStart = 0;
            this.txtMontant.ShortcutsEnabled = true;
            this.txtMontant.Size = new System.Drawing.Size(346, 20);
            this.txtMontant.TabIndex = 4;
            this.txtMontant.UseSelectable = true;
            this.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantAjoutTransaction_KeyPress);
            this.txtMontant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMontantAjoutTransaction_KeyUp);
            // 
            // ckbRecette
            // 
            this.ckbRecette.AutoSize = true;
            this.ckbRecette.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckbRecette.Location = new System.Drawing.Point(355, 3);
            this.ckbRecette.Name = "ckbRecette";
            this.ckbRecette.Size = new System.Drawing.Size(62, 20);
            this.ckbRecette.TabIndex = 5;
            this.ckbRecette.Text = "Recette";
            this.ckbRecette.UseSelectable = true;
            this.ckbRecette.Click += new System.EventHandler(this.ckbRecetteAjoutTransaction_Click);
            // 
            // ckbPercu
            // 
            this.ckbPercu.AutoSize = true;
            this.ckbPercu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckbPercu.Location = new System.Drawing.Point(423, 3);
            this.ckbPercu.Name = "ckbPercu";
            this.ckbPercu.Size = new System.Drawing.Size(53, 20);
            this.ckbPercu.TabIndex = 6;
            this.ckbPercu.Text = "Perçu";
            this.ckbPercu.UseSelectable = true;
            this.ckbPercu.Click += new System.EventHandler(this.ckbPercuAjoutTransaction_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbType.Location = new System.Drawing.Point(3, 199);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(38, 19);
            this.lbType.TabIndex = 35;
            this.lbType.Text = "Type";
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.AutoSize = true;
            this.flowLayoutPanel14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel14.Controls.Add(this.cboType);
            this.flowLayoutPanel14.Controls.Add(this.IconBtnAjoutTransaction_AddType);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(3, 221);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(383, 35);
            this.flowLayoutPanel14.TabIndex = 34;
            // 
            // cboType
            // 
            this.cboType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboType.FormattingEnabled = true;
            this.cboType.ItemHeight = 23;
            this.cboType.Location = new System.Drawing.Point(3, 3);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(346, 29);
            this.cboType.TabIndex = 7;
            this.cboType.UseSelectable = true;
            // 
            // IconBtnAjoutTransaction_AddType
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.IconBtnAjoutTransaction_AddType, true);
            this.IconBtnAjoutTransaction_AddType.AutoSize = true;
            this.IconBtnAjoutTransaction_AddType.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconBtnAjoutTransaction_AddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtnAjoutTransaction_AddType.Location = new System.Drawing.Point(355, 3);
            this.IconBtnAjoutTransaction_AddType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.IconBtnAjoutTransaction_AddType.Name = "IconBtnAjoutTransaction_AddType";
            this.IconBtnAjoutTransaction_AddType.Size = new System.Drawing.Size(25, 29);
            this.IconBtnAjoutTransaction_AddType.TabIndex = 8;
            this.IconBtnAjoutTransaction_AddType.Text = "";
            this.IconBtnAjoutTransaction_AddType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IconBtnAjoutTransaction_AddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 26);
            this.panel3.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubmit.Location = new System.Drawing.Point(150, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Valider";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Location = new System.Drawing.Point(75, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 26);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // panelAjoutTransac
            // 
            this.panelAjoutTransac.AutoSize = true;
            this.panelAjoutTransac.Controls.Add(this.ListPersonneContainer);
            this.panelAjoutTransac.Controls.Add(this.ckbTtSelect);
            this.panelAjoutTransac.Controls.Add(this.btnAddPers);
            this.panelAjoutTransac.Controls.Add(this.btnClear);
            this.panelAjoutTransac.Controls.Add(this.lblPersonnesConcernees);
            this.panelAjoutTransac.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAjoutTransac.Location = new System.Drawing.Point(615, 0);
            this.panelAjoutTransac.Name = "panelAjoutTransac";
            this.panelAjoutTransac.Size = new System.Drawing.Size(209, 364);
            this.panelAjoutTransac.TabIndex = 27;
            // 
            // ListPersonneContainer
            // 
            this.ListPersonneContainer.Controls.Add(this.listBoxAjoutTransaction_Personne);
            this.ListPersonneContainer.Location = new System.Drawing.Point(6, 75);
            this.ListPersonneContainer.Name = "ListPersonneContainer";
            this.ListPersonneContainer.Padding = new System.Windows.Forms.Padding(1);
            this.ListPersonneContainer.Size = new System.Drawing.Size(200, 144);
            this.ListPersonneContainer.TabIndex = 30;
            // 
            // listBoxAjoutTransaction_Personne
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.listBoxAjoutTransaction_Personne, true);
            this.listBoxAjoutTransaction_Personne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAjoutTransaction_Personne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxAjoutTransaction_Personne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAjoutTransaction_Personne.FormattingEnabled = true;
            this.listBoxAjoutTransaction_Personne.Location = new System.Drawing.Point(1, 1);
            this.listBoxAjoutTransaction_Personne.Name = "listBoxAjoutTransaction_Personne";
            this.listBoxAjoutTransaction_Personne.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAjoutTransaction_Personne.Size = new System.Drawing.Size(198, 142);
            this.listBoxAjoutTransaction_Personne.Sorted = true;
            this.listBoxAjoutTransaction_Personne.TabIndex = 25;
            this.listBoxAjoutTransaction_Personne.TabStop = false;
            this.listBoxAjoutTransaction_Personne.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonneAjoutTransaction_SelectedIndexChanged);
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
            // lblPersonnesConcernees
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.lblPersonnesConcernees, true);
            this.lblPersonnesConcernees.AutoSize = true;
            this.lblPersonnesConcernees.Location = new System.Drawing.Point(6, 35);
            this.lblPersonnesConcernees.Name = "lblPersonnesConcernees";
            this.lblPersonnesConcernees.Size = new System.Drawing.Size(131, 13);
            this.lblPersonnesConcernees.TabIndex = 26;
            this.lblPersonnesConcernees.Text = "Personne(s) concernées : ";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
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
            this.ListPersonneContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroLabel lblMontant;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel19;
        private MetroFramework.Controls.MetroTextBox txtMontant;
        private MetroFramework.Controls.MetroCheckBox ckbRecette;
        private MetroFramework.Controls.MetroCheckBox ckbPercu;
        private MetroFramework.Controls.MetroLabel lbType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private MetroFramework.Controls.MetroComboBox cboType;
        private System.Windows.Forms.Label IconBtnAjoutTransaction_AddType;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.Panel panelAjoutTransac;
        private MetroFramework.Controls.MetroCheckBox ckbTtSelect;
        private MetroFramework.Controls.MetroButton btnAddPers;
        private MetroFramework.Controls.MetroButton btnClear;
        private System.Windows.Forms.Label lblPersonnesConcernees;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Panel ListPersonneContainer;
        private System.Windows.Forms.ListBox listBoxAjoutTransaction_Personne;
    }
}