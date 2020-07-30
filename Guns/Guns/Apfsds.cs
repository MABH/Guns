using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Apfsds : IArma
    {
        public void Dany(string objectiu)
        {
            Console.WriteLine("Hasta el infinito y más allá, " + objectiu);
        }
    }
}
