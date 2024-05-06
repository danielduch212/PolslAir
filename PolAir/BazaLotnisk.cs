using System;
using System.Collections.Generic;
using System.Text;


namespace PolAir
{
    public class BazaLotnisk
    {
       List<Lotnisko> bazaLotnisk = new List<Lotnisko>();
       Lotnisko warszawaChopin = new Lotnisko("warszawachopin", 52.1656990051, 20.967100143399996);
       Lotnisko lizbona_Portela = new Lotnisko("Lizbona Portela",-9.135919570919999, 38.7812995911);
       Lotnisko madryt = new Lotnisko("Madryt", -3.56676, 40.4936);
       Lotnisko ateny = new Lotnisko("Ateny", 23.9444999695, 37.9364013672);
       Lotnisko amsterdam = new Lotnisko("Amsterdam", 4.763889789579999, 52.3086013794);
       Lotnisko losAngeles = new Lotnisko("Los Angeles", 34.0194, -118.411);
       Lotnisko berlin = new Lotnisko("Berlin", 52.5186, 13.4081);
       Lotnisko paryz = new Lotnisko("Paryż",48.8032, 2.3511);
       Lotnisko reykjavik = new Lotnisko("Reykjavik", 64.1300, -21.9406);

       public BazaLotnisk()
       {
            bazaLotnisk.Add(warszawaChopin);
            bazaLotnisk.Add(lizbona_Portela);
            bazaLotnisk.Add(madryt);
            bazaLotnisk.Add(ateny);
            bazaLotnisk.Add(amsterdam);
            bazaLotnisk.Add(losAngeles);
            bazaLotnisk.Add(berlin);
            bazaLotnisk.Add(paryz);
            bazaLotnisk.Add(reykjavik);

       }
     
       public Lotnisko  DajLotnisko(int nr)
        {
            IEnumerator<Lotnisko> enumerator = bazaLotnisk.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i <= nr; i++)
            {
                enumerator.MoveNext();
            }
            return enumerator.Current;
        }

        public Lotnisko WyszukajLotnisko(string nazwa)
        {

            return bazaLotnisk.Find(x => x.nazwa == nazwa);
        }

    }

    

}
