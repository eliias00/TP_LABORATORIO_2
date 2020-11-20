using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;

namespace Entidades
{
    public static class SqlConexion
    {
        static SqlConnection sqlConexion;
        static SqlCommand sqlComando;
        static SqlDataReader dr;
        /// <summary>
        /// Establece el server a conectar (Temas: SQL y Base de Datos).
        /// </summary>
        static SqlConexion()
        {
            sqlConexion = new SqlConnection("Server = DESKTOP-SGS1I29\\SQLEXPRESS07 ; Database=TP4 ; Trusted_Connection = True");
        }
        /// <summary>
        /// Abre la conexion a la base de datos y devuelve el tipo de pedido especificado (Temas: SQL, Base de Datos y Tipos Genericos).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="opcion"></param>
        /// <param name="retorno"></param>
        /// <returns></returns>
        public static T SqlOpen<T>(string query, int opcion, T retorno)
        {
            sqlComando = new SqlCommand(query, sqlConexion);
            sqlComando.Connection = sqlConexion;
            try
            {
                sqlConexion.Open();
                switch (opcion)
                {
                    case 1:
                        {
                            dr = sqlComando.ExecuteReader();
                            retorno = Local.CuentoFilas<T>(dr);
                            break;
                        }
                    case 2:
                        {
                            retorno = Local.DevuelvoProdutos<T>(dr, sqlComando);
                            break;
                        }
                    case 3:
                        {
                            dr = sqlComando.ExecuteReader();
                            retorno = Local.DevuelvoListAlimentos<T>(dr);
                            break;
                        }
                    case 4:
                        {
                            dr = sqlComando.ExecuteReader();
                            retorno = Local.DevuelvoListaElectronicos<T>(dr);
                            break;
                        }
                    case 5:
                        {
                            if (sqlComando.ExecuteNonQuery() > 0)
                            {
                                retorno = (T)Convert.ChangeType(true, typeof(T));
                            }
                            else
                            {
                                retorno = (T)Convert.ChangeType(false, typeof(T));
                            }
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                throw new SqlErrorConexion(e);
            }
            finally
            {
                sqlConexion.Close();
            }
            return retorno;
        }
    }
}