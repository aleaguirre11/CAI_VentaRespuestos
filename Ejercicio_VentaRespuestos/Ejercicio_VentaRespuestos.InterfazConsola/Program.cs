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

                Repuesto r1 = new Repuesto(1, "Bujia", 150, 2);
                Repuesto r2 = new Repuesto(2, "Polea", 2000, 15);
                Repuesto r3 = new Repuesto(3, "Motor V8", 80000, 0);
                ventaElectronica.AgregarRepuesto(r1);
                ventaElectronica.AgregarRepuesto(r2);
                ventaElectronica.AgregarRepuesto(r3);

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
                            Modificar(ventaElectronica);
                            break;

                        case "4":
                            AgregarStock(ventaElectronica);
                            break;

                        case "5":
                            QuitarStock(ventaElectronica);
                            break;

                        case "6":
                            Lista(ventaElectronica);
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
            Console.WriteLine("Seleccione la opcion deseada: " + "\n" + "1 - Agregar repuesto. " + "\n" + "2 - Quitar repuesto. "
                + "\n" + "3 - Modificar precio. " + "\n" + "4 - Agregar stock. " + "\n" + "5 - Quitar stock. " + "\n" + "6 - Listar repuestos. ");
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

            Repuesto repuesto = new Repuesto(codigo, nombre, precio, stock);
            ventaElectronica.AgregarRepuesto(repuesto);
        }

        public static void Quitar(VentaRepuesto ventaElectronica)
        {
            Console.WriteLine("Ingrese el codigo de producto a eliminar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            ventaElectronica.QuitarRepuesto(codigo);

        }

        public static void Modificar(VentaRepuesto ventaElectronica)
        {
            Console.WriteLine("Ingrese el codigo de producto a modificar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            ventaElectronica.ModificarPrecio(codigo, precio);
        }

        public static void AgregarStock(VentaRepuesto ventaElectronica)
        {
            Console.WriteLine("Ingrese el codigo de producto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de unidades que desea agregar: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            ventaElectronica.AgregarStockRepuesto(codigo, stock);

        }

        public static void QuitarStock(VentaRepuesto ventaElectronica)
        {
            Console.WriteLine("Ingrese el codigo de producto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de unidades que desea quitar: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            ventaElectronica.QuitarStockRepuesto(codigo, stock);
        }

        public static void Traer(VentaRepuesto ventaElectronica)
        {
            int codigo = Convert.ToInt32(Console.ReadLine());

        }

        public static void Lista(VentaRepuesto ventaElectronica)
        {

            foreach (Repuesto repuesto in ventaElectronica.ListaRepuestos)  //Se pone la lista publica
            {
                Console.WriteLine(repuesto.Codigo + " - " + repuesto.Nombre + " - " + repuesto.Precio + " - " + repuesto.Stock);
            }

        }
    }
}
