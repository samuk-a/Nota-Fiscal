namespace Notinha.View {
	partial class FrmBuscarCliente {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.pnTop = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.clientesTable = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Razao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientesTable)).BeginInit();
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
			this.lbTitle.Size = new System.Drawing.Size(633, 56);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Cliente";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.Green;
			this.btnAdd.Location = new System.Drawing.Point(504, 435);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(113, 30);
			this.btnAdd.TabIndex = 18;
			this.btnAdd.Tag = "Disable";
			this.btnAdd.Text = "ADICIONAR";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			this.btnAdd.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnAdd.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPesquisa.Location = new System.Drawing.Point(16, 99);
			this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(600, 23);
			this.txtPesquisa.TabIndex = 1;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
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
			this.pnTop.Size = new System.Drawing.Size(633, 31);
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
			this.btnClose.Location = new System.Drawing.Point(601, 0);
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
			// clientesTable
			// 
			this.clientesTable.AllowUserToAddRows = false;
			this.clientesTable.AllowUserToDeleteRows = false;
			this.clientesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clientesTable.BackgroundColor = System.Drawing.Color.Coral;
			this.clientesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.clientesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cpf,
            this.Nome,
            this.Razao,
            this.End,
            this.Bairro,
            this.Cidade,
            this.Cep,
            this.Fone});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSalmon;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.clientesTable.DefaultCellStyle = dataGridViewCellStyle4;
			this.clientesTable.Location = new System.Drawing.Point(16, 130);
			this.clientesTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.clientesTable.Name = "clientesTable";
			this.clientesTable.ReadOnly = true;
			this.clientesTable.RowHeadersVisible = false;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clientesTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.clientesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.clientesTable.Size = new System.Drawing.Size(600, 297);
			this.clientesTable.TabIndex = 4;
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Cpf
			// 
			this.Cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Format = "000.000.000-00";
			dataGridViewCellStyle1.NullValue = null;
			this.Cpf.DefaultCellStyle = dataGridViewCellStyle1;
			this.Cpf.FillWeight = 80F;
			this.Cpf.HeaderText = "CPF";
			this.Cpf.Name = "Cpf";
			this.Cpf.ReadOnly = true;
			this.Cpf.Visible = false;
			// 
			// Nome
			// 
			this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			// 
			// Razao
			// 
			this.Razao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Razao.HeaderText = "Social";
			this.Razao.Name = "Razao";
			this.Razao.ReadOnly = true;
			// 
			// End
			// 
			this.End.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.End.FillWeight = 120F;
			this.End.HeaderText = "Endereço";
			this.End.Name = "End";
			this.End.ReadOnly = true;
			// 
			// Bairro
			// 
			this.Bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Bairro.FillWeight = 80F;
			this.Bairro.HeaderText = "Bairro";
			this.Bairro.Name = "Bairro";
			this.Bairro.ReadOnly = true;
			// 
			// Cidade
			// 
			this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Cidade.FillWeight = 70F;
			this.Cidade.HeaderText = "Cidade";
			this.Cidade.Name = "Cidade";
			this.Cidade.ReadOnly = true;
			// 
			// Cep
			// 
			this.Cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Format = "00 000-999";
			this.Cep.DefaultCellStyle = dataGridViewCellStyle2;
			this.Cep.FillWeight = 60F;
			this.Cep.HeaderText = "CEP";
			this.Cep.Name = "Cep";
			this.Cep.ReadOnly = true;
			// 
			// Fone
			// 
			this.Fone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Format = "(##) ####-####";
			dataGridViewCellStyle3.NullValue = null;
			this.Fone.DefaultCellStyle = dataGridViewCellStyle3;
			this.Fone.FillWeight = 70F;
			this.Fone.HeaderText = "Telefone";
			this.Fone.Name = "Fone";
			this.Fone.ReadOnly = true;
			// 
			// FrmBuscarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(633, 481);
			this.Controls.Add(this.clientesTable);
			this.Controls.Add(this.pnTop);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.btnAdd);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmBuscarCliente";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Itens";
			this.Load += new System.EventHandler(this.FrmBuscarCliente_Load);
			this.pnTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.clientesTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel pnTop;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView clientesTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Razao;
		private System.Windows.Forms.DataGridViewTextBoxColumn End;
		private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fone;
	}
}