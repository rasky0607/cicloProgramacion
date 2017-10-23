/*
 Ejemplo clase Math y Random
 Autor: Pablo Lopez
 Fecha: 23-10-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMathRandom.pbl
{
    class RandomYMatch
    {
        static void Main(string[] args)
        {

            double num1 = 3;
            double num2 = 4.55;
            Console.WriteLine("--------------------Clase Math------------------------");
            Console.WriteLine("el ceiling de {0} --> {1}", num1, Math.Pow(num1, 2));//Realiza la potencia elevando el valor de la varaible a 2
            Console.WriteLine("el ceiling de {0} --> {1}", num2, Math.Truncate(num2));//Realiza un truncamiento de el valor dela varaible.
            Console.WriteLine("------------------------------------------\n");

            Console.WriteLine("\n---------------------Clase Random---------------");
            //Clase Random (que genera un numero aleatorio
            Random rnd1 = new Random();
            Random rnd2 = new Random(120);//Sobrecarga: el parametro es el valor utilizado para calcular el numero aleatorio.

            int numero = 0;
            numero = rnd1.Next(100);//next-> saca Un numero aleatorio menor que el 100 "el 100 no se incluyes, el rango es entre 0 y 99"
            Console.WriteLine("numero--> {0}", numero);
            Console.WriteLine("\n\t***Sacare 10 numeros aleatorios menores que 100.***\n");
            //Saca 10 numero aleatorios menor que 100"el 100 no se incluyes, el rango es entre 0 y 99"
            for (int i = 0; i < 10; i++)
            {
                numero = rnd1.Next(100);
                Console.WriteLine("numero-->{0} ", numero + "\n");
            }

            Console.WriteLine("\n\t---------Fin clase Ramdon.---------");

            Console.ReadLine();
        }
    }
}
