using Raktar.Database;
using System;

namespace Raktar.App.Data
{
	class PartnerSellStatistics
	{
		[DatabaseColumn(0, "Count")]
		public int SellCount;

		[DatabaseColumn(1, "PartnerName")]
		public string PartnerName;

		[DatabaseColumn(2, "Date")]
		public DateTime Date;
	}
}
