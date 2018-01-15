/*
 Autor: Pablo Lopez
 Ejemplo consola: en este ejemplo se trata palabras clave como " BASE y NEW" ademas de la herencia
 Fecha:15/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPalabraBaseYHerencia.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            LienzoImpresora lip = new LienzoImpresora();
            lip.Dibuja();

            Console.ReadLine();
        }


    }

    public class Lienzo
    {
        int _x;
        int _y;
        int _alto;
        int _ancho;

        #region Constructor

        public Lienzo()
        {

        }

        public Lienzo(int x, int y, int alto, int ancho)
        {
            _x = x;
            _y = y;
            _alto = alto;
            _ancho = ancho;
        }

        #endregion

        #region Metodos
        public void Dibuja()
        {
            Console.WriteLine("Preparando el LIENZO");
        }
        #endregion
        /*Aqui más metodos, propiedades y otros miembros etc...*/ 
    }

    public class LienzoImpresora : Lienzo
    {
        string _color;

        #region Constructor
        public LienzoImpresora(int x, int y, int alto, int ancho,string color):base(x,y,alto,ancho)//En este caso la palabra reservada "BASE" va a llamar al constructor de la clase que hemos heredado con los parametros indicados, pasandoselos a nuestro nuevo constructor, por lo que todos tendran valor excepturando uno de ellos
        {
            _color = color;
        }

        public LienzoImpresora()
        { 
        
        }
        #endregion

        #region Metodos
        /*
         NEW -> Usamos la palabra reservada 'NEW', para diferenciar el metodo Dibuja() 
         de la clase LienzoImpresora de la de la clase Lienzo Dibuja() que estamos heredando
         */
        public new void Dibuja()
        {
            /*
             BASE -> Usamos la palabra reservada 'BASE' para llamar al  metodo
             de la clase que heredamos que se llama igual que uno de nuestra clase actual
             
             */
            base.Dibuja();
            Console.WriteLine("Dibujando la IMPRESORA");
        }
        #endregion
    }
}
