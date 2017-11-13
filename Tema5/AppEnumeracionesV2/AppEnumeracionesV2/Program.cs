/*
 Autor: Pablo Lopez
 Ejemplo consola:otro ejemplo con enumeraciones
 Fecha:13/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnumeracionesV2.pbl
{
    class Program
    {
        
        //Enumeracion de tipo byte
        enum Dias:byte { Lunes=1, Martes=2, Miercoles, Viernes, Sabado }; 

        static void Main(string[] args)
        {
            #region Ejemplo1
            /*
            for (Dias dia = Dias.Lunes; dia< Dias.Viernes; dia++)//Recorremos la Enumeracion          
                Console.WriteLine(dia.ToString());

           
            //Colores del sistema
            Console.WriteLine("Colores: ");
            for (ConsoleColor color = ConsoleColor.Black; color < ConsoleColor.Yellow; color++)
                Console.WriteLine(color.ToString());
              */
            #endregion

            #region Ejemplo2
            Console.WriteLine(Enum.GetName(typeof(Dias), 3));//Delvuelve el nombre de la enumeracion en la posicion 3
            Console.WriteLine((Dias)3);//Hace lo mismo pero no devuelve un String, solo convierte implicitamente el identificador de lae numeraciona string, pero esto no nos permitiria guardarlo en una variable de tipo string.
            Console.WriteLine(((Dias)3).ToString());//Ahora si hacelo mismo convertido a String,esto nos permitira guardarloe n una variable de tipo string.

            //Lista de constantes
            Console.WriteLine("\n Lista de dias ");
            foreach (String tmp in Enum.GetNames(typeof(Dias)))//GetNames devuelve un Array de string con los dias
                Console.WriteLine("  "+tmp);

            #endregion

            #region Ejemplo3
            //string[] colores;//Ahora mismo apunta a NULL ya que no tiene zona de memoria donde apuntar
           // string[] colores = new string[100];//Ahora apunta a una zona de memoria donde tiene espacio para 100 strings. 
            
            //Estamos creando un array con el espacio o longitud que nos devuelve GetNames
            string[] teclas;
            teclas = Enum.GetNames(typeof(ConsoleKey));
            Console.WriteLine("\n **Lista de TECLAS**\n");
            foreach (string tecla in teclas)           
                Console.Write("{0}\t", tecla);

            Console.WriteLine("\n\n **Hay "+ teclas.Length.ToString()+ " teclas definidas.**" );
            #endregion


            Console.ReadLine();
        }
    }
}
