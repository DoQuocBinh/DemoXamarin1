using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        bool flag = true;
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", $"You have entered {userInput}", "OK");


            var myButton = (Button)sender;
            if (flag)
            {
                myButton.Text = "Click me again!";
                myButton.BackgroundColor = Color.Green;
            }
            else
            {
                myButton.Text = "Click me!";
                myButton.BackgroundColor = Color.Orange;
            }
            //true => false; false = >true
            flag = !flag;
                     
        }

        string userInput;
        

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
             userInput = e.NewTextValue;
        }
    }
}
