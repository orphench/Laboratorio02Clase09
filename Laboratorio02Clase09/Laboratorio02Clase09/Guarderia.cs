using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase09
{
    class Guarderia:ICargar,IGuardar
    {
        private List<Mascota> _listaMascota;
        private float _precioGato;
        private float _precioPerro;

        public float PrecioPorGato
        {
            get { return this._precioGato; }
        }

        public float PrecioPorPerro
        {
            get { return this._precioPerro; }
        }

        public Guarderia(float precioGato, float precioPerro)
        {
            this._precioGato = precioGato;
            this._precioPerro = precioPerro;

            //precioGato = 20;
            //precioPerro = 30;
        }

        //public static Guarderia operator +(Guarderia miGuarderia, Mascota unaMascota)
        //{
        //    miGuarderia._listaMascota.Add(unaMascota);

        //    return miGuarderia;
        //}

        public float MostrarTotalFacturado()
        {
            float total = 0;

            total = this.PrecioPorGato + this.PrecioPorPerro;

            return total;
        }

        public void IngresarMascota(Mascota miMascota)
        {
            this._listaMascota.Add(miMascota);
        }

        
    }
}
