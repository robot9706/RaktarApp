namespace Raktar.Database
{
	public class Warehouse
	{
		[DatabaseColumn(0, "ID", true, true)]
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
	}
}
