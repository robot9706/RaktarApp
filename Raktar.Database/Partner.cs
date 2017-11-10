namespace Raktar.Database
{
	public class Partner
	{
		[DatabaseColumn(0)]
		public int ID;

		[DatabaseColumn(1)]
		public string Name;

		[DatabaseColumn(2)]
		public string PostCode;

		[DatabaseColumn(3)]
		public string City;

		[DatabaseColumn(4)]
		public string Street;

		[DatabaseColumn(5)]
		public int StreetNumber;

		[DatabaseColumn(6)]
		public string Telephone;

		[DatabaseColumn(7)]
		public string Email;
	}
}
