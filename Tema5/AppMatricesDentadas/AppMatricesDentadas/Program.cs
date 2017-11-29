/*
 Autor: Pablo Lopez
 Ejemplo consola: Matrices dentanas(inicializacion) y manejo
 Fecha:29/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMatricesDentadas.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIMENSION = 2;
            #region Declaraciones de Matrices dentanas
/*
            //Declaracion V1:
            int[][] m1 = new int[DIMENSION][];
            m1[0] = new int[3];
            m1[2] = new int[7];

            //Declaracion V2
            int[][] m2 = new int[DIMENSION][];
            m2[0] = new int[] { 1, 2, 3 };
            m2[2] = new int[] { 1, 2, 3, 4, 5, 6, };

            //Declaracion V3
            int[][] m3 = new int[DIMENSION][]
            {
                new int[3],
                new int[7]
            };
            //Declaracion V4
            int[][] m4 = new int[DIMENSION][]
            {
                new int[]{1,2,3},
                new int[7]
            };*/

            #endregion

            int[][] m = new int[DIMENSION][]
            {
                new int [7],
                new int[5]
            };

            IniMatrizAlea(m,10);
            VerMatrizDentana(m);
            Console.ReadLine();
        }
        /// <Muestra la matriz>
        /// 
        /// </Muestra la matriz>
        /// <param name="m"></param>
        static void VerMatrizDentana(int[][] m)
        {
            //Longitudes
            int d0 = m.Length;//Dimension de la primera matriz original
            int d00 = m[0].Length; //Dimension de la matriz  hacia la que apunta la primera posicion de la matriz original
            int d01 = m[1].Length;//Dimension de la matriz  hacia la que apunta la segunda posicion de la matriz original

            for (int i = 0; i < d0; i++)//Recorre la matriz o array original
            {
                if (i == 0)//Primera posicion de la matriz original que apunta a otra madriz"M[0]"
                {
                    Console.Write("Matriz[0]-> ");
                    for (int j = 0; j < d00; j++)                    
                        Console.Write(m[i][j]+"\t");
                    
                }
                Console.WriteLine();
                if (i == 1)//Primera posicion de la matriz original que apunta a otra madriz"M[0]"
                {
                    Console.Write("Matriz[1]-> ");
                    for (int j = 0; j < d01; j++)
                        Console.Write(m[i][j] + "\t");
                }
            }
        }

        /// <LLena las matrices de la matriz original>
        /// 
        /// </LLena las matrices de la matriz original>
        /// <param name="m"></param>
        /// <param name="maximo"></param>
        static void IniMatrizAlea(int[][] m, int maximo)
        {
            Random rnd = new Random();

            //Longitudes
            int d0 = m.Length;//Dimension de la primera matriz original
            int d00 = m[0].Length; //Dimension de la matriz  hacia la que apunta la primera posicion de la matriz original
            int d01 = m[1].Length;//Dimension de la matriz  hacia la que apunta la segunda posicion de la matriz original

            for (int i = 0; i < d0; i++)//Recorre la matriz o array original
            {
                if (i == 0)//Primera posicion de la matriz original que apunta a otra madriz"M[0]"
                {
                   
                    for (int j = 0; j < d00; j++)
                       m[i][j] = rnd.Next(maximo);

                }
              
                if (i == 1)//Primera posicion de la matriz original que apunta a otra madriz"M[0]"
                {
                  
                    for (int j = 0; j < d01; j++)
                        m[i][j] = rnd.Next(maximo);
                }
            }

        }


    }
}
