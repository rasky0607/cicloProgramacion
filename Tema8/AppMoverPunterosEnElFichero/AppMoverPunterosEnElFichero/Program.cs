/*
 Autor: Pablo Lopez
 Ejemplo consola:Mueve el puntero del fichero a las posiciones deseadas
 Fecha:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppMoverPunterosEnElFichero.pbl
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\entrada.txt";
            long posAMostrar = 3;
            FileStream flujoFichero = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            MostrarBytes(flujoFichero, posAMostrar);
            Console.WriteLine(" Eso es todo....");
            Console.ReadLine();

            //ahora usando el  metodo Seek()
            Console.WriteLine(" Poscion en la que esta -> {0}", flujoFichero.Position);
            flujoFichero.Seek(4, SeekOrigin.Current);//salta 4 posiciones desde donde esta actualmente (tambien es valido indicar numeros negativos par retroceder posiciones)
           

            Console.ReadLine();
        }

        static void MostrarBytes(FileStream flujo, long posInicial)
        {
            int posActual = (int)flujo.Position;//para guardar la posicion actual y poder restaurar el puntero al finalizar
            try
            {
                if (posInicial > flujo.Length - 1)//Si es mayor, esta fuera del fichero
                    throw new ArgumentOutOfRangeException();
                flujo.Position = posInicial;
                for (long i = posInicial; i < flujo.Length; i++)              
                    Console.WriteLine(" Byte: {0} es de la posicion: {1}",(char)flujo.ReadByte(), i);                 
                
                flujo.Position = posActual;//Lo devuelve a laposicion en la que estaba al principio
            }
            catch(Exception e) {
                Console.WriteLine(" Fuera del contenido del fichero\n\n " + e.Message);
            }
        }
    }
}
