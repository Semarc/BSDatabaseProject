using MySql.Data.MySqlClient;

namespace DatabaseProject.Sources
{
	public static class Datenbankzugriff
	{
		public static string GetNachname(string Volksname)
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{

				Command = Konstanten.SQLconnection.CreateCommand();
				Command.CommandText = "SELECT Name FROM Nachnamen ORDER BY RAND() LIMIT 1";

				Command.Parameters.Add(new MySqlParameter(Konstanten.SQLParameterNames.Volksname, Volksname);
				Reader = Command.ExecuteReader();
				Reader.Read();
				return Reader.GetValue(0).ToString();

			}
#if !DEBUG
			catch
			{
				return "Fehler beim Datenbankzugriff zum Nachnamen";
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
		}

	}
}