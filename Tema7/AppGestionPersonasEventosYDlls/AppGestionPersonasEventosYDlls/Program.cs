/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de persona al que le añadimos delegados y alguna otra Dll creada por  nosotros
 Fecha:22/01/2018
 * 
 *Creacion de la DLL:
 *  Nos dirigimos a "PROYECTO" -> "propiedades del proyecto" en el apartado de "Aplicacion" 
 *  En el apartado  de "Tipo de resultado" marcamos la obcion de " Biblioteca de Clases"
 *  Ahora para generar la DLL o pulsamoos  F6 pra compilar o ejecutamos"Aun que de un error por que  esta ignorando el Main"
 *  (Lo mejor es usar F6)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionarPersonas.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDePersonas Bomberos = new ListaDePersonas();

            #region eventos a los que se apunto el programa principal
            Bomberos.EntradaOK += Bomberos_EntradaOK;
            #endregion

            Bomberos.AnadirUnaPersonaAleatoria();
           // Bomberos.AnadirPersonasAleatoria(150);
            Console.WriteLine(" \n\t\t Hay {0} Bomberos\n", Bomberos.Cuantos());
            Bomberos.Listar("LISTADO BOMBEROS MALAGA");

          
            
            Console.Clear();
            ListaDePersonas Administrativos = new ListaDePersonas();
            Administrativos.AnadirPersonasAleatoria(100);
            Administrativos.Anadir(new Persona("Pepe", "Gil Garcia", DateTime.Parse("01/01/1995"), 1.75));
            Console.WriteLine(" \n\t\tHay {0} Administrativos\n", Administrativos.Cuantos());
            Administrativos.Listar("LISTADO ADMINISTRATIVOS MALAGA");
          

        }

        static void Bomberos_EntradaOK(DateTime ahora)
        {
            Console.WriteLine(" Se ha añadido una persona a las: {0}", ahora.ToShortTimeString());
        }

    }
}
