using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarcia.Servicios
{
    internal interface MenuInterfaz
    {

        /// <summary>
        /// Metodo que implmenta el menu
        /// jzg - 041223
        /// </summary>
        public int mostrarMenu();

        /// <summary>
        /// Metodo que pide el codigo de elemento
        /// jzg - 041223
        /// </summary>
        /// <returns></returns>
        public string pedirCodigoElemento();
    }
}
