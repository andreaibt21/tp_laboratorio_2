using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Crea una instancia de Sedan y Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca del Sedan.</param>
        /// <param name="chasis">Chasis del Sedan.</param>
        /// <param name="color">Color del Sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this( marca, chasis, color, ETipo.CuatroPuertas)
        {
        }

        /// <summary>
        /// Crea una instancia de Sedan seteando todos sus atributos.
        /// </summary>
        /// <param name="marca">Marca del Sedan.</param>
        /// <param name="chasis">Chasis del Sedan.</param>
        /// <param name="color">Color del Sedan.</param>
        /// <param name="tipo">Tipo del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// retorna todos los datos del vehiculo ipo Sedan
        /// </summary>
        /// <returns> retorna un string con los datos</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" {base.Mostrar()}  TIPO : {this.tipo}");
            sb.AppendLine( "");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
