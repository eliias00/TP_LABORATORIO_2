using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Usa el constructor base para mostrar un mensaje de error
        /// </summary>
        /// <param name="innerExcepction"></param>
        public ArchivosException(Exception innerExcepction) :base("Error de archivo: ", innerExcepction)
        {
        }
    }
}