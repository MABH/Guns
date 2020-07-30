using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Tanque
    {
        readonly IArma proyectil;
        public Tanque(IArma proyectil)
        {
            this.proyectil = proyectil;
        }

        public void Dispara(string objectiu)
        {
            this.proyectil.Dany(objectiu);
        }
    }
}
