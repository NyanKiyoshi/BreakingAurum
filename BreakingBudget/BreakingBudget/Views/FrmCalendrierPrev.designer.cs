namespace BreakingBudget
{
    partial class FrmCalendrierPrev
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
            this.dgvCalendrier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendrier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCalendrier
            // 
            this.dgvCalendrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalendrier.Location = new System.Drawing.Point(20, 60);
            this.dgvCalendrier.Name = "dgvCalendrier";
            this.dgvCalendrier.Size = new System.Drawing.Size(1261, 452);
            this.dgvCalendrier.TabIndex = 0;
            // 
            // FrmCalendrierPrev
            // 
            this.ClientSize = new System.Drawing.Size(1301, 532);
            this.Controls.Add(this.dgvCalendrier);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmCalendrierPrev";
            this.Text = "Calendrier Prévisionnel";
            this.Load += new System.EventHandler(this.FrmCalendrierPrev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendrier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalendrier;
    }
}