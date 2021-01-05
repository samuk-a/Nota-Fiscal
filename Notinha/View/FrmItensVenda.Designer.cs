namespace Notinha.View {
	partial class FrmItensVenda {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.itensTable = new System.Windows.Forms.DataGridView();
			this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Un = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnTop = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.itensTable)).BeginInit();
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
			this.lbTitle.Size = new System.Drawing.Size(633, 56);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Item";
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
            this.dataGridViewTextBoxColumn1});
			this.itensTable.Location = new System.Drawing.Point(16, 133);
			this.itensTable.Margin = new System.Windows.Forms.Padding(4);
			this.itensTable.Name = "itensTable";
			this.itensTable.ReadOnly = true;
			this.itensTable.RowHeadersVisible = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.itensTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.itensTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.itensTable.Size = new System.Drawing.Size(601, 294);
			this.itensTable.TabIndex = 4;
			// 
			// Cod
			// 
			this.Cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Cod.FillWeight = 70F;
			this.Cod.HeaderText = "Código";
			this.Cod.Name = "Cod";
			this.Cod.ReadOnly = true;
			// 
			// Desc
			// 
			this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Desc.FillWeight = 150F;
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
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Format = "C2";
			dataGridViewCellStyle1.NullValue = "0,00";
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn1.FillWeight = 70F;
			this.dataGridViewTextBoxColumn1.HeaderText = "Valor";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
			// FrmItensVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(633, 481);
			this.Controls.Add(this.pnTop);
			this.Controls.Add(this.itensTable);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.btnAdd);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmItensVenda";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Itens";
			this.Load += new System.EventHandler(this.FrmItensVenda_Load);
			((System.ComponentModel.ISupportInitialize)(this.itensTable)).EndInit();
			this.pnTop.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView itensTable;
		private System.Windows.Forms.Panel pnTop;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
		private System.Windows.Forms.DataGridViewTextBoxColumn Un;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
	}
}