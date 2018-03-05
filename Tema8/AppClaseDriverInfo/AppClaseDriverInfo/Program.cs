/*
 Autor: Paablo Lopez
 Ejercicio consola N :Ejemplo de uso de la clase DriverInfo
 Fecha:21/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppClaseDriverInfo.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] arrayUnidades = DriveInfo.GetDrives();//esto nos devuelve una coleccion de objetos de DriverInfo

            Console.WriteLine("\n  \t\t UNIDADES O PERIFERICOS DEL SISTEMA");
            Console.WriteLine("\t\t---------------------------------");
            foreach (DriveInfo tmp in arrayUnidades)
            {
                Console.WriteLine("\n\t -Encontre esta unidad...\n");
                Console.WriteLine("              Nombre unidad: "+ tmp.Name);
                Console.WriteLine("             Tipo de Unidad: " + tmp.DriveType);

                if (tmp.IsReady)//Si la unidad esta lista , osea montada
                {
                    Console.WriteLine("\n \t\tLA UNIDAD SI ESTA LISTA:");
                    Console.WriteLine("\t\t---------------------------------");
                    Console.WriteLine("       Sistema de archivos: " + tmp.DriveFormat);
                    Console.WriteLine("      Volumen de la unidad: " + tmp.VolumeLabel);
                    Console.WriteLine(" Tamaño total de la unidad: " + tmp.TotalSize);
                    Console.WriteLine("             Espacio libre: " + tmp.AvailableFreeSpace);
                    Console.WriteLine("           Directorio raiz: " + tmp.RootDirectory);                   
                }
                Console.WriteLine("\t\t--------------------------------\n");
            }

            Console.WriteLine(" \t\t\t FIN LISTADO...");
            Console.ReadLine();

        }
    }
}
