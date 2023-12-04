using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzarcia.Dtos
{

    /// <summary>
    /// Clase que representa un objeto del la vida real, en este caso un tipo de cuberteria
    /// jzg - 041223
    /// </summary>
    internal class CuberteriaDto
    {

        //Atributos

        private long idElemento = 0;
        private string codigoElemento = "aaaaa";
        private string nombreElemento = "aaaaa";
        private string descripcionElemento = "aaaaa";
        private int cantidadElemento = 0;

        


        // getter y setter
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }


        //constructores


        /// <summary>
        /// Constructor con valores
        /// jzg - 041223
        /// </summary>
        /// <param name="idElemento"></param>
        /// <param name="codigoElemento"></param>
        /// <param name="nombreElemento"></param>
        /// <param name="descripcionElemento"></param>
        /// <param name="cantidadElemento"></param>
        public CuberteriaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }
        /// <summary>
        /// Constructor vacio
        /// jzg - 041223
        /// </summary>
        public CuberteriaDto()
        {

        }
        
        /// <summary>
        /// Metodo ToString que debueleve un string con los valores de cada atributo
        /// jzg - 041223
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            string patata = "id: " + this.idElemento + " - " +
                "codigoElemento: " + this.codigoElemento + " - " +
                "nombreElemento: " + this.nombreElemento + " - " +
                "descripcionElemento: " + this.descripcionElemento + " - " +
                "cantidadElemento: " + this.cantidadElemento;

                

            return patata;
        }


    }
}
