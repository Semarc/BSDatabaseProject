using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject.Sources.Forms
{
	public partial class Namensgenerator : UserControl
	{
		public Namensgenerator()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = Datenbankzugriff.GetNachname("Menschen");
		}
	}
}
