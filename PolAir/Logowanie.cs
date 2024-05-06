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
    public partial class Logowanie : Form
    {
        private String email;
        private String haslo;
        private BazaUzytkownikow bazaUzytkownikow;
        BazaSamolotow bazaSamolotow;
        BazaBiletow bazaBiletow;
        
        public Logowanie(BazaUzytkownikow bazaUzytkownikow, BazaSamolotow bazaSamolotow, BazaBiletow bazaBiletow)
        {
            this.bazaUzytkownikow = bazaUzytkownikow;
            this.bazaSamolotow = bazaSamolotow;
            this.bazaBiletow = bazaBiletow;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            WyczyscAlerty();
            email = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            WyczyscAlerty();
            haslo = textBox2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (haslo != null)
            {
                if (email != null)
                {
                    Uzytkownik uzytkownik;
                    uzytkownik=bazaUzytkownikow.WyszukajUzytkownikaEmailIHaslo(email, haslo);
                    if (uzytkownik != null)
                    {
                        InterfejsUzytkownika interfejs = new InterfejsUzytkownika(bazaUzytkownikow, uzytkownik, bazaSamolotow, bazaBiletow);
                        Hide();
                        interfejs.Show();

                    }
                    else
                    {
                        errorNieEmailLubHaslo.Visible = true;
                    }
                }
                else
                {

                    PodajEmailiHaslo.Visible = true;
                }
            }
            else
            {
                PodajEmailiHaslo.Visible = true;
            }
            

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZakladanieKonta zakladanieKonta = new ZakladanieKonta(bazaUzytkownikow, bazaSamolotow, bazaBiletow);
            zakladanieKonta.Show();
        }

        public void wyjdzPrzycisk_Click(object sender, EventArgs e)
        {
            bazaBiletow.ZapiszDoPliku();
            bazaSamolotow.ZapiszDoPliku();
            bazaUzytkownikow.ZapiszDoPliku();
            this.Close();
            System.Threading.Thread.CurrentThread.Interrupt();
            Application.ExitThread();
            Application.Exit();
            
        }
        
        private void WyczyscAlerty()
        {
            errorNieEmailLubHaslo.Visible = false;
            PodajEmailiHaslo.Visible = false;
            errorZostaloUtworzone.Visible = false;
        }

        public void ZalozonoKonto()
        {
            errorZostaloUtworzone.Visible = true;
        }
    }
}


