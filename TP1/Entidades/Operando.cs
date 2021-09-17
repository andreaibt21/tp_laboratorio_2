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
       
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
           Numero = strNumero;
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
        public string BinarioDecimal(string binarioRecibido)
        {
            double digitoAuxiliar;
            double potencias = binarioRecibido.Length - 1;
            double numeroEnDecimal = 0;
            string charAuxiliar;
            int numeroFinal;

            if ( String.IsNullOrEmpty(binarioRecibido) == false && EsBinario(binarioRecibido) ) 
            {
                foreach (char digito in binarioRecibido)
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
            double resultadoDivision = numero;
            double restoDivision;

            if(resultadoDivision >= 0)
            {
                do 
                {
                    restoDivision = resultadoDivision % 2;
                    resultadoDivision /= 2;
                    valorBinario = restoDivision.ToString() + valorBinario;

                } while (resultadoDivision > 0);
                return valorBinario;
            }
            return "valor Invalido";
       }

        #endregion


    }//fin class operando
}
