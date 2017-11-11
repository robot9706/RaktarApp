using MetroFramework.Forms;

namespace Raktar.App.Forms
{
	public partial class TextEnterForm : AppForm
	{
		public string EditText
		{
			get { return tbText.Text; }
			set { tbText.Text = value; }
		}

		private bool _allowEmpty;
		public bool AllowEmptInput
		{
			get { return _allowEmpty; }
			set
			{
				_allowEmpty = value;

				CheckInput();
			}
		}

		public TextEnterForm(string title, string message)
			: this(title, message, string.Empty)
		{
		}

		public TextEnterForm(string title, string message, string editValue, bool allowEmpty = true)
		{
			InitializeComponent();

			AppDesign.Apply(this);

			Text = title;
			lblMessage.Text = message;
			tbText.Text = editValue;

			AllowEmptInput = allowEmpty;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		private void tbText_TextChanged(object sender, System.EventArgs e)
		{
			CheckInput();
		}

		private void CheckInput()
		{
			btnOK.Enabled = (_allowEmpty || !string.IsNullOrEmpty(tbText.Text));
		}
	}
}
