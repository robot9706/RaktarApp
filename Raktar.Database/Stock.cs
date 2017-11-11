namespace Raktar.Database
{
	public class Stock
	{
		[DatabaseColumn(0, "ItemID")]
		public int ItemID;

		[DatabaseColumn(1, "Warehouse")]
		public int Warehouse;

		[DatabaseColumn(2, "Count")]
		public int Count;
	}
}
