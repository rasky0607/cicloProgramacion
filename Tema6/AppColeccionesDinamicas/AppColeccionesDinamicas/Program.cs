/*
 Autor: Pablo Lopez
 Ejemplo consola: Clase ArrayList
 Fecha:13/12/2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadir
using System.Collections;

namespace AppColeccionesDinamicas.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            //añadir elementos a la lista(dentro de la lista lo que realmente se esta almacenando son objetos de cada elmento que introducimos)
            lista.Add("pepe");//esta añadiendo un objeto de la clase String
            lista.Add(125);//esta añadiendo un objeto de la clase Int

            MostrarLista(lista);
            
        }
        static void MostrarLista(ArrayList lista)
        {
            foreach (Object objeto in lista)
                Console.WriteLine(objeto);

            Console.WriteLine("\n\n\t\t Ya no hay mas elementos...");
            Console.ReadLine();
        }
    }
}
