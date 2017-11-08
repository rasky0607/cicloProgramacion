/*
 Autor: Pablo Lopez
 Ejemplo consola:Segundo Ejemplo de calculo de el area de un triangulo que se llamada des de la consoal MsDos
 Fecha:08/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLlamadConsoAreaTriang.pbl
{
    class Area
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


            double bas;//Base
            double alt;//Altura
            double area;//Area

            if(args.Length == 1 && args[0]==@"\?")//el @ Especificaque un valor de un strgin literal tambien nos serviria " \\?"
            {
                Informacion(" ");               
                return;
            }
            if (args.Length < 2)
            {
                Console.WriteLine("Faltan parametros...");
                return;//devuelve el control al S.O
            }
            try
            {
                bas = double.Parse(args[0]);
                alt = double.Parse(args[1]);
                area = bas * alt / 2;
                Console.WriteLine("El area del triangulo de base {0} y altura {1} es: {2} m2.", bas, alt, area);
            }
            catch
            {
                Informacion("ERROR: Los parametros de entrada no son correctos...");
            }
          

           Console.ReadLine();
        }
        //Metodo que muestra la ayuda y un mensje de error que pasamos en el Catch
        static void Informacion (string texto)
            {

                Console.WriteLine("\n\t " + texto+"\n\n");
                Console.WriteLine("Calcula el Area del Triangulo.  Ayuda: ");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Sintaxis: valorBase valorAltura ");
                Console.WriteLine("         AreaT valorBase valorAltura. ");
                Console.WriteLine("         AppLlamadConsoAreaTriang. -Nombre de la aplicacion. ");
                Console.WriteLine("         valorBase. -Real para la base del triangulo. ");
                Console.WriteLine("         valorAltura. -Real para la altura del triangulo. ");

                


            }
    }
}
