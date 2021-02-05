using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DatabaseProject
{
	public static class Konstanten
	{

		/// <summary>
		/// Initilises the Conection to the Database
		/// </summary>
		public static void InitConnection()
		{
			try
			{
				_SQLConnection = new MySqlConnection(myConnectionString);
				_SQLConnection.Open();
			}
			catch
			{
				MessageBox.Show($"Fehler beim verbinden mit der Datenbank. {Environment.NewLine}Nicht alle Features werden verfügbar sein");
			}
		}

		public const string myConnectionString = "SERVER=193.26.158.48;DATABASE=DnDUtilities;UID=bkah;PASSWORD=rNwnzLwb77FYWbSX;";

		private static MySqlConnection _SQLConnection;

		public static MySqlConnection SQLconnection { get { return _SQLConnection; } }

		public static bool HasConnection { get { return SQLconnection?.State == System.Data.ConnectionState.Open; } }

		public static class SQLCommands
		{
			public const string SelectNachname = "SELECT Name FROM Nachnamen WHERE Volkname = '[VOLKSNAME]' ORDER BY RAND() LIMIT 1";
			public const string SelectVorname = "SELECT Name FROM Vornamen WHERE Volkname = '[VOLKSNAME]' AND Geschlecht = '[GESCHLECHT]' ORDER BY RAND() LIMIT 1";

			public const string SelectVoelker = "SELECT Volkname FROM Voelker";

			public const string SelectTyp = "SELECT DISTINCT Typ FROM Loot";
			public const string SelectSeltenheit = "SELECT DISTINCT Seltenheit FROM Loot";
			public const string SelectBeute = "SELECT Name, Werte FROM Loot WHERE Typ = '[TYP]' AND Seltenheit = '[SELTENHEIT]' ORDER BY RAND() LIMIT 1";
		}

		public static class SQLParameterNames
		{
			public const string Volksname = "Volksname";
		}

		public static class ReplaceString
		{
			public const string Volksname = "[VOLKSNAME]";
			public const string Geschlecht = "[GESCHLECHT]";
			public const string Typ = "[TYP]";
			public const string Seltenheit = "[SELTENHEIT]";
		}

	}
}
