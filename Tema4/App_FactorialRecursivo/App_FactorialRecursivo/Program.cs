/*
Ejemplo Consola: Metodos recursivos directos.
Autor: Pablo Lopez
Fecha: 06/11/2017 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_FactorialRecursivo.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            byte num = 4;
            Console.WriteLine("El Factorial de {0} en cuenta la vieja: {1}", n, 4 *3  *2  * 1);
            Console.WriteLine("El Factorial de {0} Recursivo: {1}",n, FactorialR(n));
            Console.WriteLine("El Factorial de {0} Recursivo sobrecargado: {1}", n, FactorialR(num));
            Console.WriteLine("El Factorial de {0} Iterativo: {1}", n, FactorialI(n));
            Console.ReadLine();
        }

        //Metodo Iterativo
        static double FactorialI(int n)
        {
            double resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        //Metodo Recursivo
        static double FactorialR(int n)
        {
            if (n == 0)
                return 1;
            return n * FactorialR(n - 1);//Se llama a si mismo de nuevo pero con el valor de  pasado menos 1.
        }
        //Metodo Sobrecrgado
        static double FactorialR(byte n)
        {      
            return n == 0 ? 1 : n * FactorialR(n - 1);//Se llama a si mismo de nuevo pero con el valor de  pasado menos 1.
        }
    }
}
