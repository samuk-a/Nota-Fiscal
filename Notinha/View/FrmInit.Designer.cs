namespace Notinha.View {
	partial class FrmInit {
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
			if (disposing && (components != null)) {
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
			this.progress = new System.Windows.Forms.ProgressBar();
			this.lbDetails = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progress
			// 
			this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.progress.BackColor = System.Drawing.Color.Black;
			this.progress.ForeColor = System.Drawing.Color.Coral;
			this.progress.Location = new System.Drawing.Point(415, 378);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(296, 15);
			this.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progress.TabIndex = 0;
			this.progress.Value = 10;
			// 
			// lbDetails
			// 
			this.lbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDetails.BackColor = System.Drawing.Color.Transparent;
			this.lbDetails.ForeColor = System.Drawing.Color.White;
			this.lbDetails.Location = new System.Drawing.Point(415, 359);
			this.lbDetails.Name = "lbDetails";
			this.lbDetails.Size = new System.Drawing.Size(296, 16);
			this.lbDetails.TabIndex = 1;
			this.lbDetails.Text = "label1";
			this.lbDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmInit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Notinha.Properties.Resources.Logo;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(723, 405);
			this.Controls.Add(this.lbDetails);
			this.Controls.Add(this.progress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmInit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrmInit_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar progress;
		private System.Windows.Forms.Label lbDetails;
	}
}