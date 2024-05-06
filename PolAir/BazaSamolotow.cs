using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PolAir
{
    public class BazaSamolotow
    {
        public List<Samolot> bazaSamolotow=new List<Samolot>() ;
        public BazaLotnisk bazalotnisk =new();

        public BazaSamolotow() {
            UtworzBazeDanych();
        }



        public int PoliczSamoloty()
        {


            return bazaSamolotow.Count;



        }

        public void DodajDoBazy(Samolot samolot)
        {
            bazaSamolotow.Add(samolot);

        }

        public void ZapiszDoPliku()
        {
            IEnumerator<Samolot> enumerator = bazaSamolotow.GetEnumerator();
            int liczba_iteracji = bazaSamolotow.Count;
            StreamWriter sw = new StreamWriter("bazaSamolotow.txt");
            if (bazaSamolotow.Count!=0)
            {
                for (int i = 0; i < liczba_iteracji; i++)
                {
                    enumerator.MoveNext();
                    Samolot samolot = enumerator.Current;
                    int licznikMiejsc = samolot.zajeteMiejsca.Count;
                    string text = samolot.nr_samolotu.ToString();
                    sw.WriteLine(text);
                    text = samolot.skad.nazwa;
                    sw.WriteLine(text);
                    text = samolot.dokad.nazwa;
                    sw.WriteLine(text);
                    text = licznikMiejsc.ToString();
                    sw.WriteLine(text);
                    IEnumerator<int> enumerator1 = samolot.zajeteMiejsca.GetEnumerator();
                    for (int j = 0; j < licznikMiejsc; j++)
                    {
                        enumerator1.MoveNext();
                        string miejsce = enumerator1.Current.ToString();
                        sw.WriteLine(miejsce);

                    }
                    text = samolot.data;
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
            if(!File.Exists("bazaSamolotow.txt"))
                return;

            StreamReader sr = new StreamReader("bazaSamolotow.txt");
            string[] text = File.ReadAllLines("bazaSamolotow.txt");
            int dlugoscTablicy = text.Length;
            string nr_samolotu;
            string skadString;
            Lotnisko skad;
            Lotnisko dokad;
            string dokadString;
            string licznikM;
            int licznik_miejsc;
            string zmienna;
            int miejsce;
            string data;
           
            List<int> zajete_miejsca = new List<int>();
            if (dlugoscTablicy != 0)
            {
                for (int j = 0; j < dlugoscTablicy; j = j + 5+licznik_miejsc)
                {
                  
                    nr_samolotu=sr.ReadLine();
                    skadString = sr.ReadLine();
                    dokadString = sr.ReadLine();
                    skad = bazalotnisk.WyszukajLotnisko(skadString);
                    dokad = bazalotnisk.WyszukajLotnisko(dokadString);
                    licznikM = sr.ReadLine();
                    licznik_miejsc = Int32.Parse(licznikM);
                    for(int i = 0; i < licznik_miejsc; i++)
                    {
                        zmienna = sr.ReadLine();
                        miejsce = Int32.Parse(zmienna);
                        zajete_miejsca.Add(miejsce);
                      
                    }
                    data = sr.ReadLine();
                    Samolot samolot = new Samolot(Int32.Parse(nr_samolotu), skad, dokad, data, zajete_miejsca);
                    bazaSamolotow.Add(samolot);
                }
            }
            else
            {
               
            }

            sr.Close();
        }
        public Samolot WyszukajSamolot(string data, string skad, string dokad)
        {
       
                return bazaSamolotow.Find(x => x != null & x.data == data && x.skad.nazwa == skad && x.dokad.nazwa == dokad);
                
            
           
        }
    }
}
