using System;
using System.Collections.Generic;
using System.Text;
namespace Entidades
{
    
    public class Pokemon : IDatos
    {
        private int id;
        private string especie;
        private int hp;
        private ETipos tipo;
        private int ataque;
        private int defensa;
        private int velocidad;
        private string nombreDeAtaque;



        #region CONSTRUCTORES 
        public Pokemon(int id, string especie, ETipos tipo, int hp, int ataque, int defensa, int velocidad, string nombreDeAtaque)
        {
            this.id = id;
            this.especie = especie;
            this.tipo = tipo;
            this.hp = hp;
            this.ataque = ataque;
            this.defensa = defensa;
            this.velocidad = velocidad;
            this.nombreDeAtaque = nombreDeAtaque;
        }
        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// propiedades de lectura y escritura de id
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set {
                if (value > 0)
                { this.id = value; } }
        }
        /// <summary>
        /// propiedades de lectura y escritura de hp
        /// </summary>
        public int Hp
        {
            get { return this.hp; }
            set {
                if (value > 0)
                { this.hp = value; }
            }
        }
        
        /// <summary>
        /// propiedades de lectura y escritura de especie
        /// </summary>
        public string Especie
        {
            get { return this.especie; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                { this.especie = value; }
            }
        }
        /// <summary>
        /// propiedades de lectura y escritura de tipo
        /// </summary>
        public ETipos Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        /// <summary>
        /// propiedades de lectura y escritura de ataque
        /// </summary>
        public int Ataque
        {
            get { return this.ataque; }
            set {
                if (value > 0)
                { this.ataque = value; } }
        }
        /// <summary>
        /// propiedades de lectura y escritura de defensa
        /// </summary>
        public int Defensa
        {
            get { return this.defensa; }
            set {
                if (value > 0)
                { this.defensa = value; }
            }
        }
        /// <summary>
        /// propiedades de lectura y escritura de velocidad
        /// </summary>
        public int Velocidad
        {
            get { return this.velocidad; }
            set {
                if (value > 0)
                { this.velocidad = value; } }
        }
        /// <summary>
        /// propiedades de lectura y escritura de nombre de ataque
        /// </summary>
        public string NombreDeAtaque
        {
            get { return this.nombreDeAtaque; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                { this.nombreDeAtaque = value; }
            }
        }
        #endregion

        /// <summary>
        /// un pokemon será igual a otro si son de la misma especie.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pokemon p1, Pokemon p2)
        {
            if(p1 is not null && p2 is not null) 
            {
                return p1.especie == p2.especie;

            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// un pokemon será distinto a otro si no son de la misma especie
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pokemon p1, Pokemon p2)
        {
            return !(p1 == p2);
        }


        /// <summary>
        /// retorna mostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// retorna un string con los datos del pokemon
        /// </summary>
        /// <returns></returns>

        public string MostrarDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pokemon: { this.Especie} ");
            sb.AppendLine($"Tipo:{this.Tipo}");
            sb.AppendLine($"Hp: {this.Hp}");
            sb.AppendLine($"Ataque: {this.Ataque}   Defensa: {this.Defensa}   Velocidad: {this.Velocidad} ");
            sb.AppendLine($"Nombre de Ataque: {this.NombreDeAtaque} ");
            return sb.ToString();
        }
    }//fin class
}
