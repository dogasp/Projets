using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Site_classe
{
    public partial class Calendrier : System.Web.UI.Page
    {
		Hashtable events = null;
		string path = HttpContext.Current.Request.PhysicalApplicationPath + "/" + "Calendrier.txt";

		protected void Page_Load(object sender, EventArgs e)
		{
			events = new Hashtable();
			Session.Add("events", events);
			Chargement();
		}

		protected void Chargement()
		{
			if (Session["events"] != null)
			{
				StreamReader rd = new StreamReader(path);
				string ligne;
				events = (Hashtable)Session["events"];
				while ((ligne = rd.ReadLine()) != null)
				{
					string[] line = ligne.Split(',');
					events.Add(line[0], line[1]);
					Session.Add("events", events);
				}
				rd.Close();
			}
		}
		protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
		{
			if (Session["events"] != null)
			{
				events = (Hashtable)Session["events"];

				if (events[e.Day.Date.ToString("dd-MM-yyyy")] != null)
				{
					Literal lineBreak = new Literal
					{
						Text = "<br /><br />"
					};
					e.Cell.Controls.Add(lineBreak);

					e.Cell.BorderColor = System.Drawing.ColorTranslator.FromHtml("#808080");
					e.Cell.BackColor = System.Drawing.ColorTranslator.FromHtml("#f3f3f3");
					e.Cell.BorderStyle = BorderStyle.Solid;
					e.Cell.BorderWidth = 1;

					Label b = new Label();
					b.Font.Size = 8;
					b.Font.Bold = true;
					b.ForeColor = System.Drawing.ColorTranslator.FromHtml("#336699");
					b.Text = events[e.Day.Date.ToString("dd-MM-yyyy")].ToString();
					e.Cell.Controls.Add(b);
				}
			}
		}
	}
}