using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageAlerm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
          
        }

       
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await img.ScaleTo(1, 1200); //기본상태 1.5초
            await img.ScaleTo(0.9, 1300, Easing.Linear);//축소 1.3초간
            await img.ScaleTo(150, 100, Easing.Linear);//확대 0.1 초간

            Application.Current.MainPage = new NavigationPage(new AlermPage());

        }


    }

}