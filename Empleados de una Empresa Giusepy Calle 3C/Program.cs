using System;

namespace Empleados_de_una_Empresa_Giusepy_Calle_3C
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bienvenido al sistema de información de los Empleados de la Empresa");
                Console.WriteLine("Opción 1. Mostrar Datos de un Empleado Temporal");
                Console.WriteLine("Opción 2. Mostrar Datos de un Empleado por Horas");
                Console.WriteLine("Opción 3. Mostrar Datos de un Empleado Fijo");
                Console.WriteLine("Opción 4. Salir");
                int teclado = Int16.Parse(Console.ReadLine());
                switch (teclado)
                {
                    case 1: //Mostrar Datos de empleado temporal
                        Console.WriteLine("DATOS DE UN EMPLEADO TEMPORAL");
                        funcioneset temp1 = new funcioneset("Calle", "Giusepy", 19, "Recursos Humanos", "15/07/2020", "23/10/2020", 600, 5);
                        Empleado_Temporal Persotemp = new Empleado_Temporal("Calle", "Giusepy", 19, "Recursos Humanos", "15/07/2020", "23/10/2020", 600);
                        temp1.insertarEmpTemp(Persotemp);
                        temp1.mostrarEmptemp();
                        break;
                    case 2: //Mostrar Datos del empleado por horas
                        Console.WriteLine("DATOS DE UN EMPLEADO POR HORAS");
                        funcioneseh emhora1 = new funcioneseh("Queirolo", "Giancarlo", 21, "Administración", 6, 120, 5);
                        Empleado_por_horas Persohora = new Empleado_por_horas("Queirolo", "Giancarlo", 20, "Administración", 6, 120);
                        Console.WriteLine("Empleado mes #1: ");
                        emhora1.insertarEmpHora(Persohora);
                        emhora1.mostrarEmpHora();
                        
                        Console.WriteLine("Empleado mes #2");
                        emhora1.insertarhoras();
                        emhora1.mostrarEmpHora();
                        break;
                    case 3: //Mostrar Datos del empleado Fijo
                        Console.WriteLine("DATOS DE UN EMPLEADO FIJO");
                        funcionesef fijo1 = new funcionesef("Santana", "Alexander", 19, "Control de calidad", 6, 400, 100, 5);
                        Empleado_Fijo Persofijo = new Empleado_Fijo("Santana", "Alexander", 19, "Control de calidad", 6, 400, 100);
                        fijo1.insertarEmpFijo(Persofijo);
                        fijo1.mostrarEmpFijo();
                        break;
                    case 4: break;

                }
                    if (teclado <= 0 || teclado > 4)
                    Console.WriteLine("Por favor, seleccione una opción válida."); 
                    if (teclado == 4)
                    break;
            }

    
        }
    }
}
            
            
