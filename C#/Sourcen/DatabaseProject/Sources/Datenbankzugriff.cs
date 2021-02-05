using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatabaseProject
{
	public static class Datenbankzugriff
	{
		#region GetSingleString
		public static string GetNachname(string Volksname)
		{
			return GetDatabaseString(Konstanten.SQLCommands.SelectNachname, new SQLParameter(Konstanten.ReplaceString.Volksname, Volksname));
		}

		public static string GetVorname(string Volksname, Geschlecht geschlecht)
		{
			return GetDatabaseString(Konstanten.SQLCommands.SelectVorname, new SQLParameter(Konstanten.ReplaceString.Volksname, Volksname), new SQLParameter(Konstanten.ReplaceString.Geschlecht, geschlecht.ToString()));
		}

		public static string GetBeute(string Typ, string Seltenheit)
		{
			return GetDatabaseString(Konstanten.SQLCommands.SelectBeute, new SQLParameter(Konstanten.ReplaceString.Typ, Typ), new SQLParameter(Konstanten.ReplaceString.Seltenheit, Seltenheit));
		}

		public static string GetDatabaseString(string CommandText, params SQLParameter[] Parameters)
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				HelperFunctions.ReplaceParameters(ref CommandText, Parameters);

				Command = HelperFunctions.GetNewCommand(CommandText);

				Reader = Command.ExecuteReader();
				if (Reader.Read())
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
				return "Fehler beim Datenbankzugriff";
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
		}
		#endregion

		public static string[] GetVoelkerNamen()
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				Command = HelperFunctions.GetNewCommand(Konstanten.SQLCommands.SelectVoelker);
				Reader = Command.ExecuteReader();

				List<string> Results = new List<string>();
				while (Reader.Read())
				{
					Results.Add(Reader.GetValue(0).ToString());
				}

				Results.Sort();
				return Results.ToArray();
			}
#if !DEBUG
			catch
			{
				return new[] { "Fehler beim Datenbankzugriff" };
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
			return null;
		}

		public static string[] GetTyp()
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				Command = HelperFunctions.GetNewCommand(Konstanten.SQLCommands.SelectTyp);
				Reader = Command.ExecuteReader();

				List<string> Results = new List<string>();
				while (Reader.Read())
				{
					Results.Add(Reader.GetValue(0).ToString());
				}

				Results.Sort();
				return Results.ToArray();
			}
#if !DEBUG
			catch
			{
				return new[] { "Fehler beim Datenbankzugriff" };
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
			return null;
		}
		public static string[] GetSeltenheit()
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				Command = HelperFunctions.GetNewCommand(Konstanten.SQLCommands.SelectSeltenheit);
				Reader = Command.ExecuteReader();

				List<string> Results = new List<string>();
				while (Reader.Read())
				{
					Results.Add(Reader.GetValue(0).ToString());
				}

				Results.Sort();
				return Results.ToArray();
			}
#if !DEBUG
			catch
			{
				return new[] { "Fehler beim Datenbankzugriff" };
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
			return null;
		}

		public static string[] GetGegnerTypen()
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				Command = HelperFunctions.GetNewCommand(Konstanten.SQLCommands.SelectGegnerTypen);
				Reader = Command.ExecuteReader();

				List<string> Results = new List<string>();
				while (Reader.Read())
				{
					Results.Add(Reader.GetValue(0).ToString());
				}

				Results.Sort();
				return Results.ToArray();
			}
#if !DEBUG
			catch
			{
				return new[] { "Fehler beim Datenbankzugriff" };
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
			return null;
		}
		public static string[] GetGegnerEnviroments()
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				Command = HelperFunctions.GetNewCommand(Konstanten.SQLCommands.SelectGegnerEnviroments);
				Reader = Command.ExecuteReader();

				List<string> Results = new List<string>();
				while (Reader.Read())
				{
					Results.Add(Reader.GetValue(0).ToString());
				}

				Results.Sort();
				return Results.ToArray();
			}
#if !DEBUG
			catch
			{
				return new[] { "Fehler beim Datenbankzugriff" };
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
			return null;
		}
		public static string[] GetGegnerCombatRatings()
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				Command = HelperFunctions.GetNewCommand(Konstanten.SQLCommands.SelectGegnerCombatRatings);
				Reader = Command.ExecuteReader();

				List<string> Results = new List<string>();
				while (Reader.Read())
				{
					Results.Add(Reader.GetValue(0).ToString());
				}

				Results.Sort();
				return Results.ToArray();
			}
#if !DEBUG
			catch
			{
				return new[] { "Fehler beim Datenbankzugriff" };
			}
#endif
			finally
			{

				Command?.Dispose();
				Reader?.Close();

			}
			return null;
		}



		private static class HelperFunctions
		{
			public static string ReplaceParameters(ref string CommandText, SQLParameter[] Parameters)
			{
				foreach (SQLParameter sqLParameter in Parameters)
				{
					CommandText = CommandText.Replace(sqLParameter.ParameterName, sqLParameter.Parametervalue);
				}
				return CommandText;
			}

			public static MySqlCommand GetNewCommand(string CommandText)
			{
				MySqlCommand Command = Konstanten.SQLconnection.CreateCommand();
				Command.CommandText = CommandText;
				return Command;
			}
		}

	}
}