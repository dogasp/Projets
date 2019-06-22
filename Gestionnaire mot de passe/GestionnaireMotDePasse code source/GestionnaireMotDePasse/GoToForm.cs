using System;
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
	public partial class GoToForm : Form
	{
		Psw objet;
		Criptage hash = new Criptage();
		Form1 parent;
		public GoToForm(Form1 parent, Psw objet)
		{
			this.parent = parent;
			this.objet = objet;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.objet.SiteLink.Substring(0, 4) != "http")
			{
				System.Diagnostics.Process.Start("http://" + this.objet.SiteLink);
			}
			else
			{
				System.Diagnostics.Process.Start(this.objet.SiteLink);
			}

			button2.PerformClick();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(hash.UnHash(this.objet.pswrd));
			this.Close();

			this.parent.Close();
			Form1 f = new Form1();
			f.Show();
		}
		
	}
}
