namespace Raktar.Database
{
	public class Partner
	{
		[DatabaseColumn(0, "ID")]
		public int ID;

		[DatabaseColumn(1, "Name")]
		public string Name;

		[DatabaseColumn(2, "PostCode")]
		public string PostCode;

		[DatabaseColumn(3, "City")]
		public string City;

		[DatabaseColumn(4, "Street")]
		public string Street;

		[DatabaseColumn(5, "StreetNumber")]
		public int StreetNumber;

		[DatabaseColumn(6, "Telephone")]
		public string Telephone;

		[DatabaseColumn(7, "Email")]
		public string Email;
	}
}
