using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;

namespace FinCoursAppV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Graphe : ContentPage
	{
		Random r = new Random();

		List<ChartEntry> entries;

		public Graphe (IDictionary<string, TimeSpan> Others_Total, List<Date> Dates)
		{
			InitializeComponent ();

			var Daily_Total = Others_Total.ToDictionary(entry => entry.Key, entry => entry.Value); //copie du dictionnaire des jours suivants

			TimeSpan EndingDay = new TimeSpan();

			//calcul des temps de la journée
			DateTime Current = DateTime.Now;
			if (Current.DayOfWeek != DayOfWeek.Saturday && Current.DayOfWeek != DayOfWeek.Sunday && 18 >= Current.Hour && Current.Hour >= 8)
			{
				foreach (Date ToTest in Dates)
				{
					if (ToTest.day == Current.DayOfWeek && ToTest.start < Current.TimeOfDay && ToTest.end.TimeOfDay > Current.TimeOfDay)
					{
						TimeSpan gap = ToTest.end.TimeOfDay - Current.TimeOfDay;
						Daily_Total[ToTest.matter] += gap;
						EndingDay += gap;
					}
					else if (ToTest.day == Current.DayOfWeek && ToTest.date.TimeOfDay > Current.TimeOfDay)
					{
						Daily_Total[ToTest.matter] += ToTest.duration;
						EndingDay += ToTest.duration;
					}
				}
			}

			entries = new List<ChartEntry>();
			foreach (KeyValuePair<string, TimeSpan> entry in Daily_Total)
			{
				entries.Add(
					new ChartEntry((float)entry.Value.TotalHours)
					{
						Label = entry.Key,
						ValueLabel = entry.Value.ToString(@"hh\:mm\:ss"),
						Color = SKColor.Parse(String.Format("#{0:X6}", r.Next(0x1000000)))
					}
				);
			}
			entries.Sort((x, y) => y.ValueLabel.CompareTo(x.ValueLabel));

			Create_Chart(entries);



			Device.StartTimer(TimeSpan.FromMilliseconds(900), () =>
			{
				Daily_Total = Others_Total.ToDictionary(entry => entry.Key, entry => entry.Value); //copie du dictionnaire des jours suivants

				EndingDay = new TimeSpan();

				//calcul des temps de la journée
				Current = DateTime.Now;
				if (Current.DayOfWeek != DayOfWeek.Saturday && Current.DayOfWeek != DayOfWeek.Sunday && 18 >= Current.Hour && Current.Hour >= 8)
				{
					foreach (Date ToTest in Dates)
					{
						if (ToTest.day == Current.DayOfWeek && ToTest.start < Current.TimeOfDay && ToTest.end.TimeOfDay > Current.TimeOfDay)
						{
							TimeSpan gap = ToTest.end.TimeOfDay - Current.TimeOfDay;
							Daily_Total[ToTest.matter] += gap;
							EndingDay += gap;
						}
						else if (ToTest.day == Current.DayOfWeek && ToTest.date.TimeOfDay > Current.TimeOfDay)
						{
							Daily_Total[ToTest.matter] += ToTest.duration;
							EndingDay += ToTest.duration;
						}
					}
				}

				if (DateTime.Now.Second == 0)
				{
					entries = new List<ChartEntry>();
					foreach (KeyValuePair<string, TimeSpan> entry in Daily_Total)
					{
						entries.Add(
							new ChartEntry((float)entry.Value.TotalHours)
							{
								Label = entry.Key,
								ValueLabel = entry.Value.ToString(@"hh\:mm\:ss"),
								Color = SKColor.Parse(String.Format("#{0:X6}", r.Next(0x1000000)))
							}
						);
					}
					entries.Sort((x, y) => y.ValueLabel.CompareTo(x.ValueLabel));

					Create_Chart(entries);
				}
				return true;
			});
		}

		private void Create_Chart(List<ChartEntry> entries)
		{
			chartView.Chart = new DonutChart()
			{
				Entries = entries,
				HoleRadius = .5f,
				LabelTextSize = 35
			};
		}

		private async void NavigateButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}