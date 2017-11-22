/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de array de dos dimensiones
 Fecha:22/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppArray2Dimensiones.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NFILAS = 10; //Numero de filas
            const int NCOLUM = 10; //Numero de columnas
            int[,] array2D2 = CrearMatriz2D(6, 4, 9);          
           MostrarArry2D (CrearMatriz2D(NFILAS, NCOLUM,-1));
           Console.WriteLine("\n\n");
           MostrarArry2D(array2D2);
           Console.WriteLine("\n\n");
           MostrarArry2D(CrearMatriz2DAlea(NFILAS, NCOLUM, 10));


           Console.ReadLine();
        }
        /// <Crea una Matriz de dos dimensiones>
        /// Crea una matriz de 2D llena de valores
        /// </Crea una Matriz de dos dimensiones>
        /// <param name="nfilas">int: numero de filas que deseas que tenga </param>
        /// <param name="ncolum">int: numero de columnas que deseas que tenga</param>
        /// <param name="valores">int: numero con el que rellenaremos el array de dos dimensiones</param>
        /// <returns></returns>
        static int[,] CrearMatriz2D(int nfilas, int ncolum, int valores)
        { 
            int [,] array2D = new int[nfilas,ncolum];

            for (int i = 0; i < nfilas; i++)            
                for (int j = 0; j < ncolum; j++)                
                    array2D[i,j] = valores;
                
            

            return array2D;

        }

        /// <Crear una matriz o array numeros aleatorios>
        /// Crear una matriz o array de dos dimensiones de numeros aleatorios en el que el usuario diga el maximo de dichos numeros aleatorios
        /// </Crear una matriz o array numeros aleatorios>
        /// <param name="nfilas">numero de filas de la primera dimension del array</param>
        /// <param name="ncolum">numero de columnas de la segunda dimension del array</param>
        /// <param name="aleatoMax">numero maximo aleatorio permitido generar</param>
        /// <returns>Devuelve el array creado</returns>
        static int[,] CrearMatriz2DAlea(int nfilas, int ncolum,int aleaMax)
        {
            Random rnd = new Random();
            int[,] array2D = new int[nfilas, ncolum];

            for (int i = 0; i < nfilas; i++)
                for (int j = 0; j < ncolum; j++)
                    array2D[i, j] = rnd.Next(aleaMax);


            return array2D;

        }

        static int[,] MostrarArry2D(int [,] array2D)
        {           
            int nFilas=array2D.GetLength(0);//Lee la  longitud de la primera dimension
            int nColum = array2D.GetLength(1);//Lee la segunda dimension " Ya que tratamos a un array de dos dimensiones como  si tubiera otro array de dos dimensiones.. donde la primera dimension es la 0 y la segunda la 1.. tenceraa seria la 2 etc.."


            //Dos bucles para recorrer las filas y las columnas
            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < nColum; j++)
                {
                    Console.Write("{0,3}", array2D[i, j]);
                }
                Console.WriteLine();//Antes de escribir la siguiente fila cambia de linea.
            }



            return array2D;

        }


       

    }

}
