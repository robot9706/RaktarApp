using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace Raktar.Database
{
	public class DatabaseConnection
	{
		private const string _defaultODBCDriver = "MySQL ODBC 5.3 ANSI Driver";

		private OdbcConnection _database;

		private Dictionary<Type, ObjectParser> _parsers;

		public DatabaseConnection(string serverAddress, string database, string user, string password, string odbcDriver)
		{
			if (string.IsNullOrEmpty(odbcDriver))
				odbcDriver = _defaultODBCDriver;

			string driver = "{" + odbcDriver + "}";

			string connectionString;

			if (string.IsNullOrEmpty(password))
				connectionString = string.Format("DRIVER={0};SERVER={1};DATABASE={2};UID={3};OPTION=3", driver, serverAddress, database, user);
			else
				connectionString = string.Format("DRIVER={0};SERVER={1};DATABASE={2};UID={3};PASSWORD={4};OPTION=3", driver, serverAddress, database, user, password);

			_database = new OdbcConnection(connectionString);

			_database.Open();

			_parsers = new Dictionary<Type, ObjectParser>();
		}

		public void Close()
		{
			if (_database == null)
				return;

			_database.Close();
			_database = null;
		}

		private ObjectParser GetParser<T>()
		{
			Type objectType = typeof(T);

			if (!_parsers.ContainsKey(objectType))
				_parsers.Add(objectType, new ObjectParser(objectType));

			return _parsers[objectType];
		}

		public List<T> Select<T>(string selectQuery, params OdbcParameter[] parameters)
		{
			ObjectParser parser = GetParser<T>();

			List<T> result = new List<T>();

			using (OdbcCommand command = new OdbcCommand(selectQuery, _database))
			{
				if (parameters != null)
					command.Parameters.AddRange(parameters);

				using (OdbcDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						T item = parser.ParseItem<T>(reader);

						result.Add(item);
					}
				}
			}

			return result;
		}

		public List<T> SelectAll<T>(string from)
		{
			ObjectParser parser = GetParser<T>();

			List<T> result = new List<T>();

			string query = "SELECT * FROM `" + from + "`";

			using (OdbcCommand command = new OdbcCommand(query, _database))
			{
				using (OdbcDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						T item = parser.ParseItem<T>(reader);

						result.Add(item);
					}
				}
			}

			return result;
		}

		public T SelectOne<T>(string from, Dictionary<string, object> conditions)
		{
			List<T> sel = Select<T>(from, conditions);

			if (sel.Count == 0)
				return default(T);

			return sel[0];
		}

		public List<T> Select<T>(string from, Dictionary<string, object> conditions)
		{
			ObjectParser parser = GetParser<T>();

			List<T> result = new List<T>();

			List<string> conds = new List<string>();
			foreach (KeyValuePair<string, object> c in conditions)
			{
				conds.Add(c.Key + "=" + ObjectParser.FormatPrimitiveValue(c.Value));
			}

			string query = "SELECT * FROM `" + from + "` WHERE " + String.Join(" AND ", conds);

			using (OdbcCommand command = new OdbcCommand(query, _database))
			{
				using (OdbcDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						T item = parser.ParseItem<T>(reader);

						result.Add(item);
					}
				}
			}

			return result;
		}

		public bool InsertInto<T>(string table, T newValue)
		{
			ObjectParser parser = GetParser<T>();

			using (OdbcCommand command = new OdbcCommand())
			{
				command.Connection = _database;
				command.CommandText = "INSERT INTO " + table + " " + parser.BuildInsertStatement<T>(newValue, command) + ";";

				if (command.ExecuteNonQuery() != 0)
				{
					if (parser.HasAutoIncrementKey)
						parser.SetAutoIncrementKey<T>(newValue, GetLastAutoIncrementID());

					return true;
				}
			}

			return false;
		}

		public bool DeleteFrom<T>(string table, T value)
		{
			ObjectParser parser = GetParser<T>();

			using (OdbcCommand command = new OdbcCommand())
			{
				command.Connection = _database;
				command.CommandText = "DELETE FROM " + table + " WHERE " + parser.BuildKeyCondition<T>(value, command) + ";";

				return (command.ExecuteNonQuery() != 0);
			}
		}

		public bool Update<T>(string table, T value)
		{
			ObjectParser parser = GetParser<T>();

			using (OdbcCommand command = new OdbcCommand())
			{
				command.Connection = _database;
				command.CommandText = "UPDATE " + table + " SET " + parser.BuildValueConditions<T>(value, command) + " WHERE " + parser.BuildKeyCondition<T>(value, command) + ";";

				return (command.ExecuteNonQuery() != 0);
			}
		}

		public int GetLastAutoIncrementID()
		{
			string query = "SELECT LAST_INSERT_ID()";

			using (OdbcCommand command = new OdbcCommand(query, _database))
			{
				using (OdbcDataReader reader = command.ExecuteReader())
				{
					if (reader.HasRows)
						return reader.GetInt32(0);
				}
			}

			return 0;
		}
	}
}
