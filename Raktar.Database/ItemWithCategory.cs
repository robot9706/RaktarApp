using Raktar.Database;

namespace Raktar.Database
{
	public class ItemWithCategory : Item
	{
		[DatabaseColumn(5, "CategoryName")]
		public string CategoryName;
	}
}
