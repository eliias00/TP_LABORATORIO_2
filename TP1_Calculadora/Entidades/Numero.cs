using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        /// <summary>
        /// asigna el valor 
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }
        /// <summary>
        /// constructor de la clase
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        ///  Contructor de la clase, inicializa por parametro double
        /// </summary>
        /// <param name="numero"> numero a asigar </param>
        public Numero(double numero) : this()
        {
            this.numero = numero;
        }
        /// <summary>
        /// Contructor de la clase, inicializa por parametro string
        /// </summary>
        /// <param name="strNumero"> numero a asigar </param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// valida que el numero sea numerico 
        /// </summary>
        /// <param name="strNumero"> numero a convertir </param>
        /// <returns> retorna el numero, en caso de que no se pudo convertir retorna 0 </returns>
        private double ValidarNumero(string strNumero)
        {
            if (!double.TryParse(strNumero, out double returnNumero))
            {
                returnNumero = 0;
            }
            return returnNumero;
        }
        /// <summary>
        /// convierte numero binario a numero decimal 
        /// </summary>
        /// <param name="binario"> numero a convertir </param>
        /// <returns> retorna el numero decimal </returns>
        public string BinarioDecimal(string binario)
        {
            double numeroDecimal = 0;
            double auxDecimal, absoluto;
            string absolutobin;
            if (EsBinario(binario))
            {
                auxDecimal = Double.Parse(binario);
                absoluto = Math.Abs(auxDecimal);
                absolutobin = Convert.ToString(absoluto);

                for (int i = 0; i <= absolutobin.Length - 1; i++)
                {
                    double.TryParse(absolutobin[i].ToString(), out double binarioParsed);
                    if (binarioParsed == 1 || binarioParsed == 0)
                    {
                        numeroDecimal += binarioParsed * Math.Pow(2, absolutobin.Length - i - 1);
                    }
                    else
                    {
                        return "Valor invalido";
                    }
                }
            }
            return numeroDecimal.ToString();
        }
        /// <summary>
        /// valida si el binario esta compuesto de 0 o 1 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>retorna true si es un numero binario o false si tiene algun otro digito</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = false;
            char[] auxArray = binario.ToCharArray();

            for (int i = 0; i < auxArray.Length; i++)
            {
                if (auxArray[i] == '1' || auxArray[i] == '0')
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// convierte numero decimal en numero binario 
        /// </summary>
        /// <param name="numero"> numero a convertir </param>
        /// <returns> retorna el numero binario </returns>
        public string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            double absoluto;
            absoluto = Math.Abs(numero);
            long cociente = (long)absoluto;
            long resto = (long)absoluto;

            while (cociente >= 1)
            {
                resto = cociente % 2;
                cociente = cociente / 2;

                if (resto != 0)
                {
                    numeroBinario = "1" + numeroBinario;
                }
                else
                {
                    numeroBinario = "0" + numeroBinario;
                }
            }
            return numeroBinario;
        }
        /// <summary>
        /// convierte numero decimal en binario
        /// </summary>
        /// <param name="numero"> numero a convertir </param>
        /// <returns> retorna el numero en binario </returns>
        public string DecimalBinario(string numero)
        {
            string returnAux = "Valor invalido";

            if (double.TryParse(numero, out double cociente))
            {
                returnAux = this.DecimalBinario(cociente);
            }
            return returnAux;
        }
        /// <summary>
        /// sobrecarga del operador +
        /// </summary>
        /// <param name="n1"> primer objeto a sumar </param>
        /// <param name="n2"> segundo objeto a sumar </param>
        /// <returns> suma de los 2 objetos </returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// sobrecarga del operador -
        /// </summary>
        /// <param name="n1"> primer objeto a restar </param>
        /// <param name="n2"> segundo objeto a restar </param>
        /// <returns> resta de los 2 objetos </returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// sobrecarga del operador *
        /// </summary>
        /// <param name="n1"> primer objeto a multiplicar </param>
        /// <param name="n2"> segundo objeto a multiplicar </param>
        /// <returns> multiplicacion de los 2 objetos </returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// sobrecarga del operador /
        /// </summary>
        /// <param name="n1"> primer objeto a dividir </param>
        /// <param name="n2"> segundo objeto a dividir </param>
        /// <returns> division de los 2 objetos </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }

        }
    }
}
