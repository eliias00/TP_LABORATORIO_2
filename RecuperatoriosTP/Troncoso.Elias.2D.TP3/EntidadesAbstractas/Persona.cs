using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }

        string nombre;
        string apellido;
        ENacionalidad nacionalidad;
        int dni;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            //   this.dni = int.Parse(dni);
            this.StringToDni = dni;

        }
        /// <summary>
        /// Propiedad Dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// Propiedad Apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// Propiedad Nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        /// <summary>
        /// Setea el dni validado
        /// </summary>
        public string StringToDni
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);

            }
        }
        /// <summary>
        /// Valida dni
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (this.nacionalidad is ENacionalidad.Argentino)
            {
                if (dato >= 1 && dato <= 89999999)
                {
                    return dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else if (this.nacionalidad is ENacionalidad.Extranjero)
            {
                if (dato >= 90000000 && dato <= 99999999)
                {
                    return dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            return dato;
        }
        /// <summary>
        /// Convierte el dni y lo devuelve
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            if (int.TryParse(dato, out dni))
            {
                return ValidarDni(nacionalidad, dni);
            }
            else
            {
                throw new DniInvalidoException();
            }
        }
        /// <summary>
        /// Valida Nombre y Apellido
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char item in dato)
            {
                if (!char.IsLetter(item))
                {
                    return null;
                }
            }
            return dato;
        }
        /// <summary>
        /// Retorna los datos de Persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Apellido + "," + this.Nombre);
            sb.AppendLine("Dni: " + this.Dni);
            sb.AppendLine("Nacionalidad: " + this.Nacionalidad);
            return sb.ToString();
        }
    }
}