using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SqlErrorConexion : Exception
    {
        /// <summary>
        /// Usa el constructor base para mostrar un mensaje de error (Temas: Excepciones).
        /// </summary>
        /// <param name="innerExcepction"></param>
        public SqlErrorConexion(Exception innerExcepction) : base("Error de conexion: ", innerExcepction)
        {
        }
    }
}
