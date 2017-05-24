namespace BreakingBudget.Views.FrmMain
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SidebarTable = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarBottomFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SidebarTopFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContentPanel = new Kerido.Controls.MultiPaneControl();
            this.PagePostesFixes = new Kerido.Controls.MultiPanePage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnValiderBudgetFixe = new MetroFramework.Controls.MetroButton();
            this.btnGererPostes = new MetroFramework.Controls.MetroButton();
            this.PosteFixeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCmbPostes = new MetroFramework.Controls.MetroLabel();
            this.PanelPostes = new System.Windows.Forms.FlowLayoutPanel();
            this.ComboxBoxListePostes = new MetroFramework.Controls.MetroComboBox();
            this.HelpPosteLabel = new System.Windows.Forms.Label();
            this.labelCmbPeriodicite = new MetroFramework.Controls.MetroLabel();
            this.PanelPeriodicite = new System.Windows.Forms.FlowLayoutPanel();
            this.ComboxBoxListePeriodicites = new MetroFramework.Controls.MetroComboBox();
            this.PanelTousLesXMois = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtBoxTousLesXMois = new MetroFramework.Controls.MetroTextBox();
            this.lblDuMois = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PanelMontant = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtBoxMontantPosteFixe = new MetroFramework.Controls.MetroTextBox();
            this.SettingsPage = new Kerido.Controls.MultiPanePage();
            this.label2 = new System.Windows.Forms.Label();
            this.LicensesPage = new Kerido.Controls.MultiPanePage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HomePage = new Kerido.Controls.MultiPanePage();
            this.button1 = new System.Windows.Forms.Button();
            this.PagePostesPonctuels = new Kerido.Controls.MultiPanePage();
            this.PageRevenus = new Kerido.Controls.MultiPanePage();
            this.multiPanePage3 = new Kerido.Controls.MultiPanePage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SidebarTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.PagePostesFixes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PosteFixeFlowLayoutPanel.SuspendLayout();
            this.PanelPostes.SuspendLayout();
            this.PanelPeriodicite.SuspendLayout();
            this.PanelTousLesXMois.SuspendLayout();
            this.PanelMontant.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.LicensesPage.SuspendLayout();
            this.HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(76, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(106, 26);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // SidebarTable
            // 
            this.SidebarTable.AutoSize = true;
            this.SidebarTable.ColumnCount = 1;
            this.SidebarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidebarTable.Controls.Add(this.SidebarBottomFlowLayout, 0, 1);
            this.SidebarTable.Controls.Add(this.SidebarTopFlowLayout, 0, 0);
            this.SidebarTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarTable.Location = new System.Drawing.Point(3, 3);
            this.SidebarTable.Name = "SidebarTable";
            this.SidebarTable.RowCount = 2;
            this.SidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SidebarTable.Size = new System.Drawing.Size(6, 426);
            this.SidebarTable.TabIndex = 6;
            // 
            // SidebarBottomFlowLayout
            // 
            this.SidebarBottomFlowLayout.AutoSize = true;
            this.SidebarBottomFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SidebarBottomFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SidebarBottomFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarBottomFlowLayout.Location = new System.Drawing.Point(3, 9);
            this.SidebarBottomFlowLayout.Name = "SidebarBottomFlowLayout";
            this.SidebarBottomFlowLayout.Size = new System.Drawing.Size(1, 414);
            this.SidebarBottomFlowLayout.TabIndex = 2;
            // 
            // SidebarTopFlowLayout
            // 
            this.SidebarTopFlowLayout.AutoSize = true;
            this.SidebarTopFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SidebarTopFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SidebarTopFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarTopFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.SidebarTopFlowLayout.Name = "SidebarTopFlowLayout";
            this.SidebarTopFlowLayout.Size = new System.Drawing.Size(1, 1);
            this.SidebarTopFlowLayout.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.SidebarTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ContentPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 426);
            this.panel1.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.White;
            this.ContentPanel.Controls.Add(this.PagePostesFixes);
            this.ContentPanel.Controls.Add(this.SettingsPage);
            this.ContentPanel.Controls.Add(this.LicensesPage);
            this.ContentPanel.Controls.Add(this.HomePage);
            this.ContentPanel.Controls.Add(this.PagePostesPonctuels);
            this.ContentPanel.Controls.Add(this.PageRevenus);
            this.ContentPanel.Controls.Add(this.multiPanePage3);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ContentPanel.SelectedPage = this.PagePostesFixes;
            this.ContentPanel.Size = new System.Drawing.Size(667, 426);
            this.ContentPanel.TabIndex = 9;
            this.ContentPanel.Text = "Meow";
            this.ContentPanel.SelectedPageChanged += new System.EventHandler(this.ContentPanel_SelectedPageChanged);
            // 
            // PagePostesFixes
            // 
            this.PagePostesFixes.AccessibleName = "Tracker";
            this.PagePostesFixes.AutoSize = true;
            this.PagePostesFixes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PagePostesFixes.Controls.Add(this.panel2);
            this.PagePostesFixes.Name = "PagePostesFixes";
            this.PagePostesFixes.Size = new System.Drawing.Size(667, 426);
            this.PagePostesFixes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.PosteFixeFlowLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(667, 426);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.BtnValiderBudgetFixe);
            this.panel3.Controls.Add(this.btnGererPostes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 386);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 30);
            this.panel3.TabIndex = 2;
            // 
            // BtnValiderBudgetFixe
            // 
            this.BtnValiderBudgetFixe.AutoSize = true;
            this.BtnValiderBudgetFixe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnValiderBudgetFixe.Location = new System.Drawing.Point(567, 0);
            this.BtnValiderBudgetFixe.Name = "BtnValiderBudgetFixe";
            this.BtnValiderBudgetFixe.Size = new System.Drawing.Size(80, 30);
            this.BtnValiderBudgetFixe.TabIndex = 5;
            this.BtnValiderBudgetFixe.Text = "Valider";
            this.BtnValiderBudgetFixe.UseSelectable = true;
            this.BtnValiderBudgetFixe.Click += new System.EventHandler(this.BtnValiderBudgetFixe_Click);
            // 
            // btnGererPostes
            // 
            this.btnGererPostes.AutoSize = true;
            this.btnGererPostes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGererPostes.Location = new System.Drawing.Point(0, 0);
            this.btnGererPostes.Name = "btnGererPostes";
            this.btnGererPostes.Size = new System.Drawing.Size(93, 30);
            this.btnGererPostes.TabIndex = 6;
            this.btnGererPostes.Text = "Gérer les postes";
            this.btnGererPostes.UseSelectable = true;
            this.btnGererPostes.Click += new System.EventHandler(this.btnGererPostes_Click);
            // 
            // PosteFixeFlowLayoutPanel
            // 
            this.PosteFixeFlowLayoutPanel.AutoSize = true;
            this.PosteFixeFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PosteFixeFlowLayoutPanel.Controls.Add(this.labelCmbPostes);
            this.PosteFixeFlowLayoutPanel.Controls.Add(this.PanelPostes);
            this.PosteFixeFlowLayoutPanel.Controls.Add(this.labelCmbPeriodicite);
            this.PosteFixeFlowLayoutPanel.Controls.Add(this.PanelPeriodicite);
            this.PosteFixeFlowLayoutPanel.Controls.Add(this.PanelTousLesXMois);
            this.PosteFixeFlowLayoutPanel.Controls.Add(this.metroLabel3);
            this.PosteFixeFlowLayoutPanel.Controls.Add(this.PanelMontant);
            this.PosteFixeFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PosteFixeFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PosteFixeFlowLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.PosteFixeFlowLayoutPanel.Name = "PosteFixeFlowLayoutPanel";
            this.PosteFixeFlowLayoutPanel.Size = new System.Drawing.Size(647, 406);
            this.PosteFixeFlowLayoutPanel.TabIndex = 1;
            this.PosteFixeFlowLayoutPanel.WrapContents = false;
            // 
            // labelCmbPostes
            // 
            this.labelCmbPostes.AutoSize = true;
            this.labelCmbPostes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCmbPostes.Location = new System.Drawing.Point(3, 0);
            this.labelCmbPostes.Name = "labelCmbPostes";
            this.labelCmbPostes.Size = new System.Drawing.Size(43, 19);
            this.labelCmbPostes.TabIndex = 7;
            this.labelCmbPostes.Text = "Poste";
            // 
            // PanelPostes
            // 
            this.PanelPostes.AutoSize = true;
            this.PanelPostes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelPostes.Controls.Add(this.ComboxBoxListePostes);
            this.PanelPostes.Controls.Add(this.HelpPosteLabel);
            this.PanelPostes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPostes.Location = new System.Drawing.Point(3, 22);
            this.PanelPostes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.PanelPostes.Name = "PanelPostes";
            this.PanelPostes.Size = new System.Drawing.Size(383, 35);
            this.PanelPostes.TabIndex = 4;
            this.PanelPostes.WrapContents = false;
            // 
            // ComboxBoxListePostes
            // 
            this.ComboxBoxListePostes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboxBoxListePostes.FormattingEnabled = true;
            this.ComboxBoxListePostes.ItemHeight = 23;
            this.ComboxBoxListePostes.Location = new System.Drawing.Point(3, 3);
            this.ComboxBoxListePostes.Name = "ComboxBoxListePostes";
            this.ComboxBoxListePostes.Size = new System.Drawing.Size(346, 29);
            this.ComboxBoxListePostes.Sorted = true;
            this.ComboxBoxListePostes.TabIndex = 3;
            this.ComboxBoxListePostes.UseSelectable = true;
            // 
            // HelpPosteLabel
            // 
            this.HelpPosteLabel.AutoSize = true;
            this.HelpPosteLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HelpPosteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpPosteLabel.Location = new System.Drawing.Point(355, 3);
            this.HelpPosteLabel.Margin = new System.Windows.Forms.Padding(3);
            this.HelpPosteLabel.Name = "HelpPosteLabel";
            this.HelpPosteLabel.Size = new System.Drawing.Size(25, 29);
            this.HelpPosteLabel.TabIndex = 6;
            this.HelpPosteLabel.Text = "";
            this.HelpPosteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelpPosteLabel.Visible = false;
            this.HelpPosteLabel.Click += new System.EventHandler(this.HelpPosteLabel_Click);
            // 
            // labelCmbPeriodicite
            // 
            this.labelCmbPeriodicite.AutoSize = true;
            this.labelCmbPeriodicite.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelCmbPeriodicite.Location = new System.Drawing.Point(3, 72);
            this.labelCmbPeriodicite.Name = "labelCmbPeriodicite";
            this.labelCmbPeriodicite.Size = new System.Drawing.Size(72, 19);
            this.labelCmbPeriodicite.TabIndex = 7;
            this.labelCmbPeriodicite.Text = "Périodicité";
            // 
            // PanelPeriodicite
            // 
            this.PanelPeriodicite.AutoSize = true;
            this.PanelPeriodicite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelPeriodicite.Controls.Add(this.ComboxBoxListePeriodicites);
            this.PanelPeriodicite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPeriodicite.Location = new System.Drawing.Point(3, 94);
            this.PanelPeriodicite.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.PanelPeriodicite.Name = "PanelPeriodicite";
            this.PanelPeriodicite.Size = new System.Drawing.Size(383, 35);
            this.PanelPeriodicite.TabIndex = 6;
            // 
            // ComboxBoxListePeriodicites
            // 
            this.ComboxBoxListePeriodicites.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboxBoxListePeriodicites.FormattingEnabled = true;
            this.ComboxBoxListePeriodicites.ItemHeight = 23;
            this.ComboxBoxListePeriodicites.Location = new System.Drawing.Point(3, 3);
            this.ComboxBoxListePeriodicites.Name = "ComboxBoxListePeriodicites";
            this.ComboxBoxListePeriodicites.Size = new System.Drawing.Size(346, 29);
            this.ComboxBoxListePeriodicites.Sorted = true;
            this.ComboxBoxListePeriodicites.TabIndex = 3;
            this.ComboxBoxListePeriodicites.UseSelectable = true;
            // 
            // PanelTousLesXMois
            // 
            this.PanelTousLesXMois.AutoSize = true;
            this.PanelTousLesXMois.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelTousLesXMois.Controls.Add(this.metroLabel1);
            this.PanelTousLesXMois.Controls.Add(this.TxtBoxTousLesXMois);
            this.PanelTousLesXMois.Controls.Add(this.lblDuMois);
            this.PanelTousLesXMois.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTousLesXMois.Location = new System.Drawing.Point(3, 147);
            this.PanelTousLesXMois.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.PanelTousLesXMois.Name = "PanelTousLesXMois";
            this.PanelTousLesXMois.Size = new System.Drawing.Size(383, 25);
            this.PanelTousLesXMois.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Tous les";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBoxTousLesXMois
            // 
            // 
            // 
            // 
            this.TxtBoxTousLesXMois.CustomButton.Image = null;
            this.TxtBoxTousLesXMois.CustomButton.Location = new System.Drawing.Point(22, 1);
            this.TxtBoxTousLesXMois.CustomButton.Name = "";
            this.TxtBoxTousLesXMois.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtBoxTousLesXMois.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBoxTousLesXMois.CustomButton.TabIndex = 1;
            this.TxtBoxTousLesXMois.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBoxTousLesXMois.CustomButton.UseSelectable = true;
            this.TxtBoxTousLesXMois.CustomButton.Visible = false;
            this.TxtBoxTousLesXMois.Lines = new string[0];
            this.TxtBoxTousLesXMois.Location = new System.Drawing.Point(67, 3);
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
            this.TxtBoxTousLesXMois.Size = new System.Drawing.Size(40, 19);
            this.TxtBoxTousLesXMois.TabIndex = 11;
            this.TxtBoxTousLesXMois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxTousLesXMois.UseSelectable = true;
            this.TxtBoxTousLesXMois.WaterMark = "...";
            this.TxtBoxTousLesXMois.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBoxTousLesXMois.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBoxTousLesXMois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxTousLesXMois_KeyPress);
            this.TxtBoxTousLesXMois.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBoxTousLesXMois_KeyUp);
            // 
            // lblDuMois
            // 
            this.lblDuMois.AutoSize = true;
            this.lblDuMois.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDuMois.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDuMois.Location = new System.Drawing.Point(113, 0);
            this.lblDuMois.Name = "lblDuMois";
            this.lblDuMois.Size = new System.Drawing.Size(58, 25);
            this.lblDuMois.TabIndex = 12;
            this.lblDuMois.Text = "du mois";
            this.lblDuMois.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Montant";
            // 
            // PanelMontant
            // 
            this.PanelMontant.AutoSize = true;
            this.PanelMontant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelMontant.Controls.Add(this.TxtBoxMontantPosteFixe);
            this.PanelMontant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMontant.Location = new System.Drawing.Point(3, 209);
            this.PanelMontant.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.PanelMontant.Name = "PanelMontant";
            this.PanelMontant.Size = new System.Drawing.Size(383, 25);
            this.PanelMontant.TabIndex = 9;
            // 
            // TxtBoxMontantPosteFixe
            // 
            // 
            // 
            // 
            this.TxtBoxMontantPosteFixe.CustomButton.Image = null;
            this.TxtBoxMontantPosteFixe.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.TxtBoxMontantPosteFixe.CustomButton.Name = "";
            this.TxtBoxMontantPosteFixe.CustomButton.Size = new System.Drawing.Size(17, 17);
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
            this.TxtBoxMontantPosteFixe.PromptText = "Entrez le montant à payer chaque mois";
            this.TxtBoxMontantPosteFixe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBoxMontantPosteFixe.SelectedText = "";
            this.TxtBoxMontantPosteFixe.SelectionLength = 0;
            this.TxtBoxMontantPosteFixe.SelectionStart = 0;
            this.TxtBoxMontantPosteFixe.ShortcutsEnabled = true;
            this.TxtBoxMontantPosteFixe.Size = new System.Drawing.Size(346, 19);
            this.TxtBoxMontantPosteFixe.TabIndex = 4;
            this.TxtBoxMontantPosteFixe.UseSelectable = true;
            this.TxtBoxMontantPosteFixe.WaterMark = "Entrez le montant à payer chaque mois";
            this.TxtBoxMontantPosteFixe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBoxMontantPosteFixe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxMontantPosteFixe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxMontantPosteFixe_KeyPress);
            // 
            // SettingsPage
            // 
            this.SettingsPage.AccessibleName = "Paramètres";
            this.SettingsPage.AutoSize = true;
            this.SettingsPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsPage.Controls.Add(this.label2);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(667, 426);
            this.SettingsPage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // LicensesPage
            // 
            this.LicensesPage.AccessibleName = "Licenses";
            this.LicensesPage.AutoSize = true;
            this.LicensesPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LicensesPage.Controls.Add(this.richTextBox1);
            this.LicensesPage.Name = "LicensesPage";
            this.LicensesPage.Size = new System.Drawing.Size(667, 426);
            this.LicensesPage.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(667, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // HomePage
            // 
            this.HomePage.AccessibleName = "Accueil";
            this.HomePage.AutoSize = true;
            this.HomePage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomePage.Controls.Add(this.button1);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(667, 426);
            this.HomePage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PagePostesPonctuels
            // 
            this.PagePostesPonctuels.AccessibleName = "Expanded Test";
            this.PagePostesPonctuels.AutoSize = true;
            this.PagePostesPonctuels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PagePostesPonctuels.Name = "PagePostesPonctuels";
            this.PagePostesPonctuels.Size = new System.Drawing.Size(667, 426);
            this.PagePostesPonctuels.TabIndex = 4;
            // 
            // PageRevenus
            // 
            this.PageRevenus.AutoSize = true;
            this.PageRevenus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PageRevenus.Name = "PageRevenus";
            this.PageRevenus.Size = new System.Drawing.Size(667, 426);
            this.PageRevenus.TabIndex = 5;
            // 
            // multiPanePage3
            // 
            this.multiPanePage3.AutoSize = true;
            this.multiPanePage3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiPanePage3.Name = "multiPanePage3";
            this.multiPanePage3.Size = new System.Drawing.Size(667, 426);
            this.multiPanePage3.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 512);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(725, 512);
            this.Name = "FrmMain";
            this.Text = "Breaking Budget";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.SidebarTable.ResumeLayout(false);
            this.SidebarTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.PagePostesFixes.ResumeLayout(false);
            this.PagePostesFixes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PosteFixeFlowLayoutPanel.ResumeLayout(false);
            this.PosteFixeFlowLayoutPanel.PerformLayout();
            this.PanelPostes.ResumeLayout(false);
            this.PanelPostes.PerformLayout();
            this.PanelPeriodicite.ResumeLayout(false);
            this.PanelTousLesXMois.ResumeLayout(false);
            this.PanelTousLesXMois.PerformLayout();
            this.PanelMontant.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.LicensesPage.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel SidebarTable;
        private System.Windows.Forms.FlowLayoutPanel SidebarBottomFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel SidebarTopFlowLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Kerido.Controls.MultiPaneControl ContentPanel;
        private Kerido.Controls.MultiPanePage PagePostesFixes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton BtnValiderBudgetFixe;
        private MetroFramework.Controls.MetroButton btnGererPostes;
        private System.Windows.Forms.FlowLayoutPanel PosteFixeFlowLayoutPanel;
        private MetroFramework.Controls.MetroLabel labelCmbPostes;
        private System.Windows.Forms.FlowLayoutPanel PanelPostes;
        private MetroFramework.Controls.MetroComboBox ComboxBoxListePostes;
        private System.Windows.Forms.Label HelpPosteLabel;
        private MetroFramework.Controls.MetroLabel labelCmbPeriodicite;
        private System.Windows.Forms.FlowLayoutPanel PanelPeriodicite;
        private MetroFramework.Controls.MetroComboBox ComboxBoxListePeriodicites;
        private System.Windows.Forms.FlowLayoutPanel PanelTousLesXMois;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtBoxTousLesXMois;
        private MetroFramework.Controls.MetroLabel lblDuMois;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.FlowLayoutPanel PanelMontant;
        private MetroFramework.Controls.MetroTextBox TxtBoxMontantPosteFixe;
        private Kerido.Controls.MultiPanePage SettingsPage;
        private System.Windows.Forms.Label label2;
        private Kerido.Controls.MultiPanePage LicensesPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Kerido.Controls.MultiPanePage HomePage;
        private System.Windows.Forms.Button button1;
        private Kerido.Controls.MultiPanePage PagePostesPonctuels;
        private Kerido.Controls.MultiPanePage PageRevenus;
        private Kerido.Controls.MultiPanePage multiPanePage3;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

