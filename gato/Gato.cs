using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gato
{
    public class Gato
    { 
        public bool tieneHambre;
        public string dueno;

        public void cazar(Raton r)
        {
            if (r.vivo && tieneHambre)
            {
                r.vivo = false;
                tieneHambre = false;
            }
        }
    }
}
