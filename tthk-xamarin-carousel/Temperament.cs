using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace tthk_xamarin_carousel
{
    public class Temperament
    {
        private string title;
        private string description;
        private ImageSource picture;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public ImageSource Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }
    }
}
