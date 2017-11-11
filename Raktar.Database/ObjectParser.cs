using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Reflection;
using System.Linq;

namespace Raktar.Database
{
	class ObjectParser
	{
		public struct ColumnInfo
		{
			public int Index;
			public string Name;

			public FieldInfo Field;
			
			public bool IsKey;
			public bool IsAutoIncrement;
		}

		private Dictionary<int, ColumnInfo> _fields;

		public ObjectParser(Type type)
		{
			_fields = new Dictionary<int, ColumnInfo>();

			FieldInfo[] properties = type.GetFields();

			DatabaseColumnAttribute attribute;
			foreach (FieldInfo p in properties)
			{
				attribute = p.GetCustomAttribute<DatabaseColumnAttribute>();

				if (attribute != null)
				{
					_fields.Add(attribute.ColumnIndex, new ColumnInfo()
					{
						Field = p,
						Index = attribute.ColumnIndex,
						Name = attribute.ColumnName,
						IsAutoIncrement = attribute.IsAutoIncrement,
						IsKey = attribute.IsKey
					});
				}
			}
		}

		public static string FormatPrimitiveValue(object value, Type asType)
		{
			if (asType.IsEquivalentTo(typeof(string)))
				return "'" + (string)value + "'";

			return value.ToString();
		}

		public static string FormatPrimitiveValue(object value)
		{
			return FormatPrimitiveValue(value, value.GetType());
		}

		public T ParseItem<T>(OdbcDataReader reader)
		{
			T newItem = (T)Activator.CreateInstance(typeof(T));

			foreach (KeyValuePair<int, ColumnInfo> prop in _fields)
			{
				object value = reader.GetFieldValue<object>(prop.Key);

				prop.Value.Field.SetValue(newItem, value);
			}

			return newItem;
		}

		public string BuildInsertStatement<T>(T value)
		{
			List<string> columns = new List<string>();
			List<string> values = new List<string>();

			foreach (KeyValuePair<int, ColumnInfo> pair in _fields)
			{
				if (pair.Value.IsAutoIncrement)
					continue;

				columns.Add(pair.Value.Name);

				object fieldValue = pair.Value.Field.GetValue(value);

				values.Add(FormatPrimitiveValue(fieldValue));
			}

			return "(" + String.Join(", ", columns) + ") VALUES (" + String.Join(", ", values) + ")";
		}

		public string BuildKeyCondition<T>(T value, string[] conds)
		{
			List<string> conditionList = new List<string>();

			foreach (KeyValuePair<int, ColumnInfo> pair in _fields)
			{
				if (!pair.Value.IsKey && conds == null)
					continue;

				if (conds != null && !conds.Contains(pair.Value.Name))
					continue;

				object fieldValue = pair.Value.Field.GetValue(value);

				conditionList.Add(pair.Value.Name + "=" + FormatPrimitiveValue(fieldValue));
			}

			return String.Join(" AND ", conditionList);
		}

		public string BuildValueConditions<T>(T value)
		{
			List<string> valueList = new List<string>();

			foreach (KeyValuePair<int, ColumnInfo> pair in _fields)
			{
				if (pair.Value.IsKey)
					continue;

				object fieldValue = pair.Value.Field.GetValue(value);

				valueList.Add(pair.Value.Name + "=" + FormatPrimitiveValue(fieldValue));
			}

			return String.Join(", ", valueList);
		}
	}
}
