using MetroFramework.Controls;
using Raktar.Database;
using System;

namespace Raktar.App.Forms
{
	public partial class PartnerEditForm : AppForm
	{
		private Partner _partner;

		public Partner EditPartner
		{
			get
			{
				Partner p = new Partner();

				if (_partner != null)
					p.ID = _partner.ID;

				p.Name = tbName.Text;
				p.Telephone = tbTelephone.Text;
				p.Email = tbEmail.Text;
				p.City = tbCity.Text;
				p.Street = tbStreet.Text;
				p.PostCode = tbPostCode.Text;

				p.StreetNumber = Convert.ToInt32(tbStreetNum.Text);

				return p;
			}
		}

		public PartnerEditForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		public PartnerEditForm(Partner edit)
			: this()
		{
			_partner = edit;

			tbName.Text = edit.Name;
			tbTelephone.Text = edit.Telephone;
			tbEmail.Text = edit.Email;
			tbCity.Text = edit.City;
			tbStreet.Text = edit.Street;
			tbPostCode.Text = edit.PostCode;
			tbStreetNum.Text = edit.StreetNumber.ToString();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void tbStreetNum_TextChanged(object sender, EventArgs e)
		{
			MetroTextBox box = (MetroTextBox)sender;

			int test;
			lblStreetNumError.Visible = (!Int32.TryParse(box.Text, out test) && test >= 0);

			ValidateInput();
		}

		private void tbName_TextChanged(object sender, EventArgs e)
		{
			ValidateInput();
		}

		private void ValidateInput()
		{
			btnOk.Enabled = (!string.IsNullOrEmpty(tbName.Text) &&
				!string.IsNullOrEmpty(tbTelephone.Text) &&
				!string.IsNullOrEmpty(tbEmail.Text) &&
				!string.IsNullOrEmpty(tbCity.Text) &&
				!string.IsNullOrEmpty(tbStreet.Text) &&
				!string.IsNullOrEmpty(tbPostCode.Text) &&
				!string.IsNullOrEmpty(tbStreetNum.Text) &&
				!lblStreetNumError.Visible);
		}
	}
}
