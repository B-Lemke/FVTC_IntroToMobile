using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight
{
    public partial class TotalPage : ContentPage
    {
        public TotalPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing(){
            base.OnAppearing();

            //clear display label
            lblTotal.Text = String.Empty;

            decimal totalCost;

            try
            {
                //try to calculate the cost
                totalCost = App.dateNightPrices.GetTotalCost();

                //set the label to the cost if it was calculated
                lblTotal.Text = totalCost.ToString("c");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
