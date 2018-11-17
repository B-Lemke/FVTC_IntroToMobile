using System;
namespace MovieListSettings.Droid
{
    public class DbPathProviderForAndroid : IDbPathProvider
    {
        public string GetDbPath(){
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string dbFileName = "myMovieAndroid.db3";

            string dbFullPath = System.IO.Path.Combine(directoryPath, dbFileName);

            return dbFullPath;
        }
    }
}
