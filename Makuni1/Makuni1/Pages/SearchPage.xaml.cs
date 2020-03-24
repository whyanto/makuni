using Makuni1.Models;
using Makuni1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Makuni1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentView
    {
        public ObservableCollection<Tuote> SearchTuoteCollection;
        public List<Tuote> tuotteet;
        public int pituus = 0;
        public SearchPage()
        {
            InitializeComponent();
            SearchTuoteCollection = new ObservableCollection<Tuote>();
        }

        private async void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchTuoteCollection.Clear();
            tuotteet = await ApiService.HaeTuote(e.NewTextValue);
            if(tuotteet.Count == 0)
            {
                EtsiTuotteita.IsVisible = true;
            }

            else 
            {
                EtsiTuotteita.IsVisible = false;
                foreach (var tuote in tuotteet)
                {
                    SearchTuoteCollection.Add(tuote);
                }
            }
            LvSearch.HeightRequest = tuotteet.Count * 91;
            tuotteet.Clear();
            LvSearch.ItemsSource = SearchTuoteCollection;
        }

        private void LvSearch_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedVehicle = e.SelectedItem as Tuote;
            if (selectedVehicle != null)
            {
                Navigation.PushModalAsync(new ProductPage(selectedVehicle.Ean));
                
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}