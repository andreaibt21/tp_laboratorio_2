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
        private List<Pokemon> pokemones;

        public List<Entrenador> Entrenadores 
        {
            get { return this.entrenadores; }
            set { this.entrenadores = value; }
        }
        public List<Pokemon> Pokemones
        {
            get { return this.pokemones; }
            set { this.pokemones = value; }
        }

        private Liga()
        {
            this.entrenadores = new List<Entrenador>();
            this.pokemones = new List<Pokemon>();
        }
        public Liga(string nombre)
           : this()
        {
            this.nombre = nombre;
           
        }

        public Liga(string nombre, List<Entrenador> entrenadores, List<Pokemon> pokemones)
            :this()
        {
            this.nombre = nombre;
            this.entrenadores = entrenadores;
            this.pokemones = pokemones;
        }

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
        public static bool operator !=(Liga liga, Entrenador entrenador)
        {
            return !(liga == entrenador);
        }


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
   
    
        
    
    
    }//fin de clase
}
