using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Heat : IArma
    {
        public void Dany(string objectiu)
        {
            Console.WriteLine("Ouch, eso ha tenido que doler, " + objectiu);
        }
    }
}
