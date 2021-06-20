using System;

namespace Programa_Uni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialización de matrices
            clasesEstudiante estudiante = new clasesEstudiante("Giancarlo", "Queirolo Rodriguez", 1300000000, "Soltero", "Sistemas Electricos", 20);
            clasesProfesor profesor = new clasesProfesor("Giancarlo", "Queirolo Rodriguez", 1300000000, "Soltero", 2010, 12, "Informatica", 20);
            clasesPServicio personal = new clasesPServicio("Giancarlo", "Queirolo Rodriguez", 1300000000, "Soltero", 2010, 12, "Secretaría", 20);
            //Interfaces y metodos
            Console.WriteLine("\t\t--Bienvenido al Sistema de la Facultad :D--");
            while (true)
            {
                Console.WriteLine("\n++Menú Principal++");
                Console.WriteLine("Seleccionar: ");
                Console.WriteLine("Opcion 1. Usuario Estudiante");
                Console.WriteLine("Opcion 2. Usuario Profesores");
                Console.WriteLine("Opcion 3. Usuario Personal de Servicio");
                Console.WriteLine("Opcion 4. Salir");
                int teclado = int.Parse(Console.ReadLine());
                switch (teclado)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("\n++Menú Estudiantes++");
                            Console.WriteLine("Seleccionar: ");
                            Console.WriteLine("Opcion 1. Ingresar Estudiante");
                            Console.WriteLine("Opcion 2. Mostrar Estudiantes");
                            Console.WriteLine("Opcion 3. Cambiar Estado Civil");
                            Console.WriteLine("Opcion 4. Cambiar Curso");
                            Console.WriteLine("Opcion 5. Volver");
                            int teclado1 = int.Parse(Console.ReadLine());
                            switch (teclado1)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese Nombre de Estudiante: ");
                                    String nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellidos de Estudiante: ");
                                    String apellidos = Console.ReadLine();
                                    Console.WriteLine("Ingrese Cedula de Estudiante: ");
                                    long id = long.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Estado Civil de Estudiante: ");
                                    String civil = Console.ReadLine();
                                    Console.WriteLine("Ingrese Curso de Estudiante: ");
                                    String curso = Console.ReadLine();
                                    Estudiante U1 = new Estudiante(nombre, apellidos, id, civil, curso);
                                    estudiante.insertarEstudiante(U1);
                                    Console.WriteLine("Usuario Agregado.");
                                    break;
                                case 2:
                                    Console.WriteLine("Estudiantes Registrados: ");
                                    estudiante.mostrarEstudiante();
                                    break;
                                case 3:
                                    estudiante.cambiarCivilEs();
                                    break;
                                case 4:
                                    estudiante.cambiarCurso();
                                    break;
                                case 5:
                                    break;
                            }
                            if (teclado1 <= 0 || teclado1 > 5)
                                Console.WriteLine("Por favor, seleccione una opción válida.");
                            if (teclado1 == 5)
                                break;
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("\n++Menú Profesores++");
                            Console.WriteLine("Seleccionar: ");
                            Console.WriteLine("Opcion 1. Ingresar Profesor");
                            Console.WriteLine("Opcion 2. Mostrar Profesor");
                            Console.WriteLine("Opcion 3. Cambiar Estado Civil");
                            Console.WriteLine("Opcion 4. Cambiar Despacho");
                            Console.WriteLine("Opcion 5. Cambiar Departamento");
                            Console.WriteLine("Opcion 6. Volver");
                            int teclado2 = Int16.Parse(Console.ReadLine());
                            switch (teclado2)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese Nombre de Profesor: ");
                                    String nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellidos de profesor: ");
                                    String apellidos = Console.ReadLine();
                                    Console.WriteLine("Ingrese cedula de Profesor: ");
                                    long id = long.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese estado civil de Profesor: ");
                                    String civil = Console.ReadLine();
                                    Console.WriteLine("Ingrese Año de Incorporación: ");
                                    int incorporacion = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Numero de Despacho: ");
                                    int despacho = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Departamento Asignado: ");
                                    String departamento = Console.ReadLine();
                                    Profesor U2 = new Profesor(nombre, apellidos, id, civil, incorporacion, despacho, departamento);
                                    profesor.insertarProfesor(U2);
                                    Console.WriteLine("Usuario Agregado.");
                                    break;
                                case 2:
                                    Console.WriteLine("Profesores Registrados: ");
                                    profesor.mostrarProfesor();
                                    break;
                                case 3:
                                    profesor.cambiarCivilPr();
                                    break;
                                case 4:
                                    profesor.cambiarDespacho();
                                    break;
                                case 5:
                                    profesor.cambiarDepa();
                                    break;
                                case 6:
                                    break;
                            }
                            if (teclado2 <= 0 || teclado2 > 6)
                                Console.WriteLine("Por favor, seleccione una opción válida.");
                            if (teclado2 == 6)
                                break;
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("\n++Menú Personal de Servicio++");
                            Console.WriteLine("Seleccionar: ");
                            Console.WriteLine("Opcion 1. Ingresar Personal");
                            Console.WriteLine("Opcion 2. Mostrar Personal");
                            Console.WriteLine("Opcion 3. Cambiar Estado Civil");
                            Console.WriteLine("Opcion 4. Cambiar Despacho");
                            Console.WriteLine("Opcion 5. Cambiar Sección");
                            Console.WriteLine("Opcion 6. Volver");
                            int teclado3 = Int16.Parse(Console.ReadLine());
                            switch (teclado3)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese Nombre del Personal: ");
                                    String nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellidos del Personal: ");
                                    String apellidos = Console.ReadLine();
                                    Console.WriteLine("Ingrese Cedula del Personal: ");
                                    long id = long.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Estado Civil del Personal: ");
                                    String civil = Console.ReadLine();
                                    Console.WriteLine("Ingrese Año de Incorporación: ");
                                    int incorporacion = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Numero de Despacho: ");
                                    int despacho = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Sección Asignada: ");
                                    String seccion = Console.ReadLine();
                                    PServicio U3 = new PServicio(nombre, apellidos, id, civil, incorporacion, despacho, seccion);
                                    personal.insertarPersonal(U3);
                                    Console.WriteLine("Usuario Agregado.");
                                    break;
                                case 2:
                                    Console.WriteLine("Personal de Servicio Registrados: ");
                                    personal.mostrarPersonal();
                                    break;
                                case 3:
                                    personal.cambiarCivilPS();
                                    break;
                                case 4:
                                    personal.cambiarDespacho();
                                    break;
                                case 5:
                                    personal.cambiarSeccion();
                                    break;
                                case 6:
                                    break;
                            }
                            if (teclado3 <= 0 || teclado3 > 6)
                                Console.WriteLine("Por favor, seleccione una opción válida.");
                            if (teclado3 == 6)
                                break;
                        }
                        break;
                    case 4:

                        break;
                }
                if (teclado<=0 || teclado > 4)
                    Console.WriteLine("Por favor, seleccionar una opción válida.");
                if (teclado == 4)
                {
                    Console.WriteLine("\nGracias por usar el programa :D");
                    break;
                }

            }
        }
    }
}
