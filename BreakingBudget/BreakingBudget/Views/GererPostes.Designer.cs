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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.submitBtn = new MetroFramework.Controls.MetroButton();
            this.listBoxPostes = new System.Windows.Forms.ListBox();
            this.ListBoxContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ListBoxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listBoxPostes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 220);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.submitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 29);
            this.panel2.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelBtn.Location = new System.Drawing.Point(161, 0);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.cancelBtn.MinimumSize = new System.Drawing.Size(0, 23);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(50, 29);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.AutoSize = true;
            this.submitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.submitBtn.Location = new System.Drawing.Point(211, 0);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.submitBtn.MinimumSize = new System.Drawing.Size(0, 23);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(49, 29);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "S&ubmit";
            this.submitBtn.UseSelectable = true;
            this.submitBtn.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // listBoxPostes
            // 
            this.listBoxPostes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPostes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostes.FormattingEnabled = true;
            this.listBoxPostes.ItemHeight = 18;
            this.listBoxPostes.Location = new System.Drawing.Point(0, 0);
            this.listBoxPostes.Name = "listBoxPostes";
            this.listBoxPostes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPostes.Size = new System.Drawing.Size(260, 220);
            this.listBoxPostes.TabIndex = 1;
            this.listBoxPostes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GererPostes_KeyUp);
            this.listBoxPostes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxPostes_MouseUp);
            // 
            // ListBoxContextMenu
            // 
            this.ListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.ListBoxContextMenu.Name = "metroContextMenu1";
            this.ListBoxContextMenu.Size = new System.Drawing.Size(108, 48);
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
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.Location = new System.Drawing.Point(0, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(36, 29);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "&Add";
            this.addBtn.UseSelectable = true;
            // 
            // GererPostes
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GererPostes";
            this.Text = "GererPostes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GererPostes_FormClosing);
            this.Load += new System.EventHandler(this.GererPostes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GererPostes_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ListBoxContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxPostes;
        private MetroFramework.Controls.MetroButton submitBtn;
        private MetroFramework.Controls.MetroContextMenu ListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroButton addBtn;
    }
}