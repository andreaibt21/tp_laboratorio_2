using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Crea una instancia de Ciclomotor con sus datos.
        /// </summary>
        /// <param name="marca">Marca del Ciclomotor.</param>
        /// <param name="chasis">Chasis del Ciclomotor.</param>
        /// <param name="color">Color del Ciclomotor.</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            :base(chasis, marca, color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        /// <summary>
        /// retorna todos los datos del vehiculo tipo Ciclomotor
        /// </summary>
        /// <returns> retorna un string con los datos</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
