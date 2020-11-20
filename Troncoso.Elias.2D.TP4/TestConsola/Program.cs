using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            Alimentos alimento = new Alimentos("chocolate", 10.50, 19, 30, "10/12/21");
            Electronica electronica = new Electronica("Televisor", 40000, 100, 31, "24 meses");
            List<Alimentos> listAlimentos = Querys.BuscoAlimentos();
            List<Electronica> listaElectronicos = Querys.BuscoElectronicos();
            try
            {
                Console.WriteLine("Productos cargados: ");

                if (Querys.AgregarAlimento(alimento))
                {
                    Console.WriteLine("Producto: {0}\nCargado " , alimento.Nombre);
                }
                if (Querys.AgregarElectronica(electronica))
                {
                    Console.WriteLine("Producto: {0}\nCargado ", electronica.Nombre);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            try
            {
              Console.WriteLine("\nEstos son los productos cargados: ");

              for (int i = 0; i < listAlimentos.Count; i++)
                {
                     Console.WriteLine(listAlimentos[i].Nombre + "|" + listAlimentos[i].Id + "|" + listAlimentos[i].Precio + "|" + listAlimentos[i].Stock + "|" + listAlimentos[i].Fecha);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            try
            {
                Console.WriteLine("Se validan las unidades de stock: ");
                if(!Querys.ValidoUnidadesComprar(30, 31))
                {
                    Console.WriteLine("No hay Stock");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            try
            {
                Console.WriteLine("Se modifica el Stock del producto elegido: ");
                if (Querys.ActualizoStock(100,31))
                {
                    Console.WriteLine("Se modifico el stock");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            try
            {
                Console.WriteLine("Se valida el usuario y contraseña: ");
                if (!Querys.ValidoUsuarioYContraseña("No estoy en la base","No estoy en la base2"))
                {
                    Console.WriteLine("No se encuentra en la base de datos");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}