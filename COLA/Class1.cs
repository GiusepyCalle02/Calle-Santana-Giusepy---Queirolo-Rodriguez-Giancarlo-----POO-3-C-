using System;
using System.Collections;

public class NodoCola
{

    static Queue crearCola()
    {
        Queue<String> cola = new LinkedList<String>();
        System.out.println("Programador... has creado una cola");
        return cola;
    }

    static void imprimirCola(Queue cola)
    {
        if (cola == null)
            System.out.println("Hey... inicializa la cola primero");
        else
            System.out.println("Elementos: " + cola.toString());
    }

    static Queue Encolar(Queue cola)
    {
        if (cola == null)
            System.out.println("Hey... inicializa la cola primero");
         else
        {
            Scanner teclado = new Scanner(System.in);
            System.out.println("Ingresa Valor a encolar");
            String valor = teclado.nextLine();
            cola.add(valor);
            System.out.println("Ingreso exitoso..");

        }
        return cola;

    }

    static Queue Desencolar(Queue cola)
    {
        if (cola == null)
            System.out.println("Hey... inicializa la cola primero");
         else
        {
            System.out.println("ExtracciÃ³n de la cola: " + cola.remove());
            System.out.println("Sacaste un elemento.");

            if (cola.isEmpty())
                cola = null;

        }
        return cola;
    }

    //static Queue Miron(Qu)
}
