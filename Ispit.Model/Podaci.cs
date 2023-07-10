using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        List<Banka> ListaBanki = new List<Banka>
        {
            new Banka { Simbol = "Zaba", Naziv = "Zagrebacka banka" },
            new Banka { Simbol = "PBZ", Naziv = "Privredna banka Zagreb" },
            new Banka { Simbol = "Erste", Naziv = "Erste bank" },
        };
        public List<Banka> GetList()
        {
            return ListaBanki;
        }

        List<Kljent> ListaKljenata = new List<Kljent>
        {
            new Kljent { ImePrezime = "Nikola Tesla", Stanje = 1034000.45,Banka="PBZ" },
            new Kljent {ImePrezime = "Marko Marulić", Stanje = 1234.55,Banka="Zaba"  },
            new Kljent { ImePrezime = "Ivo Sanader", Stanje = 10011167.78,Banka="Erste" },
            new Kljent {ImePrezime = "Vladimir Par", Stanje = 2554412.69,Banka="Zaba"  },
            new Kljent {ImePrezime = "Stjepan  Mesić", Stanje = 4552.85,Banka="Erste"  },
            new Kljent {ImePrezime = "Kralj Tomislav", Stanje = 4631.63,Banka="PBZ"  },
            new Kljent { ImePrezime = "Slavoljub Penkala", Stanje = 333.69,Banka="PBZ" },
            new Kljent { ImePrezime = "Dmitar Zvonimir", Stanje = 598.94,Banka="Zaba" },
            new Kljent {ImePrezime = "Marija Čapin", Stanje = 2224.21,Banka="Erste"  },
            new Kljent { ImePrezime = "Antonija Grgur", Stanje = 204.86,Banka="Zaba" },
        };
        public List<Kljent> GetList2()
        {
            return ListaKljenata;
        }

        IEnumerable<string> GrupiraniMiliunasi = new string[] { "Nikola Tesla", "Ivo Sanader" ,"Vladimir Par" };

    }
}
