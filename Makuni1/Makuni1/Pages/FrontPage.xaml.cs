using Makuni1.Models;
using Makuni1.Pages.InfoPages;
using Makuni1.Services;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Makuni1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrontPage : ContentView
    {
        public ObservableCollection<Tuote> SearchTuoteCollection;
        public List<Tuote> tuotteet;
        public FrontPage()
        {
            InitializeComponent();
            SearchTuoteCollection = new ObservableCollection<Tuote>();
            LataaKuvat();
        }



        private async void LataaKuvat()
        {
            SearchTuoteCollection.Clear();
            tuotteet = await ApiService.UusimmatTuotteet();

            VasenYla.Source = Convert.ToString(tuotteet[0].Image);
            
            OikeaYla.Source = Convert.ToString(tuotteet[1].Image);
            
            VasenAla.Source = Convert.ToString(tuotteet[2].Image);
            
            OikeaAla.Source = Convert.ToString(tuotteet[3].Image);
        }



        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new FirstInfo());
        }

        private void TapGestureRecognizer_Tapped0(object sender, EventArgs e)
        {
            
            Navigation.PushModalAsync(new ProductPage(tuotteet[0].Ean));
        }
        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            
            Navigation.PushModalAsync(new ProductPage(tuotteet[1].Ean));
            
        }
        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductPage(tuotteet[2].Ean));
        }
        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductPage(tuotteet[3].Ean));
        }
    }
}