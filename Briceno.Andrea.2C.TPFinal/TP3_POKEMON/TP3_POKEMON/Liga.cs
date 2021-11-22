using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liga
    {
        private string nombre;
        public  List<Entrenador> entrenadores;
        public List<Pokemon> pokemones;


        /// <summary>
        /// propiedades de lectura y escritura de la lista de entrenadores
        /// </summary>
        public List<Entrenador> Entrenadores 
        {
            get { return this.entrenadores; }
            set { this.entrenadores = value; }
        }
        /// <summary>
        /// propiedades de lectura y escritura de la lista de pokemones
        /// </summary>
        public List<Pokemon> Pokemones
        {
            get { return this.pokemones; }
            set { this.pokemones = value; }
        }
        /// <summary>
        /// inicializa una lista de pokemons y una de entrenadores
        /// </summary>
        private Liga()
        {
            this.entrenadores = new List<Entrenador>();
            this.pokemones = new List<Pokemon>();
        }
        /// <summary>
        /// Inicializa una liga con solo el atributo nombre
        /// </summary>
        /// <param name="nombre"></param>
        public Liga(string nombre)
           : this()
        {
            this.nombre = nombre;
            //this.delPromedios = PromedioDeDatosDePokemonesEscogidoPorEntrenadores;
            //this.CuentasDePromedioListas += delPromedios;

        }
        /// <summary>
        /// Inicializa cada atributo de la clase pasada por parámetro.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="entrenadores"></param>
        /// <param name="pokemones"></param>
        public Liga(string nombre, List<Entrenador> entrenadores, List<Pokemon> pokemones)
            :this(nombre)
        {
            this.entrenadores = entrenadores;
            this.pokemones = pokemones;
        }
        /// <summary>
        /// retorna true cuando el entrenador está inscripto en la liga
        /// </summary>
        /// <param name="liga"></param>
        /// <param name="entrenador"></param>
        /// <returns></returns>
        public static bool operator ==(Liga liga, Entrenador entrenador)
        {
            if (entrenador is not null && liga.entrenadores.Count != 0)
            {
                foreach (Entrenador item in liga.entrenadores)
                {
                    if (item == entrenador)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
        /// <summary>
        /// retorna false cuando el entrenador no está inscripto en la liga
        /// </summary>
        /// <param name="liga"></param>
        /// <param name="entrenador"></param>
        /// <returns></returns>
        public static bool operator !=(Liga liga, Entrenador entrenador)
        {
            return !(liga == entrenador);
        }

        /// <summary>
        /// Agrega un entrenador a la lista de entrenadores de la  liga, valida que no sea un entrenador repetido
        /// </summary>
        /// <param name="liga"></param>
        /// <param name="entrenador"></param>
        /// <returns></returns>
        public static Liga operator +(Liga liga, Entrenador entrenador) 
        {

            if ( liga is not null && entrenador is not null)
            {
                foreach (Entrenador item in liga.entrenadores)
                {
                    if (item == entrenador) 
                    {
                        return liga;
                    }
                }
                    liga.entrenadores.Add(entrenador);
            }
            return liga;
        }
        /// <summary>
        /// Agrega un pokemon a la lista de pokemones de la  liga, valida que no sea un pokemon repetido
        /// </summary>
        /// <param name="liga"></param>
        /// <param name="pokemon"></param>
        /// <returns></returns>
        public static Liga operator +(Liga liga, Pokemon pokemon) 
        {

            if (liga is not null && pokemon is not null)
            {
                foreach (Pokemon item in liga.pokemones)
                {
                    if (item == pokemon)
                    {
                        return liga;
                    }
                }
                    liga.pokemones.Add(pokemon);
            }
            return liga;
        }
        /// <summary>
        /// Elimina un entrenador de la lista de entrenadores de la liga
        /// </summary>
        /// <param name="liga"></param>
        /// <param name="entrenador"></param>
        /// <returns></returns>
        public static Liga operator -(Liga liga, Entrenador entrenador)
        {
            if (liga is not null && entrenador is not null)
            {
                if (liga == entrenador)
                {
                    liga.entrenadores.Remove(entrenador);
                    return liga;
                }
            }
            return liga;
        }
        public static float PromedioDeDatosDePokemonesEscogidoPorEntrenadores(List<Entrenador> entrenadores, string tipo)
        {
            float resultado = -1;
            int tipoTotal = 0;
            int totalPokemonesElegidos = 0;
            if (entrenadores is not null)
            {
                foreach (Entrenador item in entrenadores)
                {
                    foreach (Pokemon poke in item.Pokemones)
                    {
                        totalPokemonesElegidos++;
                        switch (tipo)
                        {
                            case "HP":
                                tipoTotal += poke.Hp;
                                break;
                            case "Ataque":
                                tipoTotal += poke.Ataque;
                                break;
                            case "Defensa":
                                tipoTotal += poke.Defensa;
                                break;
                            case "Velocidad":
                                tipoTotal += poke.Velocidad;
                                break;

                        }
                    }
                }
                resultado = tipoTotal / (float)totalPokemonesElegidos;
            }
            return resultado;
        }

        public static float PorcentajeDePokemonesEscogidoPorEntrenador(List<Entrenador> entrenadores, Pokemon pokemon)
        {
            float resultado = -1;
            int coincidenciaPokemon = 0;
            int totalPokemonesElegidos = 0;
            if (entrenadores is not null && pokemon is not null)
            {
                foreach (Entrenador item in entrenadores)
                {
                    foreach (Pokemon poke in item.Pokemones)
                    {
                        totalPokemonesElegidos++;
                        if (poke == pokemon)
                        {
                            coincidenciaPokemon++;
                        }
                    }
                }
                resultado = coincidenciaPokemon * 100 / (float)totalPokemonesElegidos;
            }
            return resultado;
        }


        public static float PorcentajeDeIslaEscogidoPorEntrenador(List<Entrenador> entrenadores, Islas isla)
        {
            float resultado = -1;
            int coincidenciaPokemon = 0;
            int totalIslaElegida = 0;
            if (entrenadores is not null)
            {
                foreach (Entrenador item in entrenadores)
                {  
                    totalIslaElegida++;
                    if (isla == item.Isla)
                    {
                        coincidenciaPokemon++;
                    }
                }
                resultado = coincidenciaPokemon * 100 / (float)totalIslaElegida;
            }
            return resultado;
        }

        /*         
           
            % de entrenadores campeones y no campeones
        */
        /// <summary>
        /// Devuelve el porcentaje de Campeon por isla 
        /// </summary>
        /// <param name="entrenadores">lista de entrenadores</param>
        /// <param name="escampeon">bool, si es campeon será true si no false</param>
        /// <param name="isla">isla seleccionada</param>
        /// <returns></returns>
        public static float PorcentajeDeCampeonPorIsla(List<Entrenador> entrenadores, bool escampeon, Islas isla)
        {
            float resultado = -1;
            int tipoTotal = 0;
            if (entrenadores is not null)
            {
                foreach (Entrenador item in entrenadores)
                {

                    switch (isla)
                    {
                        case Islas.Prima:
                            if (item.Campeon == escampeon)
                            {
                                tipoTotal++;
                            }
                            break;
                        case Islas.Secunda:
                            if (item.Campeon == escampeon)
                            {
                                tipoTotal++;
                            }
                            break;
                        case Islas.Tera:
                            if (item.Campeon == escampeon)
                            {
                                tipoTotal++;
                            }
                            break;
                   
                    }

                  
                }
                resultado = tipoTotal / (float)entrenadores.Count * 100;
            }
            return resultado;
        }



        /// <summary>
        /// Devuelve el porcentaje de inscriptos mayor o menor a 21
        /// </summary>
        /// <param name="entrenadores">lista de entrenadore</param>
        /// <param name="tipo">dbe ser "Mayor" o "Menor"</param>
        /// <returns>float del porcentaje sacado</returns>
        public static float PorcentajeDeEdadDeEntrenador(List<Entrenador> entrenadores, string tipo)
        {
            float resultado = -1;
            int tipoTotal = 0;
            if (entrenadores is not null)
            {
                foreach (Entrenador item in entrenadores)
                {
                  
                    switch (tipo)
                    {
                        case "Mayor":
                            if (item.Edad >= 21 )
                            {
                                tipoTotal++;
                            }
                            break;
                        case "Menor":
                            if (item.Edad < 21)
                            {
                                tipoTotal++;
                            }
                            break;
                    }
                }
                resultado = tipoTotal / (float)entrenadores.Count * 100;
            }
            return resultado;
        }




    }//fin de clase
}
