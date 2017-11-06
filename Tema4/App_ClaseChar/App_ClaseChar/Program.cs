/*
 Autor: Pablo Lopez
 Ejemplo consola: Algunas propiedades de la clase Char
 Fecha:02/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ClaseChar.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
           byte postIni = 32;
            byte posFin = 126;
            char caracter = ' ';

            for (byte i = postIni; i < posFin; i++)//Al ser la "i" de tipo byte no puede ir mas alla de 256
            {
                caracter = (char)i;
                if (char.IsControl(caracter))
                    Console.WriteLine(" -Control: "+caracter);
                if (char.IsDigit(caracter))
                    Console.WriteLine(" *Digito: " + caracter);
                if (char.IsLetter(caracter))
                    Console.WriteLine(" #Letra: " + caracter);
                if (char.IsNumber(caracter))
                    Console.WriteLine(" =Numero: " + caracter);
            }


            Console.ReadLine();
        }
    }
}
