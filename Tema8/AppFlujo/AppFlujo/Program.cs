/*
 Autor: Pablo Lopez
 Ejemplo consola:redireccionamiento o cambio del flujo de salida de la pantalla a un fichero
 Fecha:05/03/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppFlujo.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ruta al fichero de salida
            string ruta =  @"c:/basura/salida.txt";
            Console.WriteLine("Escribiendo en la pantalla...");

            #region Crea el flujo donde vamos a redireccionar
            //Establece o crea un FLUJO para conectarlo a una salida
            FileStream fs = new FileStream(ruta, FileMode.Create);//En este caso engancha el objeto "fs" a dicha ruta y crea el fichero(si existe lo borra y lo crea de nuevo)
            #endregion

            #region cambio de flujo
            //Guarda el flujo de salida   estandar ( o flujo de salida hacia la consola)
            TextWriter tmp = Console.Out;
            
            //Cambia el flujo de salida 
            StreamWriter sw = new StreamWriter(fs);
            Console.SetOut(sw);//cambia el flujo de salida actusal de la consola al que creamos para escribir
            Console.WriteLine(" el flujo de salida de cambio a el fichero salida.txt..");
            sw.Dispose();

            #endregion
         
            #region Restaurar el flujo al estander
            Console.SetOut(tmp);
            Console.WriteLine(" Se ha restaurado el flujo a la consola");
            tmp.Dispose();
            
            #endregion

            Console.ReadLine();

        }
    }
}
