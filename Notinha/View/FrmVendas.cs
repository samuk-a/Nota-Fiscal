using Notinha.Controller;
using Notinha.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmVendas : Form {
		private bool isNew = false;
		private uint currentVendaToPress;
		private List<Control> requiredFields = new List<Control>();
		private List<Control> currentRequiredFields = new List<Control>();
		private bool errorValid = false;
		public FrmVendas()
		{
			InitializeComponent();
			GetRequires(this);
		}

		private void GetRequires(Control parent)
		{
			if (parent.Controls.Count > 0) {
				foreach (Control c in parent.Controls) {
					GetRequires(c);
					if (c.Tag != null && c.Tag.ToString() == "R") {
						requiredFields.Add(c);
					}
				}
			}
		}

		private bool ValidateForm()
		{
			currentRequiredFields = new List<Control>();
			errorValid = false;
			foreach (Control c in requiredFields) {
				if (c.Text == "") {
					errorValid = true;
					currentRequiredFields.Add(c);
					Refresh();
				}
			}
			return !errorValid;
		}

		private void VendasTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			isNew = false;
			ResetForm();
			int indice = vendasTable.CurrentRow.Index;
			DataGridViewCellCollection cells = vendasTable.Rows[indice].Cells;
			Venda venda = new Venda().GetVenda(Convert.ToUInt32(cells[0].Value));
			venda.IsNew = false;
			venda.LoadItens();
			GetDetails(venda);
			EnableButtons(true);
		}

		private void GetDetails(Venda venda)
		{
			txtCod.Text = venda.Cod.ToString();
			numFrete.Value = venda.Frete;
			numDesconto.Text = venda.Desconto.ToString();
			dtpHora.Value = dtpVendido.Value = venda.DataVenda;
			dtpOrcamento.Value = venda.DataOrcamento;
			dtpFaturamento.Value = venda.DataFaturamento;
			dtpEntregue.Value = venda.DataEntrega;
			venda.Cliente = venda.Cliente.GetCliente();
			txtClient.Text = venda.Cliente.Nome;
			txtClientId.Text = venda.Cliente.Id.ToString();
			Populate(venda.Itens);
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
			btnAddItem.Enabled = false;
			btnSave.Visible = btnSave.Enabled = false;
			btnNovoCliente.Visible = btnNovoCliente.Enabled = false;
			btnBuscarCliente.Visible = btnBuscarCliente.Enabled = false;
			btnDelete.Visible = btnDelete.Enabled = false;
			numFrete.Enabled = false;
			numDesconto.Enabled = false;
			txtClient.Enabled = false;
			vista.Enabled = false;
			parcelado.Enabled = false;
			dtpEntregue.Enabled = false;
			dtpOrcamento.Enabled = false;
			dtpHora.Enabled = false;
			dtpFaturamento.Enabled = false;
			dtpVendido.Enabled = false;
			if (!all) btnAdd.Enabled = true;
			else btnAdd.Enabled = false;
		}

		private void EnableButtons(bool all = false)
		{
			btnAddItem.Enabled = true;
			btnSave.Visible = btnSave.Enabled = true;
			btnNovoCliente.Visible = btnNovoCliente.Enabled = true;
			btnBuscarCliente.Visible = btnBuscarCliente.Enabled = true;
			if (User.instance.Admin)
				btnDelete.Visible = btnDelete.Enabled = all;
			numFrete.Enabled = true;
			numDesconto.Enabled = true;
			txtClient.Enabled = true;
			vista.Enabled = true;
			parcelado.Enabled = true;
			dtpEntregue.Enabled = true;
			dtpOrcamento.Enabled = true;
			dtpHora.Enabled = true;
			dtpFaturamento.Enabled = true;
			dtpVendido.Enabled = true;
			if (all) btnAdd.Enabled = true;
			else btnAdd.Enabled = false;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			EnableButtons();
			ResetForm();
			txtCod.Text = Connection.GetInstance().GetLastCode("tb_vendas").ToString();
			isNew = true;
		}

		private void FrmVendas_Load(object sender, EventArgs e)
		{
			Venda venda = new Venda();
			Populate(venda.Load());
			DisableButtons();
		}

		private void ResetForm()
		{
			txtCod.ResetText();
			txtClient.ResetText();
			txtClientId.ResetText();
			numFrete.Value = 0;
			numDesconto.ResetText();
			dtpEntregue.ResetText();
			dtpOrcamento.ResetText();
			dtpHora.ResetText();
			dtpFaturamento.ResetText();
			dtpVendido.ResetText();
			produtosTable.Rows.Clear();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) {
				Messages.ShowError("Preencha os campos obrigatórios");
				return;
			}
			Model.Type type = vista.Checked ? Model.Type.Vista : Model.Type.Parcelado;
			string dt = dtpVendido.Value.ToShortDateString() + " " + dtpHora.Value.ToLongTimeString();
			DateTime date = Convert.ToDateTime(dt);
			Venda venda = new Venda(
				Convert.ToUInt32(txtCod.Text),
				numFrete.Value,
				numDesconto.Value,
				new Cliente().GetCliente(Convert.ToUInt32(txtClientId.Text)),
				type,
				date,
				dtpOrcamento.Value,
				dtpFaturamento.Value,
				dtpEntregue.Value,
				isNew) {
				User = User.instance,
				Total = numFrete.Value - numDesconto.Value
			};
			foreach (DataGridViewRow row in produtosTable.Rows) {
				Item item = new Item().GetItem(row.Cells[0].Value.ToString());
				uint qtd = Convert.ToUInt32(row.Cells[3].Value);
				venda.Itens.Add(item, qtd);
				venda.Total += item.Valor * qtd;
			}
			if (venda.Save() > 0) {
				Messages.ShowSuccess("Salvo com sucesso!");
				Populate(venda.Load());
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			Venda venda = new Venda(Convert.ToUInt32(txtCod.Text));
			if (Messages.ShowQuestion("Deseja deletar mesmo?") == DialogResult.Yes)
				if (venda.Delete() > 0) Messages.ShowSuccess("Deletado com sucesso!");
				else Messages.ShowError("Erro ao deletar!\nTente novamente.");
		}

		private void Populate(List<Venda> vendas)
		{
			vendasTable.Rows.Clear();
			foreach (Venda venda in vendas)
				vendasTable.Rows.Add(venda.Cod, venda.Frete, venda.Desconto, venda.DataVenda, venda.DataOrcamento.ToShortDateString(), venda.DataFaturamento.ToShortDateString(), venda.DataEntrega.ToShortDateString(), venda.Total);
		}

		private void Populate(Dictionary<Item, uint> itens)
		{
			produtosTable.Rows.Clear();
			foreach (KeyValuePair<Item, uint> item in itens)
				produtosTable.Rows.Add(item.Key.Cod, item.Key.Descricao, item.Key.Valor, item.Value);
		}

		private void BtnAddItem_Click(object sender, EventArgs e)
		{
			FrmItensVenda itens = new FrmItensVenda(this);
			itens.ShowDialog();
		}

		private void VendasTable_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right) {
				int currentMouseOverRow = vendasTable.HitTest(e.X, e.Y).RowIndex;
				if (currentMouseOverRow >= 0) {
					currentVendaToPress = (uint)vendasTable.Rows[currentMouseOverRow].Cells[0].Value;
					menuVenda.Show(vendasTable, new Point(e.X, e.Y));
				}
			}
		}

		private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Venda venda = new Venda().GetVenda(currentVendaToPress);
			venda.LoadItens();
			venda.Cliente = venda.Cliente.GetCliente();
			PrintManager pm = new PrintManager();
			pm.GenerateDocument(venda);
			pm.Print();
		}

		private void BtnNovoCliente_Click(object sender, EventArgs e)
		{
			FrmClientesModal cliente = new FrmClientesModal(this);
			cliente.ShowDialog();
		}

		private void BtnBuscarCliente_Click(object sender, EventArgs e)
		{
			FrmBuscarCliente cliente = new FrmBuscarCliente(this);
			cliente.ShowDialog();
		}

		private void FrmVendas_Paint(object sender, PaintEventArgs e)
		{
			if (!errorValid) return;
			foreach (Control c in currentRequiredFields) {
				TextBox txt = (TextBox)c;
				txt.BorderStyle = BorderStyle.None;
				Pen p = new Pen(Color.Red);
				Graphics g = e.Graphics;
				int variance = 3;
				g.DrawRectangle(p, new Rectangle(txt.Location.X - variance, txt.Location.Y - variance, txt.Width + variance, txt.Height + variance));
			}
		}
	}
}
