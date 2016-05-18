using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto autoUno = new Auto("FIAT", 4);
            //IFacturable facturable = (IFacturable)autoUno;

            autoUno.Mostrar();

            Console.ReadKey();
            
        }
    }
}
