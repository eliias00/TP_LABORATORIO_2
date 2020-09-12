using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// validacion sobre el operador 
        /// </summary>
        /// <param name="auxOperador"> Recibe operador como string </param>
        /// <returns> retorna el operador, en caso de ser un operador invalido retorna un + </returns>
        private static string ValidarOperador(string auxOperador)
        {
            string returnOperador = auxOperador;

            if ((auxOperador != "+") && (auxOperador != "-") && (auxOperador != "*") && (auxOperador != "/"))
            {
                returnOperador = "+";
            }
            return returnOperador;
        }
        /// <summary>
        /// hace la operacion entre dos objetos
        /// </summary>
        /// <param name="auxNumero1"> Primer objeto a operar </param>
        /// <param name="auxNumero2"> Segundo objeto a operar </param>
        /// <param name="auxOperador"> String que refleja el operador de la cuenta </param>
        /// <returns> retorna el resultado de la cuenta </returns>
        public static double Operar(Numero auxNumero1, Numero auxNumero2, string auxOperador)
        {
            string operadorValidado = Calculadora.ValidarOperador(auxOperador);
            double resultado = 0;

            switch (operadorValidado)
            {
                case "+":
                    resultado = auxNumero1 + auxNumero2;
                    break;
                case "-":
                    resultado = auxNumero1 - auxNumero2;
                    break;
                case "*":
                    resultado = auxNumero1 * auxNumero2;
                    break;
                case "/":
                    resultado = auxNumero1 / auxNumero2;
                    break;
            }
            return resultado;
        }
    }
}