using System;
using System.Collections.Generic;
using System.Text;

namespace Modulos
{
    class Empleado
    {
        public static List<Empleado> MyEmpleados = new List<Empleado> { };

        private string cedula;
        private string nombre;
        private string departamento;
        private string cargo;
        private double salario;

        private double incentivo_sal;
        private string concepto_ictv;

        private double descuento_sal;
        private string concepto_desc;

        private double aFP;
        private double aRS;
        private double SueldoTotal;

        public Empleado(string cedula, string nombre, string departamento, string cargo, double salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Departamento = departamento;
            Cargo = cargo;
            Salario = salario;
        }

        public Empleado()
        {

        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public double Incentivo_sal { get => incentivo_sal; set => incentivo_sal = value; }
        public string Concepto_ictv { get => concepto_ictv; set => concepto_ictv = value; }
        public double Descuento_sal { get => descuento_sal; set => descuento_sal = value; }
        public string Concepto_desc { get => concepto_desc; set => concepto_desc = value; }
        public double AFP { get => aFP; set => aFP = value; }
        public double ARS { get => aRS; set => aRS = value; }
        public double SueldoTotal1 { get => SueldoTotal; set => SueldoTotal = value; }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}\nDepartamento: {this.Departamento}\nCargo: {this.Cargo}\nSalario: {this.Salario}\nPortador de la Cedula: {this.Cedula}";
        }
    }

}
