using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Lee un objeto mediante Deserialización
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            datos = default;
            if (!(archivo is null ))
            {
                XmlReader lector = null;
                try
                {
                    lector = new XmlTextReader(archivo);
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    datos = (T)serializador.Deserialize(lector);
                    retorno = true;
                }
                catch (Exception)
                {
                }
                finally
                {
                    if (!(lector is null))
                    {
                        lector.Close();
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Guarda el archivo en formato xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            if (!(archivo is null))
            {
                XmlWriter escritor = null;
                try
                {
                    escritor = new XmlTextWriter(archivo, Encoding.UTF8);
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(escritor, datos);
                    retorno = true;
                }
                catch (Exception)
                {

                }
                finally
                {
                    if (!(escritor is null))
                    {
                        escritor.Close();
                    }
                }

            }
            return retorno;
        }
    }
}