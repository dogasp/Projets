using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnaireMotDePasse
{
	public partial class password : Form
	{
		public password()
		{
			InitializeComponent();
			if (!File.Exists(Environment.CurrentDirectory + "/pswrd"))
				label1.Text = "Enter a password to setup the application";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Criptage hash = new Criptage();
			string Hashed = hash.Hash(passwordBox.Text);

			if (File.Exists(Environment.CurrentDirectory + "/pswrd"))
			{
				StreamReader rd = new StreamReader(Environment.CurrentDirectory + "/pswrd");
				string pswrd = rd.ReadLine();
				rd.Close();


				if (Hashed == pswrd)
				{
					Form.ActiveForm.Hide();
					Form1 f = new Form1();
					f.Show();
				}
			}

			else
			{
				StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/pswrd");
				sw.WriteLine(hash.Hash(passwordBox.Text));
				sw.Close();

				Form.ActiveForm.Hide();
				Form1 f = new Form1();
				f.Show();
			}
			
		}

		private void passwordBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				buttonValidate.PerformClick();
			}
		}
	}
}
