using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Lee el arhivo de la ruta aclarada y guarda lo leido (Temas: Archivos, Tipos Genericos y Interfaces).
        /// </summary>
        /// <param name="archivo">Ruta donde va a leer</param>
        /// <param name="datos">Dato donde se guardara lo que se leyo</param>
        /// <returns>Retorna true si lo pudo leer, caso contrario retorna false</returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader file = new StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
                }
            }
            catch (Exception e)
            {

                throw new ArchivoError(e);
            }
            return true;
        }
        /// <summary>
        /// Guarda en un archivo de texto la informacion pasada por parametro en la ruta aclarada (Temas: Archivos, Tipos Genericos y Interfaces).
        /// </summary>
        /// <param name="archivo">Ruta en la que se guardara el texto</param>
        /// <param name="datos">Informacion a guardar</param>
        /// <returns>Retorna true si se pudo guardar, caso contrario retorna false</returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo, true))
                {
                    file.WriteLine(datos);
                }
            }
            catch (Exception e)
            {
                throw new ArchivoError(e);
            }
            return true;
        }
    }
}