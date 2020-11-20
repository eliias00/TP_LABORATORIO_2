using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class IngresoError : Exception
    {
        /// <summary>
        /// Usa el constructor base para mostrar un mensaje de error (Temas: Excepciones).
        /// </summary>
        /// <param name="innerExcepction"></param>
        public IngresoError(Exception innerExcepction) : base("Error de ingreso en el sistema: ", innerExcepction)
        {
        }
    }
}
