/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de uso de la clase StreamReader para leer de 4 formas distintas un fichero
 Fecha:07/03/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppClaseStreamReader.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\entrada.txt";
            StreamReader flujoFichero = new StreamReader(ruta);

            /*Stream s = flujoFichero.BaseStream;  -> para recoger el flujo base, que si tiene propiedad , 
             * para mover el puntero  como (possition o seek etc..)
             * De esta forma podemos mover el puntero al inicio para poder usar todos los metodos a la vez.. , 
             * si no se nos quedaria el puntero al final del fichero
             */
            Stream s = flujoFichero.BaseStream; 

                 

            LeerCaracterACaracater(flujoFichero);
            s.Seek(0, SeekOrigin.Begin);
            Console.WriteLine("\n------------------------------");
            LeerCaracterACaracaterEOF(flujoFichero);
            s.Seek(0, SeekOrigin.Begin);
            Console.WriteLine("\n------------------------------");
            LeerLineaALinea(flujoFichero);
            s.Seek(0, SeekOrigin.Begin);
            Console.WriteLine("\n------------------------------");
            LeerTodoElFicheroDelTiron(flujoFichero);
            
                Console.ReadLine();
        }
        static void LeerCaracterACaracater(StreamReader f)
        {
            int tmp;
            while ((tmp = f.Read()) != -1)
                Console.Write((char)tmp);
            
        }

        static void LeerCaracterACaracaterEOF(StreamReader f)
        {           
            while (!f.EndOfStream)
                Console.Write((char)f.Read());
            
        }

        static void LeerLineaALinea(StreamReader f)
        {
            string linea = string.Empty;//donde guardaremos la linea que leeremos
            while ((linea=f.ReadLine()) != null)
                Console.Write(linea);
          
        }

        static void LeerTodoElFicheroDelTiron(StreamReader f)
        {
            string todoElFichero = string.Empty;//donde guardaremos la linea que leeremos
            todoElFichero = f.ReadToEnd();
            Console.Write(todoElFichero);
           
        }
    }

}
