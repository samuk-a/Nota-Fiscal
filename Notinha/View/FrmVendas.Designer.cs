namespace Notinha.View {
	partial class FrmVendas {
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitle = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtClientId = new System.Windows.Forms.TextBox();
			this.txtClient = new System.Windows.Forms.TextBox();
			this.btnNovoCliente = new System.Windows.Forms.Button();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.lbCliente = new System.Windows.Forms.Label();
			this.parcelado = new System.Windows.Forms.RadioButton();
			this.vista = new System.Windows.Forms.RadioButton();
			this.numDesconto = new System.Windows.Forms.NumericUpDown();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.produtosTable = new System.Windows.Forms.DataGridView();
			this.CodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpHora = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.dtpOrcamento = new System.Windows.Forms.DateTimePicker();
			this.dtpVendido = new System.Windows.Forms.DateTimePicker();
			this.lbOrcamento = new System.Windows.Forms.Label();
			this.lbVendido = new System.Windows.Forms.Label();
			this.lbDesconto = new System.Windows.Forms.Label();
			this.txtCod = new System.Windows.Forms.TextBox();
			this.lbCod = new System.Windows.Forms.Label();
			this.vendasTable = new System.Windows.Forms.DataGridView();
			this.menuVenda = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupParcelas = new System.Windows.Forms.GroupBox();
			this.numParcelas = new System.Windows.Forms.NumericUpDown();
			this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Orcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vendasTable)).BeginInit();
			this.menuVenda.SuspendLayout();
			this.groupParcelas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(0, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(1121, 51);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "VENDAS";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.groupParcelas);
			this.groupBox1.Controls.Add(this.txtClientId);
			this.groupBox1.Controls.Add(this.txtClient);
			this.groupBox1.Controls.Add(this.btnNovoCliente);
			this.groupBox1.Controls.Add(this.btnBuscarCliente);
			this.groupBox1.Controls.Add(this.lbCliente);
			this.groupBox1.Controls.Add(this.parcelado);
			this.groupBox1.Controls.Add(this.vista);
			this.groupBox1.Controls.Add(this.numDesconto);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnAddItem);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.produtosTable);
			this.groupBox1.Controls.Add(this.dtpHora);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.dtpOrcamento);
			this.groupBox1.Controls.Add(this.dtpVendido);
			this.groupBox1.Controls.Add(this.lbOrcamento);
			this.groupBox1.Controls.Add(this.lbVendido);
			this.groupBox1.Controls.Add(this.lbDesconto);
			this.groupBox1.Controls.Add(this.txtCod);
			this.groupBox1.Controls.Add(this.lbCod);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(15, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(337, 582);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Campos";
			// 
			// txtClientId
			// 
			this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtClientId.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtClientId.Enabled = false;
			this.txtClientId.Location = new System.Drawing.Point(89, 395);
			this.txtClientId.Name = "txtClientId";
			this.txtClientId.ReadOnly = true;
			this.txtClientId.Size = new System.Drawing.Size(53, 23);
			this.txtClientId.TabIndex = 45;
			this.txtClientId.TabStop = false;
			this.txtClientId.Tag = "R";
			this.txtClientId.Visible = false;
			// 
			// txtClient
			// 
			this.txtClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtClient.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtClient.Enabled = false;
			this.txtClient.Location = new System.Drawing.Point(148, 395);
			this.txtClient.Name = "txtClient";
			this.txtClient.ReadOnly = true;
			this.txtClient.Size = new System.Drawing.Size(181, 23);
			this.txtClient.TabIndex = 44;
			this.txtClient.TabStop = false;
			this.txtClient.Tag = "R";
			// 
			// btnNovoCliente
			// 
			this.btnNovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovoCliente.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.btnNovoCliente.Location = new System.Drawing.Point(73, 534);
			this.btnNovoCliente.Name = "btnNovoCliente";
			this.btnNovoCliente.Size = new System.Drawing.Size(61, 42);
			this.btnNovoCliente.TabIndex = 42;
			this.btnNovoCliente.Tag = "Disable";
			this.btnNovoCliente.Text = "NOVO CLIENTE";
			this.btnNovoCliente.UseVisualStyleBackColor = true;
			this.btnNovoCliente.Click += new System.EventHandler(this.BtnNovoCliente_Click);
			this.btnNovoCliente.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnNovoCliente.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarCliente.ForeColor = System.Drawing.Color.OliveDrab;
			this.btnBuscarCliente.Location = new System.Drawing.Point(6, 534);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(61, 42);
			this.btnBuscarCliente.TabIndex = 41;
			this.btnBuscarCliente.Tag = "Disable";
			this.btnBuscarCliente.Text = "BUSCAR CLIENTE";
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
			this.btnBuscarCliente.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnBuscarCliente.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// lbCliente
			// 
			this.lbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbCliente.AutoSize = true;
			this.lbCliente.Location = new System.Drawing.Point(8, 399);
			this.lbCliente.Name = "lbCliente";
			this.lbCliente.Size = new System.Drawing.Size(58, 17);
			this.lbCliente.TabIndex = 40;
			this.lbCliente.Text = "Cliente:";
			// 
			// parcelado
			// 
			this.parcelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.parcelado.AutoSize = true;
			this.parcelado.Location = new System.Drawing.Point(236, 425);
			this.parcelado.Name = "parcelado";
			this.parcelado.Size = new System.Drawing.Size(93, 21);
			this.parcelado.TabIndex = 39;
			this.parcelado.Text = "Parcelado";
			this.parcelado.UseVisualStyleBackColor = true;
			this.parcelado.CheckedChanged += new System.EventHandler(this.parcelado_CheckedChanged);
			// 
			// vista
			// 
			this.vista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.vista.AutoSize = true;
			this.vista.Checked = true;
			this.vista.Location = new System.Drawing.Point(148, 425);
			this.vista.Name = "vista";
			this.vista.Size = new System.Drawing.Size(70, 21);
			this.vista.TabIndex = 38;
			this.vista.TabStop = true;
			this.vista.Text = "À Vista";
			this.vista.UseVisualStyleBackColor = true;
			this.vista.CheckedChanged += new System.EventHandler(this.vista_CheckedChanged);
			// 
			// numDesconto
			// 
			this.numDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numDesconto.DecimalPlaces = 2;
			this.numDesconto.Location = new System.Drawing.Point(148, 302);
			this.numDesconto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numDesconto.Name = "numDesconto";
			this.numDesconto.Size = new System.Drawing.Size(182, 23);
			this.numDesconto.TabIndex = 36;
			this.numDesconto.Tag = "";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.Red;
			this.btnDelete.Location = new System.Drawing.Point(150, 547);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(87, 29);
			this.btnDelete.TabIndex = 35;
			this.btnDelete.Tag = "Disable";
			this.btnDelete.Text = "DELETAR";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnAddItem
			// 
			this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddItem.ForeColor = System.Drawing.Color.Brown;
			this.btnAddItem.Location = new System.Drawing.Point(252, 14);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(78, 40);
			this.btnAddItem.TabIndex = 22;
			this.btnAddItem.Tag = "Disable";
			this.btnAddItem.Text = "+ ITEM";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
			this.btnAddItem.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnAddItem.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.DarkRed;
			this.btnAdd.Location = new System.Drawing.Point(164, 14);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 40);
			this.btnAdd.TabIndex = 21;
			this.btnAdd.Text = "NOVO";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			this.btnAdd.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnAdd.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// produtosTable
			// 
			this.produtosTable.AllowUserToAddRows = false;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSalmon;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
			this.produtosTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
			this.produtosTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.produtosTable.BackgroundColor = System.Drawing.Color.Coral;
			this.produtosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.produtosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodItem,
            this.Descricao,
            this.Valor,
            this.Qtd});
			this.produtosTable.GridColor = System.Drawing.Color.DimGray;
			this.produtosTable.Location = new System.Drawing.Point(12, 61);
			this.produtosTable.Name = "produtosTable";
			this.produtosTable.ReadOnly = true;
			this.produtosTable.RowHeadersVisible = false;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSalmon;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
			this.produtosTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.produtosTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.produtosTable.Size = new System.Drawing.Size(319, 235);
			this.produtosTable.TabIndex = 20;
			// 
			// CodItem
			// 
			this.CodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CodItem.HeaderText = "Código";
			this.CodItem.Name = "CodItem";
			this.CodItem.ReadOnly = true;
			this.CodItem.Visible = false;
			// 
			// Descricao
			// 
			this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descricao.FillWeight = 150F;
			this.Descricao.HeaderText = "Descrição";
			this.Descricao.Name = "Descricao";
			this.Descricao.ReadOnly = true;
			// 
			// Valor
			// 
			this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle13.Format = "C2";
			dataGridViewCellStyle13.NullValue = "0,00";
			this.Valor.DefaultCellStyle = dataGridViewCellStyle13;
			this.Valor.FillWeight = 80F;
			this.Valor.HeaderText = "Valor";
			this.Valor.Name = "Valor";
			this.Valor.ReadOnly = true;
			// 
			// Qtd
			// 
			this.Qtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle14.Format = "N0";
			dataGridViewCellStyle14.NullValue = "-";
			this.Qtd.DefaultCellStyle = dataGridViewCellStyle14;
			this.Qtd.HeaderText = "Quantidade";
			this.Qtd.Name = "Qtd";
			this.Qtd.ReadOnly = true;
			// 
			// dtpHora
			// 
			this.dtpHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpHora.Location = new System.Drawing.Point(249, 333);
			this.dtpHora.Name = "dtpHora";
			this.dtpHora.Size = new System.Drawing.Size(80, 23);
			this.dtpHora.TabIndex = 19;
			this.dtpHora.Tag = "";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.Green;
			this.btnSave.Location = new System.Drawing.Point(244, 547);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(87, 29);
			this.btnSave.TabIndex = 18;
			this.btnSave.Tag = "Disable";
			this.btnSave.Text = "SALVAR";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			this.btnSave.MouseEnter += new System.EventHandler(this.ChangeButtonColor);
			this.btnSave.MouseLeave += new System.EventHandler(this.ChangeButtonColor);
			// 
			// dtpOrcamento
			// 
			this.dtpOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtpOrcamento.Location = new System.Drawing.Point(148, 366);
			this.dtpOrcamento.Name = "dtpOrcamento";
			this.dtpOrcamento.Size = new System.Drawing.Size(181, 23);
			this.dtpOrcamento.TabIndex = 14;
			this.dtpOrcamento.Tag = "";
			// 
			// dtpVendido
			// 
			this.dtpVendido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtpVendido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpVendido.Location = new System.Drawing.Point(148, 333);
			this.dtpVendido.Name = "dtpVendido";
			this.dtpVendido.Size = new System.Drawing.Size(94, 23);
			this.dtpVendido.TabIndex = 13;
			this.dtpVendido.Tag = "";
			// 
			// lbOrcamento
			// 
			this.lbOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbOrcamento.AutoSize = true;
			this.lbOrcamento.Location = new System.Drawing.Point(7, 371);
			this.lbOrcamento.Name = "lbOrcamento";
			this.lbOrcamento.Size = new System.Drawing.Size(112, 17);
			this.lbOrcamento.TabIndex = 7;
			this.lbOrcamento.Text = "Orçamento em:";
			// 
			// lbVendido
			// 
			this.lbVendido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbVendido.AutoSize = true;
			this.lbVendido.Location = new System.Drawing.Point(7, 338);
			this.lbVendido.Name = "lbVendido";
			this.lbVendido.Size = new System.Drawing.Size(92, 17);
			this.lbVendido.TabIndex = 6;
			this.lbVendido.Text = "Vendido em:";
			// 
			// lbDesconto
			// 
			this.lbDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbDesconto.AutoSize = true;
			this.lbDesconto.Location = new System.Drawing.Point(7, 304);
			this.lbDesconto.Name = "lbDesconto";
			this.lbDesconto.Size = new System.Drawing.Size(133, 17);
			this.lbDesconto.TabIndex = 5;
			this.lbDesconto.Text = "Valor de Desconto:";
			// 
			// txtCod
			// 
			this.txtCod.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtCod.Enabled = false;
			this.txtCod.Location = new System.Drawing.Point(68, 29);
			this.txtCod.Name = "txtCod";
			this.txtCod.Size = new System.Drawing.Size(72, 23);
			this.txtCod.TabIndex = 1;
			this.txtCod.TabStop = false;
			// 
			// lbCod
			// 
			this.lbCod.AutoSize = true;
			this.lbCod.Location = new System.Drawing.Point(8, 32);
			this.lbCod.Name = "lbCod";
			this.lbCod.Size = new System.Drawing.Size(62, 17);
			this.lbCod.TabIndex = 0;
			this.lbCod.Text = "Código:";
			// 
			// vendasTable
			// 
			this.vendasTable.AllowUserToAddRows = false;
			this.vendasTable.AllowUserToDeleteRows = false;
			this.vendasTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.vendasTable.BackgroundColor = System.Drawing.Color.Coral;
			this.vendasTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vendasTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Desconto,
            this.Vendido,
            this.Orcamento,
            this.Total,
            this.Parcelas,
            this.Cliente});
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSalmon;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.vendasTable.DefaultCellStyle = dataGridViewCellStyle21;
			this.vendasTable.GridColor = System.Drawing.Color.DimGray;
			this.vendasTable.Location = new System.Drawing.Point(358, 64);
			this.vendasTable.Name = "vendasTable";
			this.vendasTable.ReadOnly = true;
			this.vendasTable.RowHeadersVisible = false;
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vendasTable.RowsDefaultCellStyle = dataGridViewCellStyle22;
			this.vendasTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vendasTable.Size = new System.Drawing.Size(749, 574);
			this.vendasTable.TabIndex = 2;
			this.vendasTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendasTable_CellClick);
			this.vendasTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VendasTable_MouseClick);
			// 
			// menuVenda
			// 
			this.menuVenda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuVenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem});
			this.menuVenda.Name = "menuVenda";
			this.menuVenda.Size = new System.Drawing.Size(124, 26);
			// 
			// imprimirToolStripMenuItem
			// 
			this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
			this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.imprimirToolStripMenuItem.Text = "Imprimir";
			this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
			// 
			// groupParcelas
			// 
			this.groupParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupParcelas.Controls.Add(this.numParcelas);
			this.groupParcelas.Location = new System.Drawing.Point(236, 452);
			this.groupParcelas.Name = "groupParcelas";
			this.groupParcelas.Size = new System.Drawing.Size(93, 60);
			this.groupParcelas.TabIndex = 46;
			this.groupParcelas.TabStop = false;
			this.groupParcelas.Text = "Parcelas";
			// 
			// numParcelas
			// 
			this.numParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numParcelas.Location = new System.Drawing.Point(7, 23);
			this.numParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numParcelas.Name = "numParcelas";
			this.numParcelas.Size = new System.Drawing.Size(80, 23);
			this.numParcelas.TabIndex = 0;
			this.numParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Cod
			// 
			this.Cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle16.Format = "N0";
			dataGridViewCellStyle16.NullValue = null;
			this.Cod.DefaultCellStyle = dataGridViewCellStyle16;
			this.Cod.FillWeight = 50F;
			this.Cod.HeaderText = "Código";
			this.Cod.Name = "Cod";
			this.Cod.ReadOnly = true;
			// 
			// Desconto
			// 
			this.Desconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle17.Format = "C2";
			dataGridViewCellStyle17.NullValue = "0,00";
			this.Desconto.DefaultCellStyle = dataGridViewCellStyle17;
			this.Desconto.HeaderText = "Desconto";
			this.Desconto.Name = "Desconto";
			this.Desconto.ReadOnly = true;
			// 
			// Vendido
			// 
			this.Vendido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle18.Format = "G";
			dataGridViewCellStyle18.NullValue = null;
			this.Vendido.DefaultCellStyle = dataGridViewCellStyle18;
			this.Vendido.FillWeight = 150F;
			this.Vendido.HeaderText = "Vendido em";
			this.Vendido.Name = "Vendido";
			this.Vendido.ReadOnly = true;
			// 
			// Orcamento
			// 
			this.Orcamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle19.Format = "d";
			dataGridViewCellStyle19.NullValue = null;
			this.Orcamento.DefaultCellStyle = dataGridViewCellStyle19;
			this.Orcamento.FillWeight = 75F;
			this.Orcamento.HeaderText = "Orçamento";
			this.Orcamento.Name = "Orcamento";
			this.Orcamento.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle20.Format = "C2";
			dataGridViewCellStyle20.NullValue = "0,00";
			this.Total.DefaultCellStyle = dataGridViewCellStyle20;
			this.Total.FillWeight = 75F;
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// Parcelas
			// 
			this.Parcelas.HeaderText = "Parcelas";
			this.Parcelas.Name = "Parcelas";
			this.Parcelas.ReadOnly = true;
			// 
			// Cliente
			// 
			this.Cliente.HeaderText = "Cliente";
			this.Cliente.Name = "Cliente";
			this.Cliente.ReadOnly = true;
			this.Cliente.Visible = false;
			// 
			// FrmVendas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1121, 654);
			this.Controls.Add(this.vendasTable);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbTitle);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmVendas";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Vendas";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FrmVendas_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmVendas_Paint);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vendasTable)).EndInit();
			this.menuVenda.ResumeLayout(false);
			this.groupParcelas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numParcelas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbCod;
		private System.Windows.Forms.TextBox txtCod;
		private System.Windows.Forms.Label lbOrcamento;
		private System.Windows.Forms.Label lbVendido;
		private System.Windows.Forms.Label lbDesconto;
		private System.Windows.Forms.DateTimePicker dtpOrcamento;
		private System.Windows.Forms.DateTimePicker dtpVendido;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DateTimePicker dtpHora;
		private System.Windows.Forms.DataGridView vendasTable;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.NumericUpDown numDesconto;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
		public System.Windows.Forms.DataGridView produtosTable;
		private System.Windows.Forms.ContextMenuStrip menuVenda;
		private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
		private System.Windows.Forms.RadioButton parcelado;
		private System.Windows.Forms.RadioButton vista;
		private System.Windows.Forms.Button btnBuscarCliente;
		private System.Windows.Forms.Label lbCliente;
		private System.Windows.Forms.Button btnNovoCliente;
		public System.Windows.Forms.TextBox txtClient;
		public System.Windows.Forms.TextBox txtClientId;
		private System.Windows.Forms.GroupBox groupParcelas;
		private System.Windows.Forms.NumericUpDown numParcelas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vendido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Orcamento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn Parcelas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
	}
}