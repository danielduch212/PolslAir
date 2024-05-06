using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolAir {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BazaUzytkownikow bazaUzytkownikow = new BazaUzytkownikow();
            BazaSamolotow bazaSamolotow = new BazaSamolotow();
            BazaBiletow bazaBiletow = new BazaBiletow();
            Uzytkownik uzytkownik = new Uzytkownik("daniel", "michal", "email", "haslo");
            Uzytkownik uzytkownik1 = new Uzytkownik("ds", "dsad", "dsad", "dsads");
            bazaUzytkownikow.DodajDoBazy(uzytkownik);
            bazaUzytkownikow.DodajDoBazy(uzytkownik1);
            var logowanie = new Logowanie(bazaUzytkownikow, bazaSamolotow, bazaBiletow);
            Application.Run(logowanie);
        }
    }
}

