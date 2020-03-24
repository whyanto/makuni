using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Makuni1.Pages.InfoPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondInfo : PopupPage
    {
        public SecondInfo()
        {
            InitializeComponent();
        }
        [Obsolete]
        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.RemovePageAsync(this);
            PopupNavigation.PushAsync(new FirstInfo());


        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }

        [Obsolete]
        private void SwipedRight(object sender, SwipedEventArgs e)
        {
            PopupNavigation.RemovePageAsync(this);
            PopupNavigation.PushAsync(new FirstInfo());

        }
    }
}