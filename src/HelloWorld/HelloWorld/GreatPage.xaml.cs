﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreatPage : ContentPage
    {

        //[Obsolete]
        public GreatPage()
        {
            InitializeComponent();

            //slider.Value = 0.5;

            //var x = new OnPlatform<Thickness>
            //{
            //    Android = new Thickness(0),
            //    iOS = new Thickness(0, 20, 0, 0)
            //};

            //Padding = x;

            //if (Device.OS == TargetPlatform.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}

            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(10, 20, 0, 0),
            //    WinPhone: new Thickness(30, 20, 0, 0)
            //);

            //Device.OnPlatform(
            //    iOS: () => {
            //        Padding = new Thickness(0, 20, 0, 0);
            //    },
            //    Android: () => {
            //        // your code
            //    });
        }

        //private void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format($"Value is {e.NewValue:F2}");
        //}
    }
}
