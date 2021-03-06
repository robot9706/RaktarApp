﻿using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Raktar.App.Forms
{
	public class AppForm : MetroForm
	{
		public void Info(string info, string title)
		{
			MessageBox.Show(this, info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void Warning(string info, string title)
		{
			MessageBox.Show(this, info, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public void Error(string info, string title)
		{
			MessageBox.Show(this, info, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
