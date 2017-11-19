using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Raktar.App.Forms
{
	public class AppForm : MetroForm
	{
		public void Info(string info, string title)
		{
			MetroMessageBox.Show(this, info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void Error(string info, string title)
		{
			MetroMessageBox.Show(this, info, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
