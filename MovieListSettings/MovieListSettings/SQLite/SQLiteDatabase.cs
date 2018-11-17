using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieListSettings.SQLite
{
    public class SQLiteDatabase
    {
        SQLiteConnection connection;

        public SQLiteDatabase()
        {
            IDbPathProvider pathProvider = Xamarin.Forms.DependencyService.Get<IDbPathProvider>();

            string dbFullPath = pathProvider.GetDbPath();



            this.connection = new SQLiteConnection(dbFullPath);



            connection.CreateTable<Movie>();
        }

        private static readonly object dbLock = new object();

        public void InsertMovie(Movie movie){
            lock(dbLock){
                connection.Insert(movie);
            }
        }

        public List<Movie> GetAllMovies(){
            lock(dbLock){
                return connection.Table<Movie>().ToList();
            }
        }


    }
}