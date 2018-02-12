/*
 Autor: Pablo Lopez
 Ejemplo consola:ICompare(El cual necesita una clase para cada criterio de ordenacion)
 * para ordenar una coleccion de objetos con multiples criterios de ordenacion a diferencia de IComparable "El cual ordena por  un unico criterio"
 Fecha:07/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrdenaObjICompare.pbl
{
    class Program
    {
        static List<Persona> personas = new List<Persona>();
        static void Main(string[] args)
        {
            CrearVariasPersonas();
            Console.WriteLine(" \tLista sin ordernar:\n");
            Listar();
            
            //Ordenacion por distintos criterios
            Console.WriteLine(" \tLista Ordenada por Nombres:\n");
            personas.Sort(new OrdenaNombres());
            Listar();

            Console.WriteLine(" \tLista Ordenada por Apellidos:\n");
            personas.Sort(new OrdenaApellidos());
            Listar();

        }

        static void CrearVariasPersonas()
        {
            personas.Add(new Persona("Gil", "Pepe", 160));
            personas.Add(new Persona("Martin", "Lurdes", 180));
            personas.Add(new Persona("Garcia", "Juan", 115));
            personas.Add(new Persona("Marquez", "Luis", 132));
            personas.Add(new Persona("Lopez", "Ramon", 112));
            personas.Add(new Persona("Carrasco", "Carlos", 110));
            personas.Add(new Persona("Aranda", "Mirian", 109));
        }

        static void Listar()
        {
            foreach (Persona tmp in personas)
                Console.WriteLine(tmp);


            Console.WriteLine("\n\t Fin del listado...");
            Console.ReadLine();
        }
    }
}
