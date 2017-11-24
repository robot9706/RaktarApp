namespace Raktar.Database
{
	public class Stock
	{
		[DatabaseColumn(0, "ItemID", true, false)]
		public int ItemID;

		[DatabaseColumn(1, "WarehouseID", true, false)]
		public int Warehouse;

		[DatabaseColumn(2, "Count")]
		public int Count;
	}
}
