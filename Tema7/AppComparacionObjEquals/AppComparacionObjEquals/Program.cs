/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo metodo Equals() para verificar si dos objetos o tipos de datos compuestos, son iguales entre si
 * En nuestro caso de la clase Punto y Rectangulo, dos objetos son iguales(cuando nuestro punto1 y punto 3 son iguales)
 *       p1*----*p4
 *         |    |
 *       p2*----*p3
 Fecha:07/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido
using AppComparacionObjEquals;

namespace AppComparacionObjEquals.pbl
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Probando la Clase Rectangulo y Punto
            Console.WriteLine("\n Comprobaciond e la clase Punto y Rectangulo\n ");
            Punto p1 = new Punto(5, 5);
            Punto p3 = new Punto(20, 10);
            Rectangulo r1 = new Rectangulo(p1, p3);
            r1.InformacionPunto();
            r1.Dibuja();
            #endregion

            Console.ReadLine();
            Console.Clear();
            #region Copia Profunda
            Console.WriteLine("\n Copia profunda con la calse Punto y Rectangulo\n");
            Rectangulo r2copia = (Rectangulo)r1.Clone();
            r2copia.InformacionPunto();
            r2copia.Dibuja();

            Console.Clear();
            //Mostrar El original para probar que se realizo la copia correctamente
            r1.InformacionPunto();
            r1.Dibuja();

            #endregion


            Console.ReadLine();
        }
    }
}
