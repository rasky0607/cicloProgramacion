/*
 Ejemplo de Bucles pintando caracteres.
  Autor:Pablo Lopez
  Fecha: 26-10-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido
using System.Threading;

namespace AppPintaCaractConBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter = '*';
            const int MAXIMO = 1000;
            const int ESPERA = 80;//tiempo para retrasar la ejecuion del bucle.
            int anchoMax = Console.WindowWidth;
            int altoMax = Console.WindowHeight;
            int izq = 0;
            int arriba = 0;
            Random rnd = new Random();
            int colorelegido = 0;



            Console.CursorVisible = false;//Ocultamos el cursor
            for (int i = 0; i < MAXIMO; i++)
            {
                colorelegido = rnd.Next(3);//Genera un numero aleatorio entre 0 1 2
                switch (colorelegido)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                izq = rnd.Next(anchoMax);//menor que el ancho maximo
                arriba = rnd.Next(altoMax);
                Console.SetCursorPosition(izq, arriba);
                Console.WriteLine(caracter);
                Thread.Sleep(ESPERA);

            }
            Console.ResetColor();
            Console.CursorVisible = true;//Mostramos el cursos de neuvl al terminar
            Console.ReadLine();

        }
    }
}
