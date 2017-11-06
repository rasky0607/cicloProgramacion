/*
 Autor: Paablo Lopez
 Ejemplo consola:Introduccion a excepciones  usando el bloque de tratamiento "try chatch"
 Fecha:02/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIntroducionExcepcionesTryChatch.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend = 0;
            int divisor = 1;
            Console.WriteLine(" Soy un maquina dividiendo");

            do
            {
                
                Console.WriteLine("\n\n Dime el dividendo: ");
                //Bloque Try Catch de control de excepciones.
                try
                {
                    dividend = int.Parse(Console.ReadLine());

                    Console.Write("\n Dime el divisor: ");
                    divisor = int.Parse(Console.ReadLine());
                    Console.WriteLine(" El resultado de {0}/{1} -> {2}", dividend, divisor, dividend / divisor);
                    break;
                }
                //Tratamiento especifico
                catch (DivideByZeroException e)
                {
                    //Trata la excepcion de division por cero
                    Console.WriteLine("No no no...");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException x)
                {
                    //Tratamiento de desbordamiento
                    Console.WriteLine("No no no...");
                    Console.WriteLine(x.Message);
                }
                //Tratamiento general de la Excepcion
                catch (Exception e)//Solo para obtener informacion usamos las variables como e para alamcenar la informacion de la clase en la que se produjo,en este caso es la general"Exception".
                {
                    Console.WriteLine("No no no...");
                    Console.WriteLine(e.Message);

                }
            finally//Otras obciones que se pueden incluir en un bloque Try Chatch "El Finally siempre siempre se hace"
                {
                    Console.WriteLine("Soy el Finally y siempre hare esto uahahahahahhah!!!!!");
                }
            } while (true);//vuelve al comienzo de  codigo mientras  de algun tipo de error ,osea mientras devuelva false

            Console.ReadLine();
        }
    }
}
