using jzarcia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarcia.Servicios
{
    internal class CuberteriaImplementacion : CuberteriaInterfaz
    {
        List<CuberteriaDto> listaCubertria = new List<CuberteriaDto>();
        MenuInterfaz mi = new MenuImplementacion();

        public List<CuberteriaDto> altaCuberteria(List<CuberteriaDto> listaCubertria)
        {
            CuberteriaDto cuberteria = new CuberteriaDto();
            cuberteria = crearNuevaCuberteria();

            listaCubertria.Add(cuberteria);

            return listaCubertria;
        }


        /// <summary>
        /// Metodo que crea un nuevo objeto cuberteria y le da valores a los atributos
        /// jzg - 041223
        /// </summary>
        /// <returns></returns>
        private CuberteriaDto crearNuevaCuberteria() 
        {
            CuberteriaDto nuevaCuberteria = new CuberteriaDto();

            Console.WriteLine("Escriba una idElemento: ");
            nuevaCuberteria.IdElemento = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("Escriba una nombreElemento: ");
            nuevaCuberteria.NombreElemento = Console.ReadLine();

            
            nuevaCuberteria.CodigoElemento = nuevaCuberteria.IdElemento + nuevaCuberteria.NombreElemento;

            Console.WriteLine("Escriba una descripcionElemento: ");
            nuevaCuberteria.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("Escriba una cantidadElemento: ");
            nuevaCuberteria.CantidadElemento = Convert.ToInt32(Console.ReadLine());



            return nuevaCuberteria;
        
        }



        public List<CuberteriaDto> eliminarCantidadCuberteria(List<CuberteriaDto> listaCubertria)
        {
            
            string codigoElemento = mi.pedirCodigoElemento();
            int numRestar;// = restarNumeroCuberteria(cuberteria);

            foreach (CuberteriaDto cuberteria in listaCubertria)
            {
                if (cuberteria.CodigoElemento.Equals(codigoElemento))
                {
                    numRestar = restarNumeroCuberteria(cuberteria);
                    cuberteria.CantidadElemento = numRestar;
                    
                    break;
                }
                listaCubertria.Add(cuberteria);
            }
            

            return  listaCubertria;
        }

        /// <summary>
        /// metodo que resta a la cantidad ya existente el numero que se introduzca
        /// jzg - 041223
        /// </summary>
        /// <param name="cuberteria"></param>
        /// <returns></returns>
        private int restarNumeroCuberteria(CuberteriaDto cuberteria)
        {
            int patata, patata2, patataADevolver;

            Console.WriteLine("Cuantos numeros de cuberteria queiere quitar? ");
            patata = Convert.ToInt32(Console.ReadLine());

            patata2 =cuberteria.CantidadElemento;

            patataADevolver = patata2 - patata;

            return patataADevolver;
        }


    }
}
