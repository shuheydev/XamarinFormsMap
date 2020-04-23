using System;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;

namespace XamarinFormsMap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            var a = new XamarinFormsMap.MainPage();
            a
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
