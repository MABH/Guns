using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Ametralladora:IArma
    {
        public void Dany(string objectiu)
        {
            Console.WriteLine("Saludaré a tu viuda, "+ objectiu);
        }
    }
}
