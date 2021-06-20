using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_de_una_Empresa_Giusepy_Calle_3C
{
    public class Empleado_Fijo:Empleado
    {
        private int añoentrada;
        private int basemensual;
        private int complementoanual;

        public Empleado_Fijo(string apellidos, string nombres, int edad, string departamento,int añoentrada, int basemensual, int complementoanual):base(apellidos, nombres, edad, departamento)
        {
            this.añoentrada = añoentrada;
            this.basemensual = basemensual;
            this.complementoanual = complementoanual;
        }

        public int getañoentrada()
        {
            return añoentrada;
        }
        public void setañoentrada(int añoentrada)
        {
            this.añoentrada = añoentrada;
        }

        public int getbasemensual()
        {
            return basemensual;
        }
        public void setsueldomensual(int basemensual)
        {
            this.basemensual = basemensual;
        }

        public int getcomplementoanual()
        {
            return complementoanual;
        }
        public void setcomplementoanual(int complementoanual)
        {
            this.complementoanual = complementoanual;
        }


        public override string ToString()
        {
            return "Apellidos: " + getapellidos() + "\nNombres: " + getnombres() + "\nEdad: " + getedad() + "\nDepartamento: " + getdepartamento() + "\nAños en la empresa: " + añoentrada+ "\nEl sueldo base es de: " +basemensual+ "\nEl complemento anual es de: " +complementoanual;
        }
    }

        public class funcionesef:Empleado_Fijo
        {
            private Empleado_Fijo[] empleado_fijo;
            private int limite;
            private int numemplefijo;

            public funcionesef(string apellidos, string nombres, int edad, string departamento, int añoentrada, int basemensual, int complementoanual, int limite):base(apellidos, nombres, edad, departamento, añoentrada, basemensual, complementoanual)
            {
            this.empleado_fijo = new Empleado_Fijo[limite];
            this.limite = limite;
            numemplefijo = 0;
            }
            public void insertarEmpFijo(Empleado_Fijo c)
            {
                if (c != null && numemplefijo < empleado_fijo.Length)
                {
                    empleado_fijo[numemplefijo] = c;
                    numemplefijo++;
                }
            }
            public void mostrarEmpFijo()
            {
                for (int i = 0; i < numemplefijo; i++)
                {
                    Console.Write(empleado_fijo[i].ToString() + "\n");
                    int sueldoemplefijo;
                    sueldoemplefijo = (empleado_fijo[i].getbasemensual() + empleado_fijo[i].getcomplementoanual()) * empleado_fijo[i].getañoentrada();
                    Console.WriteLine("El sueldo mensual es: " + sueldoemplefijo + "\n");
                }
            }

            
        }
}
