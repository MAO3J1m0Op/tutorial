using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TUTORial
{
    public partial class LearningExercisePage : ContentPage
    {
        private readonly string[] quotes =
        {
            "your", "text", "goes", "here"
        };
        private int quoteIndex = 0;

        public LearningExercisePage()
        {
            InitializeComponent();

            quoteLabel.Text = quotes[0];
        }

        void CycleText(object sender, EventArgs e)
        {
            ++quoteIndex;
            if (quoteIndex >= quotes.Length) quoteIndex = 0;

            quoteLabel.Text = quotes[quoteIndex];
        }
    }
}
