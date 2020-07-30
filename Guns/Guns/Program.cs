using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soldado:");
            Soldat soldat1 = new Soldat(new Ametralladora());
            Soldat soldat2 = new Soldat(new Beretta());
            Soldat soldat3 = new Soldat(new Magnum());
            soldat1.Dispara("invasor");
            soldat2.Dispara("enemigo");
            soldat3.Dispara("extraterrestre");
            Console.WriteLine(" ");

            Console.WriteLine("Tanque:");
            Tanque tanque1 = new Tanque(new Apds());
            Tanque tanque2 = new Tanque(new Apfsds());
            Tanque tanque3 = new Tanque(new Heat());
            tanque1.Dispara("invasor");
            tanque2.Dispara("enemigo");
            tanque3.Dispara("extraterrestre");
            Console.WriteLine(" ");
        }
    }
}
