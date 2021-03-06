﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Reflection;

namespace Raktar.Database
{
	public class ObjectParser
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

		private int _autoIncrementKey = -1;
		public bool HasAutoIncrementKey
		{
			get { return (_autoIncrementKey != -1); }
		}

		public ObjectParser(Type type)
		{
			_fields = new Dictionary<int, ColumnInfo>();

			FieldInfo[] properties = type.GetFields();

			DatabaseColumnAttribute attribute;
			foreach (FieldInfo p in properties)
			{
				attribute = GetAttribute<DatabaseColumnAttribute>(p);

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

					if (attribute.IsKey && attribute.IsAutoIncrement)
					{
						_autoIncrementKey = attribute.ColumnIndex;
					}
				}
			}
		}

		private static T GetAttribute<T>(FieldInfo field) where T: Attribute
		{
			object[] atrs = field.GetCustomAttributes(true);

			foreach(object atr in atrs)
			{
				if (atr.GetType().IsEquivalentTo(typeof(T)))
					return (T)atr;
			}

			return null;
		}

		public static string FormatPrimitiveValue(object value, Type asType)
		{
			if (asType.IsEquivalentTo(typeof(string)))
				return "'" + (string)value + "'";

			if (asType.IsEquivalentTo(typeof(DateTime)))
				return "'" + (((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")) + "'";

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
				object value = reader.GetValue(prop.Key);

				object typeChangedValue = Convert.ChangeType(value, prop.Value.Field.FieldType);

				prop.Value.Field.SetValue(newItem, typeChangedValue);
			}

			return newItem;
		}

		public string BuildInsertStatement<T>(T value, OdbcCommand command)
		{
			List<string> columns = new List<string>();
			List<string> values = new List<string>();

			foreach (KeyValuePair<int, ColumnInfo> pair in _fields)
			{
				if (pair.Value.IsAutoIncrement)
					continue;

				columns.Add(pair.Value.Name);

				object fieldValue = pair.Value.Field.GetValue(value);

				values.Add("?");

				command.Parameters.Add(new OdbcParameter("@i" + pair.Value.Name, fieldValue));
			}

			return "(" + String.Join(", ", columns) + ") VALUES (" + String.Join(", ", values) + ")";
		}

		public string BuildKeyCondition<T>(T value, OdbcCommand command)
		{
			List<string> conditionList = new List<string>();

			foreach (KeyValuePair<int, ColumnInfo> pair in _fields)
			{
				if (!pair.Value.IsKey)
					continue;

				object fieldValue = pair.Value.Field.GetValue(value);

				command.Parameters.Add(new OdbcParameter("@k" + pair.Value.Name, fieldValue));

				conditionList.Add(pair.Value.Name + "=?");
			}

			return String.Join(" AND ", conditionList);
		}

		public string BuildValueConditions<T>(T value, OdbcCommand command)
		{
			List<string> valueList = new List<string>();

			foreach (KeyValuePair<int, ColumnInfo> pair in _fields)
			{
				if (pair.Value.IsKey)
					continue;

				object fieldValue = pair.Value.Field.GetValue(value);

				command.Parameters.Add(new OdbcParameter("@v" + pair.Value.Name, fieldValue));

				valueList.Add(pair.Value.Name + "=?");
			}

			return String.Join(", ", valueList);
		}

		public void SetAutoIncrementKey<T>(T value, int key)
		{
			if (!HasAutoIncrementKey)
				return;

			_fields[_autoIncrementKey].Field.SetValue(value, key);
		}
	}
}
