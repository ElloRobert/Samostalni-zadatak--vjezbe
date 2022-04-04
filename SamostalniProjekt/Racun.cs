using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniProjekt
{
    public class Racun:Dokument
    {
        public Racun(string Prodavac, string Kupac, decimal Iznos) :
            base(Prodavac,Kupac,Iznos)
        {


        }

        public override void Unos()
        {
            base.Unos();
            Console.WriteLine("Unosim Racun ");
        }

        public override void Brisanje()
        {
            base.Brisanje();
            Console.WriteLine("Brisem Racun ");
        }

        public override void Uredi()
        {
            base.Uredi();
            Console.WriteLine("uredujem Racun ");

        }
       
        public override void Citam()
        {
            base.Citam();
            Console.WriteLine("Citam Racun ");
        }
       

    }
}
