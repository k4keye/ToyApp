using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jagiyo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjkxMDg2QDMxMzgyZTMyMmUzMEExM3FXekJiTlh2bmdLTXNVdHAyRW40RGw2TGdzYy9aZXFCYmljRXViYk09");

            MainPage = new NavigationPage(new jagiyo.MainPage());
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
