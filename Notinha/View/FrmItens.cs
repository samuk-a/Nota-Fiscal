using Notinha.Controller;
using Notinha.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmItens : Form {
		private bool isNew = false;
		public FrmItens()
		{
			InitializeComponent();
		}

		private void FrmItens_Load(object sender, EventArgs e)
		{
			Item item = new Item();
			Populate(item.Load());
			DisableButtons();
		}

		private void ItensTabela_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int indice = itensTable.CurrentRow.Index;
			DataGridViewCellCollection cells = itensTable.Rows[indice].Cells;
			Item item = new Item(cells[0].Value.ToString(), cells[1].Value.ToString(), cells[2].Value.ToString(), Convert.ToDecimal(cells[3].Value));
			txtOldCod.Text = item.Cod;
			GetDetails(item);
			EnableButtons(true);
		}

		private void GetDetails(Item item)
		{
			txtCod.Text = item.Cod;
			txtDesc.Text = item.Descricao;
			txtUn.Text = item.Unidade;
			numValor.Value = item.Valor;
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
			txtCod.Enabled = false;
			txtDesc.Enabled = false;
			txtUn.Enabled = false;
			numValor.Enabled = false;
			if (!all) btnAdd.Enabled = true;
			else btnAdd.Enabled = false;
		}

		private void EnableButtons(bool all = false)
		{
			btnSave.Visible = btnSave.Enabled = true;
			if (User.instance.Admin)
				btnDelete.Visible = btnDelete.Enabled = all;
			txtCod.Enabled = true;
			txtDesc.Enabled = true;
			txtUn.Enabled = true;
			numValor.Enabled = true;
			if (all) btnAdd.Enabled = true;
			else btnAdd.Enabled = false;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			EnableButtons();
			ResetForm();
			isNew = true;
		}

		private void ResetForm()
		{
			txtCod.ResetText();
			txtDesc.ResetText();
			txtUn.ResetText();
			numValor.ResetText();
			txtCod.Focus();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			Item item = new Item(txtCod.Text, txtDesc.Text, txtUn.Text, numValor.Value, isNew);
			if (item.Save() > 0) {
				Messages.ShowSuccess("Salvo com sucesso!");
				Populate(item.Load());
			}
			DisableButtons(false);
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			Item item = new Item(txtOldCod.Text);
			if (Messages.ShowQuestion("Deseja deletar mesmo?") == DialogResult.Yes)
				if (item.Delete() > 0) Messages.ShowSuccess("Deletado com sucesso!");
				else Messages.ShowError("Erro ao deletar!\nTente novamente.");
		}

		private void Populate(List<Item> itens)
		{
			itensTable.Rows.Clear();
			foreach (Item item in itens)
				itensTable.Rows.Add(item.Cod, item.Descricao, item.Unidade, item.Valor);
		}
	}
}
