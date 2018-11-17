using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MovieListSettings
{
    public partial class MovieListPage : ContentPage
    {
        public MovieListPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //We need to pop the new Add Movie page
            var newPage = new AddMoviePage();

            Navigation.PushAsync(newPage);
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            MovieListView.ItemsSource = null;
            MovieListView.ItemsSource = App.Database.GetAllMovies();
        }
    }
}
