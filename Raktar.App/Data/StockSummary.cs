using Raktar.Database;

namespace Raktar.App.Data
{
	public class StockSummary
	{
		[DatabaseColumn(0, "ItemID")]
		public int ItemID;

		[DatabaseColumn(1, "ItemName")]
		public string ItemName;

		[DatabaseColumn(2, "Count")]
		public int Count;
	}
}
