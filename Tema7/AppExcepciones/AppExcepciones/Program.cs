/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de tratamiento y propagacion de excepciones
 Fecha:14/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExcepciones.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejemplo1
            /*         
            int denominador = 1;
            int numerador = 1;
                try{

                    Console.Write("Denominador ");
                    denominador = int.Parse(Console.ReadLine());
                    denominador = numerador / denominador;
                    
                }
                catch(Exception Exception)//Parametros para capturar  informacion de la excepcion que entre en este bloque para buscar tratamiento
                {
                    Console.WriteLine(" ERROR: "+Exception.ToString());//MUestra informacion de la excepcion
                    Console.WriteLine(" ERROR: " + Exception.Message);//Muestra solo el mensaje de la excepcion capturada.
                    Console.WriteLine(" ERROR: " + Exception.Source);// la fuente de donde proviene la excepcion
                }
                Console.ReadLine();
           */
            #endregion

            #region Ejemplo 2 de propagacion de Excepciones
            try
            {
                Console.WriteLine(" Try.. del NIVEl 0");

                try
                {
                    throw new DivideByZeroException();
                    Console.WriteLine(" Try.. del NIVEl 1");

                }
                catch
                {
                    Console.WriteLine(" Catch.. del NIVEl 1");
                }
                finally
                {
                    Console.WriteLine(" finaly.. del NIVEl 1");
                }

            }
            catch (NullReferenceException)//tratamiento de una excecpcion concreta en este caso "NullReferenceException"
            {
                //En caso de decir Throw; ( indicamos que siga propagandose hacia arriba aun que aqui crea que se trate.., pro que uqeremos tratarla en otro lugar
                Console.WriteLine(" Catch.. del NIVEl 0 de la Excepcion NullReferenceException");
            }
            catch
            {
                Console.WriteLine(" Catch.. del NIVEl 0");
            }
            finally
            {
                Console.WriteLine(" finaly.. del NIVEl 0");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
