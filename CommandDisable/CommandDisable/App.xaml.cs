using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CommandDisable.Services;
using CommandDisable.Views;

namespace CommandDisable
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
