using System;
using Modulos;
using System.Collections.Generic;
using System.Text;

namespace Employees_Manager
{
    class Fachada_AppCpmpleta
    {
        private Contratacion _contratacion = new Contratacion();
        private Vacaciones _vacaciones = new Vacaciones();
        private Permisos _permisos = new Permisos();
        private Desvinculacion _desvinculacion = new Desvinculacion();
        private AccionPersonal _accionPersonal = new AccionPersonal();
        private Pagos _pagos = new Pagos();

        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("         BIENVENIDO AL SISTEMA RRHH");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Contratar Empleados");
            Console.WriteLine("2. Otorgar Vacaciones");
            Console.WriteLine("3. Otorgar Permisos");
            Console.WriteLine("4. Desvincular Empleados");
            Console.WriteLine("5. Agregar Incentivos o descuentos");
            Console.WriteLine("6. Realizar Pago y Nomina");
            Console.WriteLine("7. Salir");
            Console.WriteLine();
            Console.Write("Digite el Número de la Opción que desea realizar: ");
            int Opc = int.Parse(Console.ReadLine());

            switch (Opc)
            {
                case 1:
                    _contratacion.Contratar_EMP();
                    break;
                case 2:
                    _vacaciones.OtorgarVacaciones_EMP();
                    break;
                case 3:
                    _permisos.OtorgarPermiso_EMP();
                    break;
                case 4:
                    _desvinculacion.Desvincular_EMP();
                    break;
                case 5:
                    _accionPersonal.ModifcarSalario__EMP();
                    break;
                case 6:
                    _pagos.Pagar__EMPS();
                    break;
                case 7:
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
