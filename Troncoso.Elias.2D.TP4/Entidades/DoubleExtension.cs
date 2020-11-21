using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DoubleExtension
    {
        /// <summary>
        /// Acumula el precio a cobrar en la compra (Temas: Metodos de Extension).
        /// </summary>
        /// <param name="monto"></param>
        /// <returns></returns>
        public static double TotalCompra(this double monto)
        {
            double total = 0;
            total = total + monto;
            return total;
        }
    }
}