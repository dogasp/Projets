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
	public partial class generator : Form
	{
		TextBox box;
		public generator(TextBox box)
		{
			InitializeComponent();
			this.box = box;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			len.Text = trackBar1.Value.ToString();
		}

		private void len_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				trackBar1.Value = int.Parse(len.Text);
			}
		}

		private void len_Leave(object sender, EventArgs e)
		{
			trackBar1.Value = int.Parse(len.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String select = "";
			if (min.Checked) select += "abcdefghijklmnopqrstuvwxyz";
			if (maj.Checked) select += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			if (sym.Checked) select += "&~#'{(-|_^@)=}+$€*%/:.;?,";
			if (num.Checked) select += "01234567890123456789";

			Random r = new Random();

			String pswrd = "";
			for (int i = 0; i < trackBar1.Value; i++)
			{
				pswrd += select[r.Next(select.Length)];
			}
			result.Text = pswrd;
			use.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (result.Text != "")
			{
				this.box.Text = result.Text;
				this.Close();
			}
		}
	}
}
