using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageAlerm
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk0MzMxQDMxMzgyZTMyMmUzMEk1cS80TEU0MVRxYkFuNVNxY29Qa3VBeVNGUkVtVGUyRy92RXVQanlMSjA9");
            
            InitializeComponent();
            //MainPage = new NavigationPage(new WelcomePage());
            MainPage = new NavigationPage(new AlermPage());
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
