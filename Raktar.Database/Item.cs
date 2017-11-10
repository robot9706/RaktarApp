namespace Raktar.Database
{
    public class Item
    {
		[DatabaseColumn(0)]
		public int ID;

		[DatabaseColumn(1)]
		public string Name;

		[DatabaseColumn(2)]
		public double Price;

		[DatabaseColumn(3)]
		public string Description;

		[DatabaseColumn(4)]
		public int CategoryID;
	}
}
