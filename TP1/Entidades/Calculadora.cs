using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador recibido sea +, -, / o*. Caso contrario retornará +
        /// </summary>
        /// <param name="operador">operador a usar</param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            if ( operador != '+' && 
                 operador != '-' && 
                 operador != '/' && 
                 operador != '*'  )
            {
                operador = '+';
            }

            return operador;
        }

        /// <summary>
        /// Valida los numeros pasados por parametro y realiza la operación pedida entre ambos números
        /// </summary>
        /// <param name="num1">numero </param>
        /// <param name="num2">numero</param>
        /// <param name="operador">operador entre dos numeros</param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {

            operador =  ValidarOperador(operador);
            double resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado =  num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            };
            return resultado;
        }

    }//fin class Calculadora
}
