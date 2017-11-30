/*
 Autor: Pablo Lopez
 Ejemplo consola: Ejemplo de array de estructuras
 Fecha:30/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido
using System.Threading;

namespace AppArrayEstroctura.pbl
{
    class Program
    {
        public struct Persona
        {
          
            public string Nombre;
            public DateTime FechaNacimiento;
            public float Estatura;
            public string Dni;

        }
        static int nDatos = 0;
      
        static void Main(string[] args)
        {
        const int NMAXPERSONAS = 10;
        Persona[] arrayPersonas = new Persona[NMAXPERSONAS];
       
        Persona p;
        p.Nombre = "Pepe";
        p.FechaNacimiento = DateTime.Now;
        p.Estatura = 1.78F;
        p.Dni = "7748494L";
        AddPersonas(arrayPersonas,p);
        ListarPersonas(arrayPersonas);
           
        }
      

        static bool AddPersonas(Persona[] array, Persona p)
        { 
            if(nDatos >= array.Length)
            return false;

           array[nDatos++]=p;
           return true;
        }

        static void ListarPersonas(Persona[] array)
        {
            if (nDatos == 0)
            {
                Console.Write(" La lista de personas esta vacia.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Nombre\t\t Fecha Nacimiento\t Estatura \tDNI");
           for(int i= 0;i<nDatos;i++)
            {
                Console.WriteLine("{0}\t\t {1}\t\t {2}\t\t{3}", array[i].Nombre, array[i].FechaNacimiento.ToShortDateString(), array[i].Estatura, array[i].Dni);
            }
            Console.WriteLine("\n\n Fin del listado.. Pulsa una tecla para salir..");
            Console.ReadLine();

        }
    }
}
