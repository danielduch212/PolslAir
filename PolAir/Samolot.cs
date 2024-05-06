using System;
using System.Collections.Generic;
using System.Text;

namespace PolAir
{
    public class Samolot
    {
        public int nr_samolotu;
        public Lotnisko skad;
        public Lotnisko dokad;
        public List<int> zajeteMiejsca=new();
        public String data;
       
        public Samolot(int nr_samolotu, Lotnisko skad, Lotnisko dokad, String data, List<int> zajeteMiejsca)
        {
            this.nr_samolotu = nr_samolotu;
            this.skad = skad;
            this.dokad = dokad;
            this.data = data;
            this.zajeteMiejsca = zajeteMiejsca;

        }
        public Samolot(int nr_samolotu, Lotnisko skad, Lotnisko dokad, String data)
        {
            this.nr_samolotu = nr_samolotu;
            this.skad = skad;
            this.dokad = dokad;
            this.data = data;

        }
        public void DodajZajeteMiejsce(int miejsce)
        {

            zajeteMiejsca.Add(miejsce);
        }

    }
}
