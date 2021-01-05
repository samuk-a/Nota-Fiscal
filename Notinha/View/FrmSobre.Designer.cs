namespace Notinha.View {
	partial class FrmSobre {
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.pnTop = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lbSobre = new System.Windows.Forms.Label();
			this.pnTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(0, 35);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(445, 56);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Sobre";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnTop
			// 
			this.pnTop.BackColor = System.Drawing.Color.Tomato;
			this.pnTop.Controls.Add(this.btnClose);
			this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnTop.ForeColor = System.Drawing.Color.White;
			this.pnTop.Location = new System.Drawing.Point(0, 0);
			this.pnTop.Margin = new System.Windows.Forms.Padding(4);
			this.pnTop.Name = "pnTop";
			this.pnTop.Size = new System.Drawing.Size(445, 31);
			this.pnTop.TabIndex = 36;
			this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseDown);
			this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseMove);
			this.pnTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseUp);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(413, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(32, 31);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// lbSobre
			// 
			this.lbSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbSobre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSobre.Location = new System.Drawing.Point(12, 91);
			this.lbSobre.Name = "lbSobre";
			this.lbSobre.Size = new System.Drawing.Size(421, 381);
			this.lbSobre.TabIndex = 37;
			this.lbSobre.Text = "label1";
			this.lbSobre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmSobre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(445, 481);
			this.Controls.Add(this.lbSobre);
			this.Controls.Add(this.pnTop);
			this.Controls.Add(this.lbTitle);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmSobre";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sobre";
			this.Load += new System.EventHandler(this.FrmSobre_Load);
			this.pnTop.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel pnTop;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lbSobre;
	}
}