using System;

using Xamarin.Forms;

namespace MovieListSettings
{
    public class MovieListPage : ContentPage
    {
        public MovieListPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

