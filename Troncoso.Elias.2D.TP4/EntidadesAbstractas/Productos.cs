using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Productos
    {
        string nombre;
        double precio;
        int stockActual;
        int idProducto;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Productos()
        {
            this.nombre = "sin nombre";
            this.precio = -1;
            this.stockActual = -1;
            this.idProducto = -1;
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="auxNombre"></param>
        /// <param name="auxPrecio"></param>
        /// <param name="auxStock"></param>
        /// <param name="auxIdProd"></param>
        public Productos(string auxNombre, double auxPrecio, int auxStock, int auxIdProd ) : this()
        {
            this.nombre = auxNombre;
            this.precio = auxPrecio;
            this.stockActual = auxStock;
            this.idProducto = auxIdProd;
        }
        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        /// <summary>
        /// Propiedad Precio
        /// </summary>
        public double Precio
        {
            set { this.precio = value; }
            get { return this.precio; }
        }
        /// <summary>
        /// Propiedad Stock
        /// </summary>
        public int Stock
        {
            set { this.stockActual = value; }
            get { return this.stockActual; }
        }
        /// <summary>
        /// Propiedad Id
        /// </summary>
        public int Id
        {
            set { this.idProducto = value; }
            get { return this.idProducto; }
        }
    }
}