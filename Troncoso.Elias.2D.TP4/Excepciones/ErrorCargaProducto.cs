using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorCargaProducto : Exception
    {
        /// <summary>
        /// Usa el constructor base para mostrar un mensaje de error (Temas: Excepciones).
        /// </summary>
        /// <param name="innerExcepction"></param>
        public ErrorCargaProducto(Exception innerExcepction) : base("Error en la carga del producto: ", innerExcepction)
        {
        }
    }
}
