using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCIIN5_Beadando
{
    public class Termek
    {
        public string name { get; set; }
        public string Gyartasido { get; set; }
        public string Gyarto { get; set; }
        public string Szin { get; set; }
        public int Ar { get; set; }

        public static Termek[] GetTermeks()
        {
            Termek[] termeks = new Termek[14];

            termeks[0] = new Termek { name = "Play Station4", Gyartasido = "2013", Gyarto = "Sony", Szin = "Fekete", Ar = 100000 };
            termeks[1] = new Termek { name = "Play Station5", Gyartasido = "2020", Gyarto = "Sony", Szin = "Fehér", Ar = 184990 };
            termeks[2] = new Termek { name = "Xbox One", Gyartasido = "2013", Gyarto = "Microsoft", Szin = "Fekete", Ar = 84990 };
            termeks[3] = new Termek { name = "Xbox SeriesX", Gyartasido = "2020", Gyarto = "Microsoft", Szin = "Fehér", Ar = 184990 };
            termeks[4] = new Termek { name = "Nintendo Switch", Gyartasido = "2017", Gyarto = "Nintendo", Szin = "Piros;Kék", Ar = 109000 };
            termeks[5] = new Termek { name = "Samsung QLed65", Gyartasido = "2020", Gyarto = "Samsung", Szin = "Piros;Zöld;Fekete", Ar = 250000 };
            termeks[6] = new Termek { name = "Samsung OLed77", Gyartasido = "2018", Gyarto = "Samsung", Szin = "Fehér;Kék", Ar = 189999 };
            termeks[7] = new Termek { name = "Philips 32_4KHD", Gyartasido = "2019", Gyarto = "Philips", Szin = "Szürke;Fehér", Ar = 109121 };
            termeks[8] = new Termek { name = "Sony T46_4KHD", Gyartasido = "2020", Gyarto = "Sony", Szin = "Fekete", Ar = 204566 };
            termeks[9] = new Termek { name = "iPhone 11 Pro", Gyartasido = "2018", Gyarto = "Apple", Szin = "Kék;Zöld;Sárga;Piros", Ar = 348999 };
            termeks[10] = new Termek { name = "iPhone 12 Pro", Gyartasido = "2020", Gyarto = "Apple", Szin = "Fekete;Fehér", Ar = 440000 };
            termeks[11] = new Termek { name = "Samsung S20 Ultra", Gyartasido = "2019", Gyarto = "Samsung", Szin = "Fekete", Ar = 384780 };
            termeks[12] = new Termek { name = "Samsung A71", Gyartasido = "2020", Gyarto = "Samsung", Szin = "Szürke;Fekete", Ar = 102960 };

            return termeks;
        }
    }
}
