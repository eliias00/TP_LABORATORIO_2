using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T>:IArchivo<T>
    {
        /// <summary>
        /// Lee un archivo xml en la ruta aclarada y guarda lo leido, en su anterior formato, se castea a lo que se quiere (Temas: Archivos, Serializacion, Tipos Genericos y Interfaces).
        /// </summary>
        /// <param name="archivo">Ruta donde va a leer</param>
        /// <param name="datos">Dato donde se guardara lo que se leyo</param>
        /// <returns>Retorna true si lo pudo leer, caso contrario retorna false</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            datos = default;
            if (!(archivo is null))
            {
                XmlReader lector = null;
                try
                {
                    lector = new XmlTextReader(archivo);
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    datos = (T)serializador.Deserialize(lector);
                    retorno = true;
                }
                catch (Exception e)
                {
                    throw new ArchivoError(e);
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
        /// Guarda un objeto pasado por parametro en un archivo xml, en la ruta aclarada (Temas: Archivos, Serializacion, Tipos Genericos y Interfaces).
        /// </summary>
        /// <param name="archivo">Ruta en la que se guardara el archivo</param>
        /// <param name="datos">Objeto a guardar</param>
        /// <returns>Retorna true si se pudo guardar, caso contrario retorna false</returns>
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
                catch (Exception e)
                {
                    throw new ArchivoError(e);
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
