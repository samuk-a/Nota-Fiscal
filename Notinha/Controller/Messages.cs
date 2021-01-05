using System.Windows.Forms;

namespace Notinha.Controller {
	class Messages {
		public static void ShowError(string message)
		{
			MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void ShowSuccess(string message)
		{
			MessageBox.Show(message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static DialogResult ShowQuestion(string message)
		{
			return MessageBox.Show(message, "Confirma?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
	}
}
