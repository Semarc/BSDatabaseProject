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

		private static string GetDatabaseString(string CommandText, params SQLParameter[] Parameters)
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

		#region GetStrings

		public static string[] GetGegner(string CombatRating, string Enviroment, string Gegnertyp)
		{
			return GetThreeDatabaseStrings(Konstanten.SQLCommands.SelectGegner, new SQLParameter(Konstanten.ReplaceString.CombatRating, CombatRating), new SQLParameter(Konstanten.ReplaceString.Enviroment, Enviroment), new SQLParameter(Konstanten.ReplaceString.Gegnertyp, Gegnertyp));
		}

		private static string[] GetThreeDatabaseStrings(string CommandText, params SQLParameter[] Parameters)
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				HelperFunctions.ReplaceParameters(ref CommandText, Parameters);

				Command = HelperFunctions.GetNewCommand(CommandText);

				string[] stringArray = new string[4];

				Reader = Command.ExecuteReader();
				if (Reader.Read())
				{
					stringArray[0] = Reader.GetValue(0).ToString();
					stringArray[1] = Reader.GetValue(1).ToString();
					stringArray[2] = Reader.GetValue(2).ToString();
					stringArray[3] = Reader.GetValue(3).ToString();
				}
				return stringArray;
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

		#region GetStringArray

		private static string[] GetStringArray(string CommandString)
		{
			MySqlDataReader Reader = null;
			MySqlCommand Command = null;
			try
			{
				Command = HelperFunctions.GetNewCommand(CommandString);
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
		}

		public static string[] GetVoelkerNamen()
		{
			return GetStringArray(Konstanten.SQLCommands.SelectVoelker);
		}

		public static string[] GetTyp()
		{
			return GetStringArray(Konstanten.SQLCommands.SelectTyp);
		}
		public static string[] GetSeltenheit()
		{
			return GetStringArray(Konstanten.SQLCommands.SelectSeltenheit);
		}

		public static string[] GetGegnerTypen()
		{
			return GetStringArray(Konstanten.SQLCommands.SelectGegnerTypen);
		}
		public static string[] GetGegnerEnviroments()
		{
			return GetStringArray(Konstanten.SQLCommands.SelectGegnerEnviroments);
		}
		public static string[] GetGegnerCombatRatings()
		{
			return GetStringArray(Konstanten.SQLCommands.SelectGegnerCombatRatings);
		}
		#endregion

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