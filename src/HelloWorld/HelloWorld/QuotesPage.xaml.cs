using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class QuotesPage : ContentPage
    {
        List<string> Quotes = new List<string>();
        int index = 0;

        public QuotesPage()
        {
            InitializeComponent();

            Quotes.Add("Few are those who see with their own eyes and feel with their own hearts.");
            Quotes.Add("Imagination is more important than knowledge. Knowledge is limited. Imagination encircles the world.");
            Quotes.Add("Unthinking respect for authority is the greatest enemy of truth.");
            Quotes.Add("Try not to become a man of success, but rather try to become a man of value.");
            Quotes.Add("Great spirits have always ancountered violent opposition from mediocre minds.");

            slider.Value = 16;
            label.Text = Quotes[0];
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            index++;
            int count = Quotes.Count;

            if (index == count - 1)
            {
                label.Text = Quotes[index];
                index = -1;
            }
            else
            {
                label.Text = Quotes[index];
            }
        }
    }
}
