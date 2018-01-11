/*
 Autor: Pablo Lopez
 Ejemplo consola: Funcionamiento de Constructores y Destructores
 Fecha:11/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------Añadidos------------------
using pbl.AppConstructoresDestructores;

namespace AppConstructoresDestructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();//Usando el constructor vacio(Aun que aun no podemos acceder a el por que no pusimos el codigo para ello)
            
            Clase_A a = new Clase_A();
            Console.ReadLine();
        }
    }
}
