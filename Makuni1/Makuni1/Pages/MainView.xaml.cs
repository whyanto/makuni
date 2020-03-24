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
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            SelectButton("Button1");
        }


        void SelectButton(string button)
        {
            
            ScannerView.IsVisible = false;
            FeedbackView.IsVisible = false;
            FrontView.IsVisible = false;
            ProfileView.IsVisible = false;
            SearchView.IsVisible = false;

            View view = null;
            if (button == "Button1")
                view = FrontView;
            if (button == "Button2")
                view = ProfileView;
            if (button == "Button3")
                view = ScannerView;
            if (button == "Button4")
                view = SearchView;
            if (button == "Button5")
                view = FeedbackView;

            FrontView.IsVisible = FrontView == view;
            ProfileView.IsVisible = ProfileView == view;
            ScannerView.IsVisible = ScannerView == view;
            SearchView.IsVisible = SearchView == view;
            FeedbackView.IsVisible = FeedbackView == view;

        }
        

        private void Button1_Clicked(object sender, EventArgs e)
        {
            SelectButton("Button1");
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            SelectButton("Button2");
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            SelectButton("Button3");
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            SelectButton("Button4");
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            SelectButton("Button5");
        }
    }
}