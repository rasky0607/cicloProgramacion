/*
 Autor: Pa Lopez
 Ejemplo consola:Muestra lso datos de la tecla pulsada usando ReadKey()
 Fecha:30/10/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMostrar_Info_de_la_tecla.pbl
{
    class Informacion
    {
        static void Main(string[] args)
        {
            #region Ejemplo3 Telas muertas pulsadas
            string nombre = string.Empty;
            string numeros = string.Empty;
            ConsoleKeyInfo pulsacion;    

                pulsacion = Console.ReadKey(/*true*/);//Al colocar true en la sobrecarga del metodo quitamos el eco de pantall, en cuanto se quite mostrara por pantalla lo que escriba            
            #endregion
            MostrarInfoTecla(pulsacion);
          

        }
        static private void MostrarInfoTecla(ConsoleKeyInfo tecla)
        { 
            //Datos de la tecla
            Console.WriteLine(" Caracter imprimible: "+ tecla.KeyChar);//El simbolo de la tecla pulsada si el caracter es imprible.
            Console.WriteLine("    Constante: Tecla: " + tecla.Key);//Identifica la tecla pulsada.
            Console.WriteLine("        Tecla Muerta: " + tecla.Modifiers);
            Console.ReadLine();
            return;
        }
    }
}
