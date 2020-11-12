using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Universidad
    {
        List<Alumno> alumnos;
        List<Jornada> jornadas;
        List<Profesor> profesores;
        public enum EClases {Programacion, Laboratorio, Legislacion, SPD }
        /// <summary>
        /// Propiedad Alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return alumnos;}
            set { this.alumnos = value;}
        }
        /// <summary>
        /// Propiedad Profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return profesores; }
            set { this.profesores = value; }
        }
        /// <summary>
        /// Propiedad Jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return jornadas; }
            set { this.jornadas = value; }
        }
        /// <summary>
        /// Propiedad que muestra o modifica la jornada en el indice indicado.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return jornadas[i];
            }
            set
            {
                jornadas[i] = value;
            }
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornadas = new List<Jornada>();
        }
        /// <summary>
        /// Iguala una universidad y un profesor para saber si el mismo da clases en el.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor item in g.profesores)
            {
                if (item == i)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        ///  Iguala una universidad y un profesor para saber si el mismo no da clases en el.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        /// <summary>
        /// Agrega un profesor a una universidad, verificanod que no este cargado previamente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {

            if (u != i)
            {
                u.profesores.Add(i);
            }

            return u;
        }
        /// <summary>
        /// Iguala una universidad y un alumno para saber si el mismo esta inscripto
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno item in g.Alumnos)
            {
                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Iguala una universidad y un alumno para saber si el mismo no esta inscripto
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        /// <summary>
        ///  Agrega un alumno a una universidad, verificando que no este cargado previamente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }
        /// <summary>
        /// Iguala una universidad con una clase, para saber que profesor da la clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.profesores)
            {
                if (item == clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// Iguala una universidad con una clase, para saber que profesor no da la clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.profesores)
            {
                if (item != clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// Agrega una clase a una universidad, generando una nueva jornada indicando el profesor que puede darla y los alunmos que toman la clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j = new Jornada(clase, (g == clase));
            foreach (Alumno a in g.Alumnos)
            {
                if (a == clase)
                {
                    j += a;
                }
            }
            g.jornadas.Add(j);
            return g;
        }
        /// <summary>
        /// Hace los datos publicos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        /// <summary>
        /// Muestra los datos de universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada item in uni.jornadas)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Lee un archivo serializado xml
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Universidad retorno = null;
            Xml<Universidad> lector = new Xml<Universidad>();
            lector.Leer(AppDomain.CurrentDomain.BaseDirectory + "Universidad.txt", out retorno);
            return retorno;
        }
        /// <summary>
        /// Invoca al metodo Guardar de la clase XML, serializando una universidad en un xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            bool retorno = false;
            if (!(uni is null))
            {
                Xml<Universidad> aux = new Xml<Universidad>();
                retorno = aux.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Universidad.txt", uni);
            }
            return retorno;
        }
    }
}