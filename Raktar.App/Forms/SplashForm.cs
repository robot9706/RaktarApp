using MetroFramework;
using Newtonsoft.Json;
using Raktar.App.Data;
using Raktar.Database;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raktar.App.Forms
{
	public partial class SplashForm : AppForm
	{
		public SplashForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		private void SplashForm_Load(object sender, System.EventArgs e)
		{
			Task.Factory.StartNew(() =>
			{
				try
				{
					bool ok = Task_Load();

					Close(ok ? DialogResult.OK : DialogResult.Abort);
				}
				catch (Exception ex)
				{
					Program.SaveCrashLog(ex);

					MetroMessageBox.Show(this, "Hiba történt az alkalmazás indítása közben. Az alkalmazás kilép.\nHiba: " + ex.Message, "Hiba");

					Close(DialogResult.Abort);
				}
			});
		}

		private void Close(DialogResult result)
		{
			if (InvokeRequired)
			{
				Invoke(new Action(() => Close(result)));

				return;
			}

			DialogResult = result;
			Close();
		}

		private void SetStatus(string status)
		{
			if (InvokeRequired)
			{
				Invoke(new Action(() => SetStatus(status)));

				return;
			}

			lblStatus.Text = status;
		}

		private bool Task_Load()
		{
			SetStatus("Beállítások betöltése...");

			AppConfig config;

			string configPath = Path.Combine(Application.StartupPath, AppConfig.FileName);
			if(File.Exists(configPath))
			{
				try
				{
					config = JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(configPath));
				}
				catch
				{
					MetroMessageBox.Show(this, "Hibás az alkalmazás beállítás fájl! Az alapértelmezett beállítások lesznek használva.", "Hiba");

					config = AppConfig.Default;
				}
			}
			else
			{
				config = AppConfig.Default;

				File.WriteAllText(configPath, JsonConvert.SerializeObject(config, Formatting.Indented));
			}

			Global.Config = config;

			SetStatus("Csatlakozás az adatbázishoz...");

			try
			{
				DatabaseConnection db = new DatabaseConnection(config.DatabaseServer, config.DatabaseName, config.DatabaseUser, config.DatabasePassword, config.ODBCDriver);

				Global.Database = db;
			}
			catch (Exception ex)
			{
				MetroMessageBox.Show(this, "Nem lehet csatlakozni az adatbázis szerverhez.\nSzerver: " + config.DatabaseServer + "/" + config.DatabaseName + "\n" +
					"Hiba: " + ex.Message + "\nAz alkalmazás kilép.", "Hiba");

				return false;
			}

			SetStatus("Alkalmazás indítása...");

			return true;
		}
	}
}
