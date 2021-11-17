using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerealizacionesException : Exception
    {
        private static string mensajeDeError;
        static SerealizacionesException()
        {
            mensajeDeError = "Error al serializacion del archivo";
        }


        public SerealizacionesException()
        {
        }

        public SerealizacionesException(string message) : base(mensajeDeError)
        {
        }

        public SerealizacionesException(string message, Exception innerException) : base(SerealizacionesException.mensajeDeError, innerException)
        {
        }

       
    }
}
