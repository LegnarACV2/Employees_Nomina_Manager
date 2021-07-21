using System;
using System.Collections.Generic;
using System.Text;

namespace Modulos
{
    class AccionPersonal
    {
        public  void ModifcarSalario__EMP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("         Agregue Incentivos o descuentos a Empleados: ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Ingrese la Cedula del empleado: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string Cedula = Console.ReadLine(); ;

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
                Console.Write("¿Desea continuar con la modificación de Salario del mismo (S/N)?: ");
                string continuar = Console.ReadLine();

                if (continuar.ToLower() == "s")
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Incentivar");
                    Console.WriteLine("2. Descontar");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Digite el número de la opción que desea realizar: ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    int Opc = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Ingrese el Monto: ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    double Monto = double.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Ingrese el concepto o Motivo: ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string Concepto = Console.ReadLine();

                    string AccionDePersonal = Services_EMP.Modify_Sal(empleado, Monto, Concepto, Opc);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine($"El empleado {empleado.Nombre} recibirá un {AccionDePersonal} en su proximo pago.\nMonto: {Monto}\nConcepto: {Concepto}.");
                }
                Console.ReadKey();
            }            
        }
    }
}
