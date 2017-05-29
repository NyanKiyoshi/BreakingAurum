using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HtmlPrinter
{
	/// <summary>
	/// Summary description for HtmlPrinter.
	/// </summary>
	class frmHtmlPrinter : System.Windows.Forms.Form
	{
		#region Declarations

		public AxDHTMLEDLib.AxDHTMLEdit axD;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#endregion

		#region Constructor & Destructor

		public frmHtmlPrinter()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmHtmlPrinter));
			this.axD = new AxDHTMLEDLib.AxDHTMLEdit();
			((System.ComponentModel.ISupportInitialize)(this.axD)).BeginInit();
			this.SuspendLayout();
			// 
			// axD
			// 
			this.axD.Enabled = true;
			this.axD.Location = new System.Drawing.Point(0, 0);
			this.axD.Name = "axD";
			this.axD.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axD.OcxState")));
			this.axD.Size = new System.Drawing.Size(160, 80);
			this.axD.TabIndex = 1;
			// 
			// frmHtmlPrinter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(160, 77);
			this.Controls.Add(this.axD);
			this.Name = "frmHtmlPrinter";
			this.Text = "HtmlPrinter";
			((System.ComponentModel.ISupportInitialize)(this.axD)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

	}
}
