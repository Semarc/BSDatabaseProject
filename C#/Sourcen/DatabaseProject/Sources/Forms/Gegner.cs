using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject.Sources.Forms
{
	public partial class Gegner : UserControl
	{
		public Gegner()
		{
			InitializeComponent();

			if (Konstanten.HasConnection)
			{
				GegnerTyp.DataSource = Datenbankzugriff.GetGegnerTypen();
				GegnerEnviroment.DataSource = Datenbankzugriff.GetGegnerEnviroments();
				GegnerCombatRating.DataSource = Datenbankzugriff.GetGegnerCombatRatings();
			}
		}
	}
}
