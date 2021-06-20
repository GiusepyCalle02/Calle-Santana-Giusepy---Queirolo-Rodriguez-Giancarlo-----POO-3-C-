using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Código_Apilar_Giusepy_Calle_3c
{
    class NodoPila
    {
        public static Stack<int> CrearPila()
        {
            Stack<int> pila = new Stack<int>();
            Console.WriteLine("Programador... has creado una pila");
            return pila;
        }

        public static void imprimirPila(Stack<int> pila)
        {
            if (pila == null)
                Console.WriteLine("Hey... inicializa la pila primero");
            else if (pila.Count == 0)
                Console.WriteLine("Primero debes agregar valores a la pila");
            else
            {
                int[] Imprimir = pila.ToArray();
                int contador = pila.Count;
                Console.WriteLine("Elementos: ");
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine(Imprimir[i]);
                }

            }    
            Console.WriteLine();
        }

        public static Stack<int> pushPila(Stack<int> pila)
        {

            if (pila == null)
            {
                Console.WriteLine("Hey... inicializa la pila primero");
            }
            else
            {
                Console.WriteLine("Ingresa Valor a apilar (PUSH)");
                int valor = Int16.Parse(Console.ReadLine());
                pila.Push(valor);
                Console.WriteLine("Ingreso exitoso..");
                Console.WriteLine();
            }
                return pila;
            

        }

        public static Stack<int> popPila(Stack<int> pila)
        {
            if (pila.Count == 0)
                Console.WriteLine("Hey... inicializa la pila primero");
            else
            {
                Console.WriteLine("POP a la pila: " + pila.Pop());
                Console.WriteLine("Sacaste un elemento.");
            }
               
            return pila;

        }

        public static void Peek(Stack<int> pila)
        {
            if (pila == null)
                Console.WriteLine("Hey... primero inicializa la Pila");
            else if (pila.Count == 0)
                Console.WriteLine("Primero debes agregar valores a la Pila");
            else
            {
                Console.WriteLine("Elemento en la cima de la Pila: " + pila.Peek());
            }
            Console.WriteLine();
        }
    }
}
