using MySql.Data.MySqlClient;
using Notinha.Controller;
using System;
using System.Collections.Generic;
using System.Data;

namespace Notinha.Model {
	public class Cliente {
		public uint Id { get; set; }
		public string Doc { get; set; }
		public string Nome { get; set; }
		public string RazSoc { get; set; }
		public string Endereco { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Cep { get; set; }
		public string Fone { get; set; }
		public bool IsNew { get; set; }

		public Cliente() { }
		public Cliente(uint id)
		{
			Id = id;
		}
		public Cliente(string doc)
		{
			Doc = doc;
		}
		public Cliente(string doc, string nome, string razSoc, string end, string bairro, string cidade, string cep, string fone, bool isNew = true)
		{
			Doc = doc;
			Nome = nome;
			RazSoc = razSoc;
			Endereco = end;
			Bairro = bairro;
			Cidade = cidade;
			Cep = cep;
			Fone = fone;
			IsNew = isNew;
		}

		private static Cliente LoadClient(MySqlDataReader reader)
		{
			Cliente cliente = new Cliente() {
				Id = reader.GetUInt32(0),
				Nome = reader.GetString(2)
			};
			if (!reader.IsDBNull(1)) cliente.Doc = reader.GetString(1);
			if (!reader.IsDBNull(3)) cliente.RazSoc = reader.GetString(3);
			if (!reader.IsDBNull(4)) cliente.Endereco = reader.GetString(4);
			if (!reader.IsDBNull(5)) cliente.Bairro = reader.GetString(5);
			if (!reader.IsDBNull(6)) cliente.Cidade = reader.GetString(6);
			if (!reader.IsDBNull(7)) cliente.Cep = reader.GetString(7);
			if (!reader.IsDBNull(8)) cliente.Fone = reader.GetString(8);
			cliente.IsNew = false;
			return cliente;
		}

		public List<Cliente> Load()
		{
			List<Cliente> clientes = new List<Cliente>();
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_clientes";
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					clientes.Add(LoadClient(reader));
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			}/* finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}*/
			return clientes;
		}

		public List<Cliente> Load(string pesq)
		{
			List<Cliente> clientes = new List<Cliente>();
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_clientes WHERE nome LIKE @pesq OR raz_soc LIKE @pesq OR endereco LIKE @pesq OR bairro LIKE @pesq";
				cmd.Parameters.AddWithValue("@pesq", "%" + pesq + "%");
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					Cliente cliente = LoadClient(reader);
					clientes.Add(cliente);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			}/* finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}*/
			return clientes;
		}

		public Cliente GetCliente(uint id = 0)
		{
			Cliente cliente = null;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_clientes WHERE id = @id";
				cmd.Parameters.AddWithValue("@id", id == 0 ? Id : id);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					cliente = LoadClient(reader);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro ao pegar cliente: " + erro.Message);
			}/* finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}*/
			return cliente;
		}

		public int Save(uint id = 0)
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				if (IsNew)
					cmd.CommandText = "INSERT INTO tb_clientes VALUES (NULL, @doc, @nome, @razao, @end, @bairro, @cidade, @cep, @fone)";
				else
					cmd.CommandText = "UPDATE tb_clientes SET doc=@doc, nome=@nome, raz_soc=@razao, endereco=@end, bairro=@bairro, cidade=@cidade, cep=@cep, fone=@fone WHERE id = @id";
				Console.WriteLine(IsNew.ToString());
				Console.WriteLine(cmd.CommandText);
				cmd.Parameters.AddWithValue("@doc", string.IsNullOrWhiteSpace(Doc) ? null : Doc.Replace(".", "").Replace("/", "").Replace("-", ""));
				cmd.Parameters.AddWithValue("@nome", Nome);
				cmd.Parameters.AddWithValue("@razao", string.IsNullOrWhiteSpace(RazSoc) ? null : RazSoc);
				cmd.Parameters.AddWithValue("@end", string.IsNullOrWhiteSpace(Endereco) ? null : Endereco);
				cmd.Parameters.AddWithValue("@bairro", string.IsNullOrWhiteSpace(Bairro) ? null : Bairro);
				cmd.Parameters.AddWithValue("@cidade", string.IsNullOrWhiteSpace(Cidade) ? null : Cidade);
				cmd.Parameters.AddWithValue("@cep", string.IsNullOrWhiteSpace(Cep) ? null : Cep);
				cmd.Parameters.AddWithValue("@fone", string.IsNullOrWhiteSpace(Fone) ? null : Fone);
				if (!IsNew) cmd.Parameters.AddWithValue("@id", id == 0 ? Id : id);
				rows = cmd.ExecuteNonQuery();
				if (IsNew)
				{
					cmd = conn.CreateCommand();
					cmd.CommandText = "SELECT LAST_INSERT_ID();";
					MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
						Id = reader.GetUInt32(0);
					else
						throw new Exception("Error getting client");
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
				rows = -1;
			}/* finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}*/
			return rows;
		}

		public int Delete()
		{
			int rows = 0;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "DELETE FROM tb_clientes WHERE id = @id";
				cmd.Parameters.AddWithValue("@id", Id);
				Console.WriteLine(cmd.CommandText);
				Console.WriteLine(Id);
				rows = cmd.ExecuteNonQuery();
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
				rows = -1;
			}/* finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}*/
			return rows;
		}
	}
}
