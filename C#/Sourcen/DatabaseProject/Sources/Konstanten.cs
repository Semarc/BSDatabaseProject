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

		}

		public static class SQLParameterNames
		{
			public static string Volksname = "Volksname";
		}

	}
}
