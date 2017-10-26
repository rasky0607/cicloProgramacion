/*
 Ejemplo de introduccion a Funciones o Metodos.
  Autor:Pablo Lopez
  Fecha: 23-10-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_JugandoConTiposV3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculo de una ecuacion de 2º grado
            float a = 0F;
            float b = 0F;
            float c = 0F;
            float dentroRaiz = 0F;
            float resultado1 = 0F;// sin la "F" serian doble 0 . //Para los positivos            

            Console.WriteLine("Soy un maquina resolviendo ecuaciones de 2º grado.");
            Console.WriteLine("\n===================================================\n");
            Console.Write("\t\t-Dime el coeficiente a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("\t\t-Dime el coeficiente b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("\t\t-Dime el coeficiente c: ");
            c = float.Parse(Console.ReadLine());

            //Compruebo el coeficiente a:

            if (a == 0)
            {
                //No hay solucion
            }
            else
            { 
                //Calculo
                dentroRaiz = b * b - 4 * a * c;
                if (dentroRaiz < 0)
                {
                    //No hay solucion
                }
                else
                { 
                    //Solcionar
                    resultado1 = (float)Math.Sqrt(dentroRaiz);
                }
            }
        }
    }
}
