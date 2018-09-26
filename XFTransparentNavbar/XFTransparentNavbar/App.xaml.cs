using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFTransparentNavbar.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFTransparentNavbar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigation(new TransparentNavbarView());
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
