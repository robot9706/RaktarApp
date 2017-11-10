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

		public List<T> SelectAll<T>(string from) where T: class
		{
			Type objectType = typeof(T);

			if (!_parsers.ContainsKey(objectType))
				_parsers.Add(objectType, new ObjectParser(objectType));

			ObjectParser parser = _parsers[objectType];

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
	}
}
