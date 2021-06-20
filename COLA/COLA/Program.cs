using System;
using System.Collections.Generic;

namespace COLA
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> miCola=null;
            int valor;

            while (true)
            {
                Console.WriteLine("Bienvenido a la Estructura de Datos FIFO :D");
                Console.WriteLine("Opcion 1. Crear la cola");
                Console.WriteLine("Opcion 2. Ingresar elemento(ENCOLAR)");
                Console.WriteLine("Opcion 3. Sacar elemento(DESENCOLAR)");
                Console.WriteLine("Opcion 4. Metodo Miron(PEEK)");
                Console.WriteLine("Opcion 5. Imprimir toda la cola");
                Console.WriteLine("Opcion 6. Salir");
                int teclado = Int16.Parse(Console.ReadLine());
                switch (teclado)
                {
                    case 1: //Crear
                        miCola = NodoCola.crearCola();
                        break;
                    case 2: //PUSH 
                        miCola = NodoCola.Encolar(miCola);
                        break;
                    case 3: //POP
                        miCola = NodoCola.Desencolar(miCola);
                        break;
                    case 4: //PEEK
                        NodoCola.Peek(miCola);
                        break;
                    case 5: //Imprimir
                        Console.WriteLine("Imprimiendo la cola...");
                        NodoCola.imprimirCola(miCola);
                        break;

                    case 6:
                        break;
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
