using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// Usa el constructor base para mostrar un mensaje de error
        /// </summary>
        public DniInvalidoException()
           : base("DNI Invalido")
        {

        }
        /// <summary>
        /// Usa al constructor de la clase base que resibe una excepcion para mostrar un mensaje de error
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e)
            : base("DNI Invalido", e)
        {

        }
        /// <summary>
        /// Usa el constructor base qe recibe un string para mostrar un mensaje de error
        /// </summary>
        /// <param name="mensaje"></param>
        public DniInvalidoException(string message)
            : base(message)
        {

        }
        /// <summary>
        /// Usa al constructor de la clase base que resibe una excepcion y un string para mostrar un mensaje de error
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string message, Exception e)
            : base(message, e)
        {

        }
    }
}