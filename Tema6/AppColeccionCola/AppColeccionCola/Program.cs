/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejmeplo de gestion de colas
 Fecha:14/12/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.Collections;
namespace AppColeccionCola.pbl
{
    class Program
    {
         struct Carta 
        {
           
            //Campos
            string palo;
            int valor;
            string nombre;
            double peso;
            

            //Constructor
            public Carta(string palo, int valor, string nombre, double peso)
            {
                //"this" referencia a la instancia de ese objeto( osea el this se refiere al campo que va tener la nueva isntancia del objeto que se esta creando )
                //campo     Parametro
                this.palo = palo;
                this.valor = valor;
                this.nombre = nombre;
                this.peso = peso;

            }

            public string MostrarInfocarta()
            {
                return (nombre + ", " + valor + ", " + palo + ", " + peso).ToString();
            }
        }

       
        static Queue miColaDebaraja = new Queue();//Cola
        static void Main(string[] args)
        {
            Carta micarta1 = new Carta("Oro", 10, "Sota", 0.5);
            Carta micarta2 = new Carta("Espadas", 2, "Dos", 2);
            miColaDebaraja.Enqueue(micarta1);//encola
            miColaDebaraja.Enqueue(micarta2);
            Console.WriteLine("    Número de cartas: {0}", miColaDebaraja.Count);
            Carta desencolada = (Carta) miColaDebaraja.Dequeue();//desencola
            Console.WriteLine("  Has desencolado: {0}", desencolada.MostrarInfocarta());
            Console.WriteLine("    Número de cartas: {0}", miColaDebaraja.Count);
            Carta desencolada2 = (Carta)miColaDebaraja.Dequeue();//desencola
            Console.ReadLine();
        }
    }
}
