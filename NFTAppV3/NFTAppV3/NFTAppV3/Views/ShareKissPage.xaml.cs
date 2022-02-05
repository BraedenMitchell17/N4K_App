using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShareKissPage : ContentPage
    {
        public ShareKissPage(string duration, string type)
        {
            InitializeComponent();
            lblDuration.Text = "Duration: " + duration;
            KissType.Text = type;
        }

        async void OnNextPageButtonClickedConfirm(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShareConfirmPage());
        }

        async void OnNextPageButtonClickedBack(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new KissPage());
        }
    }
}