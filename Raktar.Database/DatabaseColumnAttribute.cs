using System;

namespace Raktar.Database
{
	class DatabaseColumnAttribute : Attribute
	{
		public int ColumnIndex
		{
			get;
			private set;
		}

		public DatabaseColumnAttribute(int index)
		{
			ColumnIndex = index;
		}
	}
}
