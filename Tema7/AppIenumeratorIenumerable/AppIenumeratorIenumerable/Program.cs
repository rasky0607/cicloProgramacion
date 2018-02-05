/*
 Autor: Pablo Lopez
 Ejemplo consola: Ejemplos con los interfaces IEnumerable y Ienumerator 
 * para poder usar la instruccion Foreach con las instancias de una clase nuestra
 Fecha:05/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido para poder implementar el Ienumerable sin tipos.
using System.Collections;

namespace AppIenumeratorIenumerable.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista milista = new Lista();
            foreach (int tmp in milista)
            {
                Console.Write("\t {0}", tmp);
            }
            Console.ReadLine();
        }

       
    }
}
