/*
 Autor: Pablo Lopez
 Ejemplo consola:personalizacion excepciones (creado clases para nuestras excepiones personalizadas)
 Fecha:15/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExcepcionesPersonalizadas.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] datos1 = {1.2F,3.5F,7.6F };
            float[] datos2 = new float[] { };
            Media laMedia = new Media();
            try
            {
                Console.WriteLine(" La media de datos1 es: {0}", laMedia.HacerLaMedia(datos1));
                //return;
                Console.WriteLine(" La media de datos1 es: {0}", laMedia.HacerLaMedia(datos2));//provocara la excepcion personalizada
            }
            catch (ContadorCeroException e)//Mostrar el mensaje de la calse personalizada
            {
                Console.WriteLine(e.Message);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("A ocurrido un ERROR no controlado.");
            }
            finally//pasara por aqui siempre, con o sin salto incodicional como " return, Break,continue etc..
            {
                Console.WriteLine(" hasta luego lucas...");
                Console.ReadLine();
            }

          
        }
    }

    /// <MediaInfo>
    /// Hace la media de un array de float
    /// </MediaInfo>
    class Media
    {
        float suma;
        int contador = 0;
        #region Metodo
        public float HacerLaMedia(float[] datos)
        {
            contador = datos.Length;
            if (contador == 0)
                throw new ContadorCeroException(" ERROR: El contador no puede ser 0");
            else
            {
                foreach (float tmp in datos)
                {
                    suma += tmp;
                }
                return suma / contador;
            }
        }
        #endregion

    }
    //Clase de excepcion personalizada 
    class ContadorCeroException : Exception
    {
        #region Constructores

        public ContadorCeroException():base()//Llama al constructor base de Exception
        { 
            
        }

        public ContadorCeroException(string mensaje) : base(mensaje)//Llama a la sobrecarga del constructor base de exception que recibe un string como parametro 
        {

        }

        #endregion

    }
}
