using System;
using System.Collections.Generic;
using System.Text;


namespace PolAir
{
   public class Lotnisko
    {

        public String nazwa;
        public double szerokosc_geograficzna;
        public double dlugosc_geograficzna;
        public Lotnisko(String nazwa, double szerokosc_geograficzna, double dlugosc_geograficzna)
        {
            this.nazwa = nazwa;
            this.szerokosc_geograficzna = szerokosc_geograficzna;
            this.dlugosc_geograficzna = dlugosc_geograficzna;
        }
        
    }
}
