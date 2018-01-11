/*
 Autor: Pablo Lopez
 Ejemplo consola: Ejemplo del uso de un miembro compartido a la hora de contar el numero de objetos que se crea de una clase
 Fecha:11/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMiembrosCompartidosOEstaticos.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche[] coches = new Coche[100];
            coches[0] = new Coche();           
            Coche c2 = new Coche();//Cree el coche que crre dentro o fuera del array el miembro compartido de la clase coche se incrementara en uno al ejecutar su constructor
            Console.WriteLine(" Hay por ahí {0} coches circulando", Coche.Contador);

            Console.ReadLine();
           
        }
    }

    class Coche
    {
        public static int Contador = 0;// <---Miembro Compartido
        public Coche()
        {
            Coche.Contador++;
        }
        public void Borrar()
        {
            Coche.Contador--;
        }
    }
}
