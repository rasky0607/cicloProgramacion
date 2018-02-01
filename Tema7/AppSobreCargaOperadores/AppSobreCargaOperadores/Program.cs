/*
 Autor: Pablo Lopez
 Ejemplo consola:SobreCargar Operadores  para dar distintas funcionalidades a determinados operadores.
 Con una Clase agenda que añade apuntes o anotaciones.
 Fecha:31/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSobreCargaOperadores.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miagenda = new Agenda();
           
            /*El valor  boolean que devuelve nuestro metodo que sobrecarga el Operador.
            debe usarse si o si , por eso razon interrogamos por el .*/
            if (miagenda + " Mi primer contacto")
                                     
            miagenda.ListarAnotaciones();


        }
    }
}
