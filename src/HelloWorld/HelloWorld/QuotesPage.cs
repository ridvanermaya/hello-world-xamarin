using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

