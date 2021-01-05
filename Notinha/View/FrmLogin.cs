using Notinha.Controller;
using Notinha.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmLogin : Form {
		private Color buttonColor = Color.Tomato;
		private Color hoverButtonColor = Color.OrangeRed;
		private bool mouseDown;
		private bool authenticated = false;
		private Point lastLocation;
		public FrmLogin()
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

		private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!authenticated) Application.Exit();
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			authenticated = User.Login(txtEmail.Text, txtSenha.Text);
			if (authenticated) {
				Messages.ShowSuccess("Logado com Sucesso!");
				Close();
			} else {
				Messages.ShowError("Email ou senha incorretos!");
				txtEmail.Focus();
				txtSenha.ResetText();
			}
		}

		private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) {
				BtnLogin_Click(null, null);
			}
		}
	}
}
