using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Crea una instancia de Suv con sus datos.
        /// </summary>
        /// <param name="marca">Marca del Suv.</param>
        /// <param name="chasis">Chasis del Suv.</param>
        /// <param name="color">Color del Suv.</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }
        /// <summary>
        /// Propiedad ReadOnly, Retornara 'Grande' Para Suv
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        /// <summary>
        /// retorna todos los datos del vehiculo ipo SUV
        /// </summary>
        /// <returns> retorna un string con los datos</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
