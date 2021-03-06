using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class ManejoBD
    {
        private static string cadenaDeConexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;

        static ManejoBD()
        {
            ManejoBD.cadenaDeConexion = @"Server=.;Database=TpFinalBricenoAndrea;Trusted_Connection=True;";
        }

        public ManejoBD()
        {
            conexion = new SqlConnection(ManejoBD.cadenaDeConexion);
        }

        public bool ProbarConexion()
        {
            bool retorno = true;

            try
            {

                conexion.Open();
            }
            catch (Exception)
            {

                retorno = false;
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public bool AgregarPokemon(Pokemon pokemon)
        {
            bool retorno = true;

            try
            {   comando = new SqlCommand();
                comando.Connection = conexion;

                comando.CommandText = "INSERT INTO dbo.Pokemon(IdPokemon, Especie, Hp, Tipo, Ataque, Defensa, Velocidad, NombreDeAtaque) " +
                                      "VALUES (@IdPokemon, @Especie, @Hp, @Tipo, @Ataque, @Defensa, @Velocidad, @NombreDeAtaque)";
                comando.Parameters.AddWithValue("@IdPokemon", pokemon.Id); // int
                comando.Parameters.AddWithValue("@Especie", pokemon.Especie); //string
                comando.Parameters.AddWithValue("@Hp", pokemon.Hp);
                comando.Parameters.AddWithValue("@Tipo", pokemon.Tipo); //esto es un enum
                comando.Parameters.AddWithValue("@Ataque", pokemon.Ataque);
                comando.Parameters.AddWithValue("@Defensa", pokemon.Defensa);
                comando.Parameters.AddWithValue("@Velocidad", pokemon.Velocidad);
                comando.Parameters.AddWithValue("@NombreDeAtaque", pokemon.NombreDeAtaque);
                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    retorno = false; 
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public bool AgregarEntrenador(Entrenador entrenador)
        {
            bool retorno = true;

            try
            {
                comando = new SqlCommand();
                comando.Connection = conexion;
                int filasAfectadas = 0;

                foreach (Pokemon item in entrenador.Pokemones)
                {
                    comando.CommandText = "INSERT INTO dbo.Entrenador(Dni, Nombre, Apellido, Edad, CantidadDePokebolas, Campeon, Isla, IDPokemon) " +
                                                           "VALUES (@Dni, @Nombre, @Apellido, @Edad, @CantidadDePokebolas, @Campeon, @Isla, @IDPokemon)";
                    comando.Parameters.AddWithValue("@Dni", entrenador.Dni);
                    comando.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", entrenador.Apellido);
                    comando.Parameters.AddWithValue("@Edad", entrenador.Edad);
                    comando.Parameters.AddWithValue("@CantidadDePokebolas", entrenador.CantidadDePokebolas);
                    comando.Parameters.AddWithValue("@Campeon", entrenador.Campeon);
                    comando.Parameters.AddWithValue("@Isla", entrenador.Isla);
                    comando.Parameters.AddWithValue("@IDPokemon", item.Id);
                    conexion.Open();
                    filasAfectadas = comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    conexion.Close();
                }

                if (filasAfectadas == 0)
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public bool EliminarEntrenador(int DniEntrenador)
        {
            bool retorno = true;

            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@Dni", DniEntrenador);

                string sql = "DELETE FROM dbo.Entrenador ";
                sql += "WHERE Dni = @Dni";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;

        }

        public bool ModificarEntrenador(Entrenador entrenador)
        {
            bool retorno = true;
            try
            {
                if (EliminarEntrenador(entrenador.Dni)) {

                    if (!AgregarEntrenador(entrenador))
                    {
                        retorno = false;

                    }
                }
                else
                {
                    retorno = false;

                }


            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public bool agregarLaListaDePokemonesALaBD(List<Pokemon> pokemones)
        {
            int cantidadPokemones = pokemones.Count;
            int cantidadAgregados = 0;
            bool retorno = false;
            foreach (var item in pokemones)
            {
                if (!AgregarPokemon(item))
                {
                    break;
                }
                else
                {
                    cantidadAgregados++;
                }
            }
            if (cantidadPokemones == cantidadAgregados)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool EliminarPokemon(int idPokemon)
        {
            bool retorno = true;

            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@IdPokemon", idPokemon);

                string sql = "DELETE FROM dbo.Pokemon ";
                sql += "WHERE IdPokemon = @IdPokemon";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;

        }

        public bool AgregarEntrenadorConPokemon(Entrenador entrenador, int idPokemon)
        {
            bool retorno = true;

            try
            {
                comando = new SqlCommand();
                comando.Connection = conexion;
                int filasAfectadas = 0;

                //foreach (Pokemon item in entrenador.Pokemones)
                //{
                comando.CommandText = "INSERT INTO dbo.EntrenadorPokemon (Dni, IDPokemon) " +
                                                       "VALUES (@Dni, @IDPokemon)";
                comando.Parameters.AddWithValue("@Dni", entrenador.Dni);
                comando.Parameters.AddWithValue("@IDPokemon", idPokemon);
                //    comando.Parameters.AddWithValue("@IDPokemon", entrenador.Pokemones[0].Id);
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.Close();
                //  }

                if (filasAfectadas == 0)
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public bool agregarLaListaDeEntrenadoresALaBD(List<Entrenador> entrenadores)
        {
            int cantidadPokemones = entrenadores.Count;
            int cantidadAgregados = 0;
            bool retorno = false;
            foreach (var item in entrenadores)
            {
                if (!AgregarEntrenador(item))
                {
                    break;
                }
                else
                {
                    cantidadAgregados++;
                }
            }
            if (cantidadPokemones == cantidadAgregados)
            {
                retorno = true;
            }
            return retorno;
        }

        public List<Entrenador> ObtenerListaEntrenador()
        {
            List<Entrenador> lista = new List<Entrenador>();

            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT* FROM Entrenador" +
                                      " INNER JOIN Pokemon ON Pokemon.Idpokemon = Entrenador.IdPokemon " +
                                      "  ORDER BY Entrenador.Dni ASC";


                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    int dni = int.Parse(lector["Dni"].ToString());
                    bool existe = lista.Exists((x) => x.Dni == dni);

                    if (!existe)
                    {
                        Entrenador entrenador = new Entrenador();
                        entrenador.Dni = dni;
                        entrenador.Nombre = lector["Nombre"].ToString();
                        entrenador.Apellido = lector["Apellido"].ToString();
                        entrenador.Edad = lector.GetInt32("Edad");
                        entrenador.CantidadDePokebolas = lector.GetInt32("CantidadDePokebolas");
                        entrenador.Campeon = (bool)lector["Campeon"];
                        entrenador.Isla = (Islas)Enum.Parse(typeof(Islas), lector["Isla"].ToString());
                        List<Pokemon> pokemones = new List<Pokemon>();

                        Pokemon pokemon = new Pokemon(  lector.GetInt32("IdPokemon"), 
                                                        lector["Especie"].ToString(),
                                                         (ETipos)Enum.Parse(typeof(ETipos), lector["Tipo"].ToString()),
                                                          lector.GetInt32("Hp"),
                                                          lector.GetInt32("Ataque"),
                                                           lector.GetInt32("Defensa"),
                                                           lector.GetInt32("Velocidad"),
                                                           lector["NombreDeAtaque"].ToString());
                        entrenador += pokemon;
                        lista.Add(entrenador);
                    }
                    else
                    {
                        int id = lista.FindIndex((x) => x.Dni == dni);
                        Pokemon pokemon = new Pokemon(lector.GetInt32("IdPokemon"),
                                                       lector["Especie"].ToString(),
                                                        (ETipos)Enum.Parse(typeof(ETipos), lector["Tipo"].ToString()),
                                                         lector.GetInt32("Hp"),
                                                         lector.GetInt32("Ataque"),
                                                          lector.GetInt32("Defensa"),
                                                          lector.GetInt32("Velocidad"),
                                                          lector["NombreDeAtaque"].ToString());
                     
                        lista[id].Pokemones.Add(pokemon);
                    }
                }
                lector.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }


            return lista;
        }

        /// <summary>
        /// Obtiene la lista de pokemones guardada en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Pokemon> ObtenerListaDePokemones()
        {
            List<Pokemon> lista = new List<Pokemon>();

            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT* FROM Pokemon";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon pokemon = new Pokemon(lector.GetInt32("IdPokemon"),
                                                    lector["Especie"].ToString(),
                                                        (ETipos)Enum.Parse(typeof(ETipos), lector["Tipo"].ToString()),
                                                        lector.GetInt32("Hp"),
                                                        lector.GetInt32("Ataque"),
                                                        lector.GetInt32("Defensa"),
                                                        lector.GetInt32("Velocidad"),
                                                        lector["NombreDeAtaque"].ToString());
                    lista.Add(pokemon);
                }
                lector.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }


            return lista;
        }



    } //fin clase
}
