/*
 Autor: Pablo Lopez
 Ejemplo consola:Serializacion de una clase persona
 Fecha:08/03/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSerializar.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\personas.dat";
            GestionaPersona persona = new GestionaPersona(ruta);
            persona.Anadir(new Persona("Martinez","lolo",133.67F));
            persona.Anadir(new Persona("Gutierrez", "Marco", 130.67F));
            persona.Listar();
            Console.ReadLine();
        }
    }
}
