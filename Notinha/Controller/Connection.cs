using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Notinha.Controller {
	class Connection {

		private string connString = "Server={0};Database={1};Uid={2};Pwd={3}";
		private static Connection _instance;
		private static MySqlConnection _conn;
		private static readonly object _lock = new object();

		private Connection() { }

		public static Connection GetInstance()
		{
			if (_instance == null) {
				lock(_lock) {
					if (_instance == null)
						_instance = new Connection();
				}
			}
			return _instance;
		}

		public MySqlConnection GetConnection()
		{
#if (DEBUG)
			connString = string.Format(connString, "localhost", "nota_fiscal", "root", "");
#else
			connString = string.Format(connString, Properties.Resources.SERVER_NAME,
													Properties.Resources.SERVER_DATABASE,
													Properties.Resources.SERVER_USER,
													Properties.Resources.SERVER_PASS);
#endif
			_conn = new MySqlConnection(connString);
			try {
				if (_conn.State != ConnectionState.Open)
					_conn.Open();
			} catch (Exception ex) {
				Messages.ShowError(ex.Message);
				return null;
			}
			return _conn;
		}

		public int GetLastCode(string table)
		{
			MySqlConnection conn = GetConnection();
			MySqlCommand command = conn.CreateCommand();
			int code = 0;
			try {
				command.CommandText = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = @database AND TABLE_NAME = @tableName";
#if (DEBUG)
				command.Parameters.AddWithValue("@database", "nota_fiscal");
#else
				command.Parameters.AddWithValue("@database", Properties.Resources.SERVER_DATABASE);
#endif
				command.Parameters.AddWithValue("@tableName", table);
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
					code = reader.GetInt32(0);
			} catch (Exception erro) {
				MessageBox.Show("Erro:" + erro);
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return code;
		}
	}
}
