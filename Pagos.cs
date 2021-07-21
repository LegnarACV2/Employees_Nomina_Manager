using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Diagnostics;

namespace Modulos
{
    class Pagos
    {
        public void Pagar__EMPS()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Pago iniciado: ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();

            string Pago = Services_EMP.ModifySal_Total();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Pago);
            Console.Write("¿Desea Imprimir la nomina actual: (S/N)? ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string continuar = Console.ReadLine();

            if (continuar.ToLower() == "s")
            {
                string pathFile = AppDomain.CurrentDomain.BaseDirectory + "Nomina.xlsx";

                SLDocument sLDocument = new SLDocument();

                System.Data.DataTable dt = new System.Data.DataTable();

                //Columnas
                dt.Columns.Add("Atributo", typeof(string));
                dt.Columns.Add("Valor", typeof(string));

                //Registros, rows
                foreach (Empleado _empleado in Empleado.MyEmpleados)
                {
                    dt.Rows.Add("Nombre: ", _empleado.Nombre);
                    dt.Rows.Add("Departamento: ", _empleado.Departamento);
                    dt.Rows.Add("Salario: ", _empleado.Salario.ToString("C", CultureInfo.CurrentCulture));
                    dt.Rows.Add("Otros ingresos: ", _empleado.Incentivo_sal.ToString("C", CultureInfo.CurrentCulture));
                    dt.Rows.Add("AFP: ", _empleado.AFP.ToString("C", CultureInfo.CurrentCulture));
                    dt.Rows.Add("ARS: ", _empleado.ARS.ToString("C", CultureInfo.CurrentCulture));
                    dt.Rows.Add("Otros descuentos: ", _empleado.Descuento_sal.ToString("C", CultureInfo.CurrentCulture));
                    dt.Rows.Add("Sueldo Neto: ", _empleado.SueldoTotal1.ToString("C", CultureInfo.CurrentCulture));
                    dt.Rows.Add("", "");
                }
                
                sLDocument.ImportDataTable(1, 1, dt, true);
                sLDocument.SaveAs(pathFile);


                Process.Start(new ProcessStartInfo(pathFile) { UseShellExecute = true }); 
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"El proceso de pago y Nomina ha Finalizado....");
                Console.ReadKey();
            }

        }
    }
}
