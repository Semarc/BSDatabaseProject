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
				cbxGegnerTyp.DataSource = StringSorter(Datenbankzugriff.GetGegnerTypen());
				cbxGegnerEnviroment.DataSource = StringSorter(Datenbankzugriff.GetGegnerEnviroments());
				cbxGegnerCombatRating.DataSource = StringSorter(Datenbankzugriff.GetGegnerCombatRatings());
			}
			foreach (Control control in Controls)
			{
				if (control is ComboBox box && box.Items.Count >= 1)
				{
					box.SelectedIndex = 1;
				}
			}
		}



		static List<string> StringSorter(string[] InputArray)
		{
			List<string> OutputList = new List<string>(InputArray)
				{
					string.Empty
				};
			OutputList.Sort();
			return OutputList;
		}

		private void GegnerZiehen(object sender, EventArgs e)
		{
			string GegnerTyp = string.IsNullOrWhiteSpace(cbxGegnerTyp.Text) ? "%" : cbxGegnerTyp.Text;
			string GegnerEnviroment = string.IsNullOrWhiteSpace(cbxGegnerEnviroment.Text) ? "%" : cbxGegnerEnviroment.Text;
			string GegnerCombatRating = string.IsNullOrWhiteSpace(cbxGegnerCombatRating.Text) ? "%" : cbxGegnerCombatRating.Text;
			string[] Results = Datenbankzugriff.GetGegner(GegnerCombatRating, GegnerEnviroment, GegnerTyp);
			ResultLabel.Text = $"Gegnername: {Results[0]}{Environment.NewLine}" +
						  $"Gegnertyp: {Results[1]}{Environment.NewLine}" +
						  $"Gegnerenviroment: {Results[2]}{Environment.NewLine}" +
						  $"Gegner-CR: {Results[3]}{Environment.NewLine}";
		}
	}
}