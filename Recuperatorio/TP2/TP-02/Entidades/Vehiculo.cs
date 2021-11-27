using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Enumerado con las posibles marcas del vehiculo.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, 
            BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumarado con los posibles tamaños del vehiculo.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        /// <summary>
        /// Constructor de vehiculo con sus datos.
        /// </summary>
        /// <param name="chasis">Chasis del vehiculo.</param>
        /// <param name="marca">Marca del vehiculo.</param>
        /// <param name="color">Color del vehiculo.</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Casteo explicito de un objeto de tipo vehiculo a string
        /// </summary>
        /// <param name="p"> retorna un string con los datos del vehiculo</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{ p.GetType().Name.ToUpper() }");
            sb.AppendLine($"CHASIS: {p.chasis}");
            sb.AppendLine($"MARCA : {p.marca}");
            sb.AppendLine($"COLOR : {p.color}");
            sb.AppendLine("---------------------");
            sb.AppendLine($"TAMAÑO : {p.Tamanio}");


            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        /// <summary>
        /// Compara si dos vehiculos son diferentes al tener diferentes chasis.
        /// </summary>
        /// <param name="v1">Primer objeto tipo vehiculo a comparar</param>
        /// <param name="v2">Segundo objeto tipo vehiculo a comparar</param>
        /// <returns>Retorna True si sus chasis NO son iguales, sino false.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
