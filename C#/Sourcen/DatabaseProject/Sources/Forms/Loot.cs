﻿using System;
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
	public partial class Loot : UserControl
	{
		public Loot()
		{
			InitializeComponent();

			if (Konstanten.HasConnection)
			{
				typ.DataSource = Datenbankzugriff.GetTyp();
				Seltenheit.DataSource = Datenbankzugriff.GetSeltenheit();

			}
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			Beute.Text = Datenbankzugriff.GetBeute(typ.Text, Seltenheit.Text);
		}

	}
}