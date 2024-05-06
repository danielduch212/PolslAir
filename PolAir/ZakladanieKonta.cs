using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace PolAir
{
    public partial class ZakladanieKonta : Form
    {
        private String email;
        private String imie;
        private String nazwisko;
        private String haslo;
        private String pHaslo;
        private BazaUzytkownikow bazaUzytkownikow;
        BazaSamolotow bazaSamolotow;
        BazaBiletow bazaBiletow;

        public ZakladanieKonta(BazaUzytkownikow bazaUzytkownikow, BazaSamolotow bazaSamolotow, BazaBiletow bazaBiletow)
        {
            this.bazaUzytkownikow = bazaUzytkownikow;
            this.bazaSamolotow = bazaSamolotow;
            this.bazaBiletow = bazaBiletow;
            InitializeComponent();
            errorEmail.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            WyczyscErrory();
            email = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            WyczyscErrory();
            imie = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            WyczyscErrory();
            nazwisko = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            WyczyscErrory();
            haslo = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            WyczyscErrory();
            pHaslo = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorText1.Visible = false;
            error2.Visible = false;
            if (bazaUzytkownikow.WyszukajUzytkownika(email) != null)
            {
                error2.Visible = true;
            }
            else
            {
                if (haslo == pHaslo)
                {


                    if (SprawdzEmail(email) == true)
                    {
                        if (SprawdzHaslo(haslo) == true)
                        {

                            if (SprawdzNazwisko(nazwisko) == false)
                            {

                                Uzytkownik uzytkownik = new Uzytkownik(imie, nazwisko, email, haslo);
                                bazaUzytkownikow.DodajDoBazy(uzytkownik);
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                this.Hide();
                                Logowanie logowanie = new Logowanie(bazaUzytkownikow, bazaSamolotow, bazaBiletow);

                                logowanie.ZalozonoKonto();
                                logowanie.Show();
                            }
                            else
                            {
                                errorNazwiskoNieMoze.Visible = true;
                            }
                        }
                        else
                        {
                            errorHasloMusiZawierac.Visible = true;
                        }
                    }
                    else
                    {
                        errorEmail.Visible = true;
                    }



                }
                else
                {
                    errorText1.Visible = true;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie logowanie = new Logowanie(bazaUzytkownikow,bazaSamolotow,bazaBiletow);
            logowanie.Show();
        }

        private void WyczyscErrory()
        {
            errorHasloMusiZawierac.Visible = false;
            errorText1.Visible = false;
            error2.Visible = false;
            errorText1.Visible = false;
            errorEmail.Visible = false;
            errorNazwiskoNieMoze.Visible = false;
        }

        private bool SprawdzEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private bool SprawdzHaslo(string haslo)
        {

            if (haslo.Length >= 7 & haslo.Length <= 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool SprawdzNazwisko(string nazwisko)
        {
            return nazwisko.Any(char.IsDigit);
            //powinien zwrocic false jesli nazwisko jest dobre
        }



    }


}

