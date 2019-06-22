using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microcharts;
using SkiaSharp;

namespace FinCoursAppV2
{
	public partial class MainPage : ContentPage
	{
		string[] data = "Physique,12:45:00,00:50:00,03/06/2019 12:45:00\nAllemand,13:35:00,00:55:00,03/06/2019 13:35:00\nISN,08:25:00,01:50:00,04/06/2019 08:25:00\nMaths,11:20:00,00:55:00,04/06/2019 11:20:00\nSVT,12:45:00,00:50:00,04/06/2019 12:45:00\nAllemand,13:35:00,00:55:00,04/06/2019 13:35:00\nAnglais,14:30:00,00:50:00,04/06/2019 14:30:00\nPhilo,15:35:00,01:45:00,04/06/2019 15:35:00\nSVT,17:20:00,00:50:00,04/06/2019 17:20:00\nPhysique,08:25:00,01:50:00,05/06/2019 08:25:00\nSVT,10:30:00,01:45:00,05/06/2019 10:30:00\nMaths,12:15:00,00:50:00,05/06/2019 12:15:00\nMaths,09:20:00,02:55:00,06/06/2019 09:20:00\nHist-Geo,12:45:00,00:50:00,06/06/2019 12:45:00\nPhysique,14:30:00,00:50:00,06/06/2019 14:30:00\nHist-Geo,15:35:00,01:45:00,06/06/2019 15:35:00\nMaths,08:30:00,01:45:00,07/06/2019 08:30:00\nAnglais,11:20:00,00:55:00,07/06/2019 11:20:00\nPhilo,12:45:00,00:50:00,07/06/2019 12:45:00\nPhysique,13:35:00,00:55:00,07/06/2019 13:35:00\nAllemand,15:35:00,00:55:00,07/06/2019 15:35:00\nSVT,16:30:00,00:50:00,07/06/2019 16:30:00\nPhysique,17:30:00,00:30:00,07/06/2019 17:30:00\nSVT,18:00:00,00:30:00,07/06/2019 18:00:00".Split('\n');

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
		public MainPage()
		{
			InitializeComponent();

			foreach (string line in data)
			{
				string[] ligne = line.Split(',');
				DateTime temp3 = DateTime.ParseExact(ligne[3], "dd/MM/yyyy HH:mm:ss", null);    //Convert.ToDateTime(ligne[3]);
				TimeSpan temp1 = TimeSpan.Parse(ligne[1]);
				TimeSpan temp2 = TimeSpan.Parse(ligne[2]);
				Date temp = new Date(ligne[0], temp3, temp1, temp2)
				{
					day = temp3.DayOfWeek
				};
				Dates.Add(temp);
			}

			//data pour un jour complet
			var days = new Dictionary<DayOfWeek, Matter>()
			{
				{DayOfWeek.Monday, new Matter()},
				{DayOfWeek.Tuesday, new Matter()},
				{DayOfWeek.Wednesday, new Matter()},
				{DayOfWeek.Thursday, new Matter()},
				{DayOfWeek.Friday, new Matter()},
				{DayOfWeek.Saturday, new Matter()}
			};

			//remplissage de cette base de donnée
			foreach (Date day in Dates)
			{
				days[day.day].reference[day.matter] += day.duration;
			};

			//calcul du temps pour les jours complets à vennir
			for (DateTime jours = new DateTime(2019, 5, 20, 10, 10, 00); jours < new DateTime(2019, 6, 5); jours = jours.AddDays(1.0))
			{
				if (jours.DayOfWeek != DayOfWeek.Sunday && jours.DayOfWeek != DayOfWeek.Saturday && jours.Day != 30 && jours.Day != 31)
				{ //tri des jours non travaillés et des jours feriés
					foreach (KeyValuePair<string, TimeSpan> entry in days[jours.DayOfWeek].reference)
					{
						Others_Total[entry.Key] += entry.Value;
					}
				}
			}			
		}

		private async void NavigateButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Graphe(Others_Total, Dates));
		}

		private async void NavigateButton2_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Infos(Others_Total, Dates));
		}
	}

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