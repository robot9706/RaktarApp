using MetroFramework.Controls;
using MetroFramework.Forms;
using Raktar.Database;
using System;
using System.Windows.Forms;

namespace Raktar.App.Forms
{
	public partial class WarehouseEditForm : MetroForm
	{
		private Warehouse _edit;

		public Warehouse EditedWarehouse
		{
			get
			{
				Warehouse house = new Warehouse();

				if (_edit != null)
					house.ID = _edit.ID;

				house.Name = tbName.Text;
				house.City = tbCity.Text;
				house.Street = tbStreet.Text;
				house.PostCode = tbPostCode.Text;
				house.StreetNumber = Convert.ToInt32(tbStreetNum.Text);

				return house;
			}
		}

		public WarehouseEditForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		public WarehouseEditForm(Warehouse edit)
			: this()
		{
			_edit = edit;

			tbName.Text = _edit.Name;
			tbCity.Text = _edit.City;
			tbStreet.Text = _edit.Street;
			tbPostCode.Text = _edit.PostCode;
			tbStreetNum.Text = _edit.StreetNumber.ToString();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		private void metroButton1_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void tbName_TextChanged(object sender, EventArgs e)
		{
			ValidateInput();
		}

		private void tbStreetNum_TextChanged(object sender, EventArgs e)
		{
			MetroTextBox box = (MetroTextBox)sender;

			int test;
			lblStreetNumError.Visible = (!Int32.TryParse(box.Text, out test) && test >= 0);

			ValidateInput();
		}

		private void ValidateInput()
		{
			btnOK.Enabled = (!string.IsNullOrEmpty(tbName.Text) &&
				!string.IsNullOrEmpty(tbCity.Text) &&
				!string.IsNullOrEmpty(tbStreet.Text) &&
				!string.IsNullOrEmpty(tbPostCode.Text) &&
				!string.IsNullOrEmpty(tbStreetNum.Text) &&
				!lblStreetNumError.Visible);
		}
	}
}
