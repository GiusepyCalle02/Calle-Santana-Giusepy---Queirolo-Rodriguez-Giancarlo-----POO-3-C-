using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Uni
{
    public class PServicio : Empleados
    {
        private String Seccion;
        public PServicio(String Nombre, String Apellidos, long ID, String Civil, int Incorporacion, int Despacho, String Seccion)
               : base(Nombre, Apellidos, ID, Civil, Incorporacion, Despacho)
        {
            this.Seccion = Seccion;
        }
        public String getSeccion()
        {
            return Seccion;
        }
        public void setSeccion(String Seccion)
        {
            this.Seccion = Seccion;
        }
        public override String ToString()
        {
            return "Nombre: " + getNombre() + "\nApellidos: " + getApellidos() + "\nCedula: " + getID() + "\nEstado Civil: " + getCivil() +
                   "\nAño de Incorporación: " + getIncorporacion() + "\nN° Despacho: " + getDespacho() + "\nSección: " + Seccion;
        }

    }
    public class clasesPServicio : PServicio
    {
        private PServicio[] personal;
        private int limite;
        private int numUser;

        public clasesPServicio(String Nombre, String Apellidos, long ID, String Civil, int Incorporacion, int Despacho, String Seccion, int limite)
               : base(Nombre, Apellidos, ID, Civil, Incorporacion, Despacho, Seccion)
        {
            this.personal = new PServicio[limite];
            this.limite = limite;
            numUser = 0;
        }
        public void insertarPersonal(PServicio c)
        {
            if (c != null && numUser < personal.Length)
            {
                personal[numUser] = c;
                numUser++;
            }
        }
        public void mostrarPersonal()
        {
            for (int i = 0; i < numUser; i++)
            {
                Console.WriteLine(personal[i].ToString() + "\n");

            }
        }
        public void cambiarCivilPS()
        {
            Console.WriteLine("Ingrese el numero de cedula del Personal: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (personal[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese el nuevo estado civil del Personal: ");
                    String nuevo = Console.ReadLine();
                    personal[i].setCivil(nuevo);
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
            Console.WriteLine("Ingrese el numero de cedula del Personal: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (personal[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese el nuevo despacho del Personal: ");
                    int nuevo = int.Parse(Console.ReadLine());
                    personal[i].setDespacho(nuevo);
                    Console.WriteLine("El Despacho se actualizo exitosamente.");
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("La Cedula no coincide con los registros.");
            }
        }
        public void cambiarSeccion()
        {
            Console.WriteLine("Ingrese el numero de cedula del Personal: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (personal[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese la nueva seccion del Personal: ");
                    String nuevo = Console.ReadLine();
                    personal[i].setSeccion(nuevo);
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
