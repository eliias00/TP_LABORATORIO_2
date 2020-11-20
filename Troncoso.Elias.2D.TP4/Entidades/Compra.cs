using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;

namespace Entidades
{
    public class Compra
    {
        double precioTotal;
        List<string> nombresProductos;

        /// <summary>
        /// Propiedad PrecioTotal
        /// </summary>
        public double PrecioTotal
        {
            get { return this.precioTotal; }

            set { this.precioTotal = value; }
        }
        /// <summary>
        /// Propiedad NombresProductos
        /// </summary>
        public List<string> NombresProductos
        {
            get { return this.nombresProductos; }

            set { this.nombresProductos = value; }
        }
    }
}