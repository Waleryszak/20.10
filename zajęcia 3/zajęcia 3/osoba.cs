using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajęcia_3
{
    internal class Osoba
    {
        //public string Imie;
        //public string Nazwisko;

        private string _Nazwisko;
        private string _Imie;

        private Adres _adres {  get; set; } //właściwość adres która przechowuje dane

        public Osoba(string nazwisko, string imie, Adres adres)
        {
            _Nazwisko = nazwisko;
            _Imie = imie;
            _adres = adres;
        }

        public string Imie
        {
            get { return _Imie; } // _ oznacza zmienna prywatną
            set { _Imie = value; } // set ustawia wartość do tego imienia
        }

        public string Nazwisko
        {
            get { return _Nazwisko; } // _ oznacza zmienna prywatną
            set { _Nazwisko = value; } // set ustawia wartość do tego imienia
        }

        public string PrzedstawSie()
        {
            // return "Nazywam sie: " + this.Imie + " " + this._Nazwisko + "\n" + this.adres.PodajAdres;
            return $"Nazywam sie: {Imie} {Nazwisko}.\n Adres zamieszkania: {_adres.AdresPelny}";
        }
        public void UstawDane(string imie, string nazwisko, Adres adres)
        {
            //Używamy kiedy odwołujemy sie do zmiennych w danej klasie this
            this.Imie = imie;
            this._Nazwisko = nazwisko;
            this._adres = adres;

        }
        
       
    
    }
}
