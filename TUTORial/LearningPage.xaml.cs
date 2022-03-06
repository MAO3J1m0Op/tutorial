using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TUTORial
{
    public partial class LearningPage : ContentPage
    {
        public LearningPage()
        {
            InitializeComponent();
            slider.Value = 0.5;
        }

        void Cringe(object sender, EventArgs e)
        {
            DisplayAlert("Bruh", "Cringe", "ok.");
        }

        void ResetSlider(object sender, EventArgs e)
        {
            slider.Value = 0.5;
        }
    }
}
