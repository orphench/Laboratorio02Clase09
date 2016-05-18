using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase09
{
    public abstract class Mascota
    {
        protected int _edad;
        protected string _nombre;
        protected ERaza _raza;

        public Mascota(string nombre, ERaza raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        public Mascota(string nombre, int edad, ERaza raza):this(nombre, raza)
        {
            this._edad = edad;
        }

        //public abstract string Nombre
        //{
        //    get;
        //    set;
        //}

        public abstract void Mostrar();//no lleva implementacion

        public virtual void Jugar(string conQueJuego)//lleva implimentacion
        { }
    }
}
