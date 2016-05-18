using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase09
{
    class Gato:Mascota
    {
        public bool maulla;       

        public Gato(string nombreGato, ERaza razaGato):base(nombreGato, razaGato)
        { }

        public Gato(string nombreGato, int edadGato, ERaza razaGato):base (nombreGato, edadGato, razaGato)
        { }

        public ERaza RetornarRaza(Gato gatito)
        {
            return gatito._raza;
        }

        public override void Mostrar()
        {
            Console.WriteLine("\nRAZA: " + this._raza + "\nNOMBRE: " + this._nombre + "\nEDAD: " + this._edad);
        }

        public override void Jugar(string conQueJuego)
        {
            Console.WriteLine("\n{0} esta jugando {1}",this._nombre, conQueJuego);
        }
    }
}
