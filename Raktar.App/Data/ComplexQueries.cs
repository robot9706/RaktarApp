using Raktar.Database;
using System.Collections.Generic;

namespace Raktar.App.Data
{
	class ComplexQueries
	{
		private static string _itemsWithCategoriesQuery = "SELECT items.ItemID, items.Name, items.Price, items.Description, items.CategoryID, category.Name AS 'CategoryName' FROM `items`, `category` WHERE category.CategoryID = items.CategoryID;";

		public static List<ItemWithCategory> GetItemsWithCategories()
		{
			return Global.Database.Select<ItemWithCategory>(_itemsWithCategoriesQuery);
		}
	}
}
