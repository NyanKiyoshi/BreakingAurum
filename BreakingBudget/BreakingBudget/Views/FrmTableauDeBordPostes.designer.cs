namespace BreakingBudget.Views
{
    partial class FrmTableauDeBordPostes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRevenus = new MetroFramework.Controls.MetroGrid();
            this.dgvPostesEcheances = new MetroFramework.Controls.MetroGrid();
            this.lblPeriodiciteFixe = new MetroFramework.Controls.MetroLabel();
            this.lblPosteAEchances = new MetroFramework.Controls.MetroLabel();
            this.lblPosteRevenus = new MetroFramework.Controls.MetroLabel();
            this.cmsPosteFixes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierPosteFixesToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPosteFixesToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRevenus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierRevenuToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerRevenuToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvPostesFixes = new MetroFramework.Controls.MetroGrid();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesEcheances)).BeginInit();
            this.cmsPosteFixes.SuspendLayout();
            this.cmsRevenus.SuspendLayout();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesFixes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRevenus
            // 
            this.dgvRevenus.AllowUserToAddRows = false;
            this.dgvRevenus.AllowUserToDeleteRows = false;
            this.dgvRevenus.AllowUserToOrderColumns = true;
            this.dgvRevenus.AllowUserToResizeRows = false;
            this.dgvRevenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvRevenus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRevenus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRevenus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRevenus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRevenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRevenus.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRevenus.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvRevenus.EnableHeadersVisualStyles = false;
            this.dgvRevenus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRevenus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRevenus.Location = new System.Drawing.Point(3, 275);
            this.dgvRevenus.MultiSelect = false;
            this.dgvRevenus.Name = "dgvRevenus";
            this.dgvRevenus.ReadOnly = true;
            this.dgvRevenus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevenus.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRevenus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRevenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevenus.Size = new System.Drawing.Size(626, 218);
            this.dgvRevenus.TabIndex = 1;
            this.dgvRevenus.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRevenus_CellMouseClick);
            // 
            // dgvPostesEcheances
            // 
            this.dgvPostesEcheances.AllowUserToAddRows = false;
            this.dgvPostesEcheances.AllowUserToDeleteRows = false;
            this.dgvPostesEcheances.AllowUserToOrderColumns = true;
            this.dgvPostesEcheances.AllowUserToResizeRows = false;
            this.dgvPostesEcheances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPostesEcheances.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPostesEcheances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPostesEcheances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPostesEcheances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPostesEcheances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPostesEcheances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPostesEcheances.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPostesEcheances.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPostesEcheances.EnableHeadersVisualStyles = false;
            this.dgvPostesEcheances.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPostesEcheances.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPostesEcheances.Location = new System.Drawing.Point(3, 528);
            this.dgvPostesEcheances.MultiSelect = false;
            this.dgvPostesEcheances.Name = "dgvPostesEcheances";
            this.dgvPostesEcheances.ReadOnly = true;
            this.dgvPostesEcheances.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPostesEcheances.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPostesEcheances.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPostesEcheances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostesEcheances.Size = new System.Drawing.Size(626, 150);
            this.dgvPostesEcheances.TabIndex = 2;
            this.dgvPostesEcheances.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPostesEcheances_CellMouseDoubleClick);
            // 
            // lblPeriodiciteFixe
            // 
            this.lblPeriodiciteFixe.AutoSize = true;
            this.lblPeriodiciteFixe.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPeriodiciteFixe.Location = new System.Drawing.Point(3, 10);
            this.lblPeriodiciteFixe.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblPeriodiciteFixe.Name = "lblPeriodiciteFixe";
            this.lblPeriodiciteFixe.Size = new System.Drawing.Size(182, 19);
            this.lblPeriodiciteFixe.TabIndex = 3;
            this.lblPeriodiciteFixe.Text = "Postes à périodicité fixe : ";
            // 
            // lblPosteAEchances
            // 
            this.lblPosteAEchances.AutoSize = true;
            this.lblPosteAEchances.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPosteAEchances.Location = new System.Drawing.Point(3, 506);
            this.lblPosteAEchances.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblPosteAEchances.Name = "lblPosteAEchances";
            this.lblPosteAEchances.Size = new System.Drawing.Size(148, 19);
            this.lblPosteAEchances.TabIndex = 4;
            this.lblPosteAEchances.Text = "Postes à échéances : ";
            // 
            // lblPosteRevenus
            // 
            this.lblPosteRevenus.AutoSize = true;
            this.lblPosteRevenus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPosteRevenus.Location = new System.Drawing.Point(3, 253);
            this.lblPosteRevenus.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblPosteRevenus.Name = "lblPosteRevenus";
            this.lblPosteRevenus.Size = new System.Drawing.Size(137, 19);
            this.lblPosteRevenus.TabIndex = 5;
            this.lblPosteRevenus.Text = "Postes \"Revenus\" : ";
            // 
            // cmsPosteFixes
            // 
            this.cmsPosteFixes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierPosteFixesToolStripItem,
            this.supprimerPosteFixesToolStripItem});
            this.cmsPosteFixes.Name = "cmsPosteFixes";
            this.cmsPosteFixes.Size = new System.Drawing.Size(123, 48);
            // 
            // modifierPosteFixesToolStripItem
            // 
            this.modifierPosteFixesToolStripItem.Name = "modifierPosteFixesToolStripItem";
            this.modifierPosteFixesToolStripItem.Size = new System.Drawing.Size(122, 22);
            this.modifierPosteFixesToolStripItem.Text = "Modifier";
            this.modifierPosteFixesToolStripItem.Click += new System.EventHandler(this.modifierPosteFixeToolStripItem_Click);
            // 
            // supprimerPosteFixesToolStripItem
            // 
            this.supprimerPosteFixesToolStripItem.Name = "supprimerPosteFixesToolStripItem";
            this.supprimerPosteFixesToolStripItem.Size = new System.Drawing.Size(122, 22);
            this.supprimerPosteFixesToolStripItem.Text = "Supprimer";
            this.supprimerPosteFixesToolStripItem.Click += new System.EventHandler(this.supprimerPosteFixeToolStripItem_Click);
            // 
            // cmsRevenus
            // 
            this.cmsRevenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierRevenuToolStripItem,
            this.supprimerRevenuToolStripItem});
            this.cmsRevenus.Name = "contextMenuStrip1";
            this.cmsRevenus.Size = new System.Drawing.Size(123, 48);
            // 
            // modifierRevenuToolStripItem
            // 
            this.modifierRevenuToolStripItem.Name = "modifierRevenuToolStripItem";
            this.modifierRevenuToolStripItem.Size = new System.Drawing.Size(122, 22);
            this.modifierRevenuToolStripItem.Text = "Modifier";
            this.modifierRevenuToolStripItem.Click += new System.EventHandler(this.modifierRevenuToolStripItem_Click);
            // 
            // supprimerRevenuToolStripItem
            // 
            this.supprimerRevenuToolStripItem.Name = "supprimerRevenuToolStripItem";
            this.supprimerRevenuToolStripItem.Size = new System.Drawing.Size(122, 22);
            this.supprimerRevenuToolStripItem.Text = "Supprimer";
            this.supprimerRevenuToolStripItem.Click += new System.EventHandler(this.supprimerRevenuToolStripItem_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.AutoScroll = true;
            this.MainContainer.AutoScrollMargin = new System.Drawing.Size(15, 15);
            this.MainContainer.Controls.Add(this.lblPeriodiciteFixe);
            this.MainContainer.Controls.Add(this.dgvPostesFixes);
            this.MainContainer.Controls.Add(this.lblPosteRevenus);
            this.MainContainer.Controls.Add(this.dgvRevenus);
            this.MainContainer.Controls.Add(this.lblPosteAEchances);
            this.MainContainer.Controls.Add(this.dgvPostesEcheances);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainContainer.Location = new System.Drawing.Point(17, 60);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(640, 536);
            this.MainContainer.TabIndex = 6;
            this.MainContainer.WrapContents = false;
            // 
            // dgvPostesFixes
            // 
            this.dgvPostesFixes.AllowUserToAddRows = false;
            this.dgvPostesFixes.AllowUserToDeleteRows = false;
            this.dgvPostesFixes.AllowUserToOrderColumns = true;
            this.dgvPostesFixes.AllowUserToResizeRows = false;
            this.dgvPostesFixes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPostesFixes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPostesFixes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPostesFixes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPostesFixes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPostesFixes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPostesFixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPostesFixes.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPostesFixes.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPostesFixes.EnableHeadersVisualStyles = false;
            this.dgvPostesFixes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPostesFixes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPostesFixes.Location = new System.Drawing.Point(3, 32);
            this.dgvPostesFixes.MultiSelect = false;
            this.dgvPostesFixes.Name = "dgvPostesFixes";
            this.dgvPostesFixes.ReadOnly = true;
            this.dgvPostesFixes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPostesFixes.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPostesFixes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPostesFixes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostesFixes.Size = new System.Drawing.Size(626, 208);
            this.dgvPostesFixes.TabIndex = 0;
            this.dgvPostesFixes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPostesFixes_CellMouseClick);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // FrmTableauDeBordPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(674, 612);
            this.Controls.Add(this.MainContainer);
            this.Name = "FrmTableauDeBordPostes";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 16);
            this.Text = "FrmTableauDeBordPostes";
            this.Load += new System.EventHandler(this.FrmTableauDeBordPostes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesEcheances)).EndInit();
            this.cmsPosteFixes.ResumeLayout(false);
            this.cmsRevenus.ResumeLayout(false);
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesFixes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgvRevenus;
        private MetroFramework.Controls.MetroGrid dgvPostesEcheances;
        private MetroFramework.Controls.MetroLabel lblPeriodiciteFixe;
        private MetroFramework.Controls.MetroLabel lblPosteAEchances;
        private MetroFramework.Controls.MetroLabel lblPosteRevenus;
        private System.Windows.Forms.ContextMenuStrip cmsPosteFixes;
        private System.Windows.Forms.ToolStripMenuItem modifierPosteFixesToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerPosteFixesToolStripItem;
        private System.Windows.Forms.ContextMenuStrip cmsRevenus;
        private System.Windows.Forms.ToolStripMenuItem modifierRevenuToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerRevenuToolStripItem;
        private System.Windows.Forms.FlowLayoutPanel MainContainer;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroGrid dgvPostesFixes;
    }
}