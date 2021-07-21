using System;
using System.Collections.Generic;
using System.Text;

namespace Modulos
{
    class Desvinculacion
    {
        public void Desvincular_EMP()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("         Vamos a desvincular un Empleado: ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Ingrese la Cedula: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string Cedula = Console.ReadLine();

            Empleado empleado = Services_EMP.GetEmpleado(Cedula);

            if (empleado == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("El/La empleado/a No Existe... Intentelo de nuevo");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("         Se ha Encontrado el Empleado: ");
                Console.WriteLine();
                Console.WriteLine("DATOS: ");
                Console.WriteLine("__________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(empleado);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("¿Desea continuar con la eliminación del mismo (S/N)?: ");
                string continuar = Console.ReadLine();

                if (continuar.ToLower() == "s")
                {
                    string Nombre = empleado.Nombre;
                    Console.WriteLine();
                    Console.Write("Ingrese la Causa de desvinculación: ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string Causa = Console.ReadLine();
                    Services_EMP.Eliminar_EMP(empleado);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"El empleado {Nombre} se ha desvinvulado correctamente de la empresa.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("CAUSA: ");
                    Console.WriteLine(Causa);
                    
                }
                Console.ReadKey();
            }
        }
    }
}
