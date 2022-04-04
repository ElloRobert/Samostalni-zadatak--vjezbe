using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniProjekt
{
    public abstract class Dokument
    {
        public static int Broj = 0;
        public string Prodavac;
        public string Kupac;
        public decimal Iznos;

        public Dokument(string aProdavac, string aKupac, decimal aIznos)
        {
            Broj ++;
            Prodavac= aProdavac;
            Kupac= aKupac;
            Iznos= aIznos;
        }


        public virtual void Unos()
        {
            Console.WriteLine("Unosim podatke {0}, Prodavac:{1}, Kupac{2}, Iznos{3}",Broj,Prodavac,Kupac,Iznos);
        }

        public virtual void Brisanje()
        {
            Console.WriteLine("Brisem podatke {0}, Prodavac:{1}, Kupac{2}, Iznos{3}", Broj, Prodavac, Kupac, Iznos);
        }

        public virtual void Uredi()
        {
            Console.WriteLine(" Uredujem podatke {0}, Prodavac:{1}, Kupac{2}, Iznos{3}", Broj, Prodavac, Kupac, Iznos);
        }

        public virtual void Citam()
        {
            Console.WriteLine("Čitam podatke {0}, Prodavac:{1}, Kupac{2}, Iznos{3}", Broj, Prodavac, Kupac, Iznos);
        }



    }
}
