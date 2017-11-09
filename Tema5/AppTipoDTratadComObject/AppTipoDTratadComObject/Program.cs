/*
 Autor: Paablo Lopez
 Ejemplo consola: tratamos tipos de datos por valor en tipo de datos Object o como  objetos y Visibilidad de varibles
 Fecha:09/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTipoDTratadComObject.pbl
{
    class Program
    {
       static  int vblCompartida; //variable visible para toda la clase

        static void Main(string[] args)
        {
            
            int numero = 5;// variable visible solo para el metodo. 
            object rNumero;
            rNumero = numero;   //Boxing o Empaquetando
            object texto = "Hola caracola";
            object real = Math.PI;
           
            Console.WriteLine(rNumero);
            Console.WriteLine(texto);

            //Error generado a conciencia (ya que el entero esta empaquetado en un tipo Object y no puede operar)
            //Console.WriteLine(rNumero + 10); <-Error
            //Hay que desempaquetarlo primero.
            Console.WriteLine((int)rNumero + 10); //Unboxing o Desenpaquetado usando un casting
            /*--------------------------------------------------------*/
            Console.ReadLine();
        }
    }
}
