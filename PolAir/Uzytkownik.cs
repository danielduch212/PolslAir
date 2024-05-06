using System;
using System.Collections.Generic;
using System.Text;

namespace PolAir
{
   public  class Uzytkownik
    {
        public String imie { get; private set;}
        public String nazwisko { get; private set; }
        public String email { get; private set; }
        public String haslo { get;  set; }
        int ID { get; set; }

        public Uzytkownik(String imie, String nazwisko, String email, String haslo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.haslo = haslo;
      
        }
    }
}
