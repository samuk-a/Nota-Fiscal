using Notinha.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmItensVenda : Form {
		private uint qtd = 1;
		private Color buttonColor = Color.Tomato;
		private Color hoverButtonColor = Color.OrangeRed;
		private bool mouseDown;
		private Point lastLocation;
		private FrmVendas frmVendas;
		public FrmItensVenda(FrmVendas vendas)
		{
			InitializeComponent();
			frmVendas = vendas;
		}

		private void ChangeButtonColor(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			Color aux = btn.BackColor;
			btn.BackColor = btn.ForeColor;
			btn.ForeColor = aux;
		}

		private void PnTop_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void PnTop_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown) {
				Location = new Point(Location.X - lastLocation.X + e.X, Location.Y - lastLocation.Y + e.Y);
				Update();
			}
		}

		private void PnTop_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void BtnTop_MouseEnter(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			b.BackColor = hoverButtonColor;
		}

		private void BtnTop_MouseLeave(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			b.BackColor = buttonColor;
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FrmItensVenda_Load(object sender, EventArgs e)
		{
			Item item = new Item();
			Populate(item.Load());
		}

		private void Populate(List<Item> itens)
		{
			itensTable.Rows.Clear();
			foreach (Item item in itens)
				itensTable.Rows.Add(item.Cod, item.Descricao, item.Unidade, item.Valor);
		}

		private void TxtPesquisa_TextChanged(object sender, EventArgs e)
		{
			TextBox pesq = (TextBox)sender;
			Populate(new Item().Load(pesq.Text.ToString()));
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int indice = itensTable.CurrentRow.Index;
			DataGridViewCellCollection cells = itensTable.Rows[indice].Cells;
			bool exists = false;
			foreach (DataGridViewRow row in frmVendas.produtosTable.Rows) {
				if (row.Cells[0].Value.ToString() == cells[0].Value.ToString()) {
					exists = true;
					row.Cells[3].Value = (uint)row.Cells[3].Value + qtd;
					break;
				}
			}
			if (!exists) {
				Item item = new Item().GetItem(cells[0].Value.ToString());
				frmVendas.produtosTable.Rows.Add(item.Cod, item.Descricao, item.Valor, qtd);
			}
			
			Close();
		}
	}
}
