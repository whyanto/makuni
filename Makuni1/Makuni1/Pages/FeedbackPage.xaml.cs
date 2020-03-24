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
    public partial class FeedbackPage : ContentView
    {
        public FeedbackPage()
        {
            InitializeComponent();
        }

        private void TapMakuniFeedbackPage_Tapped(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new FrontPage());
        }

        private void TapProfileFeedbackPage_Tapped(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProfilePage());
        }

        private void btnFeedbackpageBarcode_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ScannerPage());
        }

        private void btnFeedbackpageSearch_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SearchPage());
        }

        private void btnFeedbackpageFeedback_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new FeedbackPage());
        }
    }
}