/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemeplo de eventos y la llamada inversa que realizan "Call Back" desde otra clase a la principal
 ---DESCRIPCION DE LO QUE HAREMOS:
 * crearemos una clase "Contador" 
 ----En la clase Contador---
 * Crearemos nuestros Delegados"cambioValor" y "cambioValor5"
 * Crearemos unos cambios y un Constructor de la clase, para iniciar un contador cuando 
 * con la propiedad "Iniciar" del campo _iniciar cambie a "true"
 *Creamos un metodo llamado "VerContador()" que incrementara el valor de una de las propiedades
 *Lanzaremos los eventos
 -------------------------
 -----En la clase Principal---
 * Instanciamos un objeto de la clase
 * Nos apuntamos a los eventos
 * Escribimos los metodos "c1_cambioValor" y "c1_cambioValor5"  que se van a ejecutar cuando se lance dichos eventos
 * a los que nos apuntamos.
 ------FIN DESCRIPCIONS-------
 *
 
 Fecha:18/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.Threading;


namespace AppDelegadosEventosCallBack.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Contador c1 = new Contador();
            //Nos apuntamos al metodo igualandole el al metodo"c1_cambioValor"(que es lo que va ocurrir) o que se va ejecutar cuando se produzca dicho evento"cambioValor"
            c1.cambioValor += c1_cambioValor;//Truco para que loe scriba automatico, escribimos el nombre del evento += y tabulamos dos veces

            c1.cambioValor5 += c1_cambioValor5;

            //Para inciar el contador hay que cambiar el valor dela propiedad _iniciar
            c1.Iniciar = true;
            c1.VerContador();


            Console.ReadLine();
        }

     
        #region Que va ocurrir cuando se lanza y me apunto al evento

        static bool ahora = true;//para que la primera vez pinte en la primera posicion
        static int incrementaX = 0;//para que despues de la primera vez avance la posicion de X
        //Lo que va ocurrir cuando se lanze el evento al que nos hemos apuntado
        static void c1_cambioValor()
        {
            if(ahora)

                if (ahora)
                {
                    Console.SetCursorPosition(incrementaX, 20);
                    ahora = false;
                }
            Console.SetCursorPosition(incrementaX++, 20);
            Console.Write("-");
        }


        //Lo que va ocurrir cuando se lanze el evento al que nos hemos apuntado
        static void c1_cambioValor5()
        {
            Console.SetCursorPosition(5, 5);
            Console.Write(" Eh!, es multiplo de 5!");
            Thread.Sleep(500);
            Console.SetCursorPosition(5, 5);
            Console.Write("                          ");
        }


        #endregion
    }
}
