using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PolAir
{
    public partial class Rezerwacja : Form
    {
        string data;
        Lotnisko skad;
        Lotnisko dokad;
        BazaLotnisk bazaLotnisk = new();
        Uzytkownik uzytkownik;
        BazaBiletow bazaBiletow;
        BazaSamolotow bazaSamolotow;

        public Rezerwacja(Uzytkownik uzytkownik, BazaBiletow bazaBiletow, BazaSamolotow bazaSamolotow)
        {
           
            this.uzytkownik = uzytkownik;
            this.bazaBiletow = bazaBiletow;
            this.bazaSamolotow = bazaSamolotow;        
            InitializeComponent();
            WidokNormalny();
            panelFrom.Visible = false;
            panelTO.Visible = false;
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            WyczyscErrory();
            data =monthCalendar1.SelectionRange.Start.ToShortDateString();

        }

        private void WybierzFrom_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            panelFrom.Visible = true;
            errorTo.Visible = false;
        }

        private void WybierzTo_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            if (WybierzFrom.Text == "Wybierz")
            {
                errorTo.Visible = true;
            }
            else
            {
                panelTO.Visible = true;
            }
           
        }

        private void PolskaFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            skad = bazaLotnisk.WyszukajLotnisko("warszawachopin");
            WyczyscTo();
            panelFrom.Visible = false;
            WybierzFrom.Text = PolskaFROM.Text;
            PolskaTO.Visible = false;

        }

        private void PortugaliaFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Lizbona Portela");
            panelFrom.Visible = false;
            WybierzFrom.Text = PortugaliaFROM.Text;
            PortugaliaTO.Visible = false;
        }

        private void HiszpaniaFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Madryt");
            panelFrom.Visible = false;
            WybierzFrom.Text = HiszpaniaFROM.Text;
            HiszpaniaTO.Visible = false;
        }

        private void GrecjaFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Ateny");
            panelFrom.Visible = false;
            WybierzFrom.Text = GrecjaFROM.Text;
            GrecjaTO.Visible = false;
        }

        private void HolandiaFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Amsterdam");
            panelFrom.Visible = false;
            WybierzFrom.Text = HolandiaFROM.Text;
            HolandiaTO.Visible = false;
        }

        private void USAFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Los Angeles");
            panelFrom.Visible = false;
            WybierzFrom.Text = USAFROM.Text;
            USATO.Visible = false;
        }

        private void NiemcyFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Berlin");
            panelFrom.Visible = false;
            WybierzFrom.Text = NiemcyFROM.Text;
            NiemcyTO.Visible = false;
        }

        private void FrancjaFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Paryż");
            panelFrom.Visible = false;
            WybierzFrom.Text = FrancjaFROM.Text;
            FrancjaTO.Visible = false;
        }

        private void IslandiaFROM_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            WyczyscTo();
            skad = bazaLotnisk.WyszukajLotnisko("Reykjavik");
            panelFrom.Visible = false;
            WybierzFrom.Text = IslandiaFROM.Text;
            IslandiaTO.Visible = false;
        }

        private void PolskaTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("warszawachopin"); 
            panelTO.Visible = false;
            WybierzTo.Text = PolskaTO.Text;
           
        }

        private void PortugaliaTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Lizbona Portela"); 
            panelTO.Visible = false;
            WybierzTo.Text = PortugaliaTO.Text;
        }

        private void HiszpaniaTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Madryt"); 
            panelTO.Visible = false;
            WybierzTo.Text = HiszpaniaTO.Text;
        }

        private void GrecjaTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Ateny"); 
            panelTO.Visible = false;
            WybierzTo.Text = GrecjaTO.Text;
        }

        private void HolandiaTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Amsterdam");
            panelTO.Visible = false;
            WybierzTo.Text = HolandiaTO.Text;
        }

        private void USATO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Los Angeles");
            panelTO.Visible = false;
            WybierzTo.Text = USATO.Text;
        }

        private void NiemcyTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Berlin");
            panelTO.Visible = false;
            WybierzTo.Text = NiemcyTO.Text;
        }

        private void FrancjaTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Paryż");
            panelTO.Visible = false;
            WybierzTo.Text = FrancjaTO.Text;
        }

        private void IslandiaTO_Click(object sender, EventArgs e)
        {
            WyczyscErrory();
            dokad = bazaLotnisk.WyszukajLotnisko("Reykjavik");
            panelTO.Visible = false;
            WybierzTo.Text = IslandiaTO.Text;
        }
        
        private void WyczyscTo()
        {
            PolskaTO.Visible = true;
            PortugaliaTO.Visible = true;
            HiszpaniaTO.Visible = true;
            GrecjaTO.Visible = true;
            HolandiaTO.Visible = true;
            USATO.Visible = true;
            NiemcyTO.Visible = true;
            FrancjaTO.Visible = true;
            IslandiaTO.Visible = true;
        }

        private void dalej_Click(object sender, EventArgs e)
        {
            List<Bilet> bazaBiletowUzytkownika = bazaBiletow.WyszukajWszystkieBilety(uzytkownik);
            if (bazaBiletowUzytkownika.Count==5)
            {
                errorZaDuzo.Visible = true;
                return;
            }
            if (data == null)
            {
                errorData.Visible = true;

            }
            if (WybierzFrom.Text == "Wybierz" || WybierzTo.Text == "Wybierz")
            {
                ErrorWybierz.Visible = true;

            }else if (WybierzFrom.Text == WybierzTo.Text){

                ErrorTakieSame.Visible = true;
            }
            else
            {

                WidokWToku();
                WyborMiejsca wyborMiejsca = new WyborMiejsca(uzytkownik, bazaBiletow, bazaSamolotow, data, skad, dokad);
                wyborMiejsca.Show();
            }


        }

       
        private void ErrorWybierz_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rezerwacja_Load(object sender, EventArgs e)
        {

        }

        private void WyczyscErrory()
        {
            ErrorTakieSame.Visible = false;
            errorTo.Visible = false;
            errorData.Visible = false;
            errorZaDuzo.Visible = false;
            ErrorWybierz.Visible = false;
            

        }

        private void WidokWToku()
        {
            WyczyscErrory();
            monthCalendar1.Visible = false;
            textBox4.Visible = false;
            textBox2.Visible = false;
            WybierzFrom.Visible = false;
            textBox3.Visible = false;
            WybierzTo.Visible = false;
            panelFrom.Visible = false;
            panelTO.Visible = false;
            dalej.Visible = false;
            rezerwacjaWToku.Visible = true;
            

        }
        private void WidokNormalny()
        {
            monthCalendar1.Visible = true;
            textBox4.Visible = true;
            textBox2.Visible = true;
            WybierzFrom.Visible = true;
            textBox3.Visible = true;
            WybierzTo.Visible = true;
            dalej.Visible = true;
            rezerwacjaWToku.Visible = false;
         
        }

    }
}
