using System;
using Xamarin.Forms;

namespace Calculator
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            int numberOne, numberTwo;
            //clear result labels
            lblDisplay.Text = String.Empty;
            lblDisplayNum.Text = String.Empty;

            if (int.TryParse(txtNumberOne.Text, out numberOne))
            {
                if (int.TryParse(txtNumberTwo.Text, out numberTwo))
                {
                    //Both numbers parse successfully. 
                    int sum = numberOne + numberTwo;

                    if (sum >= 0)
                    { //Make sure that the number is greater than 0 
                        string binaryNumber = Convert.ToString(sum, 2);
                        string output = string.Empty;

                        foreach (char bit in binaryNumber)
                        {
                            string addChar;

                            if (bit == '1')
                            {
                                addChar = "😂";
                            }
                            else
                            {
                                addChar = "💦";
                            }

                            output += addChar;

                        }

                        lblDisplay.Text = output;
                        lblDisplayNum.Text = "(" + sum.ToString() + ")";
                    }
                    else
                    {
                        lblDisplayNum.Text = "The result is not a positive number";
                    }

                }
                else
                {
                    //bad second number
                    lblDisplay.Text = "Second number must be numeric.";
                }
            }
            else
            {
                //Bad first number
                lblDisplay.Text = "First number must be numeric.";

            }
        }

    }
}
