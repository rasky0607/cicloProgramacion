/*-----------------------------------------------------------------
 * Autor : Pablo Lopez
 * Fecha: 18-10-2017
 * Tema:3
 *--------------------------------------------------------------- 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_jugandoConTiposV2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = (char)65;
            int i1 = 0;
            byte b1 = (byte)'A';
            short s1 = 5;       //0000 0000 0000 0101 ,0005 en base Hexadecimal.
            short s2 = 10;      //0000 0000 0000 1010 ,000A en base Hexadecimal.
            //Caso especial de los String, que a pesar de ser por referencia, el metodo "==" esta sobrecargado para los compare como si fuera por valor"
            string sS1 = "hola";
            string sS2 = "hola";
            //Los array son por referencia.
            int[] a1={1,2,3};
            int[] a2={1,2,3};
            string cadena = "===>";

            double f1 = 3.141592F;//Al colocarle una "F" detras se convierte automaticamente en un flotante.
           
            /*Otras abreviaturas que modifican el tipo de dato:
                             
                -"L" o "l" para indicar que lo trataremos como entero es largo.
                -"M" o "m" para indicarle que lo trataremos como decimal.
                -"D" o "d" para indicarle que lo trataremos como doble.
                -"U" o "u" para convertirlo a un entero sin signo.
                      Ej: "Imaginamos que el numero maximo es 300"
                        int X = 300;
                        int x = 308u; 
                        **Al convertirlo en un entero sin signo, aumentamos un bits el espacio por lo que el maximo que podamos guarda sera el doble y ya si entraria dicho numero.
*/


            Console.WriteLine("El numero s1 vale en decimal {0} y en Hexadecimal {0:X}", s1); //{0:X} para que lo escriba en formato hexadecimal (aun que en este caso sale igual).
            Console.WriteLine("El numero s1 vale en decimal {0} y en Hexadecimal {0:X4}", s2); //{0:X4} para que lo escriba en formato hexadecimal pero solo un bloque de 4 "0005".
            Console.WriteLine("El complemento A1 de {0:X4} es {1:X8}", s2, ~s2);// ~ da la vuelta al resultado(convirtiendo los 1 en 0 y los 0 en 1) y lo convierte a  Hexadecimal antes de escribirlo,
            Console.WriteLine("El complemento A1 de {0:X8} es {1:X8} -> {2:X8}", s2, ~s2,~~s2);//Realizamos el complemento sobre el propio
            Console.WriteLine("Es sS1 == sS2, {0}", sS1 == sS2);//Esta comaprando por valor, por que para los string el operado"==" esta sobrecargado
            Console.WriteLine("Es a1 == a2, {0}",a1==a2);//Esta comparando por referencia, por lo que la direccion dememoria que hace referencia esos valores de los Arrays, siempre seran diferente, aun que contengan los mismo valores

            //Booleanos
            Console.WriteLine("{0} es {1}", b1 > s1, !!true);//distinto de verdad y distinto de falto...!true = false !false=true resutlado true.

            //Concatenacion de cadenas de String
            cadena += "\nHola caracola\n" + "," + "Un dia vi una vaca ...";
            Console.WriteLine("{0}", cadena);


            Console.ReadLine();

        }
    }
}
