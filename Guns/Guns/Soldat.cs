using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Soldat
    {
        readonly IArma arma;
        public Soldat(IArma arma)
        {
            this.arma = arma;
        }

        public void Dispara(string objectiu)
        {
            this.arma.Dany(objectiu);
        }
    }
}
