using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginScreen();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
