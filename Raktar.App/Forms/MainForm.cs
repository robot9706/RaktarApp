using MetroFramework.Forms;

namespace Raktar.App.Forms
{
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}
	}
}
