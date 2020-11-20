using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorCompra : Exception
    {
        /// <summary>
        /// Usa el constructor base para mostrar un mensaje de error (Temas: Excepciones).
        /// </summary>
        /// <param name="innerExcepction"></param>
        public ErrorCompra(Exception innerExcepction) : base("Error al momento de hacer la compra: ", innerExcepction)
        {
        }
    }
}
