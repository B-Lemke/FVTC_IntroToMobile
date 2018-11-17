using System;
namespace MovieListSettings.iOS
{
    public class DbPathPRoviderForIOS : IDbPathProvider
    {
        public string GetDbPath(){
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string dbFileName = "myMoviesIOS.db3";

            string dbFullPath = System.IO.Path.Combine(directoryPath, dbFileName);

            return dbFullPath;
        }
    }
}
