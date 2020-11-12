using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS0660
#pragma warning disable CS0661
namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        int legajo;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario() : base()
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        /// <summary>
        /// Se fija si el objeto recibido es del mismo tipo que el de la instancia
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
        /// <summary>
        /// Implementa sin sobreescribir el metodo heredado MostrarDatos para mostrar todos los datos de un universitario.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Legajo" + this.legajo);
            return sb.ToString();
        }
        /// <summary>
        /// Metodo abstracto sin implementación
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();
        /// <summary>
        /// Reutilizando el metodo Equals y compara un universitario con otro comparando si sus dni son iguales o legajos.
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Compara un universitario con otro comparando para saber si no son iguales
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
    }
}