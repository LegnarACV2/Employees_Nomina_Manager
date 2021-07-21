using System;
using System.Collections.Generic;
using System.Text;

namespace Modulos
{
    class Contratacion
    {
        public void Contratar_EMP()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("         Vamos a contratar un Empleado: ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Ingrese la Cedula: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string Cedula = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese el Nombre");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string Nombre = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese el Departamento");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string Departamento = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese el Cargo");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string Cargo = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese el Salario");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            double Salario = double.Parse(Console.ReadLine());

            Empleado empleado = new Empleado(Cedula, Nombre, Departamento, Cargo, Salario);
            Services_EMP.Guardar_EMP(empleado);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("         Se ha contratado con exito un Nuevo Empleado");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();
        }
    }
}
