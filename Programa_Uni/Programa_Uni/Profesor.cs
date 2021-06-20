using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Uni
{
    public class Profesor : Empleados
    {
        private String Departamento;
        public Profesor(String Nombre, String Apellidos, long ID, String Civil, int Incorporacion, int Despacho, String Departamento) 
               : base(Nombre, Apellidos, ID, Civil, Incorporacion, Despacho)
        {
            this.Departamento = Departamento;
        }
        public String getDepartamento()
        {
            return Departamento;
        }
        public void setDepartamento(String Departamento)
        {
            this.Departamento = Departamento;
        }
        public override String ToString()
        {
            return "Nombre: " + getNombre() + "\nApellidos: " + getApellidos() + "\nCedula: " + getID() + "\nEstado Civil: " + getCivil() +
                   "\nAño de Incorporación: " + getIncorporacion() + "\nN° Despacho: " + getDespacho() + "\nDepartamento: " + Departamento;
        }

    }
    public class clasesProfesor : Profesor
    {
        private Profesor[] profesores;
        private int limite;
        private int numUser;

        public clasesProfesor(String Nombre, String Apellidos, long ID, String Civil, int Incorporacion, int Despacho, String Departamento, int limite) 
               : base(Nombre, Apellidos, ID, Civil, Incorporacion, Despacho, Departamento)
        {
            this.profesores = new Profesor[limite];
            this.limite = limite;
            numUser = 0;
        }
        public void insertarProfesor(Profesor c)
        {
            if (c != null && numUser < profesores.Length)
            {
                profesores[numUser] = c;
                numUser++;
            }
        }
        public void mostrarProfesor()
        {
            for (int i = 0; i < numUser; i++)
            {
                Console.WriteLine(profesores[i].ToString() + "\n");

            }
        }
        public void cambiarCivilPr()
        {
            Console.WriteLine("Ingrese el numero de cedula del Profesor: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (profesores[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese el nuevo estado civil del Profesor: ");
                    String nuevo = Console.ReadLine();
                    profesores[i].setCivil(nuevo);
                    Console.WriteLine("El Estado Civil se actualizo exitosamente.");
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("La Cedula no coincide con los registros.");
            }
        }
        public void cambiarDespacho()
        {
            Console.WriteLine("Ingrese el numero de cedula del Profesor: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (profesores[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese el nuevo despacho del Profesor: ");
                    int nuevo = int.Parse(Console.ReadLine());
                    profesores[i].setDespacho(nuevo);
                    Console.WriteLine("El Despacho se actualizo exitosamente.");
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("La Cedula no coincide con los registros.");
            }
        }
        public void cambiarDepa()
        {
            Console.WriteLine("Ingrese el numero de cedula del Profesor: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (profesores[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese el nuevo departamento del Profesor: ");
                    String nuevo = Console.ReadLine();
                    profesores[i].setDepartamento(nuevo);
                    Console.WriteLine("El Departamento se actualizo exitosamente.");
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("La cedula no coincide con los registros.");
            }
        }
    }
}
