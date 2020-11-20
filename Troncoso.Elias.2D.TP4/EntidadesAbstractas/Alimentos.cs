using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS0660
#pragma warning disable CS0661
namespace EntidadesAbstractas
{
    public class Alimentos : Productos
    {
        string fechaVenc;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Alimentos()
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="stockActual"></param>
        /// <param name="id"></param>
        /// <param name="auxFechaVenc"></param>
        public Alimentos(string nombre, double precio, int stockActual, int id, string auxFechaVenc) : base(nombre, precio, stockActual, id)
        {
            this.fechaVenc = auxFechaVenc;
        }
        /// <summary>
        /// Propiedad Fecha
        /// </summary>
        public string Fecha
        {
            set { this.fechaVenc = value; }
            get { return this.fechaVenc; }
        }
        /// <summary>
        /// Se agrega un alimento a la lista
        /// </summary>
        /// <param name="listaAlimentos"></param>
        /// <param name="alimento"></param>
        /// <returns></returns>
        public static bool operator +(List<Alimentos> listaAlimentos, Alimentos alimento)
        {
            bool retorno = false;

            for (int i = 0; i < listaAlimentos.Count; i++)
            {
                if (listaAlimentos[i] != alimento)
                {
                    listaAlimentos.Add(alimento);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Se saca un alimento de la lista
        /// </summary>
        /// <param name="listaAlimentos"></param>
        /// <param name="alimento"></param>
        /// <returns></returns>
        public static bool operator -(List<Alimentos> listaAlimentos, Alimentos alimento)
        {
            return (listaAlimentos.Remove(alimento));
        }
        /// <summary>
        /// Busca el alimento en la lista y si lo encuentra retorna true
        /// </summary>
        /// <param name="listaAlimentos"></param>
        /// <param name="alimento"></param>
        /// <returns></returns>
        public static bool operator ==(List<Alimentos> listaAlimentos, Alimentos alimento)
        {
            bool retorno = false;

            for (int i = 0; i < listaAlimentos.Count; i++)
            {
                if (listaAlimentos[i].Id == alimento.Id)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="listaAlimentos"></param>
        /// <param name="alimento"></param>
        /// <returns></returns>
        public static bool operator !=(List<Alimentos> listaAlimentos, Alimentos alimento)
        {
            return !(listaAlimentos == alimento);
        }
    }
}