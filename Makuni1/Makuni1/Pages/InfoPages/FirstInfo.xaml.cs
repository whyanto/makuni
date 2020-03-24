using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Makuni1.Pages.InfoPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstInfo : PopupPage
    {
        public FirstInfo()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.RemovePageAsync(this);
            PopupNavigation.PushAsync(new SecondInfo());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }

        [Obsolete]
        private void SwipedLeft(object sender, SwipedEventArgs e)
        {
            PopupNavigation.RemovePageAsync(this);
            PopupNavigation.PushAsync(new SecondInfo());
        }
    }
}