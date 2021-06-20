using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Uni
{ 
    public class Estudiante : Usuarios
    {
        private String Curso;
        public Estudiante(String Nombre, String Apellidos, long ID, String Civil, String Curso) : base(Nombre, Apellidos, ID, Civil)
        {
            this.Curso = Curso;
        }
        public String getCurso()
        {
            return Curso;
        }
        public void setCurso(String Curso)
        {
            this.Curso = Curso;
        }
        public override String ToString()
        {
            return "Nombre: " + getNombre() + "\nApellidos: " + getApellidos() + "\nCedula: " + getID() + "\nEstado Civil: " + getCivil() + 
                   "\nCurso: " + Curso;
        }
    }
    public class clasesEstudiante : Estudiante
    {
        private Estudiante[] estudiantes;
        private int limite;
        private int numUser;

        public clasesEstudiante(String Nombre, String Apellidos, long ID, String Civil, String Curso, int limite) : base(Nombre, Apellidos, ID, Civil, Curso)
        {
            this.estudiantes = new Estudiante[limite];
            this.limite = limite;
            numUser = 0;
        }
        public void insertarEstudiante(Estudiante c)
        {
            if (c != null && numUser < estudiantes.Length)
            {
                estudiantes[numUser] = c;
                numUser++;
            }
        }
        public void mostrarEstudiante()
        {
            for (int i = 0; i < numUser; i++)
            {
                Console.WriteLine(estudiantes[i].ToString() + "\n");
            }
        }
        public void cambiarCivilEs()
        {
            Console.WriteLine("Ingrese el numero de cedula del Estudiante: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (estudiantes[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese el nuevo estado civil del Estudiante: ");
                    String nuevo = Console.ReadLine();
                    estudiantes[i].setCivil(nuevo);
                    Console.WriteLine("El Estado Civil se actualizo exitosamente.");
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("La Cedula no coincide con los registros.");
            }
        }
        public void cambiarCurso()
        {
            Console.WriteLine("Ingrese el numero de cedula del Estudiante: ");
            long vcedula = long.Parse(Console.ReadLine());
            int check = 0;
            for (int i = 0; i < numUser; i++)
            {
                if (estudiantes[i].getID() == vcedula)
                {
                    Console.WriteLine("Ingrese el nuevo curso del Estudiante: ");
                    String nuevo = Console.ReadLine();
                    estudiantes[i].setCurso(nuevo);
                    Console.WriteLine("El Curso se actualizo exitosamente.");
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("La Cedula no coincide con los registros.");
            }
        }
    }
}
