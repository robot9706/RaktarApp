using System;

namespace Raktar.Database
{
	public class DatabaseColumnAttribute : Attribute
	{
		public int ColumnIndex
		{
			get;
			private set;
		}

		public string ColumnName
		{
			get;
			private set;
		}

		public bool IsKey
		{
			get;
			private set;
		}

		public bool IsAutoIncrement
		{
			get;
			private set;
		}

		public DatabaseColumnAttribute(int index, string name, bool isKey = false, bool autoIncrement = false)
		{
			ColumnIndex = index;
			ColumnName = name;
			IsKey = isKey;
			IsAutoIncrement = autoIncrement;
		}
	}
}
