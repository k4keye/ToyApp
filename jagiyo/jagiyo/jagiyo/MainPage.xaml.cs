using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jagiyo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<itemss> items = new List<itemss>();
            #region 텍스트
            items.Add(new itemss() { value= "2명 이요"});
            items.Add(new itemss() { value= "3명 이요"});
            items.Add(new itemss() { value= "4명 이요"});
            items.Add(new itemss() { value= "주문 이요"});
            items.Add(new itemss() { value= "500cc 하나 주세요"});
            items.Add(new itemss() { value= "500cc 두개 주세요"});
            items.Add(new itemss() { value= "500cc 세개 주세요"});
            items.Add(new itemss() { value= "진로 하나 주세요"});
            items.Add(new itemss() { value= "참이슬 하나 주세요"});
            items.Add(new itemss() { value= "처음처럼 하나 주세요"});

            items.Add(new itemss() { value= "가장 인기 많은게 뭔가요?"});
            items.Add(new itemss() { value= "치킨 하나 주세요"});
            items.Add(new itemss() { value= "피자 하나 주세요"});
            items.Add(new itemss() { value= "골뱅이 소면 주세요"});
            items.Add(new itemss() { value= "삼겹살 1인분 주세요"});
            items.Add(new itemss() { value= "삼겹살 2인분 주세요"});
            items.Add(new itemss() { value= "삼겹살 3인분 주세요"});
            items.Add(new itemss() { value= "1인분 추가요"});
            items.Add(new itemss() { value= "2인분 추가요"});
            items.Add(new itemss() { value= "감자튀김 하나요"});
            items.Add(new itemss() { value= "감사 합니다."});
            items.Add(new itemss() { value= "계산 이요"});
            #endregion

            listView.ItemsSource = items;
            NavigationPage.SetHasNavigationBar(this, false);

        }
        public INavigation nav;
        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DependencyService.Get<IOrientationHandler>().ForceLandscape();
            //텍스트 눌렀을때
            string tagContent = e.SelectedItem as string;
            //await nav.PushAsync();

            var page = new jumoneyo(tagContent);

            await Navigation.PushModalAsync(new NavigationPage(page));


            // DisplayAlert("Selected", tagContent, "OK");

        }

        

    }

    public class itemss
    {
     public   string value;
    }
}
