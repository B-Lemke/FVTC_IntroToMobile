using Xamarin.Forms;
using System.Collections.Generic;

namespace DistanceConverter
{
    public partial class DistanceConverterPage : ContentPage
    {

        public DistanceConverterPage()
        {
            InitializeComponent();


            DistanceConverter feetToMeters = new DistanceConverter
            {
                Title = "Convert Feet to Meters",
                StartUnit = "Feet",
                EndUnit = "Meters",
                ConverterDelegate = f => f / 3.281
            };

            DistanceConverter metersToFeet = new DistanceConverter
            {
                Title = "Convert Meters to Feet",
                StartUnit = "Meters",
                EndUnit = "Feet",
                ConverterDelegate = m => m * 3.281
            };


            List<DistanceConverter> distConverters = new List<DistanceConverter>();
            distConverters.Add(feetToMeters);
            distConverters.Add(metersToFeet);
            DistanceCarousel.ItemsSource = distConverters;
        }


    }
}
