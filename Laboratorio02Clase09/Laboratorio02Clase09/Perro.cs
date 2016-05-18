using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase09
{
    public sealed class Perro:Mascota
    {
        public bool ladra;

        //public override string Nombre
        //{
        //    get
        //    {
        //        return this._nombre;
        //    }
        //    set
        //    {
        //        this._nombre = value;
        //    }
        //}

        public Perro(string nombrePerro, ERaza razaPerro)
            : base(nombrePerro, razaPerro)
        { }

        public Perro(string nombrePerro, int edadPerro, ERaza razaPerro):base(nombrePerro, edadPerro, razaPerro)
        { }

        public static ERaza RetornarRaza(Perro perrito)
        {
            return perrito._raza;
        }

        public override void Mostrar()
        {
            Console.WriteLine("\nRAZA: " + this._raza + "\nNOMBRE: " + this._nombre + "\nEDAD: " + this._edad);           
        }

        public override void Jugar(string conQueJuego)
        {
            Console.WriteLine("\n{0} esta jugando {1}",this._nombre ,conQueJuego);
        }
    }
}
