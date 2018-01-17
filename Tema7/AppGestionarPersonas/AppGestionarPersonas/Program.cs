/*
 Autor: Pablo Lopez
 Ejemplo consola:
 Fecha:
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
            Bomberos.AnadirUnaPersonaAleatoria();
            Bomberos.AnadirPersonasAleatoria(150);
            Console.WriteLine(" \n\t\t Hay {0} Bomberos\n", Bomberos.Cuantos());
            Bomberos.Listar("LISTADO BOMBEROS MALAGA");

            Console.Clear();
            ListaDePersonas Administrativos = new ListaDePersonas();
            Administrativos.AnadirPersonasAleatoria(100);
            Administrativos.Anadir(new Persona("Pepe", "Gil Garcia", DateTime.Parse("01/01/1995"), 1.75));
            Console.WriteLine(" \n\t\tHay {0} Administrativos\n", Administrativos.Cuantos());
            Administrativos.Listar("LISTADO ADMINISTRATIVOS MALAGA");
          

        }

    }
}
