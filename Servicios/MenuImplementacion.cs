using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarcia.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("0. cerrar menu");
            Console.WriteLine("1. dar de alta nueva cuberteria");
            Console.WriteLine("2. quitar cuberteria");
            Console.WriteLine("3. Ver elementos de la lista");


            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }

        public string pedirCodigoElemento()
        {
            string opcionSeleccionada;

            Console.WriteLine("Esciba el codigoElemento de la cuberteria que quiera modificar");
            opcionSeleccionada = Console.ReadLine();
            return opcionSeleccionada;
        }

    }
}
