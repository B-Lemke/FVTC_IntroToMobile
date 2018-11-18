using System;
using Xamarin.Forms;
using System.Net.Http;

using Maraton.data;
using Newtonsoft.Json;

namespace Maraton
{
    public partial class MaratonPage : ContentPage
    {
        RaceCollection RacesObject;
        ResultsCollection ResultsObject;

        public MaratonPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            FillPicker();
        }

        private void FillPicker()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://itweb.fvtc.edu/wetzel/marathon/");
            var response = client.GetAsync("races/").Result;
            var wsJson = response.Content.ReadAsStringAsync().Result;

            RacesObject = JsonConvert.DeserializeObject<RaceCollection>(wsJson);

            if (RacesObject != null){
                this.RacePicker.Items.Clear();
                foreach (race CurrentRace in RacesObject.races){
                    RacePicker.Items.Add(CurrentRace.race_name);
                }

            }

        }

        void Race_Changed(object sender, System.EventArgs e)
        {
            var SelectedRace = ((Xamarin.Forms.Picker)sender).SelectedIndex;
            var race_id = RacesObject.races[SelectedRace].id;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://itweb.fvtc.edu/wetzel/marathon/");
            var response = client.GetAsync("results/" + race_id).Result;
            var wsJson = response.Content.ReadAsStringAsync().Result;

            ResultsObject = JsonConvert.DeserializeObject<ResultsCollection>(wsJson);

            var CellTemplate = new DataTemplate(typeof(TextCell));
            CellTemplate.SetBinding(TextCell.TextProperty, "name");
            CellTemplate.SetBinding(TextCell.DetailProperty, "detail");
            ResultsListView.ItemTemplate = CellTemplate;

            ResultsListView.ItemsSource = ResultsObject.results;
        }
    }
}
