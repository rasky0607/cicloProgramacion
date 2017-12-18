/*
 Autor: Pablo Lopez
 Ejemplo consola:Lista de tipos concretos"realizando el ejemplo del juego 7 y medio"
 Fecha:18/12/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaConTipos.pbl
{
    class Program
    {
        #region Datos Basicos
        enum Palo { Oro, Copa, Espada, Basto };
        struct Carta { 
        
            //Constructor
            public Carta(int val,Palo palo)
            {
                string[]nombres ={"Uno","Dos","Tres","Cuatro","Cinco","Seis","Siete","Ocho","nueve","Sota","Caballo","Rey"};
                _nombre = nombres[val - 1];
                _valor = val;               
                _palo = palo;
                if (val <= 9)
                    _peso = val;
                else
                    _peso =0.5;                
                
            }

            //Campos
            string _nombre;
            int _valor;
            double _peso;
            Palo _palo;
            public int Getvalor()
            {
                return _valor;
            }
            public string GetNombre()
            {
             return _nombre;
            }
            public Palo GetPalo()
            {
                return _palo;
            }
            public double GetPeso()
            {
                return _peso;
            }

        }
        static List<Carta> baraja = new List<Carta>();
        static Random rnd = new Random();
        #endregion

        static void Main(string[] args)
        {
            baraja.Add(CreaCarta());
            //MostarCarta(baraja1[0]);
            AnadirVariasCartas(baraja, 20);
            // VerBaraja(baraja1);
            ListaBaraja(baraja);
            Console.ReadLine();
        }

        static Carta CreaCarta()
        {
            return new Carta(rnd.Next(1,13),(Palo)rnd.Next(4));
        }

        static void MostrarCarta(Carta carta)
        {
            Console.WriteLine();
            Console.WriteLine("  Valor: {0}", carta.Getvalor());
            Console.WriteLine(" Nombre: {0}", carta.GetNombre());
            Console.WriteLine("   Palo: {0}", carta.GetPalo());
            Console.WriteLine("   Peso: {0}", carta.GetPeso());
        }

        static void AnadirVariasCartas(List<Carta> baraja, int nCartas)
        {
            for (int i = 0; i < nCartas; i++)
                baraja.Add(CreaCarta());
        }

        static void MostrarBaraja(List<Carta> baraja)
        { 
            //Muestra el contenido complero de la baraja en formato listado
            foreach (Carta cartaTmp in baraja)
                MostrarCarta(cartaTmp);

        }

        static void ListaBaraja(List<Carta> baraja)
        {
            Console.WriteLine("{0,3}\t{1}\t{2}\t{3}", "Valor", "Nombre", "Palo", "Peso");
            foreach (Carta cartaTmp in baraja)
            {
                Console.WriteLine("{0,3}\t{1}\t{2}\t{3,3}", cartaTmp.Getvalor(), cartaTmp.GetNombre(), cartaTmp.GetPalo(), cartaTmp.GetPeso());
            }
        }

    }
}
