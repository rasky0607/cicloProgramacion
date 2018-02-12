using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClonacionDeObjetos
{
    
    class Rectangulo:ICloneable
    {

        ConsoleColor color;//color de relleno  del  rectangulo
        char textura;
       public Punto[] puntos;//Los 4 puntos  que correcponde a los vertices del rectangulo

        #region Constructor

       public Rectangulo()
       {
           puntos = new Punto[4];
           textura = ' ';
           color = ConsoleColor.Red;
       }

       public Rectangulo(Punto p1, Punto p3)//conociendo el uno(Superior Izquierdo) y conociendo el 3(Inferior derecho) calculamos los otros dos
       {
           Punto p2 = new Punto(p3.X, p1.Y);  
           Punto p4 = new Punto(p1.X,p3.Y );
           puntos = new Punto[4] { p1, p2, p3, p4 };
           textura = ' ';
           color = ConsoleColor.Red;          
           
       }

        #endregion

       /// <InformacionPunto>
        /// Escribe por p antalla informacion sobre los  puntos.
       /// </InformacionPunto>
       public void InformacionPunto()
       {
           Console.WriteLine("p1: {0},\t p2:{1},\t p3:{2},\t p4:{3} ", puntos[0], puntos[1], puntos[2], puntos[3]);
           Console.WriteLine("Color: {0}, \t\t Textura: {1}", color, textura);
       }
       public void Dibuja()
       {
           char caracter = textura;
           ConsoleColor colorEntrada = Console.BackgroundColor;
           Console.BackgroundColor = color;
           int x1 = puntos[0].X;//punto p1
           int y1 = puntos[1].Y;//punto p3 los punto iniciales que obtenemos
           int x2 = puntos[2].X;
           int y2 = puntos[3].Y;

           for (int i = x1; i <= x2; i++)
           {
               for (int j = y1; j <= y2; j++)
               {
                   Console.SetCursorPosition(i, j);
                   Console.Write(caracter);
               }
               
           }
           Console.BackgroundColor = colorEntrada;

       }


        //Copia Profunda
       public object Clone()
       {
          Rectangulo c = new Rectangulo();
         // c = (Rectangulo)this.MemberwiseClone();
          c.textura = this.textura;
          c.color = this.color;
          for (int i = 0; i < puntos.Length; i++)//Aqui es donde radica la copia profunda ya qeue estamos copiando uan estructura por referencia de un lado a otro.         
              c.puntos[i] = this.puntos[i];
          

          return c;
       }

    }

    class Punto
    {
        // representacion de Puntos en el espacio
        #region Campos
        int x;
        int y;
        #endregion

        #region Propiedades
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        #endregion

        public Punto()
        {
            x = 0;
            y = 0;
        }

        public Punto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", x, y);
        }
    }
}
