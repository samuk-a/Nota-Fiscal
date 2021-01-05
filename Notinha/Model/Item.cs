using MySql.Data.MySqlClient;
using Notinha.Controller;
using System;
using System.Collections.Generic;
using System.Data;

namespace Notinha.Model {
	public class Item {
		public string Cod { get; set; }
		public string Descricao { get; set; }
		public string Unidade { get; set; }
		public decimal Valor { get; set; }
		public bool IsNew { get; set; }

		public Item() { }
		public Item(string cod)
		{
			Cod = cod;
		}
		public Item(string cod, string desc, string un, decimal val, bool isNew = true)
		{
			Cod = cod;
			Descricao = desc;
			Unidade = un;
			Valor = val;
			IsNew = isNew;
		}

		public List<Item> Load()
		{
			List<Item> itens = new List<Item>();
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_itens";
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					Item item = new Item(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), false);
					itens.Add(item);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return itens;
		}

		public List<Item> Load(string pesq)
		{
			List<Item> itens = new List<Item>();
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_itens WHERE descricao LIKE @pesq OR cod LIKE @pesq";
				cmd.Parameters.AddWithValue("@pesq", "%" + pesq + "%");
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					Item item = new Item(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), false);
					itens.Add(item);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
				Console.WriteLine(erro);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return itens;
		}

		public Item GetItem(string cod)
		{
			Item item = null;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_itens WHERE cod = @cod";
				cmd.Parameters.AddWithValue("@cod", cod ?? Cod);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					item = new Item(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), false);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return item;
		}

		public int Save(string oldCod = null)
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				if (IsNew)
					cmd.CommandText = "INSERT INTO tb_itens VALUES (@cod, @desc, @un, @valor)";
				else
					cmd.CommandText = "UPDATE tb_itens SET cod=@cod, descricao=@desc, unidade=@un, valor=@valor WHERE cod = @oldCod";
				cmd.Parameters.AddWithValue("@cod", Cod);
				cmd.Parameters.AddWithValue("@desc", Descricao);
				cmd.Parameters.AddWithValue("@un", Unidade);
				cmd.Parameters.AddWithValue("@valor", Valor);
				if (!IsNew) cmd.Parameters.AddWithValue("@oldCod", oldCod);
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

		public int Delete()
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "DELETE FROM tb_itens WHERE cod = @oldCod";
				cmd.Parameters.AddWithValue("@oldCod", Cod);
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
	}
}
