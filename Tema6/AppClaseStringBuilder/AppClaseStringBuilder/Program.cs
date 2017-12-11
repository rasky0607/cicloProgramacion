/*
 Autor: Pablo Lopez
 Ejemplo consola: Clase String Builder
 Fecha:11/12/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClaseStringBuilder.pbl
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //MostrarInfoContenidoString();
            //MostrarInfoContenidoStringBuilder();
            int nCopias = 300000;
            NtickTrascurridosStrBuilder(nCopias);
            NtickTrascurridosString(nCopias);
            Console.ReadLine();
        }


        static void MostrarInfoContenidoString()
        {
            string cadena = null;//que noe s lo mismo que String.empty Que si apunta a memoria aun que este vacio, con null, aun no tiene memoria..
            Console.Write(" Dime un texto simpatico: ");
            cadena = Console.ReadLine();

            int i = 0;//Indice o posicion

            do
            {
                Console.WriteLine(" Caracter: {0} -> Unicode: {1}",cadena[i],(int)cadena[i]);
                i++;
            } while (i < cadena.Length);
            Console.WriteLine("\n\n Ya no hay mas..");
            Console.ReadLine();
        }

        static void MostrarInfoContenidoStringBuilder()
        {
            StringBuilder cadena = new StringBuilder();

            Console.Write(" Dime un texto simpatico: ");

            cadena.Append(Console.ReadLine());//Añade lo que lee de teclado a la cadena

            int i = 0;//Indice o posicion

            do
            {
                Console.WriteLine(" Caracter: {0} -> Unicode: {1}", cadena[i], (int)cadena[i]);              
                i++;
            } while (i < cadena.Length);
            Console.WriteLine("\n -Capacidad: {0}\n -Numero de caracteres o datos: {1}\n -Maxima capacidad: {2}", cadena.Capacity, cadena.Length,cadena.MaxCapacity);
            Console.WriteLine("\n\n Ya no hay mas..");
            Console.ReadLine();

        }

        static void NtickTrascurridosStrBuilder(int nCopias)
        { 
            //Realiza un nº de modificaciones en el String Builder indicado por un numero de copias
            //Muestra el  tiempo consumido para esta opearcion.

            DateTime ahora = DateTime.Now;
            DateTime despues;
            long diferenciaTicks;
            StringBuilder textoInicial = new StringBuilder("");
            string letra = "x";
            DateTime diferenciaEnTiempo;

            for (int i = 0; i < nCopias; i++)
                textoInicial.Append(letra);

            despues = DateTime.Now;
            diferenciaTicks = despues.Ticks - ahora.Ticks;
            diferenciaEnTiempo = new DateTime(diferenciaTicks);//El constructor de la estructura DateTime saca la diferencia.
            //Mostrar informacion
            Console.WriteLine("     String Builder");
            Console.WriteLine("------------------------------");
            Console.WriteLine("     Al entrar: {0,24}", ahora.Ticks);
            Console.WriteLine("     Al salir: {0,24}", despues.Ticks);
            Console.WriteLine("".PadRight(50,'-'));
            Console.WriteLine("     Diferencia de ticks: {0,24}", diferenciaTicks);
            Console.WriteLine("     Diferencia de tiempo {0,24}", diferenciaEnTiempo);
            Console.WriteLine("\n\n Eso es todo.. \n");
        }

        static void NtickTrascurridosString(int nCopias)
        {
            //Realiza un nº de modificaciones en el String Builder indicado por un numero de copias
            //Muestra el  tiempo consumido para esta opearcion.

            DateTime ahora = DateTime.Now;
            DateTime despues;
            long diferenciaTicks;
            string textoInicial = "";
            string letra = "x";
            DateTime diferenciaEnTiempo;

            for (int i = 0; i < nCopias; i++)
                textoInicial += letra;

            despues = DateTime.Now;
            diferenciaTicks = despues.Ticks - ahora.Ticks;
            diferenciaEnTiempo = new DateTime(diferenciaTicks);//El constructor de la estructura DateTime saca la diferencia.
            //Mostrar informacion
            Console.WriteLine("     String ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("     Al entrar: {0,24}", ahora.Ticks);
            Console.WriteLine("     Al salir: {0,24}", despues.Ticks);
            Console.WriteLine("".PadRight(50, '-'));
            Console.WriteLine("     Diferencia de ticks: {0,24}", diferenciaTicks);
            Console.WriteLine("     Diferencia de tiempo {0,24}", diferenciaEnTiempo);
            Console.WriteLine("\n\n Eso es todo.. \n");
        }

    }
}
