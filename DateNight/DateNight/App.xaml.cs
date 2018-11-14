using Xamarin.Forms;

namespace DateNight
{
    public partial class App : Application
    {
        public static Prices dateNightPrices;

        public App()
        {
            InitializeComponent();

            MainPage = new TabPage();
            dateNightPrices = new Prices();
        }


    }
}
