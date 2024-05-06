using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PolAir
{
    public class BazaBiletow
    {
        public List<Bilet> bazaBiletow = new List<Bilet>();
        public BazaLotnisk bazaLotnisk = new();

        public BazaBiletow() {
            UtworzBazeDanych();
        }
        
     
        public void DodajDoBazy(Bilet bilet)
        {
            bazaBiletow.Add(bilet);

        }
        public void UsunBilet(Bilet bilet)
        {
            bazaBiletow.Remove(bilet);

        }
        public void ZapiszDoPliku()
        {
            IEnumerator<Bilet> enumerator = bazaBiletow.GetEnumerator();
            StreamWriter sw = new StreamWriter("bazaBiletow.txt");
            string text;
            if (bazaBiletow.Count != 0)
            {
                for (int i = 0; i < bazaBiletow.Count; i++)
                {
                   

                    enumerator.MoveNext();
                    Bilet bilet = enumerator.Current;
                    text = bilet.imie;
                    sw.WriteLine(text);
                    text =bilet.nazwisko;
                    sw.WriteLine(text);
                    text = bilet.email;
                    sw.WriteLine(text);
                    text = bilet.data;
                    sw.WriteLine(text);
                    text = bilet.from.nazwa;
                    sw.WriteLine(text);
                    text = bilet.to.nazwa;
                    sw.WriteLine(text);
                    text = bilet.miejsce.ToString();
                    sw.WriteLine(text);
              
                }
            }
            else
            {
                
            }
            sw.Close();
        }


        public void UtworzBazeDanych() {
            if(!File.Exists("bazaBiletow.txt"))
                return;

            StreamReader sr = new StreamReader("bazaBiletow.txt");
            string[] text = System.IO.File.ReadAllLines("bazaBiletow.txt");
            int dlugoscTablicy = text.Length;
            string imie;
            string nazwisko;
            string email;
            string data;
            string skadString;
            string dokadString;
            Lotnisko skad;
            Lotnisko dokad;
            string miejsceString;
            int miejsce;


            if (dlugoscTablicy == 0) {
                bazaBiletow.Clear();
                sr.Close();
                return;
            }

            for (int j = 0; j < dlugoscTablicy; j = j + 7) {
                imie = sr.ReadLine();
                nazwisko = sr.ReadLine();
                email = sr.ReadLine();
                data = sr.ReadLine();
                skadString = sr.ReadLine();
                dokadString = sr.ReadLine();
                skad = bazaLotnisk.WyszukajLotnisko(skadString);
                dokad = bazaLotnisk.WyszukajLotnisko(dokadString);
                miejsceString = sr.ReadLine();
                miejsce = int.Parse(miejsceString);
                Bilet bilet = new Bilet(imie, nazwisko, email, data, skad, dokad, miejsce);
                bazaBiletow.Add(bilet);
              
            }
            sr.Close();
        }

        public List<Bilet> WyszukajWszystkieBilety(Uzytkownik uzytkownik)
        {

            return bazaBiletow.FindAll(x => x.imie == uzytkownik.imie && x.nazwisko == uzytkownik.nazwisko && x.email == uzytkownik.email);

        }

    }

   
}
