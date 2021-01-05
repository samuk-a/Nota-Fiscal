using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Notinha.View;

namespace Notinha {
	static class Program {
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			FrmInit frmSplash = new FrmInit();
			frmSplash.Show();
			Application.Run();
			Application.DoEvents();
		}
	}
}
