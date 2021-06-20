using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Código_Apilar_Giusepy_Calle_3c
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> miPila = null;
            
            while (true)
            {
                Console.WriteLine("Bienvenido a la Estructura de Datos LIFO");
                Console.WriteLine("Opción 1. Crear la pila");
                Console.WriteLine("Opción 2. Ingresar elemento(PUSH)");
                Console.WriteLine("Opción 3. Sacar elemento (POP)");
                Console.WriteLine("Opción 4. Método miron (PEEK)");
                Console.WriteLine("Opción 5. Imprimir toda la pila");
                Console.WriteLine("Opción 6. Salir");
                int teclado = Int16.Parse(Console.ReadLine());
                switch (teclado)
                {
                    case 1: //Crear
                        miPila = NodoPila.CrearPila();
                        break;
                    case 2: //PUSH 
                        miPila = NodoPila.pushPila(miPila);
                        break;
                    case 3: //POP
                        miPila = NodoPila.popPila(miPila);
                        break;
                    case 4: //PEEK
                        NodoPila.Peek(miPila);
                        break;
                    case 5: //Imprimir
                        Console.WriteLine("Imprimiendo la pila...");
                        NodoPila.imprimirPila(miPila);
                        break;

                    case 6: break;
                }

                if (teclado == 6)
                {
                    Console.WriteLine("Gracias por usar el programa");
                    break;
                }

            }
        }
    }
}
