using Raktar.Database;

namespace Raktar.App.Data
{
	class PartnerBuyStatistics
	{
		[DatabaseColumn(0, "PartnerName")]
		public string PartnerName;

		[DatabaseColumn(1, "ItemName")]
		public string ItemName;

		[DatabaseColumn(2, "Count")]
		public int Count;
	}
}
