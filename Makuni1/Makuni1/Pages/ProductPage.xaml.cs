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
    public partial class ProductPage : ContentPage
    {
        public ObservableCollection<Allergeeni> SearchTuoteCollection;
        private string Ean;
        public ProductPage(string ean)
        {
            InitializeComponent();
            Ean = ean;
            SearchTuoteCollection = new ObservableCollection<Allergeeni>();
            GetProductDetails(ean);
            HaeTuotteenAllergeenit(ean);
        }

        private async void GetProductDetails(string ean)
        {
            var a = await ApiService.HaeTuoteEan(ean);
            ProductName.Text = a[0].Name;
            ProductCategory.Text = a[0].Category;
            ProductImage.Source = a[0].Image;
        }
        private async void HaeTuotteenAllergeenit(string ean)
        {
            var a = await ApiService.HaeTuotetteenAllergeenit(ean);
            
            string allergialista1 = LvOnAllergiaa.Height.ToString();
            string grid1 = AllergeeniGrid.Height.ToString();
            foreach (var allergeeni in a)
            {   
                if(allergeeni.Arvo == "2")
                {
                    SearchTuoteCollection.Add(allergeeni);
                }
                
            }
            
            LvOnAllergiaa.ItemsSource = SearchTuoteCollection;
            string allergialista2 = LvOnAllergiaa.Height.ToString();
            LvOnAllergiaa.HeightRequest = int.Parse(allergialista2);
            
            string grid2 = AllergeeniGrid.Height.ToString();
        }

        private void ArvosteleTuote_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuestionPage(Ean ,ProductName.Text));
        }
    }
}