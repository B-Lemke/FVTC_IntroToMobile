using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight
{
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateNightPrices.MoviePrice = txtMoviePrice.Text;
        }
    }
}
