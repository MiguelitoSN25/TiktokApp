using System;
using TiktokApp.Services;
using TiktokApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TiktokApp.Views;

namespace TiktokApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Reproductor();
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
