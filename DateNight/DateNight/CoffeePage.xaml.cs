using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight
{
    public partial class CoffeePage : ContentPage
    {
        public CoffeePage()
        {
            InitializeComponent();

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateNightPrices.CoffeePrice = txtCoffeePrice.Text;
        }
    }
}
