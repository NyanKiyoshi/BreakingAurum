namespace BreakingBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarTable = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarBottomFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SidebarTopFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentPanel = new Kerido.Controls.MultiPaneControl();
            this.TrackerPage = new Kerido.Controls.MultiPanePage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsPage = new Kerido.Controls.MultiPanePage();
            this.label2 = new System.Windows.Forms.Label();
            this.LicensesPage = new Kerido.Controls.MultiPanePage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HomePage = new Kerido.Controls.MultiPanePage();
            this.multiPanePage1 = new Kerido.Controls.MultiPanePage();
            this.tableLayoutPanel1.SuspendLayout();
            this.SidebarTable.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.TrackerPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.LicensesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.SidebarTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContentPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SidebarTable
            // 
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
            this.SidebarTable.Size = new System.Drawing.Size(189, 352);
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
            this.SidebarBottomFlowLayout.Size = new System.Drawing.Size(183, 340);
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
            this.SidebarTopFlowLayout.Size = new System.Drawing.Size(183, 1);
            this.SidebarTopFlowLayout.TabIndex = 1;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.White;
            this.ContentPanel.Controls.Add(this.TrackerPage);
            this.ContentPanel.Controls.Add(this.SettingsPage);
            this.ContentPanel.Controls.Add(this.LicensesPage);
            this.ContentPanel.Controls.Add(this.HomePage);
            this.ContentPanel.Controls.Add(this.multiPanePage1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(198, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.SelectedPage = this.TrackerPage;
            this.ContentPanel.Size = new System.Drawing.Size(528, 358);
            this.ContentPanel.TabIndex = 7;
            this.ContentPanel.Text = "Meow";
            this.ContentPanel.SelectedPageChanged += new System.EventHandler(this.ContentPanel_SelectedPageChanged);
            // 
            // TrackerPage
            // 
            this.TrackerPage.AccessibleName = "Tracker";
            this.TrackerPage.Controls.Add(this.flowLayoutPanel1);
            this.TrackerPage.Controls.Add(this.label1);
            this.TrackerPage.Name = "TrackerPage";
            this.TrackerPage.Size = new System.Drawing.Size(528, 358);
            this.TrackerPage.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(157, 184);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(272, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // SettingsPage
            // 
            this.SettingsPage.AccessibleName = "Paramètres";
            this.SettingsPage.Controls.Add(this.label2);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(528, 358);
            this.SettingsPage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // LicensesPage
            // 
            this.LicensesPage.AccessibleName = "Licenses";
            this.LicensesPage.Controls.Add(this.richTextBox1);
            this.LicensesPage.Name = "LicensesPage";
            this.LicensesPage.Size = new System.Drawing.Size(528, 358);
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
            this.richTextBox1.Size = new System.Drawing.Size(528, 358);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // HomePage
            // 
            this.HomePage.AccessibleName = "Accueil";
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(528, 358);
            this.HomePage.TabIndex = 3;
            // 
            // multiPanePage1
            // 
            this.multiPanePage1.AccessibleName = "Expanded Test";
            this.multiPanePage1.Name = "multiPanePage1";
            this.multiPanePage1.Size = new System.Drawing.Size(528, 358);
            this.multiPanePage1.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Breaking Budget";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SidebarTable.ResumeLayout(false);
            this.SidebarTable.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.TrackerPage.ResumeLayout(false);
            this.TrackerPage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.LicensesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel SidebarTable;
        private System.Windows.Forms.FlowLayoutPanel SidebarBottomFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel SidebarTopFlowLayout;
        private Kerido.Controls.MultiPaneControl ContentPanel;
        private Kerido.Controls.MultiPanePage TrackerPage;
        private Kerido.Controls.MultiPanePage SettingsPage;
        private Kerido.Controls.MultiPanePage LicensesPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private Kerido.Controls.MultiPanePage HomePage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Kerido.Controls.MultiPanePage multiPanePage1;
    }
}

