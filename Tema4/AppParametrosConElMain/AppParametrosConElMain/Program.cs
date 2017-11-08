/*
 Autor: Paablo Lopez
 Ejemplo consola: para ver como pasar parametros a mi programa, ejecutado des de la consola de MSDos
 Fecha:08/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParametrosConElMain.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Como introducir los parametros por consola MSDos
            /*
             1- una vez compilado nuestro ejecutable, intentamos lelvarlo a un lugar mas acesible para nosotrso, como C o el Escritorio.
             2- Abrimos una consola de MSDos o "CMD" pulsnado Inicio o el icono de Windows y escribiendo en el buscador CMD.
             3- Una vez dentro usamos los comandos "cd" y " dir" para movernos entre los disrectorios y ver que hay dentro de estos respectivamente.
                Ej: cd pruebas o cd pruebas\Ej1 "dir solo debemos escribirlo a secas y mostrara loq ue hay dentro del directorio"
             4- Una vez estemos en la ruta donde se encuentra nuestro ejecutable, escribirmos su nombre seguido de ".exe" espacio y los parametros que vayamos a introducir
                    separados por espacios, si es un string con espacios como una frase usa las comillas.
                       Ej: AppParametrosConElMain uno dos "en un lugar de ..."
             5- Listo pulsa ENTER.
             */
            #endregion

            #region como introducir los args en el entorno de visual sin usar MSDos
            /*
             1- Nos dirigimos a  PROYECTO -> PROPIEDADES de "y el nombre del proyecto (la ultima obcion normalmente) ->Depurar
             2- Introduce los argumentos donde indica "Argumentos dela linea de comandos" recuerda dejar un espacio entre cada argumento
                    o de escribirlo entre comillas dobles si es una cade o frase como Ej: "en un lugar de .. "
             3- Listo pincha en Iniciar.
             */

            #endregion

            //Mostrar informacion sobre los parametros
            int nParametros = args.Length; //Length -> la longitud de el array donde se guadan los distintos parametros
            if (nParametros == 0)//Si el numero de parametros vale 0 o la coleccion esta vacia
            {
                Console.WriteLine("No hay parametros a mostrar...");
                return;//Devolvemos el control al que lo esta llmando en este caso el S.O
            }

            //Mostrar lista de parametros
            Console.WriteLine(" LISTA DE PARAMETROS RECIBIDOS. ");
            Console.Write("-----------------------------------------------");
            Console.WriteLine(" Recorriendo parametros con un FOREACH:");
            Console.WriteLine("--------------------------------------------\n");
            foreach (string tmp in args)
                Console.WriteLine(tmp);


            Console.WriteLine("\n---------------------------------------------");
             Console.WriteLine(" Recorriendo parametros con un FOR:");
            Console.WriteLine("----------------------------------------------n");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("[{0}] -> {1}",i,args[i]);
            }

            
        }
    }
}
