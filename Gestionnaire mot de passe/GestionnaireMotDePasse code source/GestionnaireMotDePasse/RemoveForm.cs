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
	public partial class RemoveForm : Form
	{
		private Form1 parent;
		public RemoveForm(Form1 parent)
		{
			InitializeComponent();
			this.parent = parent;
		}

		private List<RadioButton> RadioArray = new List<RadioButton>();

		private void RemoveForm_Load(object sender, EventArgs e)
		{
			this.SuspendLayout();
			tableLayoutRemove.RowStyles.Clear();
			tableLayoutRemove.TabIndex = 0;

			tableLayoutRemove.ColumnCount = 1;
			tableLayoutRemove.RowCount = this.parent.array.Count();
			
			for (int i = 0; i < tableLayoutRemove.RowCount; i++)
				if (tableLayoutRemove.RowCount < 4)
				{
					tableLayoutRemove.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
				}
				else tableLayoutRemove.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

			for (int i =0; i< tableLayoutRemove.RowCount; i++)
			{
				RadioButton radio = new RadioButton();
				radio.Text = this.parent.array[i].SiteName;
				radio.Font = new Font("arial narrow", 13f);
				radio.ForeColor = Color.Black;
				radio.BackColor = TransparencyKey;
				radio.TextAlign = ContentAlignment.MiddleCenter;
				radio.Dock = DockStyle.Fill;

				tableLayoutRemove.Controls.Add(radio, 0, i);
				RadioArray.Add(radio);
			}
			this.ResumeLayout();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (RadioButton temp in RadioArray)
			{
				if (temp.Checked == true)
				{
					List<Psw> parentArray = this.parent.array;
					for (int i = 0; i < parentArray.Count(); i++) {
						if (parentArray[i].SiteName == temp.Text)
						{
							parentArray.Remove(parentArray[i]);
						}
					}
				}
			}
			StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/save.txt");
			foreach (Psw password in this.parent.array)
			{
				sw.WriteLine(password.user + "," + password.pswrd + "," + password.SiteName + "," + password.SiteLink);
			}
			sw.Close();

			this.Close();
			this.parent.Close();
			Form1 f = new Form1();
			f.Show();
		}
	}
}
