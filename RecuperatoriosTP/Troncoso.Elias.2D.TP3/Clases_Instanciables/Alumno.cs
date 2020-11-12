using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado }
        EEstadoCuenta estadoCuenta;
        Universidad.EClases claseQueToma;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno() : base()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        /// <summary>
        ///  Muetra todos los datos del Alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta}");
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// retorna la cadena "TOMA CLASE DE " + el nombre de la clase que toma.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return String.Format($"TOMA CLASE DE: {this.claseQueToma}");
        }
        /// <summary>
        /// Hace públicos los datos del Alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Compara un alumno y una clase segun la clase que toma y el estado de su cuenta
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Un Alumno será distinto a un EClase sólo si no toma esa clase.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma != clase)
            {
                return true;
            }
            return false;
        }
    }
}