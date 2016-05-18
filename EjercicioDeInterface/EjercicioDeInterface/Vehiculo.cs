using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeInterface
{
    public abstract class Vehiculo:IFacturable
    {
        protected string _marca;
        protected int _cantidadRuedas;

        public Vehiculo(string marca, int cantidadRuedas)
        {
            this._cantidadRuedas = cantidadRuedas;
            this._marca = marca;
        }

        public void Mostrar() 
        {
            Console.WriteLine("interface");
        }

    }
}
