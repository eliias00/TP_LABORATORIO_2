using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntidadesAbstractas;
using Archivos;
namespace Entidades
{
    public static class Local
    {
        static List<Alimentos> nuevosAlimentos;
        static List<Electronica> nuevosElectronicos;
        static Compra compra;

        /// <summary>
        /// Constructor estatico
        /// </summary>
        static Local()
        {
            compra = new Compra();
        }
        /// <summary>
        /// Le paso a la compra los datos correspondientes
        /// </summary>
        /// <param name="monto"></param>
        /// <param name="productos"></param>
        /// <returns></returns>
        public static Compra HagoCompra(double monto, List<string> productos)
        {
            compra.PrecioTotal = monto;
            compra.NombresProductos = productos;
            return compra;
        }

        /// <summary>
        /// Cuenta las filas afectadas por la instruccion de SQL (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <typeparam name="T"> Parametro que devuelve el tipo de dato necesario </typeparam>
        /// <param name="dr"> parametro de SQL </param>
        /// <returns></returns>
        public static T CuentoFilas<T>(SqlDataReader dr)
        {
            int filas = 0;
            bool ret = false;
            while (dr.Read())
            {
                filas++;
            }
            if (filas > 0)
            {
                ret = true;
            }
            return (T)Convert.ChangeType(ret, typeof(T));
        }
        /// <summary>
        /// Devuelve los productos para ser consumidos por un DataTable (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <typeparam name="T"> Parametro que devuelve el tipo de dato necesario </typeparam>
        /// <param name="dr"> parametro de SQL </param>
        /// <param name="comando"> parametro de SQL </param>
        /// <returns></returns>
        public static T DevuelvoProdutos<T>(SqlDataReader dr, SqlCommand comando)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable tabla = new DataTable();
            adaptador.SelectCommand = comando;
            adaptador.Fill(tabla);
            return (T)Convert.ChangeType(tabla, typeof(T));
        }
        /// <summary>
        /// Devuelve lista de alimentos (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <typeparam name="T"> Parametro que devuelve el tipo de dato necesario </typeparam>
        /// <param name="dr"> parametro de SQL </param>
        /// <returns></returns>
        public static T DevuelvoListAlimentos<T>(SqlDataReader dr)
        {
            nuevosAlimentos = new List<Alimentos>();
            Alimentos alimento;
            while (dr.Read())
            {
                alimento = new Alimentos(dr["Nombre"].ToString(), double.Parse(dr["Precio"].ToString()), int.Parse(dr["StockActual"].ToString()), int.Parse(dr["IdProducto"].ToString()), dr["FechaVencimiento"].ToString());
                nuevosAlimentos.Add(alimento);
            }
            return (T)Convert.ChangeType(nuevosAlimentos, typeof(T));
        }
        /// <summary>
        /// Devuelve lista de Electronicos (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <typeparam name="T"> Parametro que devuelve el tipo de dato necesario </typeparam>
        /// <param name="dr"> parametro de SQL </param>
        /// <returns></returns>
        public static T DevuelvoListaElectronicos<T>(SqlDataReader dr)
        {
            nuevosElectronicos = new List<Electronica>();
            Electronica electronica;
            while (dr.Read())
            {
                electronica = new Electronica(dr["Nombre"].ToString(), double.Parse(dr["Precio"].ToString()), int.Parse(dr["StockActual"].ToString()), int.Parse(dr["IdProducto"].ToString()), dr["Garantia"].ToString());
                nuevosElectronicos.Add(electronica);
            }
            return (T)Convert.ChangeType(nuevosElectronicos, typeof(T));
        }
        /// <summary>
        /// Crea ticket de la compra realizada (Temas: Archivos).
        /// </summary>
        /// <param name="compra"></param>
        /// <returns></returns>
        public static bool GuardoComprovante(Compra compra)
        {
            StringBuilder sb = new StringBuilder();
            string hora = DateTime.Now.ToString("hhmmss");
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string ticket = hora + fecha;
            string path;
            Texto texto = new Texto();
            
            path = AppDomain.CurrentDomain.BaseDirectory + "Compra" + ticket + ".txt";

            sb.AppendLine("Hora: " + hora.Substring(0, 2) + ":" + hora.Substring(2, 2) + ":" + hora.Substring(4, 2) +
            "          " + "Fecha: " + fecha.Substring(0, 4) + "/" + fecha.Substring(4, 2) + "/" + fecha.Substring(6, 2));
            sb.AppendLine("\nProductos: \n----------");
            for (int i = 0; i < compra.NombresProductos.Count; i++)
            {
                sb.AppendLine(String.Format("\nNombre Producto: {0} ", compra.NombresProductos[i]));
            }
            sb.AppendLine("-------------------------");
            sb.AppendLine(String.Format("\nPrecio total: ${0: #,###.00}", compra.PrecioTotal));
            sb.AppendLine("Muchas Gracias por su compra...!!!");
            return texto.Guardar(path, sb.ToString());
        }
        /// <summary>
        /// Guarda la Compra en formato xml (Temas: Archivos).
        /// </summary>
        /// <param name="compra"></param>
        /// <returns></returns>
        public static bool GuardoXml(Compra compra)
        {
            bool retorno = false;
            if (!(compra is null))
            {
                Xml<Compra> xmlCompra = new Xml<Compra>();
                retorno = xmlCompra.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Compra.xml", compra);
            }
            return retorno;
        }

    }
}