using MySql.Data.MySqlClient;
using Notinha.Controller;
using System;
using System.Collections.Generic;
using System.Data;

namespace Notinha.Model {
	public enum Type {
		Vista = 1,
		Parcelado = 2
	}
	public class Venda {
		public uint Cod { get; set; }
		public decimal Desconto { get; set; }
		public Cliente Cliente { get; set; }
		public User User { get; set; }
		public Type Tipo { get; set; }
		public DateTime DataVenda { get; set; }
		public DateTime DataOrcamento { get; set; }
		public Dictionary<Item, uint> Itens { get; set; }
		public decimal Total { get; set; }
		public bool IsNew { get; set; }
		public uint Parcelas { get; set; }

		public Venda() { Itens = new Dictionary<Item, uint>(); }
		public Venda(uint cod)
		{
			Cod = cod;
			Itens = new Dictionary<Item, uint>();
		}
		public Venda(uint cod, decimal desconto, Cliente cli, Type tipo, DateTime venda, DateTime orcamento, uint parcelas = 1, bool isNew = true)
		{
			Cod = cod;
			Desconto = desconto;
			Cliente = cli;
			Tipo = tipo;
			DataVenda = venda;
			DataOrcamento = orcamento;
			IsNew = isNew;
			if (tipo == Type.Vista)
				Parcelas = 1;
			else
				Parcelas = parcelas;
			Itens = new Dictionary<Item, uint>();
		}

		private Venda Populate(MySqlDataReader reader)
		{
			Venda venda = new Venda(
				reader.GetUInt32(0),
				reader.GetDecimal(1),
				new Cliente(reader.GetUInt32(2)),
				(Type)reader.GetInt32(4),
				reader.GetDateTime(7),
				reader.GetDateTime(8),
				reader.GetUInt32(6)
			) {
				User = new User().GetUser(reader.GetUInt32(3)),
				Total = reader.GetDecimal(5)
			};
			return venda;
		}

		public List<Venda> Load()
		{
			List<Venda> vendas = new List<Venda>();
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				if (conn.State != ConnectionState.Open)
					conn.Open();
				cmd.CommandText = "SELECT V.* FROM tb_vendas V INNER JOIN tb_itens_venda IV ON IV.cod_venda = V.cod INNER JOIN tb_itens I ON I.cod = IV.cod_item GROUP BY V.cod";
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					vendas.Add(Populate(reader));
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return vendas;
		}

		public Venda GetVenda(uint cod)
		{
			Venda venda = null;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT V.* FROM tb_vendas V INNER JOIN tb_itens_venda IV ON IV.cod_venda = V.cod INNER JOIN tb_itens I ON I.cod = IV.cod_item WHERE V.cod = @cod GROUP BY V.cod";
				cmd.Parameters.AddWithValue("@cod", cod);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					venda = Populate(reader);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return venda;
		}

		public void LoadItens()
		{
			Itens = new Dictionary<Item, uint>();
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT I.*, IV.qtd FROM tb_itens I INNER JOIN tb_itens_venda IV ON I.cod = IV.cod_item WHERE IV.cod_venda = @venda";
				cmd.Parameters.AddWithValue("@venda", Cod);
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					Item item = new Item(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), false);
					Itens.Add(item, reader.GetUInt32(4));
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
		}

		public int Save()
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try
			{
				if (IsNew)
					cmd.CommandText = "INSERT INTO tb_vendas VALUES (@cod, @desc, @cliente, @vendido_por, @tipo, @total, @parcelas, @vendido, @orcamento)";
				else
					cmd.CommandText = "UPDATE tb_vendas SET desconto=@desc, cliente=@cliente, vendido_por=@vendido_por, tipo=@tipo, total=@total, parcelas=@parcelas, data_venda=@vendido, data_orcamento=@orcamento WHERE cod = @cod";
				cmd.Parameters.AddWithValue("@cod", Cod);
				cmd.Parameters.AddWithValue("@desc", Desconto);
				cmd.Parameters.AddWithValue("@cliente", Cliente.Id);
				cmd.Parameters.AddWithValue("@vendido_por", User.Id);
				cmd.Parameters.AddWithValue("@tipo", Tipo);
				cmd.Parameters.AddWithValue("@total", Total);
				cmd.Parameters.AddWithValue("@parcelas", Parcelas);
				cmd.Parameters.AddWithValue("@vendido", DataVenda.ToString("yyyy-MM-dd H:mm:ss"));
				cmd.Parameters.AddWithValue("@orcamento", DataOrcamento.ToString("yyyy-MM-dd"));
				rows = cmd.ExecuteNonQuery();
				if (!IsNew)
					DeleteItens();
				rows = InsertItens();
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
				rows = -1;
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return rows;
		}

		public int Delete()
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "DELETE FROM tb_vendas WHERE cod = @cod";
				cmd.Parameters.AddWithValue("@cod", Cod);
				rows = cmd.ExecuteNonQuery();
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
				rows = -1;
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return rows;
		}

		private int DeleteItens()
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				Messages.ShowSuccess(Cod.ToString());
				cmd.CommandText = "DELETE FROM tb_itens_venda WHERE cod_venda = @cod";
				cmd.Parameters.AddWithValue("@cod", Cod);
				rows = cmd.ExecuteNonQuery();
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
				rows = -1;
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return rows;
		}

		public int InsertItens()
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "INSERT INTO tb_itens_venda VALUES (@venda, @item, @qtd)";
				cmd.Parameters.AddWithValue("@venda", Cod);
				cmd.Parameters.Add("@item", MySqlDbType.VarChar);
				cmd.Parameters.Add("@qtd", MySqlDbType.UInt32);
				foreach (KeyValuePair<Item, uint> item in Itens) {
					cmd.Parameters["@item"].Value = item.Key.Cod;
					cmd.Parameters["@qtd"].Value = item.Value;
					rows = cmd.ExecuteNonQuery();
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
				rows = -1;
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return rows;
		}
	}
}
