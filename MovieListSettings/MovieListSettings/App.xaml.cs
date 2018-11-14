using Xamarin.Forms;
using System.Collections.Generic;

namespace MovieListSettings
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Instantiate a movie list page
            MovieListPage moviePage = new MovieListPage();

            //Instantiate a navigation page to use push and pop, with moviewPage as the root
            NavigationPage navPage = new NavigationPage(moviePage);

            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            base.OnStart();
            LoadMoviesFromProperties();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            base.OnSleep();
            SaveMoviesToProperties();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            base.OnResume();
            LoadMoviesFromProperties();
        }

        const string MovieListPropertyKey = "Movies";

        public static void LoadMoviesFromProperties()
        {
            MyMovieList.Clear();

            if (Application.Current.Properties.ContainsKey(MovieListPropertyKey))
            {
                string json = Application.Current.Properties[MovieListPropertyKey] as string;

                if (json != null) 
                {
                    List<Movie> memoryMovies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(json);

                    MyMovieList.AddRange(memoryMovies);
                }
            }
        }

        public static void SaveMoviesToProperties()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(MyMovieList);

            Application.Current.Properties[MovieListPropertyKey] = json;
        }

        public static List<Movie> MyMovieList { get; } = new List<Movie>();
    }
}
