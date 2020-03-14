using CursoMobile.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoMobile
{
    public partial class App : Application
    {
        public static INavigation Navigation;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListUserPage());

            Navigation = MainPage.Navigation;
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
