using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmMain : Form {
		private Form currentForm = null;
		private Color buttonColor = Color.Tomato;
		private Color hoverButtonColor = Color.OrangeRed;
		private bool mouseDown;
		private Point lastLocation;

		public FrmMain()
		{
			new FrmLogin().ShowDialog();
			InitializeComponent();
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
			Application.Exit();
		}

		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void BtnVenda_Click(object sender, EventArgs e)
		{
			OpenMiniForm(new FrmVendas());
		}

		private void OpenMiniForm(Form form)
		{
			if (currentForm != null) {
				if (currentForm.GetType() == form.GetType()) {
					form.Close();
					return;
				}
				currentForm.Close();
			}
			currentForm = form;
			currentForm.TopLevel = false;
			currentForm.Width = pnContent.Width;
			currentForm.Height = pnContent.Height;
			currentForm.Visible = true;
			pnContent.Controls.Add(currentForm);
		}

		private void BtnItem_Click(object sender, EventArgs e)
		{
			OpenMiniForm(new FrmItens());
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

		private void BtnClientes_Click(object sender, EventArgs e)
		{
			OpenMiniForm(new FrmClientes());
		}

		private void BtnSobre_Click(object sender, EventArgs e)
		{
			new FrmSobre().ShowDialog();
		}
	}
}
