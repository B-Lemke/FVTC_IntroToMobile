using Xamarin.Forms;

namespace Maraton
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MaratonPage firstPage = new MaratonPage();
            MainPage = new NavigationPage(firstPage);
        }

        protected override void OnStart()
        {
            // Handle when your app start
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
