using System;

namespace Employees_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu() {
            Fachada_AppCpmpleta fachada_AppCpmpleta = new Fachada_AppCpmpleta();
            Fachada_AppCliente fachada_AppCliente = new Fachada_AppCliente();

            bool continuar = true;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("        BIENVENIDO A LAS APP DE RRHH");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1. Versión Completa");
                Console.WriteLine("2. Versión Cliente");
                Console.WriteLine("3. Salir");
                Console.WriteLine();
                Console.Write("Ingrese el número de la Versión que desea utilizar: ");
                int Opc = int.Parse(Console.ReadLine());

                switch (Opc)
                {
                    case 1:
                        fachada_AppCpmpleta.Menu();
                        break;
                    case 2:
                        fachada_AppCliente.Menu();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Este programa ha Finalizado....");
                        Console.WriteLine("Pulse ENTER para Salir....");
                        Console.ReadKey();
                        continuar = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("El número de la opción que usted ha ingresado es incorrecto o no Existe...");
                        Console.WriteLine("Pulse ENTER para volver a intentar...");
                        Console.ReadKey();
                        break;
                }

            } while (continuar);
        }
    }
}
