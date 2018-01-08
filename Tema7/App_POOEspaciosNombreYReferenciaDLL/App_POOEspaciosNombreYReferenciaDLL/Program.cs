/*
 Autor: Pablo Lopez
 Ejemplo consola: Aclaraciones sobre los espacios de nombre Alias y formas de referenciar las DLLs para poder usar sus espacio de nombres.
 Fecha: 08/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using pbl.Dos;
using pbl.Tres;
//Alias
using Alias3 = pbl.Tres; //<-- forma de declarar un alias

//añadidas referenciadas Manualmente de .NET
using System.Windows.Forms;

//-----------------------------------------------
// Forma de referenciar una Libreria externa:
/*
   -Una de .NET: Nos dirigimso al explorador de soluciones, hacemos click derecho encima de "References" ->"Agregar referencia"->Dentro de Ensamlado  en Framework 
   buscamos y marcamos la que necesitemos en este caso "System.Windows.Forms;"
  
  -Una Externa: Relizamos los mismo pasos, pero  en lugar de dirigirnos a Ensamlado  en Framework;  nos dirigimos al boton examinar que encontraremos abajo.. y buscamos
  la carpeta concreta en la que esta nuesta DLL o libreria Externa, y ya podremos colocar su Using y usarla.
 
 */
//-----------------------------------------------------

namespace pbl.App_POOEspaciosNombreYReferenciaDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo... desde App_POOEspaciosNombreYReferenciaDLL.pbl.Program");
            HolaMundo.Principal();
            pbl.Dos.ClaseDos.Saluda();//De esta forma "si no colocamos el using" llamamos a otra clase que es estatica y esta en otro espacio de nombre
            //ClaseDos.Saluda(); //<- Colocando a el Using de su espacio de nombre "using pbl.Dos;"
            ClaseTres.Saluda();
            Alias3.ClaseTres.Saluda();//usando el alias para llamar a la clase que esta dentro de un espacio de nombre, el cual puede ser tremendamente largo o no...
            
            Console.ReadLine();
        }
        
    }

    class HolaMundo
    {
        public static void Principal()//Al ser un miembro estatico de esta clase solo podremos acceder ael a traves del nombre de la calse punto y el nombre del mienbro,"NO creando un objeto de dicha clase"
        {
            Console.WriteLine("Hola Mundo... desde App_POOEspaciosNombreYReferenciaDLL.pbl.HolaMundo.Principal()");
        }
    }
}

namespace pbl.Dos
{
    public static class ClaseDos//para poder ver esta clase en los otras clase que estan dentro de otro espacio de nombre, debemos usar el espacio de nombre de esta.
    {
        static public void Saluda()
        {
            Console.WriteLine("Hola Mundo... desde  pbl.Dos.ClaseDos.Saluda()");
        }
    }
}


namespace pbl.Tres
{
    public static class ClaseTres//para poder ver esta clase en los otras clase que estan dentro de otro espacio de nombre, debemos usar el espacio de nombre de esta.
    {
        static public void Saluda()
        {
            Console.WriteLine("Hola Mundo... desde  pbl.Tres.ClaseTres.Saluda()");
        }
    }
}
