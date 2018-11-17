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


        private static SQLite.SQLiteDatabase _database;

        public static SQLite.SQLiteDatabase Database {
            get {
                if(_database == null){
                    _database = new SQLite.SQLiteDatabase();
                }

                return _database;
            }

        }

    }
}
