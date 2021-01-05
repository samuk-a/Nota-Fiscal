namespace Notinha.View {
	partial class FrmClientes {
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtOldId = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtRazao = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lbRazao = new System.Windows.Forms.Label();
			this.lbNome = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbCod = new System.Windows.Forms.Label();
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
			this.camposBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientesTable)).BeginInit();
			this.SuspendLayout();
			// 
			// lbClientes
			// 
			this.lbClientes.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbClientes.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbClientes.Location = new System.Drawing.Point(0, 0);
			this.lbClientes.Name = "lbClientes";
			this.lbClientes.Size = new System.Drawing.Size(1102, 52);
			this.lbClientes.TabIndex = 1;
			this.lbClientes.Text = "CLIENTES";
			this.lbClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// camposBox
			// 
			this.camposBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.camposBox.Controls.Add(this.txtFone);
			this.camposBox.Controls.Add(this.lbTelefone);
			this.camposBox.Controls.Add(this.groupBox1);
			this.camposBox.Controls.Add(this.txtCpf);
			this.camposBox.Controls.Add(this.btnDelete);
			this.camposBox.Controls.Add(this.txtOldId);
			this.camposBox.Controls.Add(this.btnSave);
			this.camposBox.Controls.Add(this.txtRazao);
			this.camposBox.Controls.Add(this.txtNome);
			this.camposBox.Controls.Add(this.lbRazao);
			this.camposBox.Controls.Add(this.lbNome);
			this.camposBox.Controls.Add(this.btnAdd);
			this.camposBox.Controls.Add(this.lbCod);
			this.camposBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.camposBox.Location = new System.Drawing.Point(15, 57);
			this.camposBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.camposBox.Name = "camposBox";
			this.camposBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.camposBox.Size = new System.Drawing.Size(350, 482);
			this.camposBox.TabIndex = 2;
			this.camposBox.TabStop = false;
			this.camposBox.Text = "Campos";
			// 
			// txtFone
			// 
			this.txtFone.Location = new System.Drawing.Point(108, 259);
			this.txtFone.Mask = "(99) 0000-0000";
			this.txtFone.Name = "txtFone";
			this.txtFone.Size = new System.Drawing.Size(229, 23);
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
			this.groupBox1.Size = new System.Drawing.Size(334, 124);
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
			this.txtCpf.Size = new System.Drawing.Size(140, 23);
			this.txtCpf.TabIndex = 1;
			this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.Red;
			this.btnDelete.Location = new System.Drawing.Point(161, 447);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(87, 28);
			this.btnDelete.TabIndex = 34;
			this.btnDelete.Tag = "Disable";
			this.btnDelete.Text = "DELETAR";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			this.btnDelete.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnDelete.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// txtOldId
			// 
			this.txtOldId.Enabled = false;
			this.txtOldId.Location = new System.Drawing.Point(8, 449);
			this.txtOldId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtOldId.Name = "txtOldId";
			this.txtOldId.Size = new System.Drawing.Size(116, 23);
			this.txtOldId.TabIndex = 33;
			this.txtOldId.TabStop = false;
			this.txtOldId.Visible = false;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.Green;
			this.btnSave.Location = new System.Drawing.Point(255, 447);
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
			this.txtRazao.Size = new System.Drawing.Size(234, 23);
			this.txtRazao.TabIndex = 3;
			// 
			// txtNome
			// 
			this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNome.Location = new System.Drawing.Point(108, 68);
			this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(234, 23);
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
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.DarkRed;
			this.btnAdd.Location = new System.Drawing.Point(261, 16);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 44);
			this.btnAdd.TabIndex = 25;
			this.btnAdd.Text = "NOVO";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			this.btnAdd.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnAdd.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
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
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.clientesTable.DefaultCellStyle = dataGridViewCellStyle4;
			this.clientesTable.Location = new System.Drawing.Point(372, 64);
			this.clientesTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.clientesTable.Name = "clientesTable";
			this.clientesTable.ReadOnly = true;
			this.clientesTable.RowHeadersVisible = false;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clientesTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.clientesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.clientesTable.Size = new System.Drawing.Size(716, 475);
			this.clientesTable.TabIndex = 3;
			this.clientesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItensTabela_CellClick);
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
			this.Razao.HeaderText = "Razão Social";
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
			// FrmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1102, 554);
			this.Controls.Add(this.clientesTable);
			this.Controls.Add(this.camposBox);
			this.Controls.Add(this.lbClientes);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmClientes";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Itens";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FrmItens_Load);
			this.camposBox.ResumeLayout(false);
			this.camposBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientesTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbClientes;
		private System.Windows.Forms.GroupBox camposBox;
		private System.Windows.Forms.DataGridView clientesTable;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lbCod;
		private System.Windows.Forms.TextBox txtRazao;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lbRazao;
		private System.Windows.Forms.Label lbNome;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtOldId;
		private System.Windows.Forms.Button btnDelete;
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