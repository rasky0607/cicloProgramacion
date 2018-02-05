/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de clonacion de Objetos usando la colnacion Simple o superficial
 * y la clonacion Profunda(usando una clase Punto yotra Rectangulo)
 Fecha:05/02/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using AppGestionarPersonas;

namespace AppClonacionDeObjetos.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Copia Simple o superficial
            Persona pOrigen = new Persona("Nombre1", "Apellido1", DateTime.Now, 1.0);
            Persona PCopia = (Persona)pOrigen.Clone();//Necesitamos el casting ha persona , ya que nuestro metodo devuelve un objeto,**El casting realizado en nuestro metodo clone (es para realizar la copia,pero realmente sigue devolviendo un objeto luego)
            Console.WriteLine("\n -Objt Persona Original\n");
           Console.WriteLine(pOrigen.ToString());
           Console.WriteLine("\n -Objt Persona Copiado del Original\n");
           Console.WriteLine(PCopia.ToString());
           Console.WriteLine("\n --Comprobacion de que es una copia correcta y uno no cambia datos del otro --\n");
            //comprobamos que al cambiar los datos de uno, no cambiamos los datos del otro objeto.
           pOrigen.Nombre = "JuanOrigen";
           PCopia.Nombre = "PepitoCopia";
           Console.WriteLine(pOrigen.ToString());
           Console.WriteLine(PCopia.ToString());
            #endregion

           Console.ReadLine(); 
           Console.Clear();

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
           r2copia.puntos[0].X = 0;
           r2copia.puntos[0].Y = 0;
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
