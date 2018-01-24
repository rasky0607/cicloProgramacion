/*
 Autor: Pablo Lopez
 Ejemplo consola: Resumen de uso delegados, metodos anonimos , y expresiones Lambda
 Fecha:24/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDelgExpreLambMetAnonimos.pbl
{
    class Program
    {
        #region Delegados

        //Declaracion del delegado:
        delegate int dlgCuadrado(int x);

        #endregion

        static void Main(string[] args)
        {
            int numero = 10;

            #region En C# 1.0 aparece el Uso de delegados
            Console.WriteLine("\n ---C# 1.0 uso de delegados ---");

            //Creo una instancia del delegado
            dlgCuadrado dc1 = new dlgCuadrado(Cuadrado);

            //LLama a la instancia del delegado y pasamos un valor
            Console.WriteLine("\t{0}\n", dc1(numero).ToString());
            #endregion

            #region C# 2.0 delegados con codigo de inicializacion (metodos Anonimos)
            Console.WriteLine("\n ---C# 2.0 Uso de delegados con cod. inicializacion ---");

            //Metodo anonimo con  un delegado
            dlgCuadrado dc2 = delegate(int x)
            {
                return x * x;
            };

            Console.WriteLine("\t{0}\n", dc2(numero).ToString());
            #endregion

            #region C# 3.0 Delegados con expresiones Lambda
            Console.WriteLine("\n ---C# 3.0 Delegados con expresiones Lambda ---");
                           //Expresion lambda
            dlgCuadrado dc3 = x => x * x;
            Console.WriteLine("\t{0}\n", dc3(numero).ToString());

            #region Otra forma de hacer lo mismo en  la version de las 3.1 u otra ...
            Console.WriteLine("\n ---C# 3.1 u otra.. Delegados generico integrado con expresiones Lambda  ---");
            /*
             Func -> es un delegado generico que no necesita nombre al cual le decimos
            1º-> los tipo de datos que recibe y 2º-> el tipo de dato que devuelve, tras esto creamos la instancia del deleago,
             en este caso 'dc4' y la expresion Lambda*/

            Func<int, int> dc4 = x => x * x;
            Console.WriteLine("\t{0}\n", dc4(numero).ToString());

            #endregion

            #endregion

            Console.ReadLine();

        }

        #region Metodos

        static int Cuadrado(int i)
        {
            return i * i;
        }

        #endregion
    }
}
