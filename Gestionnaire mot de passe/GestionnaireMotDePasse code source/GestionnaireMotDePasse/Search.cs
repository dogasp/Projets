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
	public partial class Search : Form
	{
		private Form1 parent;
		public Search(Form1 parent)
		{
			this.parent = parent;
			InitializeComponent();
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (SearchBox.Text != "")
			{
				TableLayoutSearch.Controls.Clear();
				List<Psw> array = new List<Psw>();
				foreach (Psw pswrd in this.parent.array)
				{
					if (pswrd.SiteName.Contains(SearchBox.Text)){
						array.Add(pswrd);
					}
				}

				Form1 command = new Form1();

				this.SuspendLayout();
				TableLayoutSearch.Refresh();
				TableLayoutSearch.RowStyles.Clear();
				TableLayoutSearch.TabIndex = 0;
				
				TableLayoutSearch.RowCount = array.Count();

				TableLayoutSearch.ColumnCount = 5;
				for (int i = 0; i < TableLayoutSearch.ColumnCount; i++)
					TableLayoutSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
				
				for (int i = 0; i < TableLayoutSearch.RowCount; i++)
					if (TableLayoutSearch.RowCount < 4)
					{
						TableLayoutSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
					}
					else TableLayoutSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 65));

				for (int i = 0; i < TableLayoutSearch.RowCount; i++)
				{
					Label label0 = new Label();
					label0.Text = array[i].SiteName;
					label0.Font = new Font("arial narrow", 14f);
					label0.ForeColor = Color.Black;
					label0.BackColor = TransparencyKey;
					label0.TextAlign = ContentAlignment.MiddleCenter;
					label0.Dock = DockStyle.Fill;

					Label label1 = new Label();
					label1.Text = array[i].user;
					label1.Font = new Font("arial narrow", 14f);
					label1.ForeColor = Color.Black;
					label1.BackColor = TransparencyKey;
					label1.TextAlign = ContentAlignment.MiddleCenter;
					label1.Dock = DockStyle.Fill;

					Label label2 = new Label();
					label2.Text = new Func<string>(() => { string text = ""; for (int j = 0; j < array[i].pswrd.Length; j++) text += "*"; return text; })();
					label2.Font = new Font("arial narrow", 14f);
					label2.ForeColor = Color.Black;
					label2.Anchor = AnchorStyles.None;
					label2.BackColor = TransparencyKey;
					label2.TextAlign = ContentAlignment.MiddleCenter;
					label1.Dock = DockStyle.Fill;

					buttonp show = new buttonp(i);
					show.Text = "click here to show\n the details of " + array[i].SiteName;
					show.Font = new Font("arial narrow", 10f);
					show.ForeColor = Color.Black;
					show.BackColor = TransparencyKey;
					show.TextAlign = ContentAlignment.MiddleCenter;
					show.Dock = DockStyle.Fill;
					show.FlatStyle = FlatStyle.Flat;
					show.FlatAppearance.BorderSize = 0;
					show.Click += command.Show_Click;

					buttonp link = new buttonp(i);
					link.Text = "click here to connect to " + array[i].SiteName;
					link.Font = new Font("arial narrow", 10f);
					link.ForeColor = Color.Black;
					link.BackColor = TransparencyKey;
					link.TextAlign = ContentAlignment.MiddleCenter;
					link.Dock = DockStyle.Fill;
					link.FlatStyle = FlatStyle.Flat;
					link.FlatAppearance.BorderSize = 0;
					link.Click += command.Link_Click;

					TableLayoutSearch.Controls.Add(label0, 0, i);
					TableLayoutSearch.Controls.Add(label1, 1, i);
					TableLayoutSearch.Controls.Add(label2, 2, i);
					TableLayoutSearch.Controls.Add(show, 3, i);
					TableLayoutSearch.Controls.Add(link, 4, i);
				}
				this.ResumeLayout();
			}
		}
	}
}
