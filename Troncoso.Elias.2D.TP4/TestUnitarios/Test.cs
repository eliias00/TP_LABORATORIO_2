using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesAbstractas;
using Entidades;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Controla que la lista de alimentos no sea null (Temas: Test Unitarios).
        /// </summary>
        [TestMethod]
        public void ValidaAtributoNull()
        {
            Alimentos alimentos = new Alimentos();
            Assert.IsNotNull(alimentos);
        }
        /// <summary>
        /// Valida excepcion ErrorCargaProducto (Temas: Test Unitarios y Excepciones).
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ErrorCargaProducto))]
        public void Test_Error()
        {
            long numero = 1111111111111111111;
             Alimentos alimento = new Alimentos("banana", numero, 1, 1, "10/10/2020");
            Querys.AgregarAlimento(alimento);
        }
        /// <summary>
        /// Controla que el valor Double sea el esperado (Temas: Test Unitarios).
        /// </summary>
        [TestMethod]
        public void ValidarNumerico()
        {
            double valorEsperado = 22.4;
            Electronica electronica;
            electronica = new Electronica(" ",22.4,3,44,"12 meses");

            Assert.AreEqual(valorEsperado, electronica.Precio);
        }
    }
}