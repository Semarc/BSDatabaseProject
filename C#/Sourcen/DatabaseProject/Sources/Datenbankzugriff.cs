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
				Command.CommandText = Konstanten.SQLCommands.SelectNachname.Replace(Konstanten.ReplaceString.Volksname, "testvolk");

				Reader = Command.ExecuteReader();
				if (Reader.HasRows)
				{
					Reader.Read();
					return Reader.GetValue(0).ToString();
				}
				else
				{
					return null;
				}

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