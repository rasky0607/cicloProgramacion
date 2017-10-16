/*-----------------------------------------------------------------
 * Autor : Pablo Lopez
 * Fecha: 16-10-2017
 * Tema:3
 *--------------------------------------------------------------- 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_JugandoConTiposV1
{
    class TipoDeDatos
    {
        static void Main(string[] args)
        {
            //Varaibles

            float f1, f2, f3;
            int i1;
            byte b1, b2;
            //-------------//

            Console.Clear();
            Console.WriteLine("\t\t------------Nombre de la clase del tipo----------------\n");
            Console.WriteLine("-El tipo \"int\" pertenece a la clase: {0}", typeof(int));
            Console.WriteLine("-El tipo \"float\" pertenece a la clase: {0}", typeof(float));
            Console.WriteLine("-El tipo \"byte\" pertenece a la clase: {0}", typeof(byte));

            Console.WriteLine("\n\t\t-------------------------------------------\n");

            Console.WriteLine("\t\t------------Espacio ocupado en memoria------------\n");
            Console.WriteLine("-El tipo {0} ocupa {1} bytes en memoria.", "int", sizeof(int));
            Console.WriteLine("-El tipo {0} ocupa {1} bytes en memoria.", "float", sizeof(float));
            Console.WriteLine("-El tipo {0} ocupa {1} bytes en memoria.", "double", sizeof(double));
            Console.WriteLine("\n\t\t-------------------------------------------\n");
            Console.WriteLine("\t\t------------Valores maximos.---------------\n");
            Console.WriteLine("-Los limites del tipo {0} son {1} -{2}", "int", int.MinValue, int.MaxValue);
            Console.WriteLine("-Los limites del tipo {0} son {1} -{2}", "double", double.MinValue, double.MaxValue);
            Console.WriteLine("-Los limites del tipo {0} son {1} -{2}", "sbyte", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("\n\t\t-----------------------------------------\n");

            //------------------Desbordamiento------------------------------//
            Console.WriteLine("\n\t\t------------------Desbordamiento------------");
            b1 = 254;

            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            b1++;//Es lo mismo que b1 = b1+1;
            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            b1++;// al llegar a "256" ,se desborda el maximo de ese numero y al darse este caso vuvlve al valor 0.

                                        //Explicacion grafica:
            /*                                                                    ^->----------->---| 
                                                                                  |                  v  
            //El numero realmente esta guardado como si fuera de manera circular: |0|1|2|3|......|255|
                                                                                  |                  v
                                                                                  ^----<-----------<--- 
             */



            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            b1++;//si volvemos a incrementarlo uno mas, este pasara al siguiente numero "1"
            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            Console.WriteLine("\n\t\t-----------------------------------------\n");
            #region Ejemplo de comprobacion de desbordamiento
            /*
             Para comprobar si hay desbordamiento en el nuemro MAXIMo de un tipo como ocurre arriba usando la palabra reservada "checked" como en el ejemplo:
           checked
            {
            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            b1++;//Es lo mismo que b1 = b1+1;
            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            b1++;                 
            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            b1++;
            Console.WriteLine("\n-El valor de {0} es -> {1}", "b1", b1);
            Console.WriteLine("\n\t\t-----------------------------------------\n");

              
            }
             
             */
            #endregion
            //---------Casting o conversion de un tipo en otro tipo -----//(Solo valido entre tipos compatibles)
            Console.WriteLine("\n\t\t-------Casting o conversion de un tipo en otro tipo. -----");
            i1 = 65;
            char letra = 'X';
            letra = (char)65;// <- Casting
            Console.WriteLine("-El UNICODE/ASCCI de {0} -> {1}", letra, i1);
            Console.WriteLine("-El UNICODE/ASCCI de {0} -> {1}", letra, (int)letra);// <-- Otra forma de hacer el Casting
            Console.WriteLine("-El UNICODE/ASCCI de {0} -> {1}", (char)i1, i1);// <-- Otra forma de hacer el Casting solo que en este caso lo guarda en la variable

            Console.ReadLine();


            //---------------//
        }
    }
}
