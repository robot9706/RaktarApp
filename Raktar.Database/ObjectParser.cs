using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Reflection;

namespace Raktar.Database
{
	class ObjectParser
	{
		private Dictionary<int, FieldInfo> _fields;

		public ObjectParser(Type type)
		{
			_fields = new Dictionary<int, FieldInfo>();

			FieldInfo[] properties = type.GetFields();

			DatabaseColumnAttribute attribute;
			foreach (FieldInfo p in properties)
			{
				attribute = p.GetCustomAttribute<DatabaseColumnAttribute>();

				if (attribute != null)
				{
					_fields.Add(attribute.ColumnIndex, p);
				}
			}
		}

		public T ParseItem<T>(OdbcDataReader reader)
		{
			T newItem = (T)Activator.CreateInstance(typeof(T));

			foreach (KeyValuePair<int, FieldInfo> prop in _fields)
			{
				object value = reader.GetFieldValue<object>(prop.Key);

				prop.Value.SetValue(newItem, value);
			}

			return newItem;
		}
	}
}
