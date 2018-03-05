/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de escritura y lectura de un fichero con la clase FileStrem
 Fecha:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppFileStreamLecturaEscritura.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = "c:\\basura\\entrada.txt";

            listar(ruta);
            Console.WriteLine();
            Console.ReadLine();

        }


        static void listar( string ruta)
        {
            Console.WriteLine("\n Lectura del fichero de la ruta: " + ruta+" \n");
            FileStream fichero = new FileStream(ruta, FileMode.Open);//Por defecto Open , abre para leer y pone el puntero al principio.
            int caracter;
            while((caracter = fichero.ReadByte()) != -1)//Si el caracter que ha leido es -1 es que esta leiendo fuera del fichero o que llego al final de este, si no lo guarda en caracter
                Console.Write((char) caracter);
            fichero.Close();

            Console.WriteLine("\n Este es el contenido... ");
        }
    }
}
