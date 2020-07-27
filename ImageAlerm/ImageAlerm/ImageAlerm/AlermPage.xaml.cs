using ImageAlerm.ViewModel;
using Plugin.Media;
using Plugin.Media.Abstractions;
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
    public partial class AlermPage : ContentPage
    {
        AlermListDataViewModel AlermListDataViewModel = new AlermListDataViewModel();
        public AlermPage()
        {
            InitializeComponent();
            listview.ItemsSource = AlermListDataViewModel.AlermListDataModel;
        }

      

        private async void OnLabelClicked(object sender, EventArgs e)
        {
            #region 카메라 구현 코드
            /* try
             {
                 if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                 {
                     await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                     return;
                 }
                 var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                 {
                     Directory = "Sample",
                     Name = "test.jpg"
                 });
                 if (file == null)
                     return;
                 await DisplayAlert("File Location", file.Path, "OK");
                 AlermImg.Source = ImageSource.FromStream(() =>
                 {
                     var stream = file.GetStream();
                     file.Dispose();
                     return stream;
                 });
             }
             catch(Exception ee)
             {
                 System.Diagnostics.Debug.WriteLine("---> "+ ee.Message);
             }*/
            #endregion

            AlermListDataViewModel.AlermListDataModel.Add(new Model.AlermListDataModel()
            {
                aM_PMFlag = "오전",
                alermDay="월요일",
                alermTime="16시"
            });
            AlermListDataViewModel.AlermListDataModel.Add(new Model.AlermListDataModel()
            {
                aM_PMFlag = "오후",
                alermDay = "월요일",
                alermTime = "16시"
            });
            AlermListDataViewModel.AlermListDataModel.Add(new Model.AlermListDataModel()
            {
                aM_PMFlag = "오전",
                alermDay = "화요일",
                alermTime = "16시"
            });


        }
    }
}