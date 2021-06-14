using Notinha.Controller;
using Notinha.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmClientes : Form {
		private bool isNew = false;
		private bool isExceeded = false;

		public FrmClientes()
		{
			InitializeComponent();
		}

		private void FrmItens_Load(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			Populate(cliente.Load());
			DisableButtons();
		}

		private void ItensTabela_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int indice = clientesTable.CurrentRow.Index;
			DataGridViewCellCollection cells = clientesTable.Rows[indice].Cells;
			Cliente cliente = new Cliente().GetCliente(Convert.ToUInt32(cells[0].Value));
			txtOldId.Text = cliente.Id.ToString();
			GetDetails(cliente);
			EnableButtons(true);
		}

		private void GetDetails(Cliente cliente)
		{
			txtCpf.Text = cliente.Doc;
			txtNome.Text = cliente.Nome;
			txtRazao.Text = cliente.RazSoc;
			txtEndereco.Text = cliente.Endereco;
			txtBairro.Text = cliente.Bairro;
			txtCidade.Text = cliente.Cidade;
			txtCep.Text = cliente.Cep;
			txtFone.Text = cliente.Fone;
		}

		private void ChangeButtonColor(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			Color aux = btn.BackColor;
			btn.BackColor = btn.ForeColor;
			btn.ForeColor = aux;
		}

		private void DisableButtons(bool all = false)
		{
			btnSave.Visible = btnSave.Enabled = false;
			btnDelete.Visible = btnDelete.Enabled = false;
			txtCpf.Enabled = false;
			txtNome.Enabled = false;
			txtRazao.Enabled = false;
			txtBairro.Enabled = false;
			txtCep.Enabled = false;
			txtCidade.Enabled = false;
			txtEndereco.Enabled = false;
			txtFone.Enabled = false;
			if (!all) btnAdd.Enabled = true;
			else btnAdd.Enabled = false;
		}

		private void EnableButtons(bool all = false)
		{
			btnSave.Visible = btnSave.Enabled = true;
			if (User.instance.Admin)
				btnDelete.Visible = btnDelete.Enabled = all;
			txtCpf.Enabled = true;
			txtNome.Enabled = true;
			txtRazao.Enabled = true;
			txtBairro.Enabled = true;
			txtCep.Enabled = true;
			txtCidade.Enabled = true;
			txtEndereco.Enabled = true;
			txtFone.Enabled = true;
			if (all) btnAdd.Enabled = true;
			else btnAdd.Enabled = false;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			EnableButtons();
			ResetForm();
		}

		private void ResetForm()
		{
			txtCpf.ResetText();
			txtNome.ResetText();
			txtRazao.ResetText();
			txtCpf.Focus();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			uint oldId = Convert.ToUInt32(txtOldId.Text == "" ? "0" : txtOldId.Text);
			isNew = oldId == 0;
			Cliente cliente = new Cliente(txtCpf.Text, txtNome.Text, txtRazao.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtFone.Text, isNew);
			if (cliente.Save(oldId) > 0) {
				Messages.ShowSuccess("Salvo com sucesso!");
				Populate(cliente.Load());
			}
			DisableButtons(false);
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente(Convert.ToUInt32(txtOldId.Text));
			if (Messages.ShowQuestion("Deseja deletar mesmo?") == DialogResult.Yes)
				if (cliente.Delete() > 0) Messages.ShowSuccess("Deletado com sucesso!");
				else Messages.ShowError("Erro ao deletar!\nTente novamente.");
		}

		private void Populate(List<Cliente> clientes)
		{
			clientesTable.Rows.Clear();
			foreach (Cliente cli in clientes)
				clientesTable.Rows.Add(cli.Id, cli.Doc, cli.Nome, cli.RazSoc, cli.Endereco, cli.Bairro, cli.Cidade, cli.Cep, cli.Fone);
		}

		private void txtCpf_TextChanged(object sender, EventArgs e)
		{
			if (!isExceeded)
			{
				txtCpf.Mask = "000,000,000-00";
			}
			Console.WriteLine(txtCpf.Text.Length);
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
