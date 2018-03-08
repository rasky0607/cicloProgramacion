/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de uso de clases BinaryWriter y BinaryReader usada para manejar ficheros binarios.
 Fecha:08/03/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppBinaryReaderYWriter.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\binario.mio";
            FileStream flujo = new FileStream(ruta, FileMode.Append, FileAccess.Write); //Flujo de apertura del fichero                    
            EscribirFicheroBinario(ruta,flujo);          
            FileStream flujo2 = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            LeerficheroBinario(ruta, flujo2);
           

            Console.ReadLine();
        }

        static void EscribirFicheroBinario(string ruta, FileStream flujo)
        {         
            //Registros que escribiremos.
            string texto = "Soy un texto";
            int entero = 133;
            double undouble = Math.PI;
            //Etc..

            BinaryWriter escritor = new BinaryWriter(flujo);//flujo de escritura que se basa en el flujo pare de apertura del fichero

            //Escribimos
            escritor.Write(texto);
            escritor.Write(entero);
            escritor.Write(undouble);

            flujo.Close();
            if(escritor !=null)
                escritor.Close();

           
        }

        static void LeerficheroBinario(string ruta, FileStream flujo)
        {
            BinaryReader lector = new BinaryReader(flujo);
            //Leemos en el mismo orden y con el metodo adecuado a cada tipo.
            Console.WriteLine(lector.ReadString());
            Console.WriteLine(lector.ReadInt32());
            Console.WriteLine(lector.ReadDouble());

            flujo.Close();
            if (lector != null) 
                lector.Close();

        }
    }
}
