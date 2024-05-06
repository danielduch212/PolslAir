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
    public partial class WyborMiejsca : Form
    {
        String data;
        Lotnisko skad;
        Lotnisko dokad;
        Uzytkownik uzytkownik;
        int nr_miejsca;
        Samolot samolot;
        BazaSamolotow bazaSamolotow;
        BazaBiletow bazaBiletow;
       

        public WyborMiejsca(Uzytkownik uzytkownik, BazaBiletow bazaBiletow, BazaSamolotow bazaSamolotow, String data, Lotnisko skad, Lotnisko dokad)
        {
            this.uzytkownik = uzytkownik;
            this.data = data;
            this.skad = skad;
            this.dokad = dokad;
            this.bazaBiletow = bazaBiletow;
            this.bazaSamolotow = bazaSamolotow;
            
            InitializeComponent();
            samolot = bazaSamolotow.WyszukajSamolot(data, skad.nazwa, dokad.nazwa);
            if(samolot!=null)
            {
                ZrobMiejsca(samolot);
            }
            

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b1.BackColor = Color.Gray;
            nr_miejsca = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b2.BackColor = Color.Gray;
            nr_miejsca = 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b3.BackColor = Color.Gray;
            nr_miejsca = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b4.BackColor = Color.Gray;
            nr_miejsca = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b5.BackColor = Color.Gray;
            nr_miejsca = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b6.BackColor = Color.Gray;
            nr_miejsca = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b7.BackColor = Color.Gray;
            nr_miejsca = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b8.BackColor = Color.Gray;
            nr_miejsca = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b9.BackColor = Color.Gray;
            nr_miejsca = 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b10.BackColor = Color.Gray;
            nr_miejsca = 10;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b11.BackColor = Color.Gray;
            nr_miejsca = 11;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b12.BackColor = Color.Gray;
            nr_miejsca = 12;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b13.BackColor = Color.Gray;
            nr_miejsca = 13;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b14.BackColor = Color.Gray;
            nr_miejsca = 14;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b15.BackColor = Color.Gray;
            nr_miejsca = 15;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b16.BackColor = Color.Gray;
            nr_miejsca = 16;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b17.BackColor = Color.Gray;
            nr_miejsca = 17;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b18.BackColor = Color.Gray;
            nr_miejsca = 18;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b19.BackColor = Color.Gray;
            nr_miejsca = 19;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WyczyscMiejsca();
            b20.BackColor = Color.Gray;
            nr_miejsca = 20;
        }


        private void WyczyscMiejsca()
        {
          
            if(b1.BackColor==Color.Gray)
            {
                b1.BackColor = Color.Green;
            }
            if (b2.BackColor == Color.Gray)
            {
                b2.BackColor = Color.Green;
            }
            if (b3.BackColor == Color.Gray)
            {
                b3.BackColor = Color.Green;
            }
            if (b4.BackColor == Color.Gray)
            {
                b4.BackColor = Color.Green;
            }
            if (b5.BackColor == Color.Gray)
            {
                b5.BackColor = Color.Green;
            }
            if (b6.BackColor == Color.Gray)
            {
                b6.BackColor = Color.Green;
            }
            if (b7.BackColor == Color.Gray)
            {
                b7.BackColor = Color.Green;
            }
            if (b8.BackColor == Color.Gray)
            {
                b8.BackColor = Color.Green;
            }
            if (b9.BackColor == Color.Gray)
            {
                b9.BackColor = Color.Green;
            }
            if (b10.BackColor == Color.Gray)
            {
                b10.BackColor = Color.Green;
            }
            if (b11.BackColor == Color.Gray)
            {
                b11.BackColor = Color.Green;
            }
            if (b12.BackColor == Color.Gray)
            {
                b12.BackColor = Color.Green;
            }
            if (b13.BackColor == Color.Gray)
            {
                b13.BackColor = Color.Green;
            }
            if (b14.BackColor == Color.Gray)
            {
                b14.BackColor = Color.Green;
            }
            if (b15.BackColor == Color.Gray)
            {
                b15.BackColor = Color.Green;
            }
            if (b16.BackColor == Color.Gray)
            {
                b16.BackColor = Color.Green;
            }
            if (b17.BackColor == Color.Gray)
            {
                b17.BackColor = Color.Green;
            }
            if (b18.BackColor == Color.Gray)
            {
                b18.BackColor = Color.Green;
            }
            if (b19.BackColor == Color.Gray)
            {
                b19.BackColor = Color.Green;
            }
            if (b20.BackColor == Color.Gray)
            {
                b20.BackColor = Color.Green;
            }



        }

        private void dalej_Click(object sender, EventArgs e)
        {
            if (nr_miejsca != 0)
            {
                Platnosc nowaPlatnosc = new Platnosc(uzytkownik, data, skad, dokad, nr_miejsca,samolot,bazaSamolotow,bazaBiletow);
                nowaPlatnosc.Odswiez();
                this.Hide();
                nowaPlatnosc.Show();
            }
            else
            {
                //error najpierw wybierz miejsce
            }
        }

        public void ZrobMiejsca(Samolot samolot)
        {
            if(samolot == null)
                return;

            if (samolot.zajeteMiejsca.Contains(1))
            {
                b1.BackColor = Color.Red;
                b1.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(2))
            {
                b2.BackColor = Color.Red;
                b2.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(3))
            {
                b3.BackColor = Color.Red;
                b3.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(4))
            {
                b4.BackColor = Color.Red;
                b4.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(5))
            {
                b5.BackColor = Color.Red;
                b5.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(6))
            {
                b6.BackColor = Color.Red;
                b6.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(7))
            {
                b7.BackColor = Color.Red;
                b7.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(8))
            {
                b8.BackColor = Color.Red;
                b8.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(9))
            {
                b9.BackColor = Color.Red;
                b9.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(10))
            {
                b10.BackColor = Color.Red;
                b10.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(11))
            {
                b11.BackColor = Color.Red;
                b11.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(12))
            {
                b12.BackColor = Color.Red;
                b12.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(13))
            {
                b13.BackColor = Color.Red;
                b13.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(14))
            {
                b14.BackColor = Color.Red;
                b14.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(15))
            {
                b15.BackColor = Color.Red;
                b15.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(16))
            {
                b16.BackColor = Color.Red;
                b16.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(17))
            {
                b17.BackColor = Color.Red;
                b17.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(18))
            {
                b18.BackColor = Color.Red;
                b18.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(19))
            {
                b19.BackColor = Color.Red;
                b19.Enabled = false;
            }
            if (samolot.zajeteMiejsca.Contains(20))
            {
                b20.BackColor = Color.Red;
                b20.Enabled = false;
            }


        }
    }
}
