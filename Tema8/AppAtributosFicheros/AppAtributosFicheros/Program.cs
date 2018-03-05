/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemeplo de lectura y modificacion de atributos de un fichero
 Fecha:22/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppAtributosFicheros.pbl
{
    class Program
    {
        static void Main(string[] args)
        {

            string ruta = @"c:\basura\prueba.txt";
            string texto = "\r\n Hola caracola";

            Console.WriteLine(" Atributos: "+File.GetAttributes(ruta));//Si tiene permisos de escritura y es visible, dira que es de tipo Archive
            File.SetAttributes(ruta, FileAttributes.Normal);
            Console.WriteLine(" Atributos: " + File.GetAttributes(ruta));
            Console.WriteLine(File.ReadAllText(ruta));
            Console.ReadLine();
        }
    }
}
