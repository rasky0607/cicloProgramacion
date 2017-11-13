/*
 Autor: Pablo Lopez
 Ejemplo consola:Enumeracion marcadas con el atributo flags, y operacioens que pueden realizar
 Fecha:13/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnumerTipoFlags.pbl
{
    class Program
    {
        [Flags]
        public enum ValoresBits : uint
        {
            noBit = 0x0,
            bit1 = 0x1,
            bit2 = 0x2,
            bit3 = 0x4,
            bit4 = 0x8,
            bit5 = 0x10,
            todos = 0xFFFFFFFF
        };
        static void Main(string[] args)
        {
            // con la operacion | añade valores
            //Con la operacion & quita valores
            ValoresBits unBit = ValoresBits.bit1;
            ValoresBits resultado = ValoresBits.bit1 | ValoresBits.bit3;
            Console.WriteLine(" Bit1 -> {0:X}", unBit);
            Console.WriteLine(" Bit3 -> {0:X}",ValoresBits.bit3);
            Console.WriteLine("Bit1 | Bit3 -> {0} osea en esadecimal el: {0:X}", ValoresBits.bit1 | ValoresBits.bit3);
            Console.WriteLine("Bit1 | Bit3 -> {0}", (ValoresBits) resultado);//Al ser de tipo Flag  te dice los nombre que combinandose generaron el valor de Resultado
            

            Console.ReadLine();
        }
    }
}
