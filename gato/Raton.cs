using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gato
{
    public class Raton
    {
        public bool vivo;
        public bool tieneHambre;
        public void comer(ref int queso)
        {
            if (queso >= 2)
            {
                tieneHambre = false;
                queso -= 2;
            }
            else
            {
                if (queso == 1)
                {
                    queso -= 1;
                }
            }
        }
        public string VerEstado() 
        {
            string Resultado = "";
            Resultado += "vivo ";
            if (vivo) Resultado += "Sí";
            else Resultado += "No";

            Resultado += "Hambre ";
            if (tieneHambre) Resultado += "Sí";
            else Resultado += "No";

            return Resultado;
        }
    }
}
