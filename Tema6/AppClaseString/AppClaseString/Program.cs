/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de algunos contrusctores y metodos de la clase String
 Fecha:04/12/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClaseString.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] arraychar = {'h','o','l','a' };
            String s1 = new String(arraychar);//crear un String a traves de un array de Char
            String s2 = "Malaga";//Igual que una variable realmene
            
            String s3 = new String('=', 5);//Escribe 5 veces un determinado caracter          
            String s5 = "Malaga";
            String s11 = "pepe";
            
            int entero = 125;
            s11 = entero.ToString();//Conviertimos un entero a String;

            #region Metodo Concatenacion de strgin
            //Concatena dos string
            Console.WriteLine("concatenare \"{0}\" con \"{1}\"", s11, s3);
            string s4 = s11 + s3;
            Console.WriteLine(" Resultado: "+s4);
            #endregion

            #region Metodo PadLeft o Right()
            //Rellena por la izquierda hasta quela cadena strginta sea 20 si no llega con "hola caracola" añade por la izquierda con '*'
            Console.WriteLine("\n -Rellenare por la izquierda con \"-\" hasta que la longitud de lacadena sume 20. ");
            Console.WriteLine(" Cadena original:");
            Console.WriteLine("hola caracola");
            Console.WriteLine(" Cadena rellena:");
            Console.WriteLine("hola caracola".PadLeft(20, '-'));

            #endregion

            #region Metodo CompareTo()
            //Compara dos cadena '1 si no son iguales (y el de la derecha es mayor) -1 si es el de la izquierda', '0 si son iguales'
            Console.WriteLine("\n -Compara {0} con {1} \"0 son iguales\" \"1 el de la derecha es mayor\" \"-1 el de la izquierda es mayor\" ", s2, s5);     
            Console.WriteLine(" Respuesta: "+s2.CompareTo(s5));
            #endregion

            #region Metodo Replace()

            Console.WriteLine("\n -Remplazare donde encuentr la cadena\"la\" por \"xxxxx\" ");
            Console.WriteLine(" Cadena original:");
            string texto = "malaga la bella";
            string textoremplazado = texto.Replace("la", "xxxxx");
            Console.WriteLine(" Cadena sustituida:");
            Console.WriteLine(" "+textoremplazado);
            #endregion

            #region Metodo Split()
            // Ejemplo del metodo Split()
            Console.WriteLine("\n -Voy a separar las palabras de la frase : \""+texto+"\".");           
            char[] separadores = new char[1];//Crea el array de separadores
            separadores[0] = ' ';//Añadimos los separadores , en este caso solo es  uno..(añadimos los que queramos..)
            string[] palabrasdelString;//array creado para guardar cada una de las palabras.. ya que el metodo devuelve un array de string..
            palabrasdelString = texto.Split(separadores);
            //Recorrermos el array de string para mostrarlo.
            for (int i = 0; i < palabrasdelString.Length; i++)
            {
                Console.WriteLine(" [{0}]-> {1} ",i,palabrasdelString[i]);
            }

            //Metodo Substring()
            Console.WriteLine("\n -Extrae parte del string:");
            string partedelstringtexto = texto.Substring(5, 10);
            Console.WriteLine(" Texto original:");
            Console.WriteLine(" "+texto);
            Console.WriteLine(" Texto extraido:");
            Console.WriteLine(" "+partedelstringtexto);
            #endregion

            Console.ReadLine();

        }
    }
}
