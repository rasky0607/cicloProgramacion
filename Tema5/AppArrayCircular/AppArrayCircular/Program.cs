/*
 Autor: Pablo Lopez
 Ejemplo consola: Recorrer array de manera circular
 Fecha: 20/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArrayCircular.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            int vueltas = 5;
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Inicializacion de un aray de manera manual.

            //Vamos a recorrer de forma ciclica solo el 3,4,5
            int posIni = 2; // Posicion inicial del SubArray
            int posFin = 4;//Posicion final del SubArray
            int tamanoSub = posFin - posIni + 1; //Tamaño del subarray
            int indice = 0;

            for (int i = 0; i < vueltas; i++)
            {
                indice = i % tamanoSub + posIni;
                Console.Write("Pos-> [{0}] valor-> {1}",indice,vector[indice]);
            }

            Console.ReadLine();

        }


       

    }
}
