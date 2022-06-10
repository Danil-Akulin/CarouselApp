using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace tthk_xamarin_carousel
{
	public class MainPage : CarouselPage
    {
        public MainPage()
        {
            Title = "Темпераменты";
            List<Temperament> temperaments = TemperLoader.LoadStaticValues();
            foreach (var temperament in temperaments)
            {
                var temperamentPage = new TemperPage(temperament);
                this.Children.Add(temperamentPage);
            }
        }
    }
}