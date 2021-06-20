using System;
using System.Collections;
using System.Collections.Generic;

namespace COLA
{
    public class NodoCola
    {
       public static Queue<int> crearCola()
        {
            Queue<int> cola = new Queue<int>();
            Console.WriteLine("Programador... has creado una cola");
            Console.WriteLine();
            return cola;
        }

        public static void imprimirCola(Queue<int> cola)
        {
            if (cola == null)
                Console.WriteLine("Hey... primero inicializa la cola");
            else if(cola.Count == 0)
                Console.WriteLine("Primero debes agregar valores a la cola");
            else
            {
                int[] Impri = cola.ToArray();
                int contador = cola.Count;
                Console.WriteLine("Elementos:");
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine(Impri[i]);
                }
            }
            Console.WriteLine();
        }

        public static Queue<int> Encolar(Queue<int> cola)
        {

            if (cola == null)
            {
                Console.WriteLine("Hey... primero inicializa la cola");
            }
            else
            {
                Console.WriteLine("Ingresa Valor a encolar");
                int valor = Int16.Parse(Console.ReadLine());
                cola.Enqueue(valor);
                Console.WriteLine("Ingreso exitoso..");
                Console.WriteLine();
            }
           return cola;

        }

        public static Queue<int> Desencolar(Queue<int> cola)
        {
            if (cola == null)
                Console.WriteLine("Hey... primero inicializa la cola");
            else if (cola.Count == 0)
                Console.WriteLine("Primero debes agregar valores a la cola");
            else
            {
                Console.WriteLine("Extracción de la cola: " + cola.Dequeue());
                Console.WriteLine("Sacaste un elemento.");
            }
            Console.WriteLine();
            return cola;
        }

        public static void Peek(Queue<int> cola)
        {
            if (cola == null)
                Console.WriteLine("Hey... primero inicializa la cola");
            else if (cola.Count == 0)
                Console.WriteLine("Primero debes agregar valores a la cola");
            else
            {
               Console.WriteLine("Elemento en la cabeza de la cola: " + cola.Peek());
            }
            Console.WriteLine();
        }
    }
}
