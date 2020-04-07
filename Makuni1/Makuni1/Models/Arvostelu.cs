using System;
using System.Collections.Generic;
using System.Text;

namespace Makuni1.Models
{
    public class Arvostelu
    {
        public string EAN { get; set; }
        public int TykkasitkoMausta { get; set; }
        public int TuotteenMakeus { get; set; }
        public int ToimitJatkossa { get; set; }
        public int PakkausenAvaaminen { get; set; }
        public int RakenneKuiva { get; set; }
        public int RakenneJauhoinen { get; set; }
        public int RakenneRapea { get; set; }
        public int RakenneRoiskuva { get; set; }
        public int RakenneIlmava { get; set; }
        public int RakenneKova { get; set; }
        public int RakennePehmea { get; set; }
        public int RakenneHajoava { get; set; }
        public int RakenneTasainen { get; set; }
        public int MikaKierratys { get; set; }     //Lasi,Metalli,Muovi,Pahvi,Paperi,Seka
        public string Kommentti { get; set; }

        public Arvostelu(string ean, int tykkasitkomausta, int tuotteenmakeus, int toimitjatkossa, int pakkauksenavaaminen, 
            int rakennekuiva, int rakenneroiskuva, int rakenneilmava, int rakennekova, int rakennepehmea, int rakennehajoava, 
            int rakennetasainen, int mikakierratys, string kommentti)
        {
            EAN = ean;
            TykkasitkoMausta = tykkasitkomausta;
            TuotteenMakeus = tuotteenmakeus;
            ToimitJatkossa = toimitjatkossa;
            PakkausenAvaaminen = pakkauksenavaaminen;
            RakenneKuiva = rakennekuiva;
            RakenneRoiskuva = rakenneroiskuva;
            RakenneIlmava = rakenneilmava;
            RakenneKova = rakennekova;
            RakennePehmea = rakennepehmea;
            RakenneHajoava = rakennehajoava;
            RakenneTasainen = rakennetasainen;
            MikaKierratys = mikakierratys;
            Kommentti = kommentti;
        }
    }
}
