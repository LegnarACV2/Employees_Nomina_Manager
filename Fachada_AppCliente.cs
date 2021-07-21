using System;
using Modulos;
using System.Collections.Generic;
using System.Text;

namespace Employees_Manager
{
    class Fachada_AppCliente
    {
        private Contratacion _contratacion = new Contratacion();
        private Desvinculacion _desvinculacion = new Desvinculacion();
        private Pagos _pagos = new Pagos();

        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("        BIENVENIDO AL SISTEMA RRHH--VERSION DEMO");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Contratar Empleados");
            Console.WriteLine("2. Desvincular Empleados");
            Console.WriteLine("3. Realizar Pago y Nomina");
            Console.WriteLine("4. Salir");
            Console.WriteLine();
            Console.Write("Digite el Número de la Opción que desea realizar: ");
            int Opc = int.Parse(Console.ReadLine());

            switch (Opc)
            {
                case 1:
                    _contratacion.Contratar_EMP();
                    break;
                case 2:
                    _desvinculacion.Desvincular_EMP();
                    break;
                case 3:
                    _pagos.Pagar__EMPS();
                    break;
                case 4:
                    Program.Menu();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("El número de la opción que usted ha ingresado es incorrecto o no Existe...");
                    Console.WriteLine("Pulse ENTER para volver a intentar...");
                    Console.ReadKey();
                    break;
            }
            Menu();
        }
    }
}
