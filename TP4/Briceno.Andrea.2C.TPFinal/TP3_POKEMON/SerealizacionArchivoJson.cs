using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Entidades
{
    public class SerealizacionArchivoJson
    {
        /// <summary>
        /// Genera la ruta del archivo que se guardará 
        /// </summary>
        /// <param name="nombreDelArchivo">nombre del atchivo a guardar</param>
        /// <returns>nombre generado</returns>
        public static string GenerarRutaDelArchivo(string nombreDelArchivo)
        {

            try
            {
                string rutaAuxiliar = AppDomain.CurrentDomain.BaseDirectory;
                string rutaDelArchivo = Path.Combine(rutaAuxiliar, nombreDelArchivo);
                return rutaDelArchivo;

            }
            catch (Exception ex)
            {
                throw new Exception("Error, No se puedo generar la ruta", ex);
            }
        }
        /// <summary>
        /// guarda un objeto generico en un archivo de tipo Json que se guardará en la ruta pasada por parámetro
        /// </summary>
        /// <typeparam name="T">tipo objeto a guardar</typeparam>
        /// <param name="rutaDeGuardado">donde se guardara el </param>
        /// <param name="objeto">objeto a guardar</param>
        public static void SerealizarAJSON<T>(string rutaDeGuardado, T objeto) where T : class
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;
                string objetoEnJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);
                File.WriteAllText(rutaDeGuardado, objetoEnJson);

            }
            catch (Exception ex)
            {

                throw new SerealizacionesException(ex.Message);

            }
        }
        /// <summary>
        /// retorna un objeto generico deserealizado de un archive Json pasado por parámetro
        /// </summary>
        /// <typeparam name="T">tipo de objeto </typeparam>
        /// <param name="rutaDelArchivo"></param>
        /// <returns></returns>
        public static T DeseralizarDesdeJSON<T>(string rutaDelArchivo) where T : class 
        {
            try
            {
                    string objetoJson = File.ReadAllText(rutaDelArchivo);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);
                return objetoDeserealizado;
            }
            catch (Exception ex)
            {
                throw new SerealizacionesException(ex.Message);
            }
        }


    }
}
