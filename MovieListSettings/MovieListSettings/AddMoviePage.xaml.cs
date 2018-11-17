using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MovieListSettings
{
    public partial class AddMoviePage : ContentPage
    {
        public AddMoviePage()
        {
            InitializeComponent();
        }

        void Handle_Add_Movie_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entTitle.Text) || string.IsNullOrWhiteSpace(entRating.Text))
            {
                DisplayAlert("No", "No Blank Movies or Ratings", "Sorry");  
            }
            else
            {
                Movie newMovie = new Movie();

                newMovie.Title = entTitle.Text;
                newMovie.Rating = entRating.Text;

                App.Database.InsertMovie(newMovie);

                Navigation.PopAsync();
            }

        }


    }
}
