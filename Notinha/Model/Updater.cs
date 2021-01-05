using MySql.Data.MySqlClient;
using Notinha.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace Notinha.Model {
	public static class Updater {
		public static string Version { get; set; }
		public static string File { get; private set; }
		private static int MasterVersion { get; set; }
		private static int MinimalVersion { get; set; }

		public static bool IsUpdated()
		{
			if (GetLastVersion() == null) return false;
			string[] versions = Application.ProductVersion.Split('.');
			if (MasterVersion > Convert.ToInt32(versions[0])) return false;
			if (MinimalVersion > Convert.ToInt32(versions[1])) return false;
			return true;
		}

		public static string[] GetLastVersion()
		{
			MySqlConnection conn = Connection.GetInstance().GetConnection();
			MySqlCommand cmd = conn.CreateCommand();
			try {
				cmd.CommandText = "SELECT * FROM tb_versoes WHERE NOT experimental ORDER BY versao DESC LIMIT 1";
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read()) {
					Version = reader.GetString(0);
					File = reader.GetString(1);
					MasterVersion = Convert.ToInt32(Version.Split('.')[0]);
					MinimalVersion = Convert.ToInt32(Version.Split('.')[1]);
				}
			} catch (Exception erro) {
				Messages.ShowError("Erro ao verificar a última versão.\nVerifique sua conexão com a internet!\n" + erro.Message);
				return null;
			} finally {
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
			return new string[] { Version, File };
		}
	}
}
