using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolAir
{
    public partial class MojeKonto : Form
    {
        BazaUzytkownikow bazaUzytkownikow;
        Uzytkownik uzytkownik;
        BazaSamolotow bazaSamolotow;
        BazaBiletow bazaBiletow;
        string starehaslo;
        string nowehaslo;
        string pnowehaslo;
   
      
        public MojeKonto(BazaUzytkownikow bazaUzytkownikow, Uzytkownik uzytkownik, BazaSamolotow bazaSamolotow, BazaBiletow bazaBiletow)
        {
            this.bazaUzytkownikow = bazaUzytkownikow;
            this.uzytkownik = uzytkownik;
            this.bazaSamolotow = bazaSamolotow;
            this.bazaBiletow = bazaBiletow;
            InitializeComponent();
            textImie.Text = uzytkownik.imie;
            textNazwisko.Text = uzytkownik.nazwisko;
            textEmail.Text = uzytkownik.email;
            CzyUsunac.Visible = false;
            TAK.Visible = false;
            NIE.Visible = false;
            WyczyscZmianeHasla();
            WyczyscErrory();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usunKonto.Visible = false;
            sHasloLabel.Visible = true;
            nhasloLabel.Visible = true;
            pnhasloLabel.Visible = true;
            textBoxStareHaslo.Visible = true;
            textBoxNoweHaslo.Visible = true;
            textBoxNoweHasloP.Visible = true;
            zmienhaslo2.Visible = true;
            anulujZmianeHasla.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zmienHaslo.Visible = false;
            usunKonto.Visible = false;
            CzyUsunac.Visible = true;
            TAK.Visible = true;
            NIE.Visible = true;
            Logowanie noweLogowanie = new Logowanie(bazaUzytkownikow, bazaSamolotow, bazaBiletow);
        }

        private void TAK_Click(object sender, EventArgs e)
        {
            bazaUzytkownikow.UsunUzytkownika(uzytkownik);
            this.Close();
            ActiveForm.Close();
            
        }

        private void NIE_Click(object sender, EventArgs e)
        {
            TAK.Visible = false;
            NIE.Visible = false;
            CzyUsunac.Visible = false;
            zmienHaslo.Visible = true;
            usunKonto.Visible = true;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            
        }


        private void textBoxStareHaslo_TextChanged(object sender, EventArgs e)
        {
            starehaslo = textBoxStareHaslo.Text;
        }

        private void textBoxNoweHaslo_TextChanged(object sender, EventArgs e)
        {
            nowehaslo = textBoxNoweHaslo.Text;
        }

        private void textBoxNoweHasloP_TextChanged(object sender, EventArgs e)
        {
            pnowehaslo = textBoxNoweHasloP.Text;
        }

        private void zmienhaslo2_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            if (starehaslo == uzytkownik.haslo)
            {
                if (nowehaslo == pnowehaslo)
                {
                    if(nowehaslo.Length>=7 & nowehaslo.Length <= 15)
                    {
                        uzytkownik.haslo = nowehaslo;

                    }
                    else
                    {
                        errorliczbaznakow.Visible = true;
                    }
                }
                else
                {
                    errorZleNowe.Visible = true; 
                }
            }
            else
            {
                ErrorZleStare.Visible = true;
            }
        }

        private void WyczyscZmianeHasla()
        {
            usunKonto.Visible = true;
            zmienHaslo.Visible = true;
            zmienhaslo2.Visible = false;
            textBoxStareHaslo.Visible = false;
            textBoxNoweHaslo.Visible = false;
            textBoxNoweHasloP.Visible = false;
            sHasloLabel.Visible = false;
            nhasloLabel.Visible = false;
            pnhasloLabel.Visible = false;
            anulujZmianeHasla.Visible = false;
        }

        private void anulujZmianeHasla_Click(object sender, EventArgs e)
        {
            WyczyscZmianeHasla();
        }

        private void WyczyscErrory()
        {
            ErrorZleStare.Visible = false;
            errorZleNowe.Visible = false;
            errorliczbaznakow.Visible = false;
        }

        private void errorliczbaznakow_Click(object sender, EventArgs e)
        {

        }

        private void textImie_Click(object sender, EventArgs e)
        {

        }
    }
    
}
