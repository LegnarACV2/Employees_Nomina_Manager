using System;
using System.Collections.Generic;
using System.Text;

namespace Modulos
{
    class Vacaciones
    {
        public void OtorgarVacaciones_EMP()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("         Otorgue vacaciones a un Empleado: ");
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
                Console.WriteLine("___________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(empleado);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("¿Desea Otorgarle Vacaciones (S/N)?: ");
                string continuar = Console.ReadLine();
                
                if (continuar.ToLower() == "s")
                {
                    Console.WriteLine();
                    Console.Write("Ingrese la fecha de inicio (YYYY/MM/DD): ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string fecha1 = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Ingrese la fecha de fin (YYYY/MM/DD): ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string fecha2 = Console.ReadLine();

                    int año = int.Parse(fecha1.Substring(0, 4));
                    int mes = int.Parse(fecha1.Substring(5, 2));
                    int dia = int.Parse(fecha1.Substring(8, 2));

                    int año1 = int.Parse(fecha2.Substring(0, 4));
                    int mes1 = int.Parse(fecha2.Substring(5, 2));
                    int dia1 = int.Parse(fecha2.Substring(8, 2));

                    DateTime date = new DateTime(año, mes, dia);
                    DateTime date1 = new DateTime(año1, mes1, dia1);

                    TimeSpan Diff_Days = date1.Subtract(date);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"El/La empleado/a: {empleado.Nombre} recibira {Diff_Days.Days} días de vacaciones...");
                }
                Console.ReadKey();
            }
        }
    }
}
