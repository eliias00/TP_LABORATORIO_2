using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#pragma warning disable CS0660
#pragma warning disable CS0661
namespace EntidadesAbstractas
{
    public class Electronica : Productos
    {
        string garantia;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Electronica()
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="stockActual"></param>
        /// <param name="id"></param>
        /// <param name="auxGarantia"></param>
        public Electronica(string nombre, double precio, int stockActual, int id, string auxGarantia) : base(nombre, precio, stockActual, id)
        {
            this.garantia = auxGarantia;
        }
        /// <summary>
        /// Propiedad Garantia
        /// </summary>
        public string Garantia
        {
            set { this.garantia = value; }
            get { return this.garantia; }
        }
        /// <summary>
        /// Se agrega un electronico a la lista
        /// </summary>
        /// <param name="listaElectronica"></param>
        /// <param name="electronica"></param>
        /// <returns></returns>
        public static bool operator +(List<Electronica> listaElectronica, Electronica electronica)
        {
            bool retorno = false;

            for (int i = 0; i < listaElectronica.Count; i++)
            {
                if (listaElectronica[i] != electronica)
                {
                    listaElectronica.Add(electronica);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Se saca un electronico de la lista
        /// </summary>
        /// <param name="listaElectronica"></param>
        /// <param name="electronica"></param>
        /// <returns></returns>
        public static bool operator -(List<Electronica> listaElectronica, Electronica electronica)
        {
            return (listaElectronica.Remove(electronica));
        }
        /// <summary>
        /// Busca el electronico en la lista y si lo encuentra retorna true
        /// </summary>
        /// <param name="listaElectronica"></param>
        /// <param name="electronica"></param>
        /// <returns></returns>
        public static bool operator ==(List<Electronica> listaElectronica, Electronica electronica)
        {
            bool retorno = false;

            for (int i = 0; i < listaElectronica.Count; i++)
            {
                if (listaElectronica[i].Id == electronica.Id)
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
        /// <param name="listaElectronica"></param>
        /// <param name="electronica"></param>
        /// <returns></returns>
        public static bool operator !=(List<Electronica> listaElectronica, Electronica electronica)
        {
            return !(listaElectronica == electronica);
        }
    }
}