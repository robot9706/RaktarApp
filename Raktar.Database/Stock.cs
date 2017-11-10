namespace Raktar.Database
{
	public class Stock
	{
		[DatabaseColumn(0)]
		public int ItemID;

		[DatabaseColumn(1)]
		public int Warehouse;

		[DatabaseColumn(2)]
		public int Count;
	}
}
