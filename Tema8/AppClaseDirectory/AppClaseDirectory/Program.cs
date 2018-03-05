/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de usao de la clase directory
 Fecha:22/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppClaseDirectory.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura";
            string[] ficheros = Directory.GetFiles(ruta);
            string[] fichero2 = Directory.GetFiles(ruta, "*.txt");//Filtrar por un tipo de ficheros en concreto
            string[] directorios = Directory.GetDirectories(ruta);

            foreach (string tmp in directorios)
            {
                Console.WriteLine(tmp);
            }
           
            foreach (string tmp in ficheros)
            {              
                if(File.GetAttributes(tmp) != FileAttributes.Hidden)//Pregunta por el atributo del fichero
                Console.WriteLine(tmp);
            }


            Console.ReadLine();
        }
    }
}
