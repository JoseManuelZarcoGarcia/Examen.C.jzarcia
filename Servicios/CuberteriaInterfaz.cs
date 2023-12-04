using jzarcia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarcia.Servicios
{
    internal interface CuberteriaInterfaz
    {
        /// <summary>
        /// Metodo que añade a la lista el nuevo objeto 
        /// jzg - 041223
        /// </summary>
        /// <param name="listaCubertria"></param>
        /// <returns></returns>
        public List<CuberteriaDto> altaCuberteria(List<CuberteriaDto> listaCubertria);

        /// <summary>
        /// Metodo que modifica la cantidad de la lista 
        /// jzg - 041223
        /// </summary>
        /// <param name="listaCubertria"></param>
        /// <returns></returns>
        public List<CuberteriaDto> eliminarCantidadCuberteria(List<CuberteriaDto> listaCubertria);

    }
}
