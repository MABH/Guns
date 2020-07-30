using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Beretta : IArma
    {
        public void Dany(string objectiu)
        {
            Console.WriteLine("El primero en la frente, " + objectiu);
        }
    }
}
