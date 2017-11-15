/*
 Autor: Pablo Lopez
 Ejemplo consola: Ejemplo de estructuras  V1->sin constructor
 Fecha:13/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.Threading;

namespace AppEstructuras.pbl
{
    class Program
    {
        //Contiene los datos de una persona
        public struct Persona
        {
            private string  Privado;//No podemos verlo desde fuera de la estructura.
            public string Nombre;
            public DateTime FechaNacimiento;
            public float Estatura;
            public string Dni;

        }
        static void Main(string[] args)
        {
            Persona aux1;
            aux1 = PedirDatos();
            Console.WriteLine();
            MostrarDatos(aux1);
            Console.ReadLine();
        }

        #region Metodos para las Estructuras
        public static void MostrarDatos (Persona p)
        {
            Console.WriteLine(" Datos de una persona:");
            Console.WriteLine("===============================");
            Console.WriteLine("     Nombre: {0}",p.Nombre);
            Console.WriteLine("     Fecha Nacimiento: {0}", p.FechaNacimiento.ToLongDateString());
            Console.WriteLine("     Estatura: {0}", p.Estatura);
            Console.WriteLine("     DNI: {0}", p.Dni);
        }

        public static Persona PedirDatos()
        {
            Persona p = new Persona();
            bool corecto = false;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Datos de una persona:");
                    Console.WriteLine("===============================");
                    Console.Write("     Nombre: ");
                    p.Nombre = Console.ReadLine();
                    Console.Write("     Fecha Nacimiento: ");
                    p.FechaNacimiento = DateTime.Parse(Console.ReadLine());
                    Console.Write("     Estatura: ");
                    p.Estatura = float.Parse(Console.ReadLine());
                    Console.Write("     DNI: ");
                    p.Dni = Console.ReadLine();
                    corecto = true;
                }
                catch
                {
                    Console.WriteLine("ERROR al introducir los datos. Intentalo de nuevo");
                    Thread.Sleep(1000);
                }
            } while (!corecto);
            return p;
        }
        #endregion
    }
}
