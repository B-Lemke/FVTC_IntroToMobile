using System.Collections.Generic;
using Xamarin.Forms;

namespace OverwatchHeroPicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OverwatchHeroPickerPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            base.OnStart();
            

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        Heroes testing = new Heroes();


    }
}
