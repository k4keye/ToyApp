using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jagiyo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jumoneyo : ContentPage
    {
        public jumoneyo(string text)
        {
            InitializeComponent();


            Order.Text = text;
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {

        }
    }
}