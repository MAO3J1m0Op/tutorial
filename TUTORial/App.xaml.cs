using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TUTORial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var rootPage = new LearningPage();
            var navPage = new NavigationPage(rootPage);

            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
