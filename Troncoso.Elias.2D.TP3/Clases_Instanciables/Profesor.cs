using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Threading;

namespace Clases_Instanciables
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public sealed class Profesor : Universitario
    {
        static Random random;
        Queue<Universidad.EClases> clasesDelDia;
        /// <summary>
        ///  Constructor estatico.{
        /// </summary>
        static Profesor() 
        {
            random = new Random();
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Profesor() :base()
        {

        }
        /// <summary>
        /// Constructos con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :base(id,nombre,apellido,dni,nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();
        }
        /// <summary>
        /// Muestra todos los datos de tipo Profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Hace publicos los datos del metodo MostrarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Retorna la cadena "CLASES DEL DÍA" + el nombre de las clases que da el Profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Compara un profesor y una clase segun la clase que da
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Compara un profesor y una clase segun la clase que da
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i,Universidad.EClases clase)
        {
            return !(i == clase);
        }
        /// <summary>
        /// Asigna una clase a un porfesor
        /// </summary>
        private void _randomClases()
        {
            clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            Thread.Sleep(300);
        }
    }
}