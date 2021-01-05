using CryptSharp;
using MySql.Data.MySqlClient;
using Notinha.Controller;
using System;
using System.Data;

namespace Notinha.Model {
	public class User {
		public static User instance;

		public uint Id { get; private set; }
		public string Nome { get; private set; }
		public string Email { get; private set; }
		public bool Admin { get; private set; }

		public User() { }
		public User(uint id, string nome, string email, bool admin)
		{
			Id = id;
			Nome = nome;
			Email = email;
			Admin = admin;
		}

		public static bool Login(string user, string senha)
		{
			if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(senha)) return false;
			instance = new User().LoginUser(user, senha);
			return instance != null;
		}

		public User GetUser(uint id = 0)
		{
			User user = null;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_funcionarios WHERE id = @cod";
				cmd.Parameters.AddWithValue("@cod", id == 0 ? Id : id);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					user = new User(
						reader.GetUInt32(0),
						reader.GetString(1),
						reader.GetString(2),
						reader.GetBoolean(4)
					);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return user;
		}

		private User LoginUser(string email, string pass)
		{
			User user = null;
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_funcionarios WHERE email = @email";
				cmd.Parameters.AddWithValue("@email", email);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					bool match = Crypter.CheckPassword(pass, reader.GetString(3));
					if (match)
						user = new User(
							reader.GetUInt32(0),
							reader.GetString(1),
							reader.GetString(2),
							reader.GetBoolean(4)
						);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro: " + erro.Message);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return user;
		}
	}
}
