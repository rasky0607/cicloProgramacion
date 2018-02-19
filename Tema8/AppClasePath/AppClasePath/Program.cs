/*
 Autor: Pablo Lopez
 Ejemplo consola: Clase path Ejempo en el que tratamos de mostrar el nombre d eun archivo concreto, que buscamos a atraves de una 
 ruta determinada, de forma que nos quedamos con una parte concreta de esta ruta, para identificar el archivo
 Fecha:19/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;//Necesario para usar las clases que manejan ficheros rutas y directorios.

namespace AppClasePath.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\dir1\dir2\dir3\dir4\datos.dat";

            //Esta ruta montara los separadores en funcion del S.O en el que se ejecuta
            string ruta2 = @"c:" + Path.VolumeSeparatorChar + "direc1" + Path.DirectorySeparatorChar + "direc2";

            VerDatos(ruta);           
            //Como cambiar la extension de el fichero:
            ruta = Path.ChangeExtension(ruta,"IES");
            VerDatos(ruta);
        }

        static void VerDatos(string ruta)
        { 
            //Obtener informacion y mostrarla
            Console.WriteLine("     Ruta y fichero origen : {0}", ruta);
            Console.WriteLine("     Extension: {0}",Path.GetExtension(ruta));
            Console.WriteLine("     Nombre Completo: {0}",Path.GetFileName(ruta));
            Console.WriteLine("     Unidad Raiz: {0}",Path.GetPathRoot(ruta));
            Console.WriteLine("     Nombre sin extension: {0}",Path.GetFileNameWithoutExtension(ruta));
            //Etc...
            Console.WriteLine("\n   Pulsa Enter....\n");
            Console.ReadLine();

        }
    }
}
