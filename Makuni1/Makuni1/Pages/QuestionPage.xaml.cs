using Makuni1.Models;
using Makuni1.Services;
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
    public partial class QuestionPage : ContentPage
    {
        private string TuotteenEAN = "";
        private int sivuGridKorkeus = 0;
        private int variVaihtuu = 1;
        private int tykkasitkoMaustaPisteet = 3;
        private int tuotteenMakeusPisteet = 2;
        private int mtnJatkossaPisteet = 3;
        private int pakkausHelppoAvataPisteet = 3;
        private int rakenneKuiva = 0;
        private int rakenneJauhoinen = 0;
        private int rakenneRapea = 0;
        private int rakenneRoiskuva = 0;
        private int rakenneIlmava = 0;
        private int rakenneKova = 0;
        private int rakennePehmea = 0;
        private int rakenneHajoava = 0;
        private int rakenneTasainen = 0;
        private int mikaKierratys = 1;      //Lasi,Metalli,Muovi,Pahvi,Paperi,Seka
        private string entryValmisText = "";
        private int entryValmisLenght = 0;
        public QuestionPage(string ean, string tuotteenNimi)
        {
            InitializeComponent();
            lblProductName.Text = tuotteenNimi;
            TuotteenEAN = ean;
        }
        private void EDELLINEN(object sender, SwipedEventArgs e)
        {
            if (sivuGridKorkeus != 0)
            {
                sivuGridKorkeus -= 500;
                Skroll.ScrollToAsync(0, sivuGridKorkeus, true);
                SwitchBackground();
            }
        }

        private void SEURAAVA(object sender, SwipedEventArgs e)
        {
            if (sivuGridKorkeus < 3500)
            {
                sivuGridKorkeus += 500;
                Skroll.ScrollToAsync(0, sivuGridKorkeus, true);
                SwitchBackground();
            }

        }


        private void EDELLINEN(object sender, EventArgs e)
        {
            if (sivuGridKorkeus != 0)
            {
                sivuGridKorkeus -= 500;
                Skroll.ScrollToAsync(0, sivuGridKorkeus, true);
                SwitchBackground();

            }
        }

        private void SEURAAVA(object sender, EventArgs e)
        {

            if (sivuGridKorkeus < 3500)
            {
                sivuGridKorkeus += 500;
                Skroll.ScrollToAsync(0, sivuGridKorkeus, true);
                SwitchBackground();
            }
        }

        private async void SwitchBackground()
        {

            if (sivuGridKorkeus <= 1000 && variVaihtuu != 1)
            {
                lblOsio.Text = "MAKU";
                variVaihtuu = 1;
                await PaaGrid.FadeTo(0.5, 500);
                PaaGrid.BackgroundColor = Xamarin.Forms.Color.FromHex("#FFA500");
                await PaaGrid.FadeTo(1, 1000);

            }
            if (sivuGridKorkeus > 1000 && sivuGridKorkeus <= 2000 && variVaihtuu != 2)
            {
                lblOsio.Text = "RAKENNE";
                variVaihtuu = 2;
                await PaaGrid.FadeTo(0.5, 500);
                PaaGrid.BackgroundColor = Xamarin.Forms.Color.DarkBlue;
                await PaaGrid.FadeTo(1, 1000);

            }
            if (sivuGridKorkeus > 2000 && sivuGridKorkeus <= 3000 && variVaihtuu != 3)
            {
                lblOsio.Text = "PAKKAUS";
                variVaihtuu = 3;
                await PaaGrid.FadeTo(0.6, 500);
                PaaGrid.BackgroundColor = Xamarin.Forms.Color.DarkOliveGreen;
                await PaaGrid.FadeTo(1, 1000);
            }
            if (sivuGridKorkeus > 3000 && variVaihtuu != 4)
            {
                lblOsio.Text = "VALMIS!";
                variVaihtuu = 4;
                await PaaGrid.FadeTo(0.5, 500);
                PaaGrid.BackgroundColor = Xamarin.Forms.Color.FromHex("#FFA500");
                await PaaGrid.FadeTo(1, 1000);
            }
        }

        private async void mtnToimitJatkossaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (mtnToimitJatkossaSlider.Value <= 25 && mtnJatkossaPisteet != 1)
            {
                mtnJatkossaPisteet = 1;
                mtnToimitJatkossaKuva.Opacity = 0;
                mtnToimitJatkossaKuva.Source = "arvostelu1enostajakerronsen1616.png";
                lblMitenToimitJatkossa.Text = "En osta uudelleen ja kehoitan muitakin olemaana ostamatta!";
                await mtnToimitJatkossaKuva.FadeTo(1, 1000);

            }
            if (mtnToimitJatkossaSlider.Value > 25 && mtnToimitJatkossaSlider.Value <= 50 && mtnJatkossaPisteet != 2)
            {
                mtnJatkossaPisteet = 2;
                mtnToimitJatkossaKuva.Opacity = 0;
                mtnToimitJatkossaKuva.Source = "arvostelu2enosta15.png";
                lblMitenToimitJatkossa.Text = "En osta uudelleen.";
                await mtnToimitJatkossaKuva.FadeTo(1, 1000);

            }
            if (mtnToimitJatkossaSlider.Value > 50 && mtnToimitJatkossaSlider.Value <= 75 && mtnJatkossaPisteet != 3)
            {
                mtnJatkossaPisteet = 3;
                mtnToimitJatkossaKuva.Opacity = 0;
                mtnToimitJatkossaKuva.Source = "arvostelu3ostan15.png";
                lblMitenToimitJatkossa.Text = "Voisin ostaa tuotteen uudelleen.";
                await mtnToimitJatkossaKuva.FadeTo(1, 1000);

            }
            if (mtnToimitJatkossaSlider.Value > 75 && mtnJatkossaPisteet != 4)
            {
                mtnJatkossaPisteet = 4;
                mtnToimitJatkossaKuva.Opacity = 0;
                mtnToimitJatkossaKuva.Source = "arvostelu4ostanjasuosittelen16.png";
                lblMitenToimitJatkossa.Text = "Ostan tuotteen uudelleen ja kehoitan muitakin ostamaan sitä!";
                await mtnToimitJatkossaKuva.FadeTo(1, 1000);

            }
        }

        private async void TykkasitkoMaustaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (tykkasitkoMaustaSlider.Value <= 25 && tykkasitkoMaustaPisteet != 1)
            {
                tykkasitkoMaustaPisteet = 1;
                tykkasitkoMaustaKuva.Opacity = 0;
                tykkasitkoMaustaKuva.Source = "arvostelumielipide1.png";
                lblTykkasitkoMausta.Text = "En todellakaan tykännyt!";
                await tykkasitkoMaustaKuva.FadeTo(1, 1000);
            }
            if (tykkasitkoMaustaSlider.Value > 25 && tykkasitkoMaustaSlider.Value <= 50 && tykkasitkoMaustaPisteet != 2)
            {
                tykkasitkoMaustaPisteet = 2;
                tykkasitkoMaustaKuva.Opacity = 0;
                tykkasitkoMaustaKuva.Source = "arvostelumielipide2.png";
                lblTykkasitkoMausta.Text = "En erityisemmin tykännyt.";
                await tykkasitkoMaustaKuva.FadeTo(1, 1000);
            }
            if (tykkasitkoMaustaSlider.Value > 50 && tykkasitkoMaustaSlider.Value <= 75 && tykkasitkoMaustaPisteet != 3)
            {
                tykkasitkoMaustaPisteet = 3;
                tykkasitkoMaustaKuva.Opacity = 0;
                tykkasitkoMaustaKuva.Source = "arvostelumielipide3.png";
                lblTykkasitkoMausta.Text = "Pidin mausta.";
                await tykkasitkoMaustaKuva.FadeTo(1, 1000);
            }
            if (tykkasitkoMaustaSlider.Value > 75 && tykkasitkoMaustaPisteet != 4)
            {
                tykkasitkoMaustaPisteet = 4;
                tykkasitkoMaustaKuva.Opacity = 0;
                tykkasitkoMaustaKuva.Source = "arvostelumielipide4.png";
                lblTykkasitkoMausta.Text = "Pidin todella paljon mausta!";
                await tykkasitkoMaustaKuva.FadeTo(1, 1000);

            }
        }

        private async void pakkausHelppoAvataSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (pakkausHelppoAvataSlider.Value <= 25 && pakkausHelppoAvataPisteet != 1)
            {
                pakkausHelppoAvataPisteet = 1;
                pakkausHelppoAvata.Opacity = 0;
                pakkausHelppoAvata.Source = "arvostelumielipide1.png";
                lblPakkausHelppoAvata.Text = "Pakkaus oli erittäin vaikea avata!";
                await pakkausHelppoAvata.FadeTo(1, 1000);
            }
            if (pakkausHelppoAvataSlider.Value > 25 && pakkausHelppoAvataSlider.Value <= 50 && pakkausHelppoAvataPisteet != 2)
            {
                pakkausHelppoAvataPisteet = 2;
                pakkausHelppoAvata.Opacity = 0;
                pakkausHelppoAvata.Source = "arvostelumielipide2.png";
                lblPakkausHelppoAvata.Text = "Pakkaus oli vaikea avata.";
                await pakkausHelppoAvata.FadeTo(1, 1000);
            }
            if (pakkausHelppoAvataSlider.Value > 50 && pakkausHelppoAvataSlider.Value <= 75 && pakkausHelppoAvataPisteet != 3)
            {
                pakkausHelppoAvataPisteet = 3;
                pakkausHelppoAvata.Opacity = 0;
                pakkausHelppoAvata.Source = "arvostelumielipide3.png";
                lblPakkausHelppoAvata.Text = "Pakkaus oli helppo avata.";
                await pakkausHelppoAvata.FadeTo(1, 1000);
            }
            if (pakkausHelppoAvataSlider.Value > 75 && pakkausHelppoAvataPisteet != 4)
            {
                pakkausHelppoAvataPisteet = 4;
                pakkausHelppoAvata.Opacity = 0;
                pakkausHelppoAvata.Source = "arvostelumielipide4.png";
                lblPakkausHelppoAvata.Text = "Pakkaus oli erittäine helppo avata!";
                await pakkausHelppoAvata.FadeTo(1, 1000);
            }
        }

        private void TuotteenRakenne1_Tapped(object sender, EventArgs e)
        {
            if (imgKuiva.Opacity != 1)
            {
                rakenneKuiva = 1;
                imgKuiva.Opacity = 1;
            }
            else
            {
                rakenneKuiva = 0;
                imgKuiva.Opacity = 0.5;
            }

        }
        private void TuotteenRakenne2_Tapped(object sender, EventArgs e)
        {
            if (imgJauhoinen.Opacity != 1)
            {
                rakenneJauhoinen = 1;
                imgJauhoinen.Opacity = 1;
            }
            else
            {
                rakenneJauhoinen = 0;
                imgJauhoinen.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne3_Tapped(object sender, EventArgs e)
        {
            if (imgRapea.Opacity != 1)
            {
                rakenneRapea = 1;
                imgRapea.Opacity = 1;
            }
            else
            {
                rakenneRapea = 0;
                imgRapea.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne4_Tapped(object sender, EventArgs e)
        {
            if (imgRoiskuva.Opacity != 1)
            {
                rakenneRoiskuva = 1;
                imgRoiskuva.Opacity = 1;
            }
            else
            {
                rakenneRoiskuva = 0;
                imgRoiskuva.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne5_Tapped(object sender, EventArgs e)
        {
            if (imgIlmava.Opacity != 1)
            {
                rakenneIlmava = 1;
                imgIlmava.Opacity = 1;
            }
            else
            {
                rakenneIlmava = 0;
                imgIlmava.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne6_Tapped(object sender, EventArgs e)
        {
            if (imgKova.Opacity != 1)
            {
                rakenneKova = 1;
                imgKova.Opacity = 1;
            }
            else
            {
                rakenneKova = 0;
                imgKova.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne7_Tapped(object sender, EventArgs e)
        {
            if (imgPehmea.Opacity != 1)
            {
                rakennePehmea = 1;
                imgPehmea.Opacity = 1;
            }
            else
            {
                rakennePehmea = 0;
                imgPehmea.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne8_Tapped(object sender, EventArgs e)
        {
            if (imgHajoava.Opacity != 1)
            {
                rakenneHajoava = 1;
                imgHajoava.Opacity = 1;
            }
            else
            {
                rakenneHajoava = 0;
                imgHajoava.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne9_Tapped(object sender, EventArgs e)
        {
            if (imgTasainen.Opacity != 1)
            {
                rakenneTasainen = 1;
                imgTasainen.Opacity = 1;
            }
            else
            {
                rakenneTasainen = 0;
                imgTasainen.Opacity = 0.5;
            }
        }

        private void kierratysScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (kierratysScrollView.ScrollX < 90)
            {
                imgkierratyslasi.Opacity = 1;
                lblKierratys.Text = "Lasi";
                mikaKierratys = 1;
            }
            else
            {
                imgkierratyslasi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 90 && kierratysScrollView.ScrollX < 210)
            {
                imgkierratysmetalli.Opacity = 1;
                lblKierratys.Text = "Metalli";
                mikaKierratys = 2;
            }
            else
            {
                imgkierratysmetalli.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 210 && kierratysScrollView.ScrollX < 330)
            {
                imgkierratysmuovi.Opacity = 1;
                lblKierratys.Text = "Muovi";
                mikaKierratys = 3;
            }
            else
            {
                imgkierratysmuovi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 330 && kierratysScrollView.ScrollX < 450)
            {
                imgkierratyspahvi.Opacity = 1;
                lblKierratys.Text = "Pahvi";
                mikaKierratys = 4;
            }
            else
            {
                imgkierratyspahvi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 450 && kierratysScrollView.ScrollX < 570)
            {
                imgkierratyspaperi.Opacity = 1;
                lblKierratys.Text = "Paperi";
                mikaKierratys = 5;
            }
            else
            {
                imgkierratyspaperi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 570 && kierratysScrollView.ScrollX < 690)
            {
                imgkierratysseka.Opacity = 1;
                lblKierratys.Text = "Seka";
                mikaKierratys = 6;
            }
            else
            {
                imgkierratysseka.Opacity = 0.5;
            }
        }

        private void entryValmis_TextChanged(object sender, TextChangedEventArgs e)
        {
            entryValmisLenght = entryValmis.Text.Length;
            lblMerkkejaJaljella.Text = $"Merkkejä jäljellä {50 - entryValmis.Text.Length}/50";
        }
        

        private void MakeusLiianvahan_Tapped(object sender, EventArgs e)
        {
            imgMakeusLiianvahan.Opacity = 1;
            imgMakeusSopiva.Opacity = 0.5;
            imgMakeusLiikaa.Opacity = 0.5;
            lblMakeus.Text = "Makeutta on liian vähän.";
            tuotteenMakeusPisteet = 1;
        }

        private void MakeusSopiva_Tapped(object sender, EventArgs e)
        {
            imgMakeusLiianvahan.Opacity = 0.5;
            imgMakeusSopiva.Opacity = 1;
            imgMakeusLiikaa.Opacity = 0.5;
            lblMakeus.Text = "Makeus on sopiva.";
            tuotteenMakeusPisteet = 2;
        }

        private void MakeusLiikaa_Tapped(object sender, EventArgs e)
        {
            imgMakeusLiianvahan.Opacity = 0.5;
            imgMakeusSopiva.Opacity = 0.5;
            imgMakeusLiikaa.Opacity = 1;
            lblMakeus.Text = "Makeutta on liikaa.";
            tuotteenMakeusPisteet = 3;
        }
        private async void ValmisBtn_Tapped(object sender, EventArgs e)
        {
            Arvostelu arvostelu = new Arvostelu(TuotteenEAN,tykkasitkoMaustaPisteet,tuotteenMakeusPisteet,mtnJatkossaPisteet,
                                                pakkausHelppoAvataPisteet,rakenneKuiva,rakenneRoiskuva,rakenneIlmava,
                                                rakenneKova,rakennePehmea,rakenneHajoava,rakenneTasainen,mikaKierratys,entryValmisText);
            bool response = await ApiService.LahetaArvostelu(arvostelu);

            if(response != true)
            {
                await DisplayAlert("Oho!", "Jokin meni vikaan =(", "Ok");
            }
            else
            {
                await DisplayAlert("Jippii!", "Kiitos palautteesta", "Ok");
            }
        }
    }
}