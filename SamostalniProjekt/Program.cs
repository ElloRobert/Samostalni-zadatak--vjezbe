using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Racun dok = new Racun( "Marko Maric", "Ivo Ivić", 2.11m);
            dok.Citam();
            Ponuda dok1 = new Ponuda("Marko Maric", "Ivo Ivić", 2.11m);
            dok1.Unos();
            Racun dok2 = new Racun("Marko Maric", "Ivo Ivić", 2.11m);
            dok2.Brisanje();
            Console.ReadKey();
            
        }


    }
}
