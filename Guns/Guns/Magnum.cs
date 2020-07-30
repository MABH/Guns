using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Magnum : IArma
    {
        public void Dany(string objectiu)
        {
            Console.WriteLine("Sayonara baby, " + objectiu);
        }
    }
}
