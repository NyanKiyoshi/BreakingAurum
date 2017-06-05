namespace BreakingBudget
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
            this.dgvPostesFixes = new System.Windows.Forms.DataGridView();
            this.dgvRevenus = new System.Windows.Forms.DataGridView();
            this.dgvPostesEcheances = new System.Windows.Forms.DataGridView();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.cmsPosteFixes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRevenus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesFixes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesEcheances)).BeginInit();
            this.cmsPosteFixes.SuspendLayout();
            this.cmsRevenus.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPostesFixes
            // 
            this.dgvPostesFixes.AllowUserToAddRows = false;
            this.dgvPostesFixes.AllowUserToDeleteRows = false;
            this.dgvPostesFixes.AllowUserToOrderColumns = true;
            this.dgvPostesFixes.AllowUserToResizeRows = false;
            this.dgvPostesFixes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPostesFixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostesFixes.Location = new System.Drawing.Point(3, 285);
            this.dgvPostesFixes.MultiSelect = false;
            this.dgvPostesFixes.Name = "dgvPostesFixes";
            this.dgvPostesFixes.ReadOnly = true;
            this.dgvPostesFixes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostesFixes.Size = new System.Drawing.Size(626, 208);
            this.dgvPostesFixes.TabIndex = 0;
            this.dgvPostesFixes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPostesFixes_CellMouseClick);
            // 
            // dgvRevenus
            // 
            this.dgvRevenus.AllowUserToAddRows = false;
            this.dgvRevenus.AllowUserToDeleteRows = false;
            this.dgvRevenus.AllowUserToOrderColumns = true;
            this.dgvRevenus.AllowUserToResizeRows = false;
            this.dgvRevenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvRevenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenus.Location = new System.Drawing.Point(3, 32);
            this.dgvRevenus.MultiSelect = false;
            this.dgvRevenus.Name = "dgvRevenus";
            this.dgvRevenus.ReadOnly = true;
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
            this.dgvPostesEcheances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostesEcheances.Location = new System.Drawing.Point(3, 528);
            this.dgvPostesEcheances.MultiSelect = false;
            this.dgvPostesEcheances.Name = "dgvPostesEcheances";
            this.dgvPostesEcheances.ReadOnly = true;
            this.dgvPostesEcheances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostesEcheances.Size = new System.Drawing.Size(626, 150);
            this.dgvPostesEcheances.TabIndex = 2;
            this.dgvPostesEcheances.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPostesEcheances_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Postes à périodicité fixe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label2.Location = new System.Drawing.Point(3, 506);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Postes à échéances : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label3.Location = new System.Drawing.Point(3, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Postes \"Revenus\" : ";
            // 
            // cmsPosteFixes
            // 
            this.cmsPosteFixes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.cmsPosteFixes.Name = "cmsPosteFixes";
            this.cmsPosteFixes.Size = new System.Drawing.Size(130, 48);
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
            // cmsRevenus
            // 
            this.cmsRevenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.cmsRevenus.Name = "contextMenuStrip1";
            this.cmsRevenus.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.AutoScroll = true;
            this.MainContainer.AutoScrollMargin = new System.Drawing.Size(15, 15);
            this.MainContainer.Controls.Add(this.label1);
            this.MainContainer.Controls.Add(this.dgvRevenus);
            this.MainContainer.Controls.Add(this.label3);
            this.MainContainer.Controls.Add(this.dgvPostesFixes);
            this.MainContainer.Controls.Add(this.label2);
            this.MainContainer.Controls.Add(this.dgvPostesEcheances);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainContainer.Location = new System.Drawing.Point(17, 49);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(640, 547);
            this.MainContainer.TabIndex = 6;
            this.MainContainer.WrapContents = false;
            // 
            // FrmTableauDeBordPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(674, 612);
            this.Controls.Add(this.MainContainer);
            this.Name = "FrmTableauDeBordPostes";
            this.Padding = new System.Windows.Forms.Padding(17, 49, 17, 16);
            this.Text = "FrmTableauDeBordPostes";
            this.Load += new System.EventHandler(this.FrmTableauDeBordPostes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesFixes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostesEcheances)).EndInit();
            this.cmsPosteFixes.ResumeLayout(false);
            this.cmsRevenus.ResumeLayout(false);
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPostesFixes;
        private System.Windows.Forms.DataGridView dgvRevenus;
        private System.Windows.Forms.DataGridView dgvPostesEcheances;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private System.Windows.Forms.ContextMenuStrip cmsPosteFixes;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsRevenus;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel MainContainer;
    }
}