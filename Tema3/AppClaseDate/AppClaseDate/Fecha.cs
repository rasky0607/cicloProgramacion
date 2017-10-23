/*
 Ejemplo formatos Fecha.
 Autor:Pablo lopez
 Fecha:23-10-2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClaseDate.pbl
{
    class Fecha
    {
        static void Main(string[] args)
        {
            DateTime fechaEntrada;
            fechaEntrada = DateTime.Now;//Fecha actual incluyendo horas,minutos y segundos

            Console.WriteLine("La fecha actual es " + DateTime.Today.ToLongDateString());//fecha actual formato largo, con el mes  y dia escritos a letra.
            Console.WriteLine("La fecha actual es " + DateTime.Today.ToShortDateString());//Formato corto sin la hora.
           

            Console.WriteLine("\nPulsa una tecla...");
            Console.ReadLine();
            Console.WriteLine("   conexion: " + fechaEntrada.Millisecond);//Solo muestra los Milisegundos  de la fehca en la que entraste o que guardamos anteriormente, se actual o deotro dia...

            Console.WriteLine("desconexion: " + DateTime.Now.Millisecond);//Muestra los Milisegundos de la fecha acuales

            Console.ReadLine();
        }
    }
}
