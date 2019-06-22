using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinCoursAppV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Infos : ContentPage
	{
		public Infos (IDictionary<string, TimeSpan> Others_Total, List<Date> Dates)
		{
			InitializeComponent ();

			Device.StartTimer(TimeSpan.FromMilliseconds(900), () =>
			{
				var Daily_Total = Others_Total.ToDictionary(entry => entry.Key, entry => entry.Value); //copie du dictionnaire des jours suivants

				TimeSpan EndingDay = new TimeSpan();

				//calcul des temps de la journée
				DateTime Current = DateTime.Now;
				if (Current.DayOfWeek != DayOfWeek.Saturday && Current.DayOfWeek != DayOfWeek.Sunday && 18 >= Current.Hour && Current.Hour >= 8)
				{
					bool DayisFinished = true;
					foreach (Date ToTest in Dates)
					{
						if (ToTest.day == Current.DayOfWeek && ToTest.start < Current.TimeOfDay && ToTest.end.TimeOfDay > Current.TimeOfDay)
						{
							TimeSpan gap = ToTest.end.TimeOfDay - Current.TimeOfDay;
							EndLesson.Text = "Time before ending lesson: " + gap.ToString(@"hh\:mm\:ss");
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

					if (DayisFinished == false && EndLesson.Text.Length < 20) EndLesson.Text = "Currently in pause";
					//affichages
					if (DayisFinished == false)
					{
						EndDay.Text = "Ending day in " + EndingDay.ToString(@"hh\:mm\:ss");
					}
					else
					{
						EndDay.Text = "Have a good day";
						EndLesson.Text = "You are not in class";
					}
				}

				//calcul du temps restant au total
				var delta = new DateTime(2019, 6, 5, 13, 10, 00) - Current;
				EndingSchool.Text = String.Format("Time left before the End: {0} days, {1} hours {2} minute and {3} seconds", delta.Days, delta.Hours, delta.Minutes, delta.Seconds);

				var deltaBac = new DateTime(2019, 6, 17, 08, 00, 00) - Current;
				Bac.Text = String.Format("Time left before first test: {0} days, {1} hours {2} minute and {3} seconds", deltaBac.Days, deltaBac.Hours, deltaBac.Minutes, deltaBac.Seconds);

				Timer.Text = "Current date: " + DateTime.Now.ToString("G");

				return true;
			});
		}
		private async void NavigateButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}