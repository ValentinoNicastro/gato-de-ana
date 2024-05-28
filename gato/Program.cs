using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gato
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int queso = 50;

            Gato Tom = new Gato();

            Tom.dueno = "Ana";
            Tom.tieneHambre = true;

            Raton Jerry = new Raton();
            
            Jerry.vivo = true;
            Jerry.tieneHambre = true;
            Jerry.comer(ref queso);

            Console.WriteLine("El numero de queso es: {0}", queso);

            Tom.cazar(Jerry);

            Console.WriteLine("{0}", Jerry.VerEstado());
        }

    }

}


