using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{

	public enum Geschlecht
	{
		M,
		W
	}

	public partial class Namensgenerator : UserControl
	{
		private string GewaehltersVolksname { get { return (string)cbx_VolkAuswahl.SelectedItem; } }
		private Geschlecht GewaehltesGeschlecht { get { return (Geschlecht)cbx_GeschlechtAuswahl.SelectedItem; } }


		public Namensgenerator()
		{
			InitializeComponent();
			cbx_VolkAuswahl.DataSource = Datenbankzugriff.GetVoelkerNamen();
			cbx_GeschlechtAuswahl.DataSource = Enum.GetValues(typeof(Geschlecht));
		}

		private void NachnamenButtonClick(object sender, EventArgs e)
		{
			lbl_Nachname.Text = Datenbankzugriff.GetNachname(GewaehltersVolksname);
		}

		private void VornamenButtonClick(object sender, EventArgs e)
		{
			lbl_Vorname.Text = Datenbankzugriff.GetVorname(GewaehltersVolksname, GewaehltesGeschlecht);
		}

	}
}
