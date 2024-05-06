using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PolAir
{
    public partial class Platnosc : Form
    {
        String data;
        Uzytkownik uzytkownik;
        Lotnisko skad;
        Lotnisko dokad;
        int nr_miejsca;
        string nr_blik;
        BazaBiletow bazaBiletow;
        private BazaSamolotow bazaSamolotow;
        Samolot samolot;

        public Platnosc(Uzytkownik uzytkownik, String data, Lotnisko skad, Lotnisko dokad, int nr_miejsca, Samolot samolot, BazaSamolotow bazaSamolotow, BazaBiletow bazaBiletow)
        {
            this.uzytkownik = uzytkownik;
            this.data = data;
            this.skad = skad;
            this.dokad = dokad;
            this.nr_miejsca = nr_miejsca;
            this.samolot = samolot;

            this.bazaBiletow = bazaBiletow;
            this.bazaSamolotow = bazaSamolotow;
           

            InitializeComponent();
            nieprawidlowyBlik.Visible = false;
        }

        public void Odswiez() {
            textImie.Text = uzytkownik.imie;
            textNazwisko.Text = uzytkownik.nazwisko;
            textSkad.Text = skad.nazwa;
            textDokad.Text = dokad.nazwa;
            textData.Text = data;
            var odleglosc = Math.Round(ObliczOdleglosc());
            textOdleglosc.Text = $"{odleglosc} KM";
            var koszt = Math.Round(ObliczKoszt(ObliczOdleglosc()));
            textKoszt.Text = $"{koszt} ZŁ";

        }

        // mozna robic tak, ze odswiezac interfejs i jeszcze raz go tworzyc ;)
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public double ObliczOdleglosc()
        {
            double long1 = ToRadians(skad.dlugosc_geograficzna);
            double long2 = ToRadians(dokad.dlugosc_geograficzna);
            double lat1 = ToRadians(skad.szerokosc_geograficzna);
            double lat2 = ToRadians(dokad.szerokosc_geograficzna);

            double dlugosc = long2 - long1;
            double szerokosc = lat2 - lat1;
            
            double wynik1= ((Math.Sin(szerokosc / 2)*(Math.Sin(szerokosc / 2)) + Math.Cos(lat1) * Math.Cos(lat2) * (Math.Sin(dlugosc / 2)* (Math.Sin(dlugosc / 2)))));

            wynik1 = 2 * Math.Asin(Math.Sqrt(wynik1));
            double R = 6371;
            double wynik = wynik1 * R;
            return wynik;
        }

        public double ObliczKoszt(double odleglosc)
        {
            double cena=odleglosc / 100 * 50;
            Math.Round(cena);
            return cena;
        }

        public double ToRadians(double x)
        {

            double pi = Math.PI;
            return x * (pi / 180);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TAK_Click(object sender, EventArgs e)
        {
            TAK.Visible = false;
            NIE.Visible = false;
            glownyText.Text = "Podaj NR BLIK:";
            OdrzucZakup.Visible = true;
            akceptujBlik.Visible = true;
            nrBlik.Visible = true;

        }

        private void NIE_Click(object sender, EventArgs e)
        {

            glownyText.Text = "Czy na pewno odrzucasz zakup?";
            NIE2.Visible = true;
            TAK2.Visible = true;
        }

        private void nrBlik_TextChanged(object sender, EventArgs e)
        {
            nr_blik = nrBlik.Text;


            



        }

        private void NIE2_Click(object sender, EventArgs e)
        {
            glownyText.Text = "Czy potwierdzasz zakup biletu?";
            NIE2.Visible = false;
            TAK2.Visible = false;
            TAK.Visible = true;
            NIE.Visible = true;
        }

        private void TAK2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OdrzucZakup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textData_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textOdleglosc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDokad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKoszt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void akceptujBlik_Click(object sender, EventArgs e)
        {
            if (nr_blik.All(char.IsDigit) ==true)
            {
                Bilet nowyBilet = new Bilet(uzytkownik.imie, uzytkownik.nazwisko, uzytkownik.email, data, skad, dokad, nr_miejsca);
                bazaBiletow.DodajDoBazy(nowyBilet);

                if (samolot == null)
                {
                    Samolot nowySamolot = new Samolot(bazaSamolotow.PoliczSamoloty() + 1, skad, dokad, data);

                    bazaSamolotow.DodajDoBazy(nowySamolot);
                    nowySamolot.DodajZajeteMiejsce(nr_miejsca);
                }
                else
                {
                    samolot.DodajZajeteMiejsce(nr_miejsca);
                }


                this.Hide();

            }
            else
            {
                nieprawidlowyBlik.Visible = true;
            }


        }

        private void textOdleglosc_Click(object sender, EventArgs e)
        {

        }
    }
}
