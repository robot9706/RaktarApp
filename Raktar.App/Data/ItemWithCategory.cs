using Raktar.Database;

namespace Raktar.App.Data
{
	public class ItemWithCategory : Item
	{
		[DatabaseColumn(5, "CategoryName")]
		public string CategoryName;
	}
}
