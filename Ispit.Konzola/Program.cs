using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit.Model.Klase;
using Ispit.Model;
namespace Ispit.Konzola
{
    internal class Program
    {
       
       
        static void Main(string[] args)
        {


            ////////////////////////////////////////////////////////////////////////////////////////////////////
            List<Banka> ListaBanki = new List<Banka>
            {
                new Banka { Simbol = "Zaba", Naziv = "Zagrebacka banka" },
                new Banka { Simbol = "PBZ", Naziv = "Privredna banka Zagreb" },
                new Banka { Simbol = "Erste", Naziv = "Erste bank" },
            };

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
            IEnumerable<string> GrupiraniMiliunasi = new string[] { "Nikola Tesla", "Ivo Sanader", "Vladimir Par" };

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            //7.A                                                                                                /
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            var GrupirajPremaBanci = ListaBanki.GroupJoin(
            ListaKljenata,
            banka => banka.Simbol,
            kljent => kljent.Banka,

            (banka, grupaKljenata) => new
            {
                Kljenti = grupaKljenata,
                NazivBanke = banka.Simbol


            });
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            ///7..B                                                                                              /
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            foreach (var stavka in GrupirajPremaBanci)
            {
               
                Console.WriteLine(stavka.NazivBanke);
                foreach (var polaznik in stavka.Kljenti)
                {
                    if (polaznik.Stanje > 1000000)
                    {
                        Console.WriteLine(polaznik.ImePrezime);
                    }
                }
                Console.WriteLine();

             

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            //7.C)                                                                                               /
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            var IzvjestajMiliunasa = from p in ListaKljenata
                                     where p.Stanje > 1000000
                                     select p.ImePrezime ;

            foreach (var s in IzvjestajMiliunasa)

            {
                Console.WriteLine("Miliunas  je " + s);


            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            //7.D ovo je jako loše rješenje                                                                      /
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            foreach (var x in IzvjestajMiliunasa)
            {
                switch (x)
                {
                    case "Vladimir Par":
                        Console.WriteLine(x + " je u " + "Zagrebacka banka");
                        break;
                    case "Ivo Sanader":
                        Console.WriteLine(x + " je u " + "Erste bank");
                        break;
                    case "Nikola Tesla":
                        Console.WriteLine(x + " je u " + "Privredna banka Zagreb");
                        break;
                }
             ////////////////////////////////////////////////////////////////////////////////////////////////////
                   

                
                
                
            }
            Console.ReadLine();
        }

    }
}
