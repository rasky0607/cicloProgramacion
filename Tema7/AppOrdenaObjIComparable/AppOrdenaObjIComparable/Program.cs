/*
 Autor: Pablo Lopez
 Ejemplo consola:Implementacion del interfaz IComparable para ordenar objetos o tipo de datos complejo
 * bajo un criterio de ordenacion definido en el metodo CompareTo() que implementa este interfaz
 * una vez realizado esto, n uestro metodo Sort() sabra ordenar tipo de datos complejos o  Objetos
 Fecha:07/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrdenaObjIComparable.pbl
{
    class Program
    {
        static List<Persona> personas = new List<Persona>();
        static void Main(string[] args)
        {
            CrearVariasPersonas();
            Console.WriteLine(" \tLista sin ordernar:\n");
            Listar();
   //Ej1:   Console.WriteLine(" \tLista Ordenada por codigo:\n");
            Console.WriteLine(" \tLista Ordenada por Apellidos:\n");
            personas.Sort();
            Listar();


        }

        static void CrearVariasPersonas()
        { 
            personas.Add(new Persona("Gil","Pepe",160));
            personas.Add(new Persona("Martin", "Lurdes", 180));
            personas.Add(new Persona("Garcia", "Juan", 115));
            personas.Add(new Persona("Marquez", "Luis", 132));
            personas.Add(new Persona("Lopez", "Ramon", 104));
            personas.Add(new Persona("Carrasco", "Carlos", 104));
            personas.Add(new Persona("Aranda", "Mirian", 104));
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
