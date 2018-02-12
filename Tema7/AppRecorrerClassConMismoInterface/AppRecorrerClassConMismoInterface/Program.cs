/*
 Autor: Pablo Lopez
 Ejemplo consola: Llamar al metodo en comun de ambas clases implementado por el interfaz
 Fecha:12/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRecorrerClassConMismoInterface.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(10, 2.3);
            Proveedor p = new Proveedor("Daniel", "Moreno", 101);
            //Ejemplo2
            t.OnPresentar += t_OnPresentar;//Se apunta al evento
            //----------/
            VerDatos(t);
            VerDatos(p);
        }

        //Ejmplo2 Lo que va hacer cuando se lance el evento
        static void t_OnPresentar(object sender, EventArgs e)
        {
            Console.WriteLine(" Está contento con el evento...?");
            Console.ReadLine();
        }
        //--------------------------//

        /*Dado el parametro el cual es un interface, podremos llamar a cualquiera delas clases que implemente dicho interface 
         y llamar a el metodo  inplementado en cada clase que es comun*/
        public static void VerDatos(Ipresentable p)
        {          

            p.Presentable();
            Console.Write(" Eso es todo...");
            Console.ReadLine();
        }
    }
}
