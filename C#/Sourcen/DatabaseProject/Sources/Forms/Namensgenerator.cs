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
		public Namensgenerator()
		{
			InitializeComponent();
			cbx_VolkAuswahl.DataSource = Datenbankzugriff.GetVoelkerNamen();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = Datenbankzugriff.GetNachname((string)cbx_VolkAuswahl.SelectedItem);
		}
	}
}
