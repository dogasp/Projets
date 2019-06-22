using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace Site_classe
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		DateTime hour = DateTime.Now;
		protected void Page_Load(object sender, EventArgs e)
		{
			heure.Text = hour.ToString("dd/MM/yyyy");
		}
	}
}