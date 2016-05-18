using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase09
{
    class Program
    {
        static void Main(string[] args)
        {

            //PARA LA PROXIMA CLASE HACER UN LISTADO DE INTERFACE

            Perro perroUno = new Perro("COQUITO", 5, ERaza.PastorAleman);
            Perro perroDos = new Perro("ROCO", 2, ERaza.Doberman);
            Perro perroTres = new Perro("LOLA", 3, ERaza.Dogo);

            Gato gatoUno = new Gato("MIAU", 3, ERaza.Persa);
            Gato gatoDos = new Gato("MICHI", 6, ERaza.Siames);
            Gato gatoTres = new Gato("RONRON", 4, ERaza.Egipcio);

            Guarderia GuarderiaUno = new Guarderia(20, 30);

            perroUno.Mostrar();
            gatoUno.Mostrar();

            perroUno.Jugar("Ajedrez");
            gatoUno.Jugar("WoW");

            GuarderiaUno.IngresarMascota(perroUno);
            GuarderiaUno.IngresarMascota(perroDos);
            GuarderiaUno.IngresarMascota(perroTres);

            GuarderiaUno.IngresarMascota(gatoUno);
            GuarderiaUno.IngresarMascota(gatoDos);
            GuarderiaUno.IngresarMascota(gatoTres);

            GuarderiaUno.MostrarTotalFacturado();

            Console.ReadKey();
        }
    }
}
