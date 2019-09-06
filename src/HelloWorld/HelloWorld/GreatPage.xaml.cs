using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreatPage : ContentPage
    {
        public GreatPage()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "Ok");
        }
    }
}