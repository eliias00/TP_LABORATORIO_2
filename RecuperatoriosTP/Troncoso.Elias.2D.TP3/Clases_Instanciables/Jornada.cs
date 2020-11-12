using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Jornada
    {
        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;
        /// <summary>
        /// Propiedad Alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        /// <summary>
        /// Propiedad clases
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        /// <summary>
        /// Propiedad Profesores
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        /// <summary>
        /// constructor por defecto
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) :this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno item in j.alumnos)
            {
                if (item == a)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Una Jornada será distinta a un Alumno si el mismo no participa de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// Agrega Alumnos a la clase y valida que no estén previamente cargados.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            return j;
        }
        /// <summary>
        /// Muestra todos los datos de la Jornada.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<--------------------------------------------------------------------->");
            sb.AppendLine($"CLASE DE {this.clase.ToString()} POR {this.instructor.ToString()}");
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Guarda el objeto de tipo Jornada en formato texto
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            Texto txt = new Texto();
            string ret = " ";
            if (!(txt is null))
            {
                txt.Leer(AppDomain.CurrentDomain.BaseDirectory + @"\Jornada.txt", out ret);
            }
            return ret;
        }
        /// <summary>
        /// Guarda el archivo de un objeto de tipo Jornada en formato texto
        /// </summary>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada j)
        {
            Texto txt = new Texto();
            bool ret = false;
            if (!(txt is null && j is null))
            {
                ret = txt.Guardar(AppDomain.CurrentDomain.BaseDirectory + @"\Jornada.txt", j.ToString());
            }
            return ret;
        }
    }
}