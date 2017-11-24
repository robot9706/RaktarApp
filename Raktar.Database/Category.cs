namespace Raktar.Database
{
	public class Category
	{
		[DatabaseColumn(0, "ID", true, true)]
		public int ID;

		[DatabaseColumn(1, "Name")]
		public string Name;

		public override string ToString()
		{
			return Name;
		}
	}
}
