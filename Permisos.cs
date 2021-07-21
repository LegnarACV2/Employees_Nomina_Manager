using System;
using System.Collections.Generic;
using System.Text;

namespace Modulos
{
    class Permisos
    {
        public void OtorgarPermiso_EMP()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("         Otorgue Permiso a un Empleado: ");
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
                Console.Write("¿Desea continuar para otorgarle un permiso (S/N)?: ");
                string continuar = Console.ReadLine();

                if (continuar.ToLower() == "s")
                {
                    Console.WriteLine();
                    Console.Write("Ingrese la fecha (YYYY/MM/DD): ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string fecha1 = Console.ReadLine();

                    int año = int.Parse(fecha1.Substring(0, 4));
                    int mes = int.Parse(fecha1.Substring(5, 2));
                    int dia = int.Parse(fecha1.Substring(8, 2));

                    DateTime date = new DateTime(año, mes, dia);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"Se le otorgo un permiso al/la Empleado/a {empleado.Nombre} para el día: {dia} del mes {mes} del año {año}");
                }
                Console.ReadKey();
            }
        }
    }
}
