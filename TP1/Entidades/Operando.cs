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
       /// inicializa el campo numero en 0;
       /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// inicializa el campo numero en el numero ingresado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// inicializa el campo numero en el numero ingresado por parametro
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

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
       
        public double ValidarOperando(string strNumero)
           {
               double numero;

            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
                return numero;
           } 

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

        public string DecimalBinario(string numeroRecibido)
        {
            double numeroDouble;
            double.TryParse(numeroRecibido, out numeroDouble);
            
            return DecimalBinario(numeroDouble);
        }
        #endregion



        #region OPERATORS

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
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator -(Operando n1, Operando n2) 
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        #endregion


    }//fin class operando
}
