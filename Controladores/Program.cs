using jzarcia.Dtos;
using jzarcia.Servicios;
using System.Collections.Generic;

namespace jzarcia.Controladores
{

    /// <summary>
    /// Clase principal poe la que empieza el programa
    /// jzg - 041223
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo main por donde empieza la aplicacion
        /// jzg - 041223
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            CuberteriaInterfaz ci = new CuberteriaImplementacion();
            List<CuberteriaDto> listaCubertria = new List<CuberteriaDto>();

            bool cerrar = false;
            int opcionSeleccionada;

            while (!cerrar)
            {
                opcionSeleccionada = mi.mostrarMenu();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrar = true;
                        break;

                    case 1:
                        ci.altaCuberteria(listaCubertria);
                        break;

                    case 2:
                        ci.eliminarCantidadCuberteria(listaCubertria);
                        cerrar = false;
                        break;

                    case 3:
                        foreach(CuberteriaDto cuberteria in listaCubertria)
                        {
                            Console.WriteLine(cuberteria.ToString());                       
                        }

                        cerrar = false;
                        break;

                    default: 
                        Console.WriteLine("no es una opcion valida");
                        cerrar = false;
                        break;

                }
            }
            


        }


    }

}