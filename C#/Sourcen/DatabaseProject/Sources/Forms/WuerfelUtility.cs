using System;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseProject
{
	public partial class WuerfelUtility : UserControl
	{
		enum WuerfelTypen : int
		{
			D2 = 2,
			D3 = 3,
			D4 = 4,
			D6 = 6,
			D8 = 8,
			D10 = 10,
			D12 = 12,
			D20 = 20,
			D100 = 100
		}

		readonly Random RNG = new Random();

		public WuerfelUtility()
		{
			InitializeComponent();

			cbx_WuerfelTyp.DataSource = Enum.GetValues(typeof(WuerfelTypen));
		}

		private void evh_btnWuerfelnClick(object sender, EventArgs e)
		{
			int intWuerfelAnzahl = (int)nud_WuerfelAnzahl.Value;

			int[] Results = new int[intWuerfelAnzahl];

			for (int intCurrentWuerfel = 0; intCurrentWuerfel < intWuerfelAnzahl; intCurrentWuerfel++)
			{
				Results[intCurrentWuerfel] = RNG.Next(1, (int)cbx_WuerfelTyp.SelectedItem + 1);
			}
			lbl_WuerfelResult.Text = $"{string.Join(", ", Results)}, + {(int)nud_WuerfelBonus.Value} = {Results.Sum() + nud_WuerfelBonus.Value}";
		}

        private void Wüfelanzahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}