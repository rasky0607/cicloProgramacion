/*
 Autor: Pablo Lopez
 Ejemplo consola: como definir una enumeracion y su uso
 Fecha:09/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdefiniEnumeraciones.pbl
{
    class Program
    { //Definicion de Enumeracion
        enum Dedo { indice, anular, corazon, pulgar, meñique };//Posiciones dadas autmaticamente ' indice = 0, anular = 1,corazon=2, pulgar =3, meñique=4 '

        enum Dedo2 { indice=0, anular=2, corazon=4, pulgar=5, meñique=9 };//le damos valor alas posiciones manualmente , no de forma automatica que empezara por el 0
        static void Main(string[] args)
        {

            Dedo dedoRoto = Dedo.anular; // solo puede utilizar un valor de la enumeracion
            Console.WriteLine(dedoRoto);
            Console.WriteLine((int)dedoRoto);//Convierte al entero que lo representa que tiene que ver con su posicion "la cual siempre empieza por el 0"
            Console.WriteLine((Dedo)3);// Al contrario , convierte el 3 a el dedo que esta en la posicion 3 de la enumeracion.
            int dedo = 0;

            //Generar dedos aleatorios:
            Console.WriteLine("\n Generar dedos Aleatorios:");
            Console.WriteLine("-------------------------------\n");
            Random rnd = new Random();
            int max = 4;
            for (int i = 0; i < 10; i++)
            {
                dedo = rnd.Next(max);//Genera el numero y
                Console.WriteLine((Dedo)dedo+", "+dedo); //Lo convierte a  un dedo de esa posicion
            }
        
                     
            Console.ReadLine();
        }
    }
}
