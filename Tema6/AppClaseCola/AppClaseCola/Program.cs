/*
 Autor: Pablo Lopez
 Ejemplo consola: Ejemplo  de como crear nuestra propia clase cola gestinada con un Array
 Fecha:14/12/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClaseCola.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola micola = new Cola();
            micola.Encolar("Pepe");
            micola.Encolar("Ramon");
           Console.WriteLine("N Datos en la cola: "+ micola.GetNdatos());
           Console.WriteLine("Capacidad de la cola: " + micola.GetCapacidad());
           Console.WriteLine("Desencolando..");
           micola.Desencolar();           
           Console.WriteLine("N Datos en la cola: " + micola.GetNdatos());
           Console.WriteLine("Capacidad de la cola: " + micola.GetCapacidad());
           Console.ReadLine();
        }
    }
}
