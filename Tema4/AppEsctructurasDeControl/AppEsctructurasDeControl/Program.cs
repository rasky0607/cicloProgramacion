/*
 Ejemplo de Bucles.
  Autor:Pablo Lopez
  Fecha: 26-10-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEsctructurasDeControl.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAXIMO = 10;
            const int MAXIMO2 = 5;
            int contador = 0;
            string[] arraydias = { "lunes", "martes", "viernes", "sabados" };

            Console.WriteLine("\n -Los 10 primeros numeros con un Bucle \"for\": ");           
            for (int i = 0; i < MAXIMO; i++)//Escribe los 10 primeros numeros (del 0 al 9)
                Console.Write("{0}\t", i);
            Console.WriteLine("\n\t\t-------------------------------\n- ");
            Console.WriteLine("\n -Lo mismo con un Bucle \"While\": ");          
            while (contador < MAXIMO)
            {
                Console.Write("{0}\t", contador);
                contador++;
            }

            Console.WriteLine("\n\t\t-------------------------------- ");
            Console.WriteLine("\n -Mostramos el contenido del Array con un Bucle \"foreach\": ");          
            foreach (string dia in arraydias)//buscara el primer indice o la posicion de 0  coge el strin en este caso"lunes y lo guarda en la varaible "dia" y luego lo muestra(luego la siguiente posicion "1" etc..)
                Console.Write("{0}\t", dia);

            Console.WriteLine("\n\t\t-------------------------------- ");
            Console.WriteLine("\n -Lo mismo con un Bucle \"for\": ");
            for (int i = 0; i < arraydias.Length; i++)// arraydias.length "se refiere a la longitud total de posiciones dentro del array, en este caso 4(recuerda que empezamos por el 0 siempre).           
                Console.Write("{0}\t", arraydias[i]);

            Console.WriteLine("\n\t\t-------------------------------- ");
            Console.WriteLine("\n -Lo mismo con un Bucle \"for\" anidados: ");
            //For anidados          
            for (int i = 0; i < MAXIMO2; i++) 
                for (int j = 0; j < MAXIMO2; j++)
                    Console.WriteLine("i->{0} y j->{1}", i, j);


            
                    

            Console.ReadLine();
        }
    }
}
