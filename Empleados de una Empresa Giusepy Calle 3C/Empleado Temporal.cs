using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_de_una_Empresa_Giusepy_Calle_3C
{
    public class Empleado_Temporal:Empleado
    {
        private string fechaingreso;
        private string fechasalida;
        private int sueldomensual;

        public Empleado_Temporal(string apellidos, string nombres, int edad, string departamento, string fechaingreso, string fechasalida, int sueldomensual):base(apellidos, nombres, edad, departamento) 
        {
            this.fechaingreso = fechaingreso;
            this.fechasalida = fechasalida;
            this.sueldomensual = sueldomensual;
        }

        public string getfechaingreso()
        {
            return fechaingreso;
        }
        public void setfechaingreso(string fechaingreso)
        {
            this.fechaingreso = fechaingreso;
        }

        public string getfechasalida()
        {
            return fechasalida;
        }
        public void setfechasalida(string fechasalida)
        {
            this.fechasalida = fechasalida;
        }

        public int getsueldomensual()
        {
            return sueldomensual;
        }
        public void setsueldomensual(int sueldomensual)
        {
            this.sueldomensual = sueldomensual;
        }
        public override string ToString()
        {
            return "Apellidos: " + getapellidos() + "\nNombre: " + getnombres() + "\nEdad: " + getedad() + "\nDepartamento: " +getdepartamento()+ "\nFecha de ingreso: " + getfechaingreso() + "\nFecha de Salida: " + getfechasalida() + "\nEl sueldo mensual es: " + sueldomensual;
        }

    }
        public class funcioneset:Empleado_Temporal
        {
            private Empleado_Temporal[] empleado_Temporals;
            private int limite;
            private int numtemp;

            public funcioneset(string apellidos, string nombres, int edad, string departamento, string fechaingreso, string fechasalida, int sueldomensual, int limite) : base(apellidos, nombres, edad, departamento, fechaingreso, fechasalida, sueldomensual)
            {
            this.empleado_Temporals = new Empleado_Temporal[limite];
            this.limite = limite;
            numtemp = 0;

            }

            public void insertarEmpTemp(Empleado_Temporal c)
            {
                if (c != null && numtemp < empleado_Temporals.Length)
                {
                    empleado_Temporals[numtemp] = c;
                    numtemp++;
                }
            }
        public void mostrarEmptemp()
            {
                for(int i = 0; i <numtemp; i++)
                {
                Console.WriteLine(empleado_Temporals[i].ToString() + "\n");
                }
            }
          
        }
    

}
