using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador
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

        private Entrenador()
        {
            this.pokemones = new List<Pokemon>();
        }

        public Entrenador(int dni, string nombre, string apellido,
                          int edad, int cantidadDePokebolas, bool campeon,
                          Islas isla, List<Pokemon> pokemones) : this()
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
        public string NombreCompleto
        {
            get
            {
                return this.Nombre + " " + this.Apellido;
            }
        }

        #endregion
        #region METODOS


        public bool AgregarPokemon(Pokemon pokemon)
        {
            if (pokemon is not null) {
                this.pokemones.Add(pokemon);
                return true;
            }
            return false;
        }
        public static bool operator ==(Entrenador e1, Entrenador e2)
        {
            return (e1.Dni == e2.Dni && e1.Nombre == e2.Nombre);
        }
        public static bool operator !=(Entrenador e1, Entrenador e2)
        {
            return !(e1 == e2);
        }

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



        private string MostrarDatos()
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


        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion
    }
}
