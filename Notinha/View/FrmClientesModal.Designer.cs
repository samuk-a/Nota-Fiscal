namespace Notinha.View {
	partial class FrmClientesModal {
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
			this.lbClientes = new System.Windows.Forms.Label();
			this.camposBox = new System.Windows.Forms.GroupBox();
			this.txtFone = new System.Windows.Forms.MaskedTextBox();
			this.lbTelefone = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbEndereco = new System.Windows.Forms.Label();
			this.txtCep = new System.Windows.Forms.MaskedTextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.lbCep = new System.Windows.Forms.Label();
			this.lbBairro = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.lbCidade = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.MaskedTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtRazao = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lbRazao = new System.Windows.Forms.Label();
			this.lbNome = new System.Windows.Forms.Label();
			this.lbCod = new System.Windows.Forms.Label();
			this.pnTop = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.camposBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbClientes
			// 
			this.lbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbClientes.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbClientes.Location = new System.Drawing.Point(0, 35);
			this.lbClientes.Name = "lbClientes";
			this.lbClientes.Size = new System.Drawing.Size(380, 52);
			this.lbClientes.TabIndex = 1;
			this.lbClientes.Text = "CLIENTES";
			this.lbClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// camposBox
			// 
			this.camposBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.camposBox.Controls.Add(this.txtFone);
			this.camposBox.Controls.Add(this.lbTelefone);
			this.camposBox.Controls.Add(this.groupBox1);
			this.camposBox.Controls.Add(this.txtCpf);
			this.camposBox.Controls.Add(this.btnSave);
			this.camposBox.Controls.Add(this.txtRazao);
			this.camposBox.Controls.Add(this.txtNome);
			this.camposBox.Controls.Add(this.lbRazao);
			this.camposBox.Controls.Add(this.lbNome);
			this.camposBox.Controls.Add(this.lbCod);
			this.camposBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.camposBox.Location = new System.Drawing.Point(15, 91);
			this.camposBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.camposBox.Name = "camposBox";
			this.camposBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.camposBox.Size = new System.Drawing.Size(353, 335);
			this.camposBox.TabIndex = 2;
			this.camposBox.TabStop = false;
			this.camposBox.Text = "Campos";
			// 
			// txtFone
			// 
			this.txtFone.Location = new System.Drawing.Point(108, 259);
			this.txtFone.Mask = "(99) 0000-0000";
			this.txtFone.Name = "txtFone";
			this.txtFone.Size = new System.Drawing.Size(237, 23);
			this.txtFone.TabIndex = 20;
			this.txtFone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lbTelefone
			// 
			this.lbTelefone.AutoSize = true;
			this.lbTelefone.Location = new System.Drawing.Point(16, 262);
			this.lbTelefone.Name = "lbTelefone";
			this.lbTelefone.Size = new System.Drawing.Size(65, 17);
			this.lbTelefone.TabIndex = 45;
			this.lbTelefone.Text = "Telefone:";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lbEndereco);
			this.groupBox1.Controls.Add(this.txtCep);
			this.groupBox1.Controls.Add(this.txtEndereco);
			this.groupBox1.Controls.Add(this.lbCep);
			this.groupBox1.Controls.Add(this.lbBairro);
			this.groupBox1.Controls.Add(this.txtCidade);
			this.groupBox1.Controls.Add(this.txtBairro);
			this.groupBox1.Controls.Add(this.lbCidade);
			this.groupBox1.Location = new System.Drawing.Point(9, 129);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(337, 124);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Localização";
			// 
			// lbEndereco
			// 
			this.lbEndereco.AutoSize = true;
			this.lbEndereco.Location = new System.Drawing.Point(6, 28);
			this.lbEndereco.Name = "lbEndereco";
			this.lbEndereco.Size = new System.Drawing.Size(73, 17);
			this.lbEndereco.TabIndex = 36;
			this.lbEndereco.Text = "Endereço:";
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(247, 55);
			this.txtCep.Mask = "00 000-999";
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(81, 23);
			this.txtCep.TabIndex = 11;
			this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(99, 25);
			this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(229, 23);
			this.txtEndereco.TabIndex = 9;
			// 
			// lbCep
			// 
			this.lbCep.AutoSize = true;
			this.lbCep.Location = new System.Drawing.Point(210, 59);
			this.lbCep.Name = "lbCep";
			this.lbCep.Size = new System.Drawing.Size(38, 17);
			this.lbCep.TabIndex = 42;
			this.lbCep.Text = "CEP:";
			// 
			// lbBairro
			// 
			this.lbBairro.AutoSize = true;
			this.lbBairro.Location = new System.Drawing.Point(6, 59);
			this.lbBairro.Name = "lbBairro";
			this.lbBairro.Size = new System.Drawing.Size(48, 17);
			this.lbBairro.TabIndex = 38;
			this.lbBairro.Text = "Bairro:";
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(99, 87);
			this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(229, 23);
			this.txtCidade.TabIndex = 12;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(99, 56);
			this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(105, 23);
			this.txtBairro.TabIndex = 10;
			// 
			// lbCidade
			// 
			this.lbCidade.AutoSize = true;
			this.lbCidade.Location = new System.Drawing.Point(6, 90);
			this.lbCidade.Name = "lbCidade";
			this.lbCidade.Size = new System.Drawing.Size(61, 17);
			this.lbCidade.TabIndex = 40;
			this.lbCidade.Text = "Cidade:";
			// 
			// txtCpf
			// 
			this.txtCpf.Location = new System.Drawing.Point(108, 36);
			this.txtCpf.Mask = "000\\.000\\.000-99";
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(237, 23);
			this.txtCpf.TabIndex = 1;
			this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.Green;
			this.btnSave.Location = new System.Drawing.Point(258, 300);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(87, 28);
			this.btnSave.TabIndex = 32;
			this.btnSave.Tag = "Disable";
			this.btnSave.Text = "SALVAR";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			this.btnSave.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnSave.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// txtRazao
			// 
			this.txtRazao.Location = new System.Drawing.Point(108, 99);
			this.txtRazao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtRazao.Name = "txtRazao";
			this.txtRazao.Size = new System.Drawing.Size(237, 23);
			this.txtRazao.TabIndex = 3;
			// 
			// txtNome
			// 
			this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNome.Location = new System.Drawing.Point(108, 68);
			this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(237, 23);
			this.txtNome.TabIndex = 2;
			// 
			// lbRazao
			// 
			this.lbRazao.AutoSize = true;
			this.lbRazao.Location = new System.Drawing.Point(7, 103);
			this.lbRazao.Name = "lbRazao";
			this.lbRazao.Size = new System.Drawing.Size(95, 17);
			this.lbRazao.TabIndex = 27;
			this.lbRazao.Text = "Razão Social:";
			// 
			// lbNome
			// 
			this.lbNome.AutoSize = true;
			this.lbNome.Location = new System.Drawing.Point(7, 71);
			this.lbNome.Name = "lbNome";
			this.lbNome.Size = new System.Drawing.Size(52, 17);
			this.lbNome.TabIndex = 26;
			this.lbNome.Text = "Nome:";
			// 
			// lbCod
			// 
			this.lbCod.AutoSize = true;
			this.lbCod.Location = new System.Drawing.Point(7, 39);
			this.lbCod.Name = "lbCod";
			this.lbCod.Size = new System.Drawing.Size(37, 17);
			this.lbCod.TabIndex = 23;
			this.lbCod.Text = "CPF:";
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
			this.pnTop.Size = new System.Drawing.Size(380, 31);
			this.pnTop.TabIndex = 37;
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
			this.btnClose.Location = new System.Drawing.Point(348, 0);
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
			// FrmClientesModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(380, 441);
			this.Controls.Add(this.pnTop);
			this.Controls.Add(this.camposBox);
			this.Controls.Add(this.lbClientes);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmClientesModal";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Itens";
			this.TopMost = true;
			this.camposBox.ResumeLayout(false);
			this.camposBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.pnTop.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbClientes;
		private System.Windows.Forms.GroupBox camposBox;
		private System.Windows.Forms.Label lbCod;
		private System.Windows.Forms.TextBox txtRazao;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lbRazao;
		private System.Windows.Forms.Label lbNome;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label lbEndereco;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label lbBairro;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label lbCidade;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox txtCep;
		private System.Windows.Forms.Label lbCep;
		private System.Windows.Forms.MaskedTextBox txtFone;
		private System.Windows.Forms.Label lbTelefone;
		private System.Windows.Forms.Panel pnTop;
		private System.Windows.Forms.Button btnClose;
	}
}