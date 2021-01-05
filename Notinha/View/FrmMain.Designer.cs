namespace Notinha.View {
	partial class FrmMain {
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.pnTop = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSobre = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.btnItem = new System.Windows.Forms.Button();
			this.btnVenda = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnContent = new System.Windows.Forms.Panel();
			this.pnTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnTop
			// 
			this.pnTop.BackColor = System.Drawing.Color.Tomato;
			this.pnTop.Controls.Add(this.label1);
			this.pnTop.Controls.Add(this.btnSobre);
			this.pnTop.Controls.Add(this.btnClientes);
			this.pnTop.Controls.Add(this.btnItem);
			this.pnTop.Controls.Add(this.btnVenda);
			this.pnTop.Controls.Add(this.btnMinimize);
			this.pnTop.Controls.Add(this.btnClose);
			this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnTop.ForeColor = System.Drawing.Color.White;
			this.pnTop.Location = new System.Drawing.Point(0, 0);
			this.pnTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pnTop.Name = "pnTop";
			this.pnTop.Size = new System.Drawing.Size(1195, 59);
			this.pnTop.TabIndex = 0;
			this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseDown);
			this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseMove);
			this.pnTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseUp);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1140, 34);
			this.label1.TabIndex = 10;
			this.label1.Text = "AUTO ELÉTRICA CANASSA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseMove);
			this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnTop_MouseUp);
			// 
			// btnSobre
			// 
			this.btnSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSobre.FlatAppearance.BorderSize = 0;
			this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSobre.Location = new System.Drawing.Point(261, 30);
			this.btnSobre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSobre.Name = "btnSobre";
			this.btnSobre.Size = new System.Drawing.Size(87, 30);
			this.btnSobre.TabIndex = 4;
			this.btnSobre.Text = "Sobre";
			this.btnSobre.UseVisualStyleBackColor = true;
			this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
			this.btnSobre.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnSobre.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// btnClientes
			// 
			this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClientes.FlatAppearance.BorderSize = 0;
			this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClientes.Location = new System.Drawing.Point(174, 30);
			this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(87, 30);
			this.btnClientes.TabIndex = 4;
			this.btnClientes.Text = "Clientes";
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
			this.btnClientes.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnClientes.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// btnItem
			// 
			this.btnItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnItem.FlatAppearance.BorderSize = 0;
			this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnItem.Location = new System.Drawing.Point(87, 30);
			this.btnItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnItem.Name = "btnItem";
			this.btnItem.Size = new System.Drawing.Size(87, 30);
			this.btnItem.TabIndex = 3;
			this.btnItem.Text = "Itens";
			this.btnItem.UseVisualStyleBackColor = true;
			this.btnItem.Click += new System.EventHandler(this.BtnItem_Click);
			this.btnItem.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnItem.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// btnVenda
			// 
			this.btnVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnVenda.FlatAppearance.BorderSize = 0;
			this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVenda.Location = new System.Drawing.Point(0, 30);
			this.btnVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnVenda.Name = "btnVenda";
			this.btnVenda.Size = new System.Drawing.Size(87, 30);
			this.btnVenda.TabIndex = 2;
			this.btnVenda.Text = "Venda";
			this.btnVenda.UseVisualStyleBackColor = true;
			this.btnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
			this.btnVenda.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnVenda.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.Location = new System.Drawing.Point(1139, 0);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(28, 30);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.Text = "_";
			this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
			this.btnMinimize.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnMinimize.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(1167, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(28, 30);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "X";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.BtnTop_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.BtnTop_MouseLeave);
			// 
			// pnContent
			// 
			this.pnContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnContent.Location = new System.Drawing.Point(0, 66);
			this.pnContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pnContent.Name = "pnContent";
			this.pnContent.Size = new System.Drawing.Size(1195, 582);
			this.pnContent.TabIndex = 1;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1195, 648);
			this.Controls.Add(this.pnContent);
			this.Controls.Add(this.pnTop);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.pnTop.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnTop;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnVenda;
		private System.Windows.Forms.Button btnItem;
		private System.Windows.Forms.Panel pnContent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnSobre;
	}
}

