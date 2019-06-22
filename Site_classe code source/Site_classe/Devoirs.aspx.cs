using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site_classe
{
    public partial class Devoirs : System.Web.UI.Page
    {
        string Path = HttpContext.Current.Request.PhysicalApplicationPath + "/" + "Devoirs.txt";
        List<Devoir> devoirs;
        public void Page_Load(object sender, EventArgs e)
        {
            devoirs = Chargement();
            Début_Affichage();
        }

		protected List<Devoir> Chargement()
        {
            StreamReader rd = new StreamReader(Path);
            string line;
            List<Devoir> devoirs = new List<Devoir>();
            while ((line = rd.ReadLine()) != null)
            {
                string[] ligne = line.Split(',');
				if (ligne.ElementAtOrDefault(2) != null)
				{
					string ligneT = "";
					for (int i = 2; i < ligne.Count(); i++)
					{
						ligneT += ligne[i];
					}
					Devoir temp = new Devoir(ligne[0], ligne[1], ligneT);
					devoirs.Add(temp);
				}
            }
            rd.Close();
            return devoirs;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
			bool pass = true;
            string restext = "", resmat = "", resdate = "";
			if (Request.Form["trip"] != "")
			{
				resdate = Request.Form["trip"];
			}
			else
			{
				errdate.Text = "Veuillez rentrer une date!";
				pass = false;
			}

			if (Request.Form["matière"] != null)
			{
				resmat = Request.Form["matière"];
			}
			else
			{
				errmat.Text = "Veuillez sélectionner une matière!";
				pass = false;
			}

			if (Request.Form["S1"] != "" && Request.Form["S1"] != " " && Request.Form["S1"] != "  ")
			{
				restext = Request.Form["S1"].Replace("\r\n", " ").Trim();
			}
            else
             {
                ertext.Text = "Veuillez entrer un devoir!";
				pass = false;
			}

			if (pass)
			{
				Devoir temp = new Devoir(resdate, resmat, restext);
				devoirs.Add(temp);
				StreamWriter sw = new StreamWriter(Path);
				foreach (Devoir travail in devoirs)
				{
					if (DateTime.Compare(DateTime.Now, DateTime.Parse(travail.Date)) <= 0)
					{
						sw.WriteLine(travail.Date + "," + travail.Mat + "," + travail.Text);
					}
				}
				sw.Close();
				Début_Affichage();
			}
        }

        protected void Début_Affichage()
        {
            affdevoirs.Text = "";
            string[] date = DateTime.Now.ToString("yyyy,MM,dd").Split(',');

            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Sunday)
            {
                Fin_Affichage(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]) + 1);
            }
            else
            {
                Fin_Affichage(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
            };
        }

        protected void Fin_Affichage(int year,int month, int day)
        {
            CultureInfo culture = new CultureInfo("fr-Fr");
			string[] matières = { "Mathématiques", "Physique", "SVT", "Philosophie", "Histoire-Géographie", "Allemand LV1", "Allemand LV2", "Anglais LV1", "Anglais LV2", "Espagnol LV2", "Espagnol LV3", "Latin", "ISN", "sp PC" };
			int index = 0, dayindex = 0;
			devoirs.Sort((x, y) => x.Date.CompareTo(y.Mat));
			devoirs.Sort((x, y) => x.Date.CompareTo(y.Date));
            List<List<string[]>> textedevoir = new List<List<string[]>> ();
			Devoir précédent = new Devoir(null,null,null);

			foreach(Devoir travail in devoirs)
			{
				if (travail == précédent)
				{
					continue;
				}
				else if (précédent.Date == travail.Date)
				{
					if (précédent.Mat == travail.Mat) textedevoir[dayindex - 1][index][1] += " + " + travail.Text;
					else
					{
						textedevoir[dayindex - 1].Add(new string[] { travail.Mat, travail.Text, travail.Date });
						index++;
					}
				}
                else //if (précédent.Date != travail.Date)
				{
					textedevoir.Add(new List<string[]> { new string[] { travail.Mat, travail.Text, travail.Date } });
					index = 0;
					dayindex++;
					if (dayindex == 5) break;
                }
				précédent = travail;
            }
			foreach (List<string[]> txtdevoir in textedevoir)
			{
				string[] temp = txtdevoir[0][2].Split('-');
				DateTime jour = new DateTime(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
				affdevoirs.Text += "<h2>" + "Devoirs pour" + " " + culture.DateTimeFormat.GetDayName(jour.DayOfWeek) + " ( le " + jour.ToString("dd") + " / " + jour.ToString("MM") + " / " + jour.ToString("yy") + " )</h2></ br>";
				foreach (string[] devoir in txtdevoir)
				{
					affdevoirs.Text += "<strong>" + devoir[0] + "</strong>" + " ➔ " + devoir[1] + "</br>";
				}
			}
        }
    }
}
	public class Devoir
	{
		private string m_date;
		public string Date
		{
			get { return m_date; }
			set { m_date = value; }
		}
		private string m_mat;
		public string Mat
		{
			get { return m_mat; }
			set { m_mat = value; }
		}
		private string m_text;
		public string Text
		{
			get { return m_text; }
			set { m_text = value; }
		}
		public Devoir(string date, string matière, string texte)
		{
			this.m_date = date;
			this.m_mat = matière;
			this.m_text = texte;
		}

	}
