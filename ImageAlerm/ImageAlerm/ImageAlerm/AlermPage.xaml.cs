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
        public AlermPage()
        {
            InitializeComponent();
        }

      

        private async void OnLabelClicked(object sender, EventArgs e)
        {
            try
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
            }
            
        }
    }
}