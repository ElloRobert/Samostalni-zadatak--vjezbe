using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniProjekt
{
    internal class Ponuda:Dokument
    {
       
            public Ponuda(string Prodavac, string Kupac, decimal Iznos) :
                base(Prodavac, Kupac, Iznos)
            {


            }

            public override void Unos()
            {
                base.Unos();
                Console.WriteLine("Unosim Ponudu ");
            }

            public override void Brisanje()
            {
                base.Brisanje();
                Console.WriteLine("Brisem Ponudu ");
            }

            public override void Uredi()
            {
                base.Uredi();
                Console.WriteLine("uredujem Ponudu ");

            }

            public override void Citam()
            {
                base.Citam();
                Console.WriteLine("Citam Ponudu ");
            }


        

    }
}
