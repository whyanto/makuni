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
        private int sivuGridKorkeus = 0;
        private int variVaihtuu = 1;
        private int tykkasitkoMaustaPisteet = 3;
        private string tuotteenMakeus = "Makeus on sopiva.";
        private int mtnJatkossaPisteet = 3;
        private int pakkausHelppoAvataPisteet = 3;
        private bool rakenneKuiva = false;
        private bool rakenneJauhoinen = false;
        private bool rakenneRapea = false;
        private bool rakenneRoiskuva = false;
        private bool rakenneIlmava = false;
        private bool rakenneKova = false;
        private bool rakennePehmea = false;
        private bool rakenneHajoava = false;
        private bool rakenneTasainen = false;
        private string mikaKierratys = "Lasi";
        private string entryValmisText = "";
        private int entryValmisLenght = 0;
        public QuestionPage(string ean, string tuotteenNimi)
        {
            InitializeComponent();
            lblProductName.Text = tuotteenNimi;
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
                rakenneKuiva = true;
                imgKuiva.Opacity = 1;
            }
            else
            {
                rakenneKuiva = false;
                imgKuiva.Opacity = 0.5;
            }

        }
        private void TuotteenRakenne2_Tapped(object sender, EventArgs e)
        {
            if (imgJauhoinen.Opacity != 1)
            {
                rakenneJauhoinen = true;
                imgJauhoinen.Opacity = 1;
            }
            else
            {
                rakenneJauhoinen = false;
                imgJauhoinen.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne3_Tapped(object sender, EventArgs e)
        {
            if (imgRapea.Opacity != 1)
            {
                rakenneRapea = true;
                imgRapea.Opacity = 1;
            }
            else
            {
                rakenneRapea = false;
                imgRapea.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne4_Tapped(object sender, EventArgs e)
        {
            if (imgRoiskuva.Opacity != 1)
            {
                rakenneRoiskuva = true;
                imgRoiskuva.Opacity = 1;
            }
            else
            {
                rakenneRoiskuva = false;
                imgRoiskuva.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne5_Tapped(object sender, EventArgs e)
        {
            if (imgIlmava.Opacity != 1)
            {
                rakenneIlmava = true;
                imgIlmava.Opacity = 1;
            }
            else
            {
                rakenneIlmava = false;
                imgIlmava.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne6_Tapped(object sender, EventArgs e)
        {
            if (imgKova.Opacity != 1)
            {
                rakenneKova = true;
                imgKova.Opacity = 1;
            }
            else
            {
                rakenneKova = false;
                imgKova.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne7_Tapped(object sender, EventArgs e)
        {
            if (imgPehmea.Opacity != 1)
            {
                rakennePehmea = true;
                imgPehmea.Opacity = 1;
            }
            else
            {
                rakennePehmea = false;
                imgPehmea.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne8_Tapped(object sender, EventArgs e)
        {
            if (imgHajoava.Opacity != 1)
            {
                rakenneHajoava = true;
                imgHajoava.Opacity = 1;
            }
            else
            {
                rakenneHajoava = false;
                imgHajoava.Opacity = 0.5;
            }
        }
        private void TuotteenRakenne9_Tapped(object sender, EventArgs e)
        {
            if (imgTasainen.Opacity != 1)
            {
                rakenneTasainen = true;
                imgTasainen.Opacity = 1;
            }
            else
            {
                rakenneTasainen = false;
                imgTasainen.Opacity = 0.5;
            }
        }

        private void kierratysScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (kierratysScrollView.ScrollX < 90)
            {
                imgkierratyslasi.Opacity = 1;
                mikaKierratys = "Lasi";
            }
            else
            {
                imgkierratyslasi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 90 && kierratysScrollView.ScrollX < 210)
            {
                imgkierratysmetalli.Opacity = 1;
                mikaKierratys = "Metalli";
            }
            else
            {
                imgkierratysmetalli.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 210 && kierratysScrollView.ScrollX < 330)
            {
                imgkierratysmuovi.Opacity = 1;
                mikaKierratys = "Muovi";
            }
            else
            {
                imgkierratysmuovi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 330 && kierratysScrollView.ScrollX < 450)
            {
                imgkierratyspahvi.Opacity = 1;
                mikaKierratys = "Pahvi";
            }
            else
            {
                imgkierratyspahvi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 450 && kierratysScrollView.ScrollX < 570)
            {
                imgkierratyspaperi.Opacity = 1;
                mikaKierratys = "Paperi";
            }
            else
            {
                imgkierratyspaperi.Opacity = 0.5;
            }

            if (kierratysScrollView.ScrollX >= 570 && kierratysScrollView.ScrollX < 690)
            {
                imgkierratysseka.Opacity = 1;
                mikaKierratys = "Seka";
            }
            else
            {
                imgkierratysseka.Opacity = 0.5;
            }
            lblKierratys.Text = mikaKierratys;
        }

        private void entryValmis_TextChanged(object sender, TextChangedEventArgs e)
        {
            entryValmisLenght = entryValmis.Text.Length;
            lblMerkkejaJaljella.Text = $"Merkkejä jäljellä {50 - entryValmis.Text.Length}/50";
        }
        private void ValmisBtn_Tapped(object sender, EventArgs e)
        {

        }

        private void MakeusLiianvahan_Tapped(object sender, EventArgs e)
        {
            imgMakeusLiianvahan.Opacity = 1;
            imgMakeusSopiva.Opacity = 0.5;
            imgMakeusLiikaa.Opacity = 0.5;
            lblMakeus.Text = "Makeutta on liian vähän.";
            tuotteenMakeus = "Makeutta on liian vähän.";
        }

        private void MakeusSopiva_Tapped(object sender, EventArgs e)
        {
            imgMakeusLiianvahan.Opacity = 0.5;
            imgMakeusSopiva.Opacity = 1;
            imgMakeusLiikaa.Opacity = 0.5;
            lblMakeus.Text = "Makeus on sopiva.";
            tuotteenMakeus = "Makeus on sopiva.";
        }

        private void MakeusLiikaa_Tapped(object sender, EventArgs e)
        {
            imgMakeusLiianvahan.Opacity = 0.5;
            imgMakeusSopiva.Opacity = 0.5;
            imgMakeusLiikaa.Opacity = 1;
            lblMakeus.Text = "Makeutta on liikaa.";
            tuotteenMakeus = "Makeutta on liikaa.";
        }
    }
}