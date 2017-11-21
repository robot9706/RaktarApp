using Raktar.Database;

namespace Raktar.App.Data
{
	class PartnerShipmentSummary : PartnerShipment
	{
		[DatabaseColumn(6, "PartnerName")]
		public string PartnerName;

		[DatabaseColumn(7, "WarehouseName")]
		public string WarehouseName;

		[DatabaseColumn(8, "ItemName")]
		public string ItemName;
	}
}
