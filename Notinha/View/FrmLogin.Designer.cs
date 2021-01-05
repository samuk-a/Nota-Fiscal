namespace Notinha.View {
	partial class FrmLogin {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.pnTop = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pnTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnTop
			// 
			this.pnTop.BackColor = System.Drawing.Color.Tomato;
			this.pnTop.Controls.Add(this.btnClose);
			this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnTop.ForeColor = System.Drawing.Color.White;
			this.pnTop.Location = new System.Drawing.Point(0, 0);
			this.pnTop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.pnTop.Name = "pnTop";
			this.pnTop.Size = new System.Drawing.Size(551, 24);
			this.pnTop.TabIndex = 37;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(527, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(24, 24);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// lbTitle
			// 
			this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(0, 30);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(551, 85);
			this.lbTitle.TabIndex = 38;
			this.lbTitle.Text = "Login";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 21);
			this.label1.TabIndex = 39;
			this.label1.Text = "Email:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 21);
			this.label2.TabIndex = 39;
			this.label2.Text = "Senha:";
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Location = new System.Drawing.Point(81, 122);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(458, 27);
			this.txtEmail.TabIndex = 10;
			this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
			// 
			// txtSenha
			// 
			this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSenha.Location = new System.Drawing.Point(81, 161);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '•';
			this.txtSenha.Size = new System.Drawing.Size(458, 27);
			this.txtSenha.TabIndex = 11;
			this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.Color.Green;
			this.btnLogin.Location = new System.Drawing.Point(444, 197);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(94, 36);
			this.btnLogin.TabIndex = 20;
			this.btnLogin.Tag = "Disable";
			this.btnLogin.Text = "ENTRAR";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			this.btnLogin.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnLogin.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(551, 246);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pnTop);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
			this.pnTop.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnTop;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnLogin;
	}
}