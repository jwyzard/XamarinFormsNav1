using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsNav1
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            // I'll set the app to start in the MainPage that I created in the pages folder
            //MainPage = new Pages.MainPage();
            MainPage = new NavigationPage(new Pages.MainPage());
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
