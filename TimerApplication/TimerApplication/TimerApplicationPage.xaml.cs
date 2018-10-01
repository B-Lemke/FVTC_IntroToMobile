using Xamarin.Forms;
using System;

namespace TimerApplication
{
    public partial class TimerApplicationPage : ContentPage
    {
        //Modular Variables
        TimeSpan updateInterval = TimeSpan.FromSeconds(1);
        bool timerIncreasing = false;
        int hour, min, sec = 0;

        public TimerApplicationPage()
        {
            InitializeComponent();

            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
        }

        bool updateTimer()
        {

            sec++;

            //check is there are too many seconds
            if (sec == 60)
            {
                sec = 0;
                min++;
                //check if there are too many minutes
                if (min == 60)
                {
                    min = 0;
                    hour++;
                }
            }

            //prevent from updating if it has been stopped
            if (timerIncreasing)
            {
                displayTime(hour, min, sec);
            }

            //variable controlled by outside button clicks
            return timerIncreasing;
        }

        void startTimer(object sender, System.EventArgs e)
        {
            //Set timer to increase if not stopped
            timerIncreasing = true;

            displayTime(hour, min, sec);

            Device.StartTimer(updateInterval, updateTimer);

            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
        }


        void stopTimer(object sender, System.EventArgs e)
        {
            //stop the increasing variabl which is used returned in the update timer method
            timerIncreasing = false;

            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
        }

        void resetTimer(object sender, System.EventArgs e)
        {
            //stop if running and reset text
            timerIncreasing = false;
            lblTimeDisplay.Text = "0️⃣0️⃣:0️⃣0️⃣:0️⃣0️⃣";

            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

            //reset time variables
            sec = 0;
            min = 0;
            hour = 0;
        }

        void displayTime(int hour, int min, int sec)
        {
            string hourString = hour.ToString();
            string minString = min.ToString();
            string secString = sec.ToString();


            //add preceeding 0s if necessary
            if (hourString.Length == 1)
                hourString = "0" + hourString;
            if (minString.Length == 1)
                minString = "0" + minString;
            if (secString.Length == 1)
                secString = "0" + secString;

            hourString = emojify(hourString);
            minString = emojify(minString);
            secString = emojify(secString);

            lblTimeDisplay.Text = hourString + ":" + minString + ":" + secString;
        }

        string emojify(string timeUnit){
            string emojifiedString = string.Empty;

            foreach(char curChar in timeUnit){
                switch(curChar){
                    case '0':
                        emojifiedString += "0️⃣";
                        break;
                    case '1':
                        emojifiedString += "1️⃣";
                        break;
                    case '2':
                        emojifiedString += "2️⃣";
                        break;
                    case '3':
                        emojifiedString += "3️⃣";
                        break;
                    case '4':
                        emojifiedString += "4️⃣";
                        break;
                    case '5':
                        emojifiedString += "5️⃣";
                        break;
                    case '6':
                        emojifiedString += "6️⃣";
                        break;
                    case '7':
                        emojifiedString += "7️⃣";
                        break;
                    case '8':
                        emojifiedString += "8️⃣";
                        break;
                    case '9':
                        emojifiedString += "9️⃣";
                        break;
                }
            }
            return emojifiedString;
        }
    }
}

