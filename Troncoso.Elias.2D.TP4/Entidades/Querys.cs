using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntidadesAbstractas;
using Excepciones;

namespace Entidades
{
    public static class Querys
    {
        /// <summary>
        /// Valido usuario y contraseña para poder acceder al sistema (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <param name="user"></param>
        /// <param name="contra"></param>
        /// <returns></returns>
        public static bool ValidoUsuarioYContraseña(string user, string contra)
        {
            bool retorno = false;
            int opcion = 1;
            string query = "Select * From Empleados where Usuario = '" + user + "' and Contraseña = '" + contra + "'";

            if ((user != "Ingrese Usuario" && contra != "Ingrese Contraseña") && (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(contra)))
            {
                if (SqlConexion.SqlOpen<bool>(query, opcion, retorno))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Carga un DataTable con los productos (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <returns></returns>
        public static DataTable CargoTabla()
        {
            string query = "Select * From Productos";
            DataTable retorno = new DataTable();
            int opcion = 2;

            retorno = SqlConexion.SqlOpen<DataTable>(query, opcion, retorno);

            return retorno;
        }
        /// <summary>
        /// Devuelve la lista de alimentos (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <returns></returns>
        public static List<Alimentos> BuscoAlimentos()
        {
            string query = "Select * From Productos";
            List<Alimentos> listaAlimentos = new List<Alimentos>();
            int opcion = 3;

            listaAlimentos = SqlConexion.SqlOpen<List<Alimentos>>(query, opcion, listaAlimentos);

            return listaAlimentos;
        }
        /// <summary>
        /// Devuelve la lista de electronicos (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <returns></returns>
        public static List<Electronica> BuscoElectronicos()
        {
            string query = "Select * From Productos";
            List<Electronica> listaElectronicos = new List<Electronica>();
            int opcion = 4;

            listaElectronicos = SqlConexion.SqlOpen<List<Electronica>>(query, opcion, listaElectronicos);

            return listaElectronicos;
        }
        /// <summary>
        /// Agrega el alimento a la base de SQL (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <param name="nuevoAlimento"></param>
        /// <returns></returns>
        public static bool AgregarAlimento(Alimentos nuevoAlimento)
        {
            try
            {
                bool retorno = false;
                int opcion = 5;
                string query = "Insert into Productos values ('" + nuevoAlimento.Nombre + "'," + nuevoAlimento.Id + "," + nuevoAlimento.Stock + "," + nuevoAlimento.Precio + ", ' ','" + nuevoAlimento.Fecha + "')";
                if (BuscoAlimentos() + nuevoAlimento)
                {
                    SqlConexion.SqlOpen<bool>(query, opcion, retorno);
                    retorno = true;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new ErrorCargaProducto(ex);
            }
        }
        /// <summary>
        /// Agrega el electronico a la base de SQL (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <param name="nuevoElectronico"></param>
        /// <returns></returns>
        public static bool AgregarElectronica(Electronica nuevoElectronico)
        {
            try
            {
                bool retorno = false;
                int opcion = 5;
                string query = "Insert into Productos values ('" + nuevoElectronico.Nombre + "'," + nuevoElectronico.Id + "," + nuevoElectronico.Stock + "," + nuevoElectronico.Precio + ", '" + nuevoElectronico.Garantia + "',' ' )";
                if (BuscoElectronicos() + nuevoElectronico)
                {
                    SqlConexion.SqlOpen<bool>(query, opcion, retorno);
                    retorno = true;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new ErrorCargaProducto(ex);
            }
        }
        /// <summary>
        /// Actualiza el stock del producto comprado anteriormente (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ActualizoStock(int stock, int id)
        {
            string query = "Update productos set StockActual = " + stock + " where IdProducto = " + id;
            bool retorno = false;
            int opcion = 5;

            retorno = SqlConexion.SqlOpen<bool>(query, opcion, retorno);

            return retorno;
        }
        /// <summary>
        /// Valida las unidades del producto a comprar antes de efectuarse la compra
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="auxUnidades"></param>
        /// <returns></returns>
        public static bool ValidoUnidadesComprar(int idProducto, double auxUnidades)
        {
            List<Alimentos> alimentos = BuscoAlimentos();
            bool retorno = false;
            for (int i = 0; i < alimentos.Count; i++)
            {
                if (idProducto == alimentos[i].Id)
                {
                    if ((alimentos[i].Stock - (int)auxUnidades) < 0)
                    {
                        retorno = false;
                        break;
                    }
                    else
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
    }
}