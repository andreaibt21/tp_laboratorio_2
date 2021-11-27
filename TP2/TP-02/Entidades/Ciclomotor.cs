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
        /// Constructor de un ciclomotor
        /// </summary>
        /// <param name="marca">marca del ciclomotor</param>
        /// <param name="chasis">chasis del ciclomotor</param>
        /// <param name="color">color del ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            :base(marca, chasis, color)
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

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
