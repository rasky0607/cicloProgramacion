/*
 Autor: Pablo Lopez
 Ejemplo consola: Ejemplo de estructuras V2->"otra forma de llenar una persona con Constructor" y como acceder y mostrar campos privados.
 Fecha:13/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadida
using System.Threading;

namespace AppConstructorEstructuras.pbl
{
    class Program
    {
        public struct Persona
        {
           
            #region Ejemplo 1 para poder acceder y ver lo que hay en el campo privado y el resto de datos.
            //Consturctor (Los parametros son loq ue le llega para crear una persona)
            public Persona(string nombre, DateTime fn, float est, string dni,string priv)
            {

                Campo_Privado = priv;//Este campo solo podemos acceder a el una sola vez cuando creamos un nuevo objeto persona con el constructor y solo con el costructor
                Nombre = nombre;
                FechaNacimiento = fn;
                Estatura = est;
                Dni = dni;
            }

            #endregion

            private string Campo_Privado;//No podemos verlo desde fuera de la estructura.
            public string Nombre;
            public DateTime FechaNacimiento;
            public float Estatura;
            public string Dni;

            #region Ejemplo 1 para poder acceder y ver lo que hay en el campo privado.

            public string Privado()//Para devolver el campo privado y poder mostrarlo, si no, no podriamos mostrar este.
            {
                return Campo_Privado;
            }

            #endregion

            #region Ejemplo 2 poder sobreescribir el campo privado

            public void RescribePrivado(string priv)// Para poder sobrescibir el campo privado des de fuera.
            {
                if (priv != "nulo")   //Siempre que lo que sobreescribimos no es con la palabra "nulo"                 
                Campo_Privado = priv;
            }

            #endregion
        }

        static void Main(string[] args)
        {
            #region Ejemplo1 mostrar datos con un constructor y acceder a campor privados

            //Pasando los datos al constructor que creamos en la estructura para crear directamente la persona.(En este caso tambien podriamos acceder alos campos privados)
            Persona aux1 = new Persona("Manolo", DateTime.Parse("11/11/1990"), 1.88F, "45356353L","Privado"); 
            MostrarDatos(aux1);

            #endregion

            Console.WriteLine();

            #region Ejemplo2 Cambiando contenidos privados
            aux1.RescribePrivado("hola caracola");//Cambiando el contenido del campo privado
            MostrarDatos(aux1);
            aux1.RescribePrivado("nulo");//En este caso nod ebe permitir escribir nulo
            MostrarDatos(aux1);
            #endregion
            Console.ReadLine();
        }

        public static void MostrarDatos(Persona p)
        {
            Console.WriteLine(" Datos de una persona:");
            Console.WriteLine("===============================");
            Console.WriteLine("     Nombre: {0}", p.Nombre);
            Console.WriteLine("     Fecha Nacimiento: {0}", p.FechaNacimiento.ToLongDateString());
            Console.WriteLine("     Estatura: {0}", p.Estatura);
            Console.WriteLine("     DNI: {0}", p.Dni);
            Console.WriteLine("     Privado: {0}", p.Privado());//De este modo podemos mostrar el campo privado.
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


    }
}
