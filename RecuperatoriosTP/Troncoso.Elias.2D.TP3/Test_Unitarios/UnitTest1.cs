using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;

namespace Test_Unitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Valida excepcion NacionalidadInvalidaException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void Test_NacionalidadInvalidaException()
        {
            Alumno alumno = new Alumno(100, "LaTota", "Santillan", "100000000", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion, Alumno.EEstadoCuenta.Becado);
        }
        /// <summary>
        /// Valida excepcion DniInvalidoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void ValidarExcepcionDniInvalido()
        {
            Alumno alumno = new Alumno(1, "jorge", "aranda", "40222354", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            alumno.StringToDni = "333rt44";
        }
        /// <summary>
        /// Controla que la lista de alumnos de una universidad no sea null.
        /// </summary>
        [TestMethod]
        public void ValidaAtributoNull()
        {
            Universidad universidad = new Universidad();
            Assert.IsNotNull(universidad.Alumnos);
        }
    }
}