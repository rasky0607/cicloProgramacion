/*
 Autor: Pablo Lopez
 Ejemplo consola: como agregar una DLL externa a mi proyecto
 Fecha:22/01/2018
 * 
 * Agregar DLL:
 * para ello nos dirigmos al explorador de soluciones click derecho dentro de "References" 
 * -> "Agregar Referencia" -> click en Boton Examinar-> y buscamos la carpeta donde este guardada nuestra DLL
 * por ultimo para poder usarla , añadimos el espacio de nombre de nuestra DLL a nuestro proyecto para poder usarla.
 * 
 *  -Para que muestre la AYUDA de nuestra DLL EXTERNA: deberiamos haber generado el fichero de ayuda XML al compilar nuestra DLL y habernos llevado este fichero XML al mismo lugar donde  dejamos nuestro DLL que hemos 
  exportado anteriormente.
 
    *(para crear este fichero de ayuda XML donde generemos la DLL, deberemos dirigirnos a explorador de soluciones -> click derecho-> propiedades->compilar-> y abajo del todo marcamos la casilla de "Archivo de documentacion XML"
       Esto generara el fichero de ayuda que necesitamospara nuestra DLL
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadimos el espacio d enombre de la DLL:
using AppGestionarPersonas;

namespace AppAgregarDLLGestionPersonas.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prueba de que la DLL esta funcionando correctamente
            ListaDePersonas Bomberos = new ListaDePersonas();
            Bomberos.EntradaOK += Bomberos_EntradaOK;
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

        static void Bomberos_EntradaOK(DateTime ahora)
        {
            Console.WriteLine(" Se ha añadido una persona a las: {0}", ahora.ToShortTimeString());
        }
    }
}
