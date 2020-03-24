using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Makuni1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentView
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void TapMakuniProfilePage_Tapped(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new FrontPage());
        }

        private void btnProfilepageBarcode_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ScannerPage());
        }

        private void btnProfilepageSearch_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SearchPage());
        }

        private void btnProfilepageFeedback_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new FeedbackPage());
        }
    }
}