using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using PdfSharp;
using PdfSharp.Drawing;

namespace PolAir
{
    public partial class MojeBilety : Form
    {
        BazaBiletow bazaBiletow;
        Uzytkownik uzytkownik;
        int ktoryPanelZglosil;

        public MojeBilety(BazaBiletow bazaBiletow, Uzytkownik uzytkownik)
        {
            this.bazaBiletow = bazaBiletow;
            this.uzytkownik = uzytkownik;
            InitializeComponent();
            ZrobMojeBilety(uzytkownik);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            WyczyscPaneleDodatkowe();
            panel11.Visible = true;
            b11.Visible = true;
            drukuj1.Visible = true;
            anuluj1.Visible = true;
        }

        private void Drukuj1_Click(object sender, EventArgs e)
        {
            PobierzPlik(1);
        }

        private void Anuluj1_Click(object sender, EventArgs e)
        {
            DajDoGoryPanel(panel1, panel11);
            Anuluj(panel1, b1, 1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            WyczyscPaneleDodatkowe();
            panel21.Visible = true;
            b21.Visible = true;
            drukuj2.Visible = true;
            anuluj2.Visible = true;
        }

        private void drukuj2_Click(object sender, EventArgs e)
        {
            PobierzPlik(2);
        }

        private void anuluj2_Click(object sender, EventArgs e)
        {
            DajDoGoryPanel(panel2, panel21);
            Anuluj(panel2, b2, 2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            WyczyscPaneleDodatkowe();
            panel31.Visible = true;
            b31.Visible = true;
            drukuj3.Visible = true;
            anuluj3.Visible = true;
        }

        private void drukuj3_Click(object sender, EventArgs e)
        {
            PobierzPlik(3);
        }

        private void anuluj3_Click(object sender, EventArgs e)
        {
            DajDoGoryPanel(panel3, panel31);
            Anuluj(panel3, b3, 3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            WyczyscPaneleDodatkowe();
            panel41.Visible = true;
            b41.Visible = true;
            drukuj4.Visible = true;
            anuluj4.Visible = true;
        }

        private void drukuj4_Click(object sender, EventArgs e)
        {
            PobierzPlik(4);
        }

        private void anuluj4_Click(object sender, EventArgs e)
        {
            DajDoGoryPanel(panel4, panel41);
            Anuluj(panel4, b4, 4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            WyczyscPaneleDodatkowe();
            panel51.Visible = true;
            b51.Visible = true;
            drukuj5.Visible = true;
            anuluj5.Visible = true;
        }

        private void drukuj5_Click(object sender, EventArgs e)
        {
            PobierzPlik(5);
        }

        private void anuluj5_Click(object sender, EventArgs e)
        {
            DajDoGoryPanel(panel5, panel51);
            Anuluj(panel5, b5, 5);
        }

        private void WyczyscPaneleDodatkowe()
        {
            panel11.Visible = false;
            b11.Visible = false;
            drukuj1.Visible = false;
            anuluj1.Visible = false;
            panel21.Visible = false;
            b21.Visible = false;
            drukuj2.Visible = false;
            anuluj2.Visible = false;
            panel31.Visible = false;
            b31.Visible = false;
            drukuj3.Visible = false;
            anuluj3.Visible = false;
            panel41.Visible = false;
            b41.Visible = false;
            drukuj4.Visible = false;
            anuluj4.Visible = false;
            panel51.Visible = false;
            b51.Visible = false;
            drukuj5.Visible = false;
            anuluj5.Visible = false;




        }
        public void ZrobMojeBilety(Uzytkownik uzytkownik)
        {
            System.Windows.Forms.Panel[] panele =
            {
                panel1, panel2,panel3,panel4,panel5
            };
            System.Windows.Forms.Button[] przyciski =
            {
                b1,b2,b3,b4,b5
            };
            System.Windows.Forms.Label[] fromy =
            {
                from1,from2,from3,from4,from5
            };
            System.Windows.Forms.Label[] to =
            {
                to1,to2,to3,to4,to5
            };
            System.Windows.Forms.Label[] data =
            {
                data1,data2,data3,data4,data5
            };
            System.Windows.Forms.Label[] miejsca =
            {
                miejsce1,miejsce2,miejsce3,miejsce4,miejsce5
            };
            ZrezetujPozycjePaneli();
            List<Bilet> biletyUzytkownika = bazaBiletow.WyszukajWszystkieBilety(uzytkownik);
            IEnumerator<Bilet> enumerator = biletyUzytkownika.GetEnumerator();
            Bilet bilet;

            WyczyscPanele();
            WyczyscPaneleDodatkowe();
            if (biletyUzytkownika.Count == 0)
            {
                return;

            }
            else
            {

                for (int i = 0; i < biletyUzytkownika.Count; i++)
                {
                    enumerator.MoveNext();
                    bilet = enumerator.Current;
                    panele[i].Visible = true;
                    przyciski[i].Visible = true;
                    fromy[i].Text = bilet.from.nazwa;
                    to[i].Text = bilet.to.nazwa;
                    data[i].Text = bilet.data;
                    miejsca[i].Text = bilet.miejsce.ToString();
                }
            }
        }
        private void WyczyscPanele()
        {
            panel1.Visible = false;
            b1.Visible = false;
            panel2.Visible = false;
            b2.Visible = false;
            panel3.Visible = false;
            b3.Visible = false;
            panel4.Visible = false;
            b4.Visible = false;
            panel5.Visible = false;
            b5.Visible = false;
        }

        private void Anuluj(System.Windows.Forms.Panel panel, System.Windows.Forms.Button b1, int ktoryPanel)
        {
            ktoryPanelZglosil = ktoryPanel;
            WyczyscPanele();
            WyczyscPaneleDodatkowe();
            panelCzyNaPewno.Location = new Point(150, 406);
            panelCzyNaPewno.Visible = true;
            panel.Visible = true;
            b1.Visible = true;
            TAK.Visible = true;
            NIE.Visible = true;
            CzyNaPewno.Visible = true;
        }

        private void TAK_Click(object sender, EventArgs e)
        {
            List<Bilet> biletyUzytkownika = bazaBiletow.WyszukajWszystkieBilety(uzytkownik);
            IEnumerator<Bilet> enumerator = biletyUzytkownika.GetEnumerator();
            Bilet bilet;
            for (int i = 0; i < ktoryPanelZglosil; i++)
            {
                enumerator.MoveNext();

            }
            bilet = enumerator.Current;
            bazaBiletow.UsunBilet(bilet);
            TAK.Visible = false;
            CzyNaPewno.Visible = false;
            panelCzyNaPewno.Visible = false;
            NIE.Visible = false;
            ZrobMojeBilety(uzytkownik);

        }

        private void NIE_Click(object sender, EventArgs e)
        {
            TAK.Visible = false;
            CzyNaPewno.Visible = false;
            panelCzyNaPewno.Visible = false;
            NIE.Visible = false;
            ZrobMojeBilety(uzytkownik);
        }

        private void PobierzPlik(int nrBiletu)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\bilet.pdf";
            Bilet bilet;
            List<Bilet> biletyUzytkownika = bazaBiletow.WyszukajWszystkieBilety(uzytkownik);
            IEnumerator<Bilet> enumerator = biletyUzytkownika.GetEnumerator();
            for(int i = 0; i < nrBiletu; i++)
            {
                enumerator.MoveNext();

            }
            bilet = enumerator.Current;



            //string daneBiletu = bilet.imie + bilet.nazwisko + bilet.data + bilet + bilet.from.nazwa + bilet.to.nazwa;

            //QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            //var MyData = QG.CreateQrCode(daneBiletu, QRCoder.QRCodeGenerator.ECCLevel.H);
            //var code = new QRCoder.QRCode(MyData);
            XPoint punkt = new XPoint(0, 100);
            PdfDocument pdf = new PdfDocument();
            PdfPage page = pdf.AddPage();
            XGraphics graphic = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 15);
            //System.Windows.Forms.PictureBox qrkod = new PictureBox();
            //qrkod.Image = code.GetGraphic(50);
            //graphic.DrawBarCode(code.GetGraphic(50), punkt);
            
            graphic.DrawString("Imie: " + "          " + uzytkownik.imie, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height),XStringFormats.Center);
            graphic.DrawString("Nazwisko: " + "          " + uzytkownik.nazwisko, font, XBrushes.Black, new XRect(0, -40, page.Width, page.Height), XStringFormats.Center);
            graphic.DrawString("Email: " + "          " + uzytkownik.email, font, XBrushes.Black, new XRect(0, -80, page.Width, page.Height), XStringFormats.Center);
            graphic.DrawString("From: " + "          " + bilet.from.nazwa, font, XBrushes.Black, new XRect(0, -120, page.Width, page.Height), XStringFormats.Center);
            graphic.DrawString("TO: " + "          " + bilet.to.nazwa, font, XBrushes.Black, new XRect(0, -160, page.Width, page.Height), XStringFormats.Center);
            graphic.DrawString("WHEN: " + "          " + bilet.data, font, XBrushes.Black, new XRect(0, -200, page.Width, page.Height), XStringFormats.Center);
            graphic.DrawString("TIME: " + "          " + "12:00", font, XBrushes.Black, new XRect(0, -240, page.Width, page.Height), XStringFormats.Center);
            pdf.Save(filepath);


        }

        private void CzyNaPewno_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void DajDoGoryPanel(System.Windows.Forms.Panel panel, System.Windows.Forms.Panel panel1)
            
        {
            panel.Location=new Point(64, 124);
            panel1.Location=new Point(64, 210);
     
        }
        private void ZrezetujPozycjePaneli()
        {
            panel1.Location = new Point(64, 124);
            panel11.Location = new Point(64, 210);
            panel2.Location = new Point(64, 265);
            panel21.Location = new Point(64, 351);
            panel3.Location = new Point(64, 406);
            panel31.Location = new Point(64, 492);
            panel4.Location = new Point(64, 547);
            panel41.Location = new Point(64, 633);
            panel5.Location = new Point(64, 686);
            panel51.Location = new Point(64, 772);

        }
  
    }
}
