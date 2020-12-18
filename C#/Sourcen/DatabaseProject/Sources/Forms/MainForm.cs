using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
	public partial class MainForm : Form
	{
		private WuerfelUtility Wuerfeler;
		private Namensgenerator Namen;

		public MainForm()
		{
			Konstanten.InitConnection();
			InitializeComponent();

			if (Konstanten.HasConnection == false)
			{
				tbc_MainControl.TabPages.Remove(tbp_Namensgenerator);
			}

		}
	}
}
