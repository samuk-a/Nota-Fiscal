namespace Notinha.View {
	partial class FrmItens {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.camposBox = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtOldCod = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.numValor = new System.Windows.Forms.NumericUpDown();
			this.lbValor = new System.Windows.Forms.Label();
			this.txtUn = new System.Windows.Forms.TextBox();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.lbUn = new System.Windows.Forms.Label();
			this.lbDesc = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtCod = new System.Windows.Forms.TextBox();
			this.lbCod = new System.Windows.Forms.Label();
			this.itensTable = new System.Windows.Forms.DataGridView();
			this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Un = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.camposBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itensTable)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(933, 52);
			this.label1.TabIndex = 1;
			this.label1.Text = "ITENS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// camposBox
			// 
			this.camposBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.camposBox.Controls.Add(this.btnDelete);
			this.camposBox.Controls.Add(this.txtOldCod);
			this.camposBox.Controls.Add(this.btnSave);
			this.camposBox.Controls.Add(this.numValor);
			this.camposBox.Controls.Add(this.lbValor);
			this.camposBox.Controls.Add(this.txtUn);
			this.camposBox.Controls.Add(this.txtDesc);
			this.camposBox.Controls.Add(this.lbUn);
			this.camposBox.Controls.Add(this.lbDesc);
			this.camposBox.Controls.Add(this.btnAdd);
			this.camposBox.Controls.Add(this.txtCod);
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
			// txtOldCod
			// 
			this.txtOldCod.Enabled = false;
			this.txtOldCod.Location = new System.Drawing.Point(8, 449);
			this.txtOldCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtOldCod.Name = "txtOldCod";
			this.txtOldCod.Size = new System.Drawing.Size(116, 23);
			this.txtOldCod.TabIndex = 33;
			this.txtOldCod.Visible = false;
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
			// numValor
			// 
			this.numValor.DecimalPlaces = 2;
			this.numValor.Location = new System.Drawing.Point(229, 100);
			this.numValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numValor.Name = "numValor";
			this.numValor.Size = new System.Drawing.Size(114, 23);
			this.numValor.TabIndex = 31;
			// 
			// lbValor
			// 
			this.lbValor.AutoSize = true;
			this.lbValor.Location = new System.Drawing.Point(182, 103);
			this.lbValor.Name = "lbValor";
			this.lbValor.Size = new System.Drawing.Size(46, 17);
			this.lbValor.TabIndex = 30;
			this.lbValor.Text = "Valor:";
			// 
			// txtUn
			// 
			this.txtUn.Location = new System.Drawing.Point(82, 100);
			this.txtUn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtUn.Name = "txtUn";
			this.txtUn.Size = new System.Drawing.Size(93, 23);
			this.txtUn.TabIndex = 29;
			// 
			// txtDesc
			// 
			this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDesc.Location = new System.Drawing.Point(82, 68);
			this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(261, 23);
			this.txtDesc.TabIndex = 28;
			// 
			// lbUn
			// 
			this.lbUn.AutoSize = true;
			this.lbUn.Location = new System.Drawing.Point(7, 103);
			this.lbUn.Name = "lbUn";
			this.lbUn.Size = new System.Drawing.Size(66, 17);
			this.lbUn.TabIndex = 27;
			this.lbUn.Text = "Unidade:";
			// 
			// lbDesc
			// 
			this.lbDesc.AutoSize = true;
			this.lbDesc.Location = new System.Drawing.Point(7, 71);
			this.lbDesc.Name = "lbDesc";
			this.lbDesc.Size = new System.Drawing.Size(76, 17);
			this.lbDesc.TabIndex = 26;
			this.lbDesc.Text = "Descrição:";
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
			// txtCod
			// 
			this.txtCod.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCod.Location = new System.Drawing.Point(82, 36);
			this.txtCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCod.Name = "txtCod";
			this.txtCod.Size = new System.Drawing.Size(172, 23);
			this.txtCod.TabIndex = 24;
			// 
			// lbCod
			// 
			this.lbCod.AutoSize = true;
			this.lbCod.Location = new System.Drawing.Point(7, 39);
			this.lbCod.Name = "lbCod";
			this.lbCod.Size = new System.Drawing.Size(62, 17);
			this.lbCod.TabIndex = 23;
			this.lbCod.Text = "Código:";
			// 
			// itensTable
			// 
			this.itensTable.AllowUserToAddRows = false;
			this.itensTable.AllowUserToDeleteRows = false;
			this.itensTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itensTable.BackgroundColor = System.Drawing.Color.Coral;
			this.itensTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itensTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Desc,
            this.Un,
            this.Valor});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.itensTable.DefaultCellStyle = dataGridViewCellStyle3;
			this.itensTable.Location = new System.Drawing.Point(372, 64);
			this.itensTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.itensTable.Name = "itensTable";
			this.itensTable.ReadOnly = true;
			this.itensTable.RowHeadersVisible = false;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itensTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.itensTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.itensTable.Size = new System.Drawing.Size(547, 475);
			this.itensTable.TabIndex = 3;
			this.itensTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItensTabela_CellClick);
			// 
			// Cod
			// 
			this.Cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Cod.HeaderText = "Código";
			this.Cod.Name = "Cod";
			this.Cod.ReadOnly = true;
			// 
			// Desc
			// 
			this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.NullValue = "-";
			this.Desc.DefaultCellStyle = dataGridViewCellStyle1;
			this.Desc.HeaderText = "Descrição";
			this.Desc.Name = "Desc";
			this.Desc.ReadOnly = true;
			// 
			// Un
			// 
			this.Un.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Un.FillWeight = 50F;
			this.Un.HeaderText = "Unidade";
			this.Un.Name = "Un";
			this.Un.ReadOnly = true;
			// 
			// Valor
			// 
			this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = "0,00";
			this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
			this.Valor.FillWeight = 70F;
			this.Valor.HeaderText = "Valor";
			this.Valor.Name = "Valor";
			this.Valor.ReadOnly = true;
			// 
			// FrmItens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(933, 554);
			this.Controls.Add(this.itensTable);
			this.Controls.Add(this.camposBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmItens";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Itens";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FrmItens_Load);
			this.camposBox.ResumeLayout(false);
			this.camposBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itensTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox camposBox;
		private System.Windows.Forms.DataGridView itensTable;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtCod;
		private System.Windows.Forms.Label lbCod;
		private System.Windows.Forms.TextBox txtUn;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Label lbUn;
		private System.Windows.Forms.Label lbDesc;
		private System.Windows.Forms.NumericUpDown numValor;
		private System.Windows.Forms.Label lbValor;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtOldCod;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
		private System.Windows.Forms.DataGridViewTextBoxColumn Un;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
	}
}