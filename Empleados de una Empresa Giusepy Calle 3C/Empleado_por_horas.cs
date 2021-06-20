using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_de_una_Empresa_Giusepy_Calle_3C
{
    public class Empleado_por_horas:Empleado
    {
        private int preciohora;
        private int numhora;

        public Empleado_por_horas(string apellidos, string nombres, int edad, string departamento, int preciohora, int numhora):base(apellidos, nombres, edad, departamento)
        {
            this.preciohora = preciohora;
            this.numhora = numhora;
        }
         public int getpreciohora()
        {
            return preciohora;
        }
        public void setpreciohora(int preciohora)
        {
            this.preciohora = preciohora;
        }

        public int getnumhora()
        {
            return numhora;
        }
        public void setnumhora(int numhora)
        {
            this.numhora = numhora;
        }
        
        
        public override string ToString()
        {
            return "Apellidos: " + getapellidos() + "\nNombre: " + getnombres() + "\nEdad: " + getedad() + "\nDepartamento: " +getdepartamento()+ "\nPrecio de hora trabajada " + preciohora + "\nNúmero de horas trabajadas: " + numhora;
        }

    }
    public class funcioneseh : Empleado_por_horas
    {
        private Empleado_por_horas[] empleado_Por_Horas;
        private int limite;
        private int numemplehora;

        public funcioneseh(string apellidos, string nombres, int edad, string departamento, int preciohora, int numhora, int limite) : base(apellidos, nombres, edad, departamento, preciohora, numhora)
        {
            this.empleado_Por_Horas = new Empleado_por_horas[limite];
            this.limite = limite;
            numemplehora = 0;
        }

        public void insertarEmpHora(Empleado_por_horas c)
        {
            if (c != null && numemplehora < empleado_Por_Horas.Length)
            {
                empleado_Por_Horas[numemplehora] = c;
                numemplehora++;
            }
        }
        public void mostrarEmpHora()
        {
            for (int i = 0; i < numemplehora; i++)
            {
                Console.Write(empleado_Por_Horas[i].ToString() + "\n");
                int sueldoemplehora;
                sueldoemplehora = empleado_Por_Horas[i].getnumhora() * empleado_Por_Horas[i].getpreciohora();

                Console.WriteLine("El sueldo mensual es: " + sueldoemplehora + "\n");
                
            }
        }

        public void insertarhoras()
        {
            Console.WriteLine("Ingrese el apellido del Empleado: ");
            string vapellido = Console.ReadLine();
            int check = 0;
            for (int i = 0; i < numemplehora; i++)
            {
                if (empleado_Por_Horas[i].getapellidos() == vapellido)
                {
                    Console.WriteLine("Ingrese el numero de horas trabajas por el empleado: ");
                    int nuevohoras = int.Parse(Console.ReadLine());
                    empleado_Por_Horas[i].setnumhora(nuevohoras);
                    Console.WriteLine("Las horas se actualizaron exitosamente.");
                    check++;

                }
            }
            if (check == 0)
            {
                Console.WriteLine("Los apellidos no coincide con los registros.");
            }

        }

       
        
    }
}
