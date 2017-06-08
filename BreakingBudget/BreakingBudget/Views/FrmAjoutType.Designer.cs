namespace BreakingBudget.Views
{
    partial class FrmAjoutType
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
            this.lblAjoutType = new MetroFramework.Controls.MetroLabel();
            this.txtType = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAjoutType
            // 
            this.lblAjoutType.AutoSize = true;
            this.lblAjoutType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAjoutType.Location = new System.Drawing.Point(23, 75);
            this.lblAjoutType.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblAjoutType.Name = "lblAjoutType";
            this.lblAjoutType.Size = new System.Drawing.Size(106, 19);
            this.lblAjoutType.TabIndex = 0;
            this.lblAjoutType.Text = "Nouveau type : ";
            // 
            // txtType
            // 
            // 
            // 
            // 
            this.txtType.CustomButton.Image = null;
            this.txtType.CustomButton.Location = new System.Drawing.Point(303, 2);
            this.txtType.CustomButton.Name = "";
            this.txtType.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtType.CustomButton.TabIndex = 1;
            this.txtType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtType.CustomButton.UseSelectable = true;
            this.txtType.CustomButton.Visible = false;
            this.txtType.Lines = new string[0];
            this.txtType.Location = new System.Drawing.Point(23, 98);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.MaxLength = 30;
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtType.SelectedText = "";
            this.txtType.SelectionLength = 0;
            this.txtType.SelectionStart = 0;
            this.txtType.ShortcutsEnabled = true;
            this.txtType.Size = new System.Drawing.Size(323, 22);
            this.txtType.TabIndex = 1;
            this.txtType.UseSelectable = true;
            this.txtType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtType_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(271, 151);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Ajouter";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseSelectable = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // FrmAjoutType
            // 
            this.ClientSize = new System.Drawing.Size(369, 186);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblAjoutType);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAjoutType";
            this.Resizable = false;
            this.Text = "Ajouter un type";
            this.Icon = global::BreakingBudget.Properties.Resources.icon;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAjoutType;
        private MetroFramework.Controls.MetroTextBox txtType;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}