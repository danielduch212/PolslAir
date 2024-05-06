using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolAir {
    public partial class InterfejsUzytkownika : Form {
        BazaUzytkownikow bazaUzytkownikow;
        Uzytkownik uzytkownik;
        BazaSamolotow bazaSamolotow;
        BazaBiletow bazaBiletow;

        public InterfejsUzytkownika(BazaUzytkownikow bazaUzytkownikow, Uzytkownik uzytkownik,
            BazaSamolotow bazaSamolotow, BazaBiletow bazaBiletow) {
            this.bazaUzytkownikow = bazaUzytkownikow;
            this.uzytkownik = uzytkownik;
            this.bazaSamolotow = bazaSamolotow;
            this.bazaBiletow = bazaBiletow;
            InitializeComponent();
            textImie.Text = uzytkownik.imie;
            textNazwisko.Text = uzytkownik.nazwisko;
        }




        void button1_Click(object sender, EventArgs e) {
            openForm(new MojeKonto(bazaUzytkownikow, uzytkownik,bazaSamolotow,bazaBiletow));
        }

        void button2_Click(object sender, EventArgs e) {
            openForm(new MojeBilety(bazaBiletow,uzytkownik));
        }

        void button3_Click(object sender, EventArgs e) {
            openForm(new Rezerwacja(uzytkownik, bazaBiletow,bazaSamolotow));
        }

        void button4_Click(object sender, EventArgs e) {
            this.Hide();
            Logowanie panelLogowania = new Logowanie(bazaUzytkownikow, bazaSamolotow, bazaBiletow);
            panelLogowania.Show();

        }

        Form aktywnyFormularz = null;

        void openForm(Form childForm) {
            if (aktywnyFormularz != null) {
                aktywnyFormularz.Close();
            }

            aktywnyFormularz = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelGlowny.Controls.Add(childForm);
            panelGlowny.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void textBox1_TextChanged(object sender, EventArgs e) { }

        void textBox2_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
