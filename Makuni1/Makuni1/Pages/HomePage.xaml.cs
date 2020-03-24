using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Makuni1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void TapMakuni_Tapped(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new FrontPage());
        }

        private void TapProfile_Tapped(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProfilePage());
            
        }
        public HomePage(int arvo)
        {
            InitializeComponent();
            CurrentPage = Children[arvo];
        }
    }
}