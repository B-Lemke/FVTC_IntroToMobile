using Xamarin.Forms;

namespace GPS
{
    public partial class GPSPage : ContentPage
    {
        public GPSPage()
        {
            InitializeComponent();

            this.LocationService = DependencyService.Get<ILocationService>();
        }

        public ILocationService LocationService { get; }


        async void HandleGetLocation(object sender, System.EventArgs e)
        {

            var location = await LocationService.GetLocationAsync();

            this.btnGetLocation.IsEnabled = false;

            this.BindingContext = location;

            this.btnGetLocation.IsEnabled = true;
        }


        void ResetClicked(object sender, System.EventArgs e)
        {
            this.BindingContext = null;
            this.btnReset.IsEnabled = false;
        }
    }
}
