using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tthk_xamarin_carousel
{
	public class TemperPage : ContentPage
    {
        private Temperament temperament;
        private Image temperImage;
        private Label temperTitleLabel, temperDescriptionLabel;
        private Button temperTestButton;
        private const string temperTestUrl = "https://www.jetbrains.com/ru-ru/";
        public TemperPage(Temperament _temperament)
        {
            temperament = _temperament;
            temperTitleLabel = new Label()
            {
                Text = temperament.Title,
                FontSize = 32,
                HorizontalTextAlignment = TextAlignment.Center
            };
            temperDescriptionLabel = new Label()
            {
                Text = temperament.Description
            };
            temperImage = new Image()
            {
                Source = temperament.Picture
            };
            temperTestButton = new Button()
            {
                Text = "Преобрести среду разработки"
            };
            temperTestButton.Clicked += TempTestButtonOnClicked;
            FlexLayout flexLayout = new FlexLayout()
            {
                Direction = FlexDirection.Column,
                JustifyContent = FlexJustify.SpaceEvenly,
                Children = { temperTitleLabel, temperImage, temperDescriptionLabel, temperTestButton },
                Margin = 20
            };
            Content = flexLayout;
        }

        private void TempTestButtonOnClicked(object sender, EventArgs e)
        {
            Browser.OpenAsync(temperTestUrl);
        }
    }
}