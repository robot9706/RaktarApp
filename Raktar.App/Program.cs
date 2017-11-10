using Raktar.App.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Raktar.App
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			bool applicationReady = false;
			using (SplashForm splash = new SplashForm())
			{
				if (splash.ShowDialog() == DialogResult.OK)
				{
					applicationReady = true;
				}
			}

			if (applicationReady)
			{
				Application.Run(new MainForm());
			}
		}

		public static void SaveCrashLog(Exception exception)
		{
			using (StreamWriter writer = new StreamWriter(Path.Combine(Application.StartupPath, "CrashLog_" + DateTime.Now.ToFileTime().ToString() + ".txt")))
			{
				writer.WriteLine("Crash @ " + DateTime.Now.ToString());
				writer.WriteLine("Exception: " + exception.Message);
				writer.WriteLine("Stack trace: " + exception.StackTrace);
			}
		}
	}
}
