using Notinha.Controller;
using Notinha.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmSobre : Form {
		private Color buttonColor = Color.Tomato;
		private Color hoverButtonColor = Color.OrangeRed;
		private bool mouseDown;
		private Point lastLocation;
		public FrmSobre()
		{
			InitializeComponent();
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

		private void FrmSobre_Load(object sender, EventArgs e)
		{
			string sobre = string.Format("{0}\n" +
				"Versão {1}\n\n" +
				"Desenvolvido por {2}\n" +
				"{3}",
				AppInfo.Title,
				AppInfo.Version,
				AppInfo.Company,
				AppInfo.Copyright);
			lbSobre.Text = sobre;
		}
	}
}
