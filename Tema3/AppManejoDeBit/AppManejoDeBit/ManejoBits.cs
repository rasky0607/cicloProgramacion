/*
 Ejemplo: Manejo de bits
 Autor:pablo
 Fehca:23-10.2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManejoDeBit.pbl
{
    class ManejoBits
    {
        static void Main(string[] args)
        {               //Binario   Hexadecimal
            int i =15; //1111       0000 000F
            int b;
            int c;
            Console.WriteLine("EL valor de i ->{0:X}", i);//Escrito en Hexadecimal
            b = i >> 1;            
            Console.WriteLine("El valor de b = i>>1 -> {0:X}", b);
            c = i << 1;
            Console.WriteLine("El valor de c = i<<1 -> {0:X}", c);//Escrito en hexadecimal da 1E
            Console.WriteLine("El valor de c = i<<1 -> "+ (i << 1));//Escrito en Decimal da 30 , que es lo mismo que 1E.

            //Operaciones logicas de Bits | & ^ (o,and,or Oexclusiva)
            /*
             Tabla de verdad Operaciones logicas
            ----------------------------------------
             Vble1 Vble2 &   |   ^
             0      0    0   0   0
             0      1    0   1   1
             1      0    0   1   1
             1      1    1   1   0
             
             */

            /*
             Ej1:
             
             Vble1= 12Base10 ->C ->1100
             Vble2= 7Base10 ->7 -> 0111
                Operaciones
             -----------------
             & 0100
             | 1111
             ^ 1011
             */


            //EJ2 En relacion con la tabla de la verdad o operaciones logicas:
            int z = 12;
            int j = 7;
            Console.WriteLine("\n\t\tOperaciones Logicas");
            Console.WriteLine("\t-------------------------------\n");
            Console.WriteLine("EL valor de z & j ->{0:X8}", (z & j));
            Console.WriteLine("EL valor de z | j ->{0:X8}", (z | j));
            Console.WriteLine("EL valor de z ^ j ->{0:X8}", (z ^ j));



            Console.ReadLine();
        }
    }
}
