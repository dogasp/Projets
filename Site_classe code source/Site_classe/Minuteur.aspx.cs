using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;

namespace Site_classe
{
    public partial class Minuteur : System.Web.UI.Page
	{ 

		public List<Date> Dates = new List<Date>();

		//temps totaux des jours à vennirs
		IDictionary<string, TimeSpan> Others_Total = new Dictionary<string, TimeSpan>() {
			{ "Maths", TimeSpan.FromHours(0)},
			{ "Physique", TimeSpan.FromHours(0)},
			{ "SVT", TimeSpan.FromHours(0)},
			{ "Anglais", TimeSpan.FromHours(0)},
			{ "Allemand", TimeSpan.FromHours(0)},
			{ "Hist-Geo", TimeSpan.FromHours(0)},
			{ "Philo", TimeSpan.FromHours(0)},
			{ "ISN", TimeSpan.FromHours(0)}
		};

		IDictionary<string, TimeSpan> Daily_Total;

		private Random rnd = new Random();

		System.Timers.Timer t = new System.Timers.Timer();		

		public void Page_Load(object sender, EventArgs e)
		{

			using (StreamReader sr = new StreamReader(HttpContext.Current.Request.PhysicalApplicationPath + "/" + "data.txt"))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					string[] ligne = line.Split(',');
					DateTime temp3 = Convert.ToDateTime(ligne[3]);
					TimeSpan temp1 = TimeSpan.Parse(ligne[1]);
					TimeSpan temp2 = TimeSpan.Parse(ligne[2]);
					Date temp = new Date(ligne[0], temp3, temp1, temp2);
					temp.day = temp3.DayOfWeek;
					Dates.Add(temp);
				}
			}

			//data pour un jour complet
			var days = new Dictionary<DayOfWeek, Matter>()
			{
				{DayOfWeek.Monday, new Matter()},
				{DayOfWeek.Tuesday, new Matter()},
				{DayOfWeek.Wednesday, new Matter()},
				{DayOfWeek.Thursday, new Matter()},
				{DayOfWeek.Friday, new Matter()},
			};

			//remplissage de cette base de donnée
			foreach (Date day in Dates)
			{
				days[day.day].reference[day.matter] += day.duration;
			};

			//calcul du temps pour les jours complets à vennir
			for (DateTime jours = DateTime.Now.AddDays(1); jours < new DateTime(2019, 6, 6); jours = jours.AddDays(1.0))
			{
				if (jours.DayOfWeek != DayOfWeek.Sunday && jours.DayOfWeek != DayOfWeek.Saturday && jours.Day != 30 && jours.Day != 31)
				{ //tri des jours non travaillés et des jours feriés
					foreach (KeyValuePair<string, TimeSpan> entry in days[jours.DayOfWeek].reference)
					{
						Others_Total[entry.Key] += entry.Value;
					}
				}
			}

			/*foreach (KeyValuePair<string, TimeSpan> entry in Others_Total)
			{
				Console.WriteLine(entry.Key + " " + entry.Value.ToString());
			}*/
		}

		//fonction appelée toutes les 100ms pour actualiser les timers 
		protected void T_Tick(object sender, EventArgs e)
		{
			Daily_Total = Others_Total.ToDictionary(entry => entry.Key, entry => entry.Value); //copie du dictionnaire des jours suivants

			TimeSpan EndingDay = new TimeSpan();

			//calcul des temps de la journée
			DateTime Current = DateTime.Now;
			//Current = Current.AddDays(2.0); //testing
			if (Current.DayOfWeek != DayOfWeek.Saturday && Current.DayOfWeek != DayOfWeek.Sunday && 18 >= Current.Hour && Current.Hour >= 8)
			{
				bool DayisFinished = true;
				foreach (Date ToTest in Dates)
				{
					if (ToTest.day == Current.DayOfWeek && ToTest.start < Current.TimeOfDay && ToTest.end.TimeOfDay > Current.TimeOfDay)
					{
						TimeSpan gap = ToTest.end.TimeOfDay - Current.TimeOfDay;
						EndLesson.Text = "Temps restant avant la fin du cours: " + gap.ToString(@"hh\:mm\:ss");
						Daily_Total[ToTest.matter] += gap;
						EndingDay += gap;
						DayisFinished = false;
					}
					else if (ToTest.day == Current.DayOfWeek && ToTest.date.TimeOfDay > Current.TimeOfDay)
					{
						Daily_Total[ToTest.matter] += ToTest.duration;
						EndingDay += ToTest.duration;
						DayisFinished = false;
					}
				}

				if (DayisFinished == false && EndLesson.Text.Length < 20) EndLesson.Text = "En pause";
				//affichages
				if (DayisFinished == false)
				{
					EndDay.Text = "Fin de la journée dans  " + EndingDay.ToString(@"hh\:mm\:ss");
				}
				else
				{
					EndDay.Text = "Bonne journée";
					EndLesson.Text = "Pas en cours";
				}
			}

			//actualisation du graphique
			Chart1.Series["Series1"].Points.Clear();
			foreach (var entry in Daily_Total)
			{
				Chart1.Series["Series1"].Points.AddXY(entry.Key, entry.Value.Hours + entry.Value.Minutes / 60 + entry.Value.Seconds / 3600);
				Chart1.Series["Series1"].Points.Last().Label = entry.Key + "\n" + (entry.Value.Hours + entry.Value.Minutes / 60 + entry.Value.Seconds / 3600).ToString() + "h";
			}

			//calcul du temps restant au total
			var delta = new DateTime(2019, 6, 5, 13, 10, 00) - Current;

			EndingSchool.Text = String.Format("Temps avant la fin de la Terminale: {0} Jours, {1} Heures {2} Minutes and {3} Secondes", delta.Days, delta.Hours, delta.Minutes, delta.Seconds);

			LabelDate.Text = "Date actuelle: " + Current.ToString("G");

		}
	}

	//classe utilisée pour enregistrer le compte des heures par journée
	public class Matter
	{
		public IDictionary<string, TimeSpan> reference = new Dictionary<string, TimeSpan>() {
				{ "Maths", TimeSpan.FromHours(0) },
				{ "Physique", TimeSpan.FromHours(0)},
				{ "SVT", TimeSpan.FromHours(0)},
				{ "Anglais", TimeSpan.FromHours(0)},
				{ "Allemand", TimeSpan.FromHours(0)},
				{ "Hist-Geo", TimeSpan.FromHours(0)},
				{ "Philo", TimeSpan.FromHours(0)},
				{ "ISN", TimeSpan.FromHours(0)}
			};
	}

	//classe utilisée pour créer des dates
	public class Date
	{
		public string matter;       // matière 
		public TimeSpan start;      // heure de commencement
		public TimeSpan duration;   // durée cours
		public DateTime date;       // heure et jour exacte du commencement
		public DayOfWeek day;       // Jour de la semaine
		public DateTime end;        //heure de fin

		public Date(string matter, DateTime day, TimeSpan start, TimeSpan duration)
		{
			this.matter = matter;
			this.date = day;
			this.start = start;
			this.duration = duration;
			this.end = this.date + this.duration;
		}
	}
}