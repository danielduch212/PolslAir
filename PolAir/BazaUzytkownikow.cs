using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PolAir
{
    public class BazaUzytkownikow
    {

        public List<Uzytkownik> bazaUzytkownikow = new List<Uzytkownik>();


        public BazaUzytkownikow()
        {
            UtworzBazeDanych();

        }


        public int ZwrocRozmiar()
        {
            int ilosc;
            ilosc = bazaUzytkownikow.Count;
            return ilosc;
        }

        public void DodajDoBazy(Uzytkownik uzytkownik) => bazaUzytkownikow.Add(uzytkownik);

        public Uzytkownik WyszukajUzytkownika(string szukanyEmail)
        {
            return bazaUzytkownikow.Find(x => x.email == szukanyEmail);

        }
        public Uzytkownik WyszukajUzytkownika(int ID)
        {
            IEnumerator<Uzytkownik> enumerator = bazaUzytkownikow.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i <= ID; i++)
            {
                enumerator.MoveNext();
            }
            return enumerator.Current;
        }

        public void WyczyscBaze()
        {
            bazaUzytkownikow.Clear();
        }

        public void UsunUzytkownika(Uzytkownik uzytkownik)
        {
            bazaUzytkownikow.Remove(uzytkownik);

        }

        public void ZapiszDoPliku()
        {
            IEnumerator<Uzytkownik> enumerator = bazaUzytkownikow.GetEnumerator();
            StreamWriter sw = new StreamWriter("bazaUzytkownikow.txt");
            string text;
            if (bazaUzytkownikow.Count != 0)
            {
                for (int i = 0; i < bazaUzytkownikow.Count; i++)
                {
                    enumerator.MoveNext();
                    Uzytkownik uzytkownik = enumerator.Current;
                    text = uzytkownik.imie.ToString();
                    sw.WriteLine(text);
                    text = uzytkownik.nazwisko.ToString();
                    sw.WriteLine(text);
                    text = uzytkownik.email.ToString();
                    sw.WriteLine(text);
                    text = uzytkownik.haslo.ToString();
                    sw.WriteLine(text);


                }
            }
            else
            {
                return;
            }
            sw.Close();







        }

        public void UtworzBazeDanych()
        {
            string nazwaPliku = "bazaUzytkownikow.txt";
            if (File.Exists(nazwaPliku) == true)
            {
                string[] text = System.IO.File.ReadAllLines("bazaUzytkownikow.txt");
                int dlugoscTablicy = text.Length;
                if (dlugoscTablicy != 0)
                {
                    for (int j = 0; j < dlugoscTablicy; j = j + 4)
                    {

                        Uzytkownik uzytkownik = new Uzytkownik(text[0 + j], text[1 + j], text[2 + j], text[3 + j]);
                        bazaUzytkownikow.Add(uzytkownik);

                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            

        }

        public Uzytkownik WyszukajUzytkownikaEmailIHaslo( string email, string haslo)
        {
            return bazaUzytkownikow.Find(x => x.email == email&&x.haslo==haslo);

        }
    }
}
