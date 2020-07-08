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
            List<string> list = new List<string>();
            #region 텍스트
            list.Add("2명 이요");
            list.Add("3명 이요");
            list.Add("4명 이요");
            list.Add("주문 이요");
            list.Add("500cc 하나 주세요");
            list.Add("500cc 두개 주세요");
            list.Add("500cc 세개 주세요");
            list.Add("진로 하나 주세요");
            list.Add("참이슬 하나 주세요");
            list.Add("처음처럼 하나 주세요");

            list.Add("가장 인기 많은게 뭔가요?");
            list.Add("치킨 하나 주세요");
            list.Add("피자 하나 주세요");
            list.Add("골뱅이 소면 주세요");
            list.Add("삼겹살 1인분 주세요");
            list.Add("삼겹살 2인분 주세요");
            list.Add("삼겹살 3인분 주세요");
            list.Add("1인분 추가요");
            list.Add("2인분 추가요");
            list.Add("감자튀김 하나요");
            list.Add("감사 합니다.");
            list.Add("계산 이요");
            #endregion
            listView.ItemsSource = list;

            
        }
        public INavigation nav;
        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string tagContent = e.SelectedItem as string;
            //await nav.PushAsync();

            await Navigation.PushAsync(new NavigationPage(new jumoneyo(tagContent)));


           // DisplayAlert("Selected", tagContent, "OK");
                
        }
    }
}
