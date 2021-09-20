using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {

        private double numero;


        #region CONSTRUCTORES
       /// <summary>
       /// constructor que inicializa el campo numero en 0;
       /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// constructor que inicializa el campo numero en el numero ingresado por parametro
        /// </summary>
        /// <param name="numero"> numero a inicializar</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// constructor que inicializa el campo numero en el numero ingresado por parametro
        /// </summary>
        /// <param name="strNumero">numero a inicializar</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        /// <summary>
        /// asignará un valor al atributo número, previa validación ( convierte un numero de string a double )
        /// </summary>
        public string  Numero
        {
            set 
            {
               if( ValidarOperando(value) != 0) 
                {
                    this.numero = ValidarOperando(value);
                }
            }
        }

        #endregion


        #region VALIDACION
        /// <summary>
        /// Comprueba que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0
        /// </summary>
        /// <param name="strNumero">valor numerico en string</param>
        /// <returns> retornará en formato double. Caso contrario, retornará 0</returns>
        public double ValidarOperando(string strNumero)
           {
               double numero;

            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
                return numero;
           }


        /// <summary>
        /// Valida que la cadena de caracteres esté compuesta solo por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario">numero binario</param>
        /// <returns> retorna true si esta compuest solo por caracteres '0' o '1'. Caso contrario false </returns>
        private bool EsBinario( string binario)
        {
            bool retorno = false;
            if ( String.IsNullOrEmpty(binario) == false )
            { 
                foreach (char digito in binario)
                {
                    if( digito != '1' && digito != '0')
                    {
                        return retorno ;
                    }   
                }
                retorno = true;
            }
            return retorno;
        }

        #endregion


        #region CONVERSORES
        /// <summary>
        /// valida que se trate de un binario y luego convertirá ese número binario a decimal, en caso de ser posible.Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero">numero a convertir</param>
        /// <returns> retorna el numero convertido, caso contrario "Valor inválido"</returns>
        public string BinarioDecimal(string numero)
        {
            double digitoAuxiliar;
            double potencias = numero.Length - 1;
            double numeroEnDecimal = 0;
            string charAuxiliar;
            int numeroFinal;

            if ( String.IsNullOrEmpty(numero) == false && EsBinario(numero) ) 
            {
                foreach (char digito in numero)
                {
                    charAuxiliar = digito.ToString();
                    double.TryParse(charAuxiliar, out digitoAuxiliar);
                    numeroEnDecimal += ( digitoAuxiliar * Math.Pow(2, potencias) );
                    potencias--;
                }
                numeroFinal= (int)numeroEnDecimal;
                
                return numeroFinal.ToString();
            }
            
            return "Valor inválido";
        }

        /// <summary>
        ///  Convierte un número decimal a binario, en caso de ser posible.Caso contrario retornará "Valor inválido"       
        /// </summary>
        /// <param name="numero">numero a convertir</param>
        /// <returns> retorna el numero convertido, caso contrario "Valor inválido"</returns>
        public string DecimalBinario(double  numero)
       {
            string valorBinario = string.Empty;
            int resultadoDivision = (int)Math.Abs(numero);
            if (resultadoDivision >= 0)
            {
                do
                {
                    valorBinario = resultadoDivision % 2 + valorBinario;
                    resultadoDivision /= 2;

                } while (resultadoDivision > 0);
                return valorBinario;
            }
            return "valor Invalido";
       }

        /// <summary>
        ///  Convierte un número decimal a binario, en caso de ser posible.Caso contrario retornará "Valor inválido"       
        /// </summary>
        /// <param name="numero">numero onvertir</param>
        /// <returns> retorna el numero convertido, caso contrario "Valor inválido"</returns>
        public string DecimalBinario(string numeroRecibido)
        {
            double numeroDouble;
            double.TryParse(numeroRecibido, out numeroDouble);
            
            return DecimalBinario(numeroDouble);
        }
        #endregion


        #region OPERATORS
        /// <summary>
        /// Realiza una division entre dos operandos
        /// </summary>
        /// <param name="n1">numero 1 </param>
        /// <param name="n2">numero 2</param>
        /// <returns>Retorna el resultado de la division</returns>
        public static double operator /(Operando n1, Operando n2)
        {

            if (n2.numero == 0)
            {
                return  double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        /// <summary>
        /// Realiza una multiplicacion entre dos operandos
        /// </summary>
        /// <param name="n1">numero 1 </param>
        /// <param name="n2">numero 2</param>
        /// <returns>Retorna el resultado de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Realiza una resta entre dos operandos
        /// </summary>
        /// <param name="n1">numero 1 </param>
        /// <param name="n2">numero 2</param>
        /// <returns>Retorna el resultado de la resta</returns>
        public static double operator -(Operando n1, Operando n2) 
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Realiza una suma entre dos operandos
        /// </summary>
        /// <param name="n1">numero 1 </param>
        /// <param name="n2">numero 2</param>
        /// <returns>Retorna el resultado de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        #endregion


    }//fin class operando
}
