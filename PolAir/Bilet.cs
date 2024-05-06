using System;
using System.Collections.Generic;
using System.Text;

namespace PolAir
{
    public class Bilet
    {
        public String imie;
        public String nazwisko;
        public String email;
        public String data;
        public Lotnisko from;
        public Lotnisko to;
        public int miejsce;

        public Bilet(String imie, String nazwisko, String email,String data, Lotnisko from, Lotnisko to, int miejsce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.from = from;
            this.to = to;
            this.data = data;
            this.miejsce = miejsce;
        }
    }
}
