using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_VentaRespuestos.Entidades;

namespace Ejercicio_VentaRespuestos.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                VentaRepuesto ventaElectronica = new VentaRepuesto("Mi negocio", "Ignacio Canal");


                bool consolaActiva = true;

                while (consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionMenu = Console.ReadLine();

                    switch (opcionMenu)
                    {
                        case "1":
                            Agregar(ventaElectronica);
                            break;

                        case "2":
                            Quitar(ventaElectronica);

                            break;

                        case "3":

                            break;

                        case "x":
                            consolaActiva = false;
                            break;

                        default:
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general");
            }

        }
        public static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Seleccione la opcion deseada");
        }

        public static void Agregar(VentaRepuesto ventaElectronica)
        {
            Console.WriteLine("Ingrese el codigo del repuesto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del repuesto: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su precio: ");
            double precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Repuesto r = new Repuesto(codigo, nombre, precio, stock);
            ventaElectronica.AgregarRepuesto(r);
        }

        public static void Quitar(VentaRepuesto ventaElectronica)
        {
            Console.WriteLine("Ingrese el codigo de producto a eliminar:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            ventaElectronica.QuitarRepuesto(codigo);

        }
          
    }
}
