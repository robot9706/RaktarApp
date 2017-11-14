namespace Raktar.Database
{
    public class Item
    {
		[DatabaseColumn(0, "ItemID", true, true)]
		public int ID;

		[DatabaseColumn(1, "Name")]
		public string Name;

		[DatabaseColumn(2, "Price")]
		public double Price;

		[DatabaseColumn(3, "Description")]
		public string Description;

		[DatabaseColumn(4, "CategoryID")]
		public int CategoryID;
	}
}
