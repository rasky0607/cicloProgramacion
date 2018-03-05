/*
 Autor: Paablo Lopez
 Ejercicio consola N : Ejemplo de uso de la clase ESTATICA File
 Fecha:21/02/2018
 *IMPORTANTE: El el cualquier sistema \r\n significa salto de linea en texto plano, que no es el mismo que el salto de linea en .net que solo es \n
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppClaseFile.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\prueba.txt";
            string texto = "\r\n Hola caracola";
            for (int i = 0; i < 10; i++)            
                File.AppendAllText(ruta, texto);

            Console.WriteLine(File.ReadAllText(ruta));
            Console.ReadLine();
            
        }

        
    }
}
