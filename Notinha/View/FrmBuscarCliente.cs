using Notinha.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmBuscarCliente : Form {
		private Color buttonColor = Color.Tomato;
		private Color hoverButtonColor = Color.OrangeRed;
		private bool mouseDown;
		private Point lastLocation;
		private FrmVendas frmVendas;
		public FrmBuscarCliente(FrmVendas vendas)
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

		private void FrmBuscarCliente_Load(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			Populate(cliente.Load());
		}

		private void Populate(List<Cliente> clientes)
		{
			clientesTable.Rows.Clear();
			foreach (Cliente cli in clientes)
				clientesTable.Rows.Add(cli.Id, cli.Doc, cli.Nome, cli.RazSoc, cli.Endereco, cli.Bairro, cli.Cidade, cli.Cep, cli.Fone);
		}

		private void TxtPesquisa_TextChanged(object sender, EventArgs e)
		{
			TextBox pesq = (TextBox)sender;
			Populate(new Cliente().Load(pesq.Text.ToString()));
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int indice = clientesTable.CurrentRow.Index;
			DataGridViewCellCollection cells = clientesTable.Rows[indice].Cells;
			Cliente cliente = new Cliente().GetCliente(Convert.ToUInt32(cells[0].Value));
			frmVendas.txtClient.Text = cliente.Nome;
			frmVendas.txtClientId.Text = cliente.Id.ToString();
			Close();
		}
	}
}
