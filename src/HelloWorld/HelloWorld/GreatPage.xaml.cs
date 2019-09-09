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

            slider.Value = 0.5;
        }

        //private void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format($"Value is {e.NewValue:F2}");
        //}
    }
}