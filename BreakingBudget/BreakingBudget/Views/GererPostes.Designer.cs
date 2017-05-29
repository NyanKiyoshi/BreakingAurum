namespace BreakingBudget.Views
{
    partial class GererPostes
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
            this.formControlersContainer = new System.Windows.Forms.Panel();
            this.buttonsContainer = new System.Windows.Forms.Panel();
            this.commitBtn = new MetroFramework.Controls.MetroButton();
            this.undoBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.CloseBtn = new MetroFramework.Controls.MetroButton();
            this.listBoxContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.listPosteContainer = new System.Windows.Forms.Panel();
            this.listBoxPostes = new System.Windows.Forms.ListBox();
            this.formControlersContainer.SuspendLayout();
            this.buttonsContainer.SuspendLayout();
            this.listBoxContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.listPosteContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // formControlersContainer
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.formControlersContainer, true);
            this.formControlersContainer.Controls.Add(this.listPosteContainer);
            this.formControlersContainer.Controls.Add(this.buttonsContainer);
            this.formControlersContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formControlersContainer.Location = new System.Drawing.Point(20, 60);
            this.formControlersContainer.Margin = new System.Windows.Forms.Padding(0);
            this.formControlersContainer.Name = "formControlersContainer";
            this.formControlersContainer.Padding = new System.Windows.Forms.Padding(1);
            this.formControlersContainer.Size = new System.Drawing.Size(382, 254);
            this.formControlersContainer.TabIndex = 0;
            // 
            // buttonsContainer
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.buttonsContainer, true);
            this.buttonsContainer.AutoSize = true;
            this.buttonsContainer.BackColor = System.Drawing.Color.White;
            this.buttonsContainer.Controls.Add(this.commitBtn);
            this.buttonsContainer.Controls.Add(this.undoBtn);
            this.buttonsContainer.Controls.Add(this.deleteBtn);
            this.buttonsContainer.Controls.Add(this.addBtn);
            this.buttonsContainer.Controls.Add(this.CloseBtn);
            this.buttonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsContainer.Location = new System.Drawing.Point(1, 214);
            this.buttonsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsContainer.MinimumSize = new System.Drawing.Size(0, 39);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonsContainer.Size = new System.Drawing.Size(380, 39);
            this.buttonsContainer.TabIndex = 2;
            // 
            // commitBtn
            // 
            this.commitBtn.AutoSize = true;
            this.commitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commitBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.commitBtn.Enabled = false;
            this.commitBtn.Location = new System.Drawing.Point(127, 10);
            this.commitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.commitBtn.MinimumSize = new System.Drawing.Size(0, 23);
            this.commitBtn.Name = "commitBtn";
            this.commitBtn.Size = new System.Drawing.Size(51, 29);
            this.commitBtn.TabIndex = 9;
            this.commitBtn.Text = "&Commit";
            this.commitBtn.UseSelectable = true;
            this.commitBtn.Click += new System.EventHandler(this.commitBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.AutoSize = true;
            this.undoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.undoBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.undoBtn.Enabled = false;
            this.undoBtn.Location = new System.Drawing.Point(84, 10);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.undoBtn.MinimumSize = new System.Drawing.Size(0, 23);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(43, 29);
            this.undoBtn.TabIndex = 8;
            this.undoBtn.Text = "&Undo";
            this.undoBtn.UseSelectable = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteBtn.Location = new System.Drawing.Point(36, 10);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(48, 29);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseSelectable = true;
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.Location = new System.Drawing.Point(0, 10);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(36, 29);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "&Add";
            this.addBtn.UseSelectable = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.Location = new System.Drawing.Point(337, 10);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.MinimumSize = new System.Drawing.Size(0, 23);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(43, 29);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Clos&e";
            this.CloseBtn.UseSelectable = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // listBoxContextMenu
            // 
            this.listBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.listBoxContextMenu.Name = "metroContextMenu1";
            this.listBoxContextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "&Add";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // listPosteContainer
            // 
            this.listPosteContainer.AutoSize = true;
            this.listPosteContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listPosteContainer.BackColor = System.Drawing.Color.DimGray;
            this.listPosteContainer.Controls.Add(this.listBoxPostes);
            this.listPosteContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPosteContainer.Location = new System.Drawing.Point(1, 1);
            this.listPosteContainer.Name = "listPosteContainer";
            this.listPosteContainer.Padding = new System.Windows.Forms.Padding(2);
            this.listPosteContainer.Size = new System.Drawing.Size(380, 213);
            this.listPosteContainer.TabIndex = 3;
            // 
            // listBoxPostes
            // 
            this.metroStyleExtender.SetApplyMetroTheme(this.listBoxPostes, true);
            this.listBoxPostes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPostes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPostes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostes.FormattingEnabled = true;
            this.listBoxPostes.ItemHeight = 18;
            this.listBoxPostes.Location = new System.Drawing.Point(2, 2);
            this.listBoxPostes.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxPostes.Name = "listBoxPostes";
            this.listBoxPostes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPostes.Size = new System.Drawing.Size(376, 209);
            this.listBoxPostes.TabIndex = 4;
            this.listBoxPostes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GererPostes_KeyUp);
            this.listBoxPostes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxPostes_MouseUp);
            // 
            // GererPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 334);
            this.Controls.Add(this.formControlersContainer);
            this.MaximizeBox = false;
            this.Name = "GererPostes";
            this.Text = "GererPostes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GererPostes_FormClosing);
            this.Load += new System.EventHandler(this.GererPostes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GererPostes_KeyUp);
            this.formControlersContainer.ResumeLayout(false);
            this.formControlersContainer.PerformLayout();
            this.buttonsContainer.ResumeLayout(false);
            this.buttonsContainer.PerformLayout();
            this.listBoxContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.listPosteContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formControlersContainer;
        private System.Windows.Forms.Panel buttonsContainer;
        private MetroFramework.Controls.MetroButton CloseBtn;
        private MetroFramework.Controls.MetroContextMenu listBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private MetroFramework.Controls.MetroButton commitBtn;
        private MetroFramework.Controls.MetroButton undoBtn;
        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Panel listPosteContainer;
        private System.Windows.Forms.ListBox listBoxPostes;
    }
}