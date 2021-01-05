using Notinha.Controller;
using Notinha.Model;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Notinha.View {
	public partial class FrmInit : Form {
		private string tempUpdate = @"C:\Temp\NotinhaUpdate.exe";
		public FrmInit()
		{
			InitializeComponent();
		}

		private void WebClientDownloadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			BeginInvoke((MethodInvoker)delegate {
				progress.Value = 100;
				lbDetails.Text = string.Format("{0}%", 100);
				InstallDialog();
			});
		}

		private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			BeginInvoke((MethodInvoker)delegate {
				double bytesIn = double.Parse(e.BytesReceived.ToString());
				double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
				double percentage = bytesIn / totalBytes * 100;
				progress.Value = int.Parse(Math.Truncate(percentage).ToString());
				lbDetails.Text = string.Format("{0}%", progress.Value);
			});
		}

		private void Run()
		{
			if (File.Exists(tempUpdate))
				File.Delete(tempUpdate);
			new FrmMain().Show();
			Close();
		}

		private void InstallDialog()
		{
			if (MessageBox.Show("Uma atualização foi baixada, deseja instalar agora?", "Instalar Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Process.Start(tempUpdate);
			Application.Exit();
		}

		private void FrmInit_Load(object sender, EventArgs e)
		{
			WebClient web = new WebClient();
			lbDetails.Text = "Verificando Atualizações";
			try {
				if (!Updater.IsUpdated()) {
					Thread thread = new Thread(() => {
						web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClientDownloadProgressChanged);
						web.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClientDownloadCompleted);
						web.DownloadFileAsync(new Uri("https://aecanassa.com.br/Installs/"+Updater.File), tempUpdate);
					});
					thread.Start();
				} else {
					Run();
				}
			} catch (Exception ex) {
				Messages.ShowError(ex.Message);
				Application.Exit();
			}
		}
	}
}
