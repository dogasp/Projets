using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnaireMotDePasse
{
	public partial class Form1 : Form
	{
		Point src;
		bool inMove = false;
		bool checkMoveArea = false;
		public List<Psw> array = new List<Psw>();
		Criptage hash = new Criptage();

		public virtual bool InMove
		{
			get { return inMove; }
		}

		bool canMove = true;

		public virtual bool CanMove
		{
			get { return canMove; }
			set { canMove = value; }
		}

		public Form1()
		{
			InitializeComponent();
			if (File.Exists(Environment.CurrentDirectory + "/save.txt"))
			{
				StreamReader rd = new StreamReader(Environment.CurrentDirectory + "/save.txt");
				string line;
				while ((line = rd.ReadLine()) != null)
				{
					string[] ligne = line.Split(',');
					Psw temporary = new Psw(ligne[0], ligne[1], ligne[2], ligne[3]);
					array.Add(temporary);
				}
				rd.Close();
			}

			this.SuspendLayout();
			tableLayoutpanel.RowStyles.Clear();
			tableLayoutpanel.TabIndex = 0;

			tableLayoutpanel.ColumnCount = 5;
			for (int i = 0; i < tableLayoutpanel.ColumnCount; i++)
				tableLayoutpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));

			tableLayoutpanel.RowCount = array.Count;

			for (int i = 0; i < tableLayoutpanel.RowCount; i++)
				if (tableLayoutpanel.RowCount < 7)
				{
					tableLayoutpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
				}
				else tableLayoutpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
			
			for (int i = 0; i < tableLayoutpanel.RowCount; i++)
			{
				Label label0 = new Label();
				label0.Text = array[i].SiteName;
				label0.Font = new Font("arial narrow", 16f);
				label0.ForeColor = Color.Black;
				label0.BackColor = TransparencyKey;
				label0.TextAlign = ContentAlignment.MiddleCenter;
				label0.Dock = DockStyle.Fill;

				Label label1 = new Label();
				label1.Text = array[i].user;
				label1.Font = new Font("arial narrow", 16f);
				label1.ForeColor = Color.Black;
				label1.BackColor = TransparencyKey;
				label1.TextAlign = ContentAlignment.MiddleCenter;
				label1.Dock = DockStyle.Fill;

				Label label2 = new Label();
				label2.Text = new Func<string>(() => { string text = ""; for (int j = 0; j < array[i].pswrd.Length; j++) text += "*"; return text; })();
				label2.Font = new Font("arial narrow", 16f);
				label2.ForeColor = Color.Black;
				label2.Anchor = AnchorStyles.None;
				label2.BackColor = TransparencyKey;
				label2.TextAlign = ContentAlignment.MiddleCenter;
				label1.Dock = DockStyle.Fill;

				buttonp show = new buttonp(i);
				show.Text = "click here to show\n the details of " + array[i].SiteName;
				show.Font = new Font("arial narrow", 12f); 
				show.ForeColor = Color.Black;
				show.BackColor = TransparencyKey;
				show.TextAlign = ContentAlignment.MiddleCenter;
				show.Dock = DockStyle.Fill;
				show.FlatStyle = FlatStyle.Flat;
				show.FlatAppearance.BorderSize = 0;
				show.Click += Show_Click;

				buttonp link = new buttonp(i);
				link.Text = "click here to connect to " + array[i].SiteName;
				link.Font = new Font("arial narrow", 12f);
				link.ForeColor = Color.Black;
				link.BackColor = TransparencyKey;
				link.TextAlign = ContentAlignment.MiddleCenter;
				link.Dock = DockStyle.Fill;
				link.FlatStyle = FlatStyle.Flat;
				link.FlatAppearance.BorderSize = 0;
				link.Click += Link_Click;

				tableLayoutpanel.Controls.Add(label0, 0, i);
				tableLayoutpanel.Controls.Add(label1, 1, i);
				tableLayoutpanel.Controls.Add(label2, 2, i);
				tableLayoutpanel.Controls.Add(show, 3, i);
				tableLayoutpanel.Controls.Add(link, 4, i);
			}
			this.ResumeLayout();
		}

		public void Show_Click(object sender, EventArgs e)
		{
			Psw objet = array[((buttonp)sender).index];
			MessageBox.Show("Site: "+ objet.SiteName + "\nlink: "+ objet.SiteLink +"\nuser: "+ objet.user +"\npassword: "+ hash.UnHash(objet.pswrd));
		}

		public void Link_Click(object sender, EventArgs e)
		{
			Psw objet = array[((buttonp)sender).index];
			GoToForm go = new GoToForm(this, objet);
			go.Show();
		}

		private void TopPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (canMove)
				inMove = true;

			src = e.Location;
		}

		private void TopPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (inMove)
			{
				if (checkMoveArea && (Left + (e.X - src.X)) < 0)
					Left = 0;
				else if (checkMoveArea && (Left + (e.X - src.X)) + Width > Screen.PrimaryScreen.WorkingArea.Width)
					Left = Screen.PrimaryScreen.WorkingArea.Width - Width;
				else
				{
					Left += e.X - src.X;
				}

				if (checkMoveArea && (Top + e.Y - src.Y) < 0)
					Top = 0;
				else if (checkMoveArea && (Top + e.Y - src.Y) + Height > Screen.PrimaryScreen.WorkingArea.Height)
					Top = Screen.PrimaryScreen.WorkingArea.Height - Height;
				else
				{
					Top += e.Y - src.Y;
				}

				CheckPosition();
			}
		}

		private void CheckPosition()
		{
			Rectangle w_area = Screen.GetWorkingArea(this);
			if (Top > w_area.Height - TopPanel.Height)
				Top = w_area.Height - TopPanel.Height;
		}

		private void TopPanel_MouseUp(object sender, MouseEventArgs e)
		{
			inMove = false;
		}

		private void buttonQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string message = "This program have been created by Dorian GASPAR. It's usage are restricted to non-comercial uses." +
				"\n If you have any problems while runing it, please contact the owner.";
			MessageBox.Show(message);
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddForm ajouter = new AddForm(this);
			ajouter.Show();
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (File.Exists(Environment.CurrentDirectory + "/save.txt"))
			{
				File.Delete(Environment.CurrentDirectory + "/save.txt");
				this.Close();
				Form1 f = new Form1();
				f.Show();
			}
		}

		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RemoveForm remove = new RemoveForm(this);
			remove.Show();
		}

		private void findToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Search s = new Search(this);
			s.Show();
		}

		private void applicationsPasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modifyPsw change = new modifyPsw();
			change.Show();
		}
	}

	public class Psw
	{
		public string user;
		public string pswrd;
		public string SiteName;
		public string SiteLink;
		public Psw(string user, string pswrd, string SiteName, string SiteLink)
		{
			this.user = user;
			this.pswrd = pswrd;
			this.SiteLink = SiteLink;
			this.SiteName = SiteName;
		}
	}

	class buttonp : Button
	{
		public int index;
		public buttonp(int i)
		{
			this.index = i;
		}
	}
}
