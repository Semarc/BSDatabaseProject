using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DatabaseProject.Sources
{
	public static class Konstanten
	{

		static Konstanten()
		{
			try
			{
				SQLconnection = new MySqlConnection(myConnectionString);
				SQLconnection.Open();
			}
			catch
			{
				MessageBox.Show("Fehler beim verbinden mit der Datenbank");
				Application.Exit();
			}
		}

		public const string myConnectionString = "SERVER=193.26.158.48;DATABASE=DnDUtilities;UID=test;PASSWORD=test123;";

		public static readonly MySqlConnection SQLconnection;

		public static class SQLCommands
		{
			public const string SelectNachname = "SELECT Name FROM Nachnamen WHERE Volkname = '[VOLKSNAME]' ORDER BY RAND() LIMIT 1";
		}

		public static class SQLParameterNames
		{
			public const string Volksname = "Volksname";
		}

		public static class ReplaceString
		{
			public const string Volksname = "[VOLKSNAME]";
		}

	}
}
