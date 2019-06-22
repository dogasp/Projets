using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionnaireMotDePasse
{
	public partial class modifyPsw : Form
	{
		Criptage hash = new Criptage();
		public modifyPsw()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StreamReader rd = new StreamReader(Environment.CurrentDirectory + "/pswrd");
			string pswrd = rd.ReadLine();
			rd.Close();
			if (hash.Hash(old.Text) == pswrd)
				if (new1.Text == new2.Text && new1.Text != "")
				{
					StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/pswrd");
					sw.WriteLine(hash.Hash(new1.Text));
					sw.Close();
					this.Close();
				}
		}
	}
}
