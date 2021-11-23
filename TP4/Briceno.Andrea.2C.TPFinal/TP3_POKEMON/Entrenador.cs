using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador : IDatos
    {

        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        private int cantidadDePokebolas;
        private bool campeon;
        private Islas isla;
        private List<Pokemon> pokemones;
        
       
        #region  CONSTRUCTORES
        /// <summary>
        /// inicializa la lista de pokemones
        /// </summary>

        public Entrenador()
        {
            this.pokemones = new List<Pokemon>();
        }
        /// <summary>
        /// inicializa todos los campos pasados por parametro
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="cantidadDePokebolas"></param>
        /// <param name="campeon"></param>
        /// <param name="isla"></param>
        /// <param name="pokemones"></param>
        public Entrenador(int dni, string nombre, string apellido,
                          int edad, int cantidadDePokebolas, bool campeon,
                          Islas isla, List<Pokemon> pokemones) :this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.cantidadDePokebolas = cantidadDePokebolas;
            this.campeon = campeon;
            this.isla = isla;
            this.pokemones = pokemones;
            
        }
        
        #endregion

        #region PROPIEDADES

    
        /// <summary>
        /// propiedades de lectura y escritura de dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value > 0)
                {
                    this.dni = value;
                }
            }

        }
        /// <summary>
        /// propiedades de lectura y escritura de nombre
        /// </summary>
        public string Nombre {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }

        }
        /// <summary>
        /// propiedades de lectura y escritura de apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.apellido = value;
                }
            }
        }
        /// <summary>
        /// propiedades de lectura y escritura de edad
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (value >= 18)
                {
                    this.edad = value;
                }
            }

        }
        /// <summary>
        /// propiedades de lectura y escritura de cantidadDePokebolas
        /// </summary>
        public int CantidadDePokebolas
        {
            get
            {
                return this.cantidadDePokebolas;
            }
            set
            {
                if (value >= 1 && value < 6)
                {
                    this.cantidadDePokebolas = value;
                }
            }
        }
        /// <summary>
        /// propiedades de lectura y escritura de campeon
        /// </summary>
        public bool Campeon
        {
            get
            {
                return this.campeon;
            }
            set
            {
                this.campeon = value;
            }
        }

        /// <summary>
        /// propiedades de lectura y escritura de isla
        /// </summary>
        public Islas Isla
        {
            get
            {
                return this.isla;
            }
            set
            {
                this.isla = value;
            }
        }
        /// <summary>
        /// propiedades de lectura y escritura de pokemones
        /// </summary>
        public List<Pokemon> Pokemones
        {
            get
            {
                return this.pokemones;
            }
            set
            {
                this.pokemones = value;
            }
        }
        /// <summary>
        /// propiedades de lectura de nombre y apellido
        /// </summary>
        public string NombreCompleto
        {
            get
            {
                return this.Nombre + " " + this.Apellido;
            }
        }

        #endregion
        
        #region METODOS
        /// <summary>
        /// un entrenador será igual a otro si tienen  el mismo dni y nombre
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Entrenador e1, Entrenador e2)
        {
            return (e1.Dni == e2.Dni && e1.Nombre == e2.Nombre);
        }

        /// <summary>
        /// un entrenador será distinto a otro si no tienen  el mismo dni y nombre
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator !=(Entrenador e1, Entrenador e2)
        {
            return !(e1 == e2);
        }
  
        /// <summary>
        /// agrega un pokemon a la lista de pokemones del entrenado, valida que no sea un pokemon repetido
        /// </summary>
        /// <param name="entrenador"></param>
        /// <param name="pokemon"></param>
        /// <returns></returns>
        public static Entrenador operator +(Entrenador entrenador, Pokemon pokemon)
        {

            if (entrenador is not null && pokemon is not null)
            {
                if(entrenador.pokemones.Count < entrenador.CantidadDePokebolas)
                {
                    foreach (Pokemon item in entrenador.pokemones)
                    {
                        if (item == pokemon)
                        {

                            return entrenador;
                        }
                    }
                    entrenador.pokemones.Add(pokemon);
                }
            }
            return entrenador;
        }

        /// <summary>
        /// Elimina un pokemon de la lista de pokemones del entrenado
        /// </summary>
        /// <param name="entrenador"></param>
        /// <param name="pokemon"></param>
        /// <returns></returns>
        public static Entrenador operator -(Entrenador entrenador, Pokemon pokemon)
        {
            if (pokemon is not null  && entrenador is not null)
            {
                foreach (Pokemon item in entrenador.Pokemones)
                {
                    if (pokemon == item)
                    {
                        entrenador.Pokemones.Remove(item);
                        break;
                    }
                }
            }
            return entrenador;
        }
 
        /// <summary>
        /// será privado y retorna un string con los datos del entrenador
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Entrenador: { this.Nombre} {this.Apellido}  ");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Cantidad de Pokebolas: {this.CantidadDePokebolas} ");
            sb.AppendLine($"Es campeón: {this.Campeon} ");
            sb.AppendLine($"Isla: {this.Isla} ");
            sb.AppendLine($"  ");

            if (this.Pokemones.Count != 0)
            {
                sb.AppendLine($"Pokemones:  ");
                sb.AppendLine($"  ");
                foreach (Pokemon item in this.Pokemones)
                {
                    sb.AppendLine($" {item.ToString()} ");
                }
            }
            else
            {
                sb.AppendLine($" No tiene pokemones ");

            }
            return sb.ToString();
        }


        /// <summary>
        /// retorna mostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
      
    



       

        #endregion
    }
}
