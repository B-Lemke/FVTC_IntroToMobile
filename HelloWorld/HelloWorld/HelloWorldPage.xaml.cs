using Xamarin.Forms;
using System;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        //Global Vars
        bool switched = false;

        public HelloWorldPage()
        {
            InitializeComponent();
        }

        public void HandleButtonClick(object sender, System.EventArgs e)
        {
            if (switched == false)
            {
                ChangingLabel.Text = "💯💯👌😂👌💯💯";
                ButtonChanging.Text = "Oh god, please stop the emojis";
            }
            else
            {
                ChangingLabel.Text = "No more emojis, woooooo";
                ButtonChanging.Text = "Show trashy emojis";
            }
            //Change switched variable
            switched = !switched;
        }

        //Testing version control
    }
}
