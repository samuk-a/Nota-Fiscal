using Notinha.Controller;
using Notinha.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmClientesModal : Form {
		private Color buttonColor = Color.Tomato;
		private Color hoverButtonColor = Color.OrangeRed;
		private bool mouseDown;
		private bool isExceeded = false;
		private Point lastLocation;
		private FrmVendas frmVendas;
		public FrmClientesModal(FrmVendas vendas)
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

		private void BtnSave_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente(txtCpf.Text, txtNome.Text, txtRazao.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtFone.Text);
			if (cliente.Save() > 0) {
				Messages.ShowSuccess("Salvo com sucesso!");
				frmVendas.txtClientId.Text = cliente.Id.ToString();
				frmVendas.txtClient.Text = txtNome.Text;
				Close();
			}
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

		private void txtCpf_TextChanged(object sender, EventArgs e)
		{
			if (!isExceeded)
			{
				txtCpf.Mask = "000,000,000-00";
			}
			isExceeded = txtCpf.Text.Length > 12;
		}

		private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (isExceeded)
			{
				int offset = txtCpf.Text.Length > 12 ? 4 : 3;
				txtCpf.Mask = "00,000,000/0000-00";
				txtCpf.Select(txtCpf.Text.Length + offset, 0);
			}
			isExceeded = txtCpf.Text.Length > 10;
		}
	}
}
