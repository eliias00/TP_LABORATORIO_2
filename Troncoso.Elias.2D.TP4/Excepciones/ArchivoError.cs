using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivoError : Exception
    {
        /// <summary>
        /// Usa el constructor base para mostrar un mensaje de error (Temas: Excepciones).
        /// </summary>
        /// <param name="innerExcepction"></param>
        public ArchivoError(Exception innerExcepction) : base("Error de archivo: ", innerExcepction)
        {
        }
    }
}
