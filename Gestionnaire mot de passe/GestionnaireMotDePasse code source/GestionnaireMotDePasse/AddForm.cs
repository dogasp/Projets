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
	public partial class AddForm : Form
	{
		private Form1 parent;
		Criptage Hash = new Criptage();
		public AddForm(Form1 parent)
		{
			this.parent = parent;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string Site = website.Text;
			string Link = link.Text;
			string User = user.Text;
			string Password = Hash.Hash(password.Text);
			if (User != "" && Password != "" && Site != "" && Link != "")
			{
				Psw temp = new Psw(User, Password, Site, Link);
				this.parent.array.Add(temp);
				StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/save.txt");
				foreach (Psw password in this.parent.array)
				{
					sw.WriteLine(password.user + "," + password.pswrd + "," + password.SiteName + "," + password.SiteLink);
				}
				sw.Close();
				this.Close();
				parent.Close();
				Form1 f = new Form1();
				f.Show();
			}
			else
			{
				MessageBox.Show("Please fill all avalable fields");
			}
		}

		private void password_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				button1.PerformClick();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			generator motdepasse = new generator(password);
			motdepasse.Show();
		}
	}
}
