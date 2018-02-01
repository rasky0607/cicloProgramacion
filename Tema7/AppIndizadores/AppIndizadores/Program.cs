/*
 Autor: Pablo Lopez
 Ejemplo consola:Dotamos de Indizador a la clase ListaDePersonas (linea117)
 Fecha:01/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIndizadores.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDePersonas Bomberos = new ListaDePersonas();
            Bomberos.AnadirUnaPersonaAleatoria();
            Bomberos.AnadirPersonasAleatoria(50);
            
            //Listamos gracias al indizador solo una parte de la lista, en este caso de la posicion 10 a la 20 gracias al Get:
          /*  for (int i = 10; i <20; i++)
            {
                Console.WriteLine(Bomberos[i].ToString());
            }

            //Añadiendo una persona a traves de su indizador,gracias al Set:
            Bomberos[4] = new Persona();
            //Comprobamos que funciono
            Console.WriteLine(Bomberos[4].ToString());*/

            Bomberos.ListarPaginado("Listado de Bomberos");

           

        }

    }
}
