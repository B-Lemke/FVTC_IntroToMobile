using System;
using Xamarin.Forms;
namespace DateNight
{
    public class Prices
    {
        //declare variables
        private string coffeePrice = String.Empty;
        private string dinnerPrice = String.Empty;
        private string moviePrice = String.Empty;

        public string CoffeePrice{
            get { return coffeePrice; }
            set { coffeePrice = value; }
        }

        public string DinnerPrice{
            get { return DinnerPrice; }
            set { dinnerPrice = value; }
        }

        public string MoviePrice{
            get { return moviePrice; }
            set { moviePrice = value; }
        }

        public decimal GetTotalCost(){
            //return the three prices added together

            decimal dcmlCoffeePrice, dcmlDinnerPrice, dcmlMoviePrice;

            if(!decimal.TryParse(coffeePrice, out dcmlCoffeePrice)){
                //failed parse, throw exception
                throw new Exception("Invalid Coffee Cost");
            }

            if (!decimal.TryParse(dinnerPrice, out dcmlDinnerPrice)){
                //failed parse, throw exception
                throw new Exception("Invalid Dinner Cost");
            }

            if (!decimal.TryParse(moviePrice, out dcmlMoviePrice)){
                //failed parse, throw exception
                 throw new Exception("Invalid Movie Cost");
            }


            return dcmlMoviePrice + dcmlCoffeePrice + dcmlDinnerPrice;
        }

    }
}
