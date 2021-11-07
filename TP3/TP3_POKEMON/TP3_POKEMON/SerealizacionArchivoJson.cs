using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        /// <param name="nombreDelArchivo"></param>
        /// <returns></returns>
        public static string GenerarRutaDelArchivo(string nombreDelArchivo)
        {
            string rutaAuxiliar = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelArchivo = Path.Combine(rutaAuxiliar, nombreDelArchivo);
            return rutaDelArchivo;
        }

        public static void SerealizarAJSON<T>(string rutaDeGuardado, T objeto) where T : class
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
            jsonSerializerOptions.WriteIndented = true;
            string objetoEnJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);
            File.WriteAllText(rutaDeGuardado, objetoEnJson);
        }

        public static T DeseralizarDesdeJSON<T>(string rutaDelArchivo) where T : class 
        {
            string objetoJson = File.ReadAllText(rutaDelArchivo);
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
            jsonSerializerOptions.WriteIndented = true;

            T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);
            return objetoDeserealizado;
        }


    }
}
