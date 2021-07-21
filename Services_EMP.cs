using System;
using System.Collections.Generic;
using System.Text;

namespace Modulos
{
    class Services_EMP
    {
        public static void Guardar_EMP(Empleado _empleado)
        {
            Empleado.MyEmpleados.Add(_empleado);
        }

        public static Empleado GetEmpleado(string cedula)
        {
            Empleado _empleado = new Empleado();
            bool IsEmpleado = false;

            foreach (Empleado emp in Empleado.MyEmpleados)
            {
                if (emp.Cedula == cedula)
                {
                    _empleado = emp;
                    IsEmpleado = true;
                    break;
                }
            }

            if (IsEmpleado == false)
            {
                return null;
            }
            return _empleado;
        }

        public static string Modify_Sal(Empleado empleado, double monto, string concepto,int accion)
        {
            string AccionDePersonal = "";

            if (accion == 1)
            {
                empleado.Incentivo_sal = monto;
                empleado.Concepto_ictv = concepto;
                AccionDePersonal = "Incentivo";
            }
            else
            {
                empleado.Descuento_sal = monto;
                empleado.Concepto_desc = concepto;
                AccionDePersonal = "Descuento";
            }

            return AccionDePersonal;
        }

        public static void Eliminar_EMP(Empleado empleado)
        {
            Empleado.MyEmpleados.Remove(empleado);
        }

        public static string ModifySal_Total()
        {
            foreach (Empleado _empleado in Empleado.MyEmpleados)
            {
                double Descuentos = _empleado.Descuento_sal;
                double AFP_desc = _empleado.Salario * 0.0287;
                double ARS_desc = _empleado.Salario * 0.0301;
             
                double Ingresos = _empleado.Salario + _empleado.Incentivo_sal;
                double Deducciones = Descuentos + AFP_desc + ARS_desc;
                
                double SueldoNeto = Ingresos - Deducciones;

                _empleado.AFP = AFP_desc;
                _empleado.ARS = ARS_desc;
                _empleado.SueldoTotal1 = SueldoNeto;

            }

            return "Se Ha realizado el pago a los empleados Existentes!!!";
        }
    }
}
