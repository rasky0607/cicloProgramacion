/*
 Autor: Pablo Lopez
 Ejemplo consola:Ordenacion de los elementos de su array
 Fecha:27/11/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrdenarArray.pbl
{
    class Program
    {
        //Datos compartidos para todos los miembros de la clase.
        static int[] array = null;

        static int nDatos = 8; //Numero de datos añadidos en el array(o datos valido para mi, el resto seran ignorados)

        
        static void Main(string[] args)
        {

            #region Copiado de otro ejemplo de arrays y reutilizado en este
            const int LONGITUD = 10;
            array = new int[LONGITUD];

            //AnadirDato(9);
            //AnadirDato(8);
            //AnadirDato(5);
            //AnadirDato(7);
            //AnadirDato(3);
            //AnadirDato(1);
            // MostraArray(array);
            //BorraDatosArray(array);
            //MostraArray(array);
            //Insertar(array, -1, 3, ref nDatos);
            //MostraArray(array);
            //BorrarPorPosicion(array, 0, ref nDatos);
            //MostraArray(array);

            #endregion
            int[] array2 = {4,6,2,7,8,9,12,3};
            Console.WriteLine(" Mostrar array sin ordenar");
            MostraArray(array2);
            Console.WriteLine(" Mostrar array ordenado");
            OrdenacionDeLaBurbuja(array2, nDatos);
            MostraArray(array2);


            Console.ReadLine();
        }

        #region Metodos

        /// <Ordena el array por intercambio directo o Burbuja>
        /// 
        /// </Ordena el array por intercambio directo o Burbuja>
        /// <param name="array">mi array</param>
        /// <param name="nDatos"> vantidad de datos validos para mi</param>
        static void OrdenacionDeLaBurbuja(int[] array,int nDatos)//En este caso no necesita colocar nDatos por Referencia ya que no se va modificar.
        {
            int tmp = 0;
            for (int i = 1; i < nDatos; i++)//aumenta uno por cada pasada que hace el interno
                for (int j = nDatos-1; j>=i ; j--)//Este se hace entero comparando dos a dos de principio a find el array
                {
                    if (array[j] < array[j - 1])
                    {
                        tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            
        }


        #region Metodos copiados del primer ejemplo de los Arrays
        static int BorrarPorPosicion(int[] array, int pos, ref int nDatos)
        {
            if (nDatos == 0 || pos < 0 || pos > nDatos - 1)
                return -1;//No se puede borrar

            for (int i = pos; i < nDatos - 1; i++)
                array[i] = array[i + 1];
            nDatos--;
            return pos;
        }

        /// <Inserta el dato en una determinada posicion del array>
        /// 
        /// </Inserta el dato en una determinada posicion del array>
        /// <param name="array"></param>
        /// <param name="dato"></param>
        /// <param name="pos"></param>
        /// <param name="nDatos"></param>
        /// <returns></returns>
        static bool Insertar(int[] array, int dato, int pos, ref int nDatos)//nDatos sera modificado por Referencia para cambiar el original
        {
            if (nDatos == array.Length || pos < 0 || pos > nDatos)//Si el array esta lleno.., si la posicion donde quieres insertar el dato es menor que cero.. o si es mayor que la longitud del arry
                return false;
            for (int i = nDatos; i > pos; i--)//Mueve hacia la derecha todos los elementos los cuales su posicion sea mayor que donde voy a insertar el nuevo dato
                array[i] = array[i - 1];
            array[pos] = dato;
            nDatos++;//El valor de la variable nDatos(Los datos validos para mi) que no es lo mismo que la longitud del array"Length"

            return true;


        }

      
        /// <Borrar los datos del array>
        ///  Borra los datos dela rray que introducimos anteriormente
        /// </Borrar los datos del array>
        /// <param name="array">nombre del array</param>
        static void BorraDatosArray(int[] array)
        {
            nDatos = 0;
        }

        /// <Añadir un dato al array>
        ///  Añade un dato al final del array si hay espacio
        /// </Añadir un dato al array>
        /// <param name="dato">valor  int del dato a introducir</param>
        /// <returns> true si pudo añadir el dato, false si el array esta lleno</returns>
        static bool AnadirDato(/*int[] ,*/ int dato/*,int nDatos*/) //nDatos no podemos aumentarlo "nDatos++" por que es realmente una copia del original, por loq ue deberiamos pasarlo por referencia, o poner nDatos publico  para compartirlo con el metodo, ya que nDatos gestiona un unico array concreto.
        {
            if (nDatos == array.Length) //Si esta lleno ..(por que ndatos es igual a array.length ) por que el ultimo dato añadido lo lleno..
                return false;
            array[nDatos++] = dato;//si no esta lleno, aumenta la posicion del array , para introducir el dato en la siguiente libre.
            return true;
        }



        /// <Busqueda secuencial de un dato en el array>
        /// Busca el dato de forma secuencial en el array dado.
        /// </Busqueda secuencial de un dato en el array>
        /// <param name="array">nombre del array en el que deseamos buscar</param>
        /// <param name="buscado"> valor int que deseamos buscar ene l array</param>
        /// <returns>posicion en la que esta en el array</returns>
        static int BusquedaSecuencial(int[] array, int buscado)
        {
            int tamano = array.Length;
            int contador = 0;
            if (tamano == 0)//Si no hay ná en el array..
                return -1;
            while (contador < tamano && buscado != array[contador])
                contador++;

            if (contador >= tamano)
                return -1;//-1 no lo ha encontrado el valor
            else
                return contador;//Posicion en la que se encuentra el dato como la varaible "i" de un for ..


        }

        /// <Inicializa el array a cero>
        /// Rellena un array con ceros en todas sus posiciones.
        /// </Inicializa el array a cero>
        /// <param name="a">Nombre del array</param>
        static void InicializaArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = 0;

        }

        /// <Sobrecarga de Inicializar Array>
        /// Rellena el array cone l valor indicado...
        /// </Sobrecarga de Inicializar Array>
        /// <param name="a">Nombre del array</param>
        /// <param name="valor">valor con el que queremos rellenar el array</param>
        static void InicializaArray(int[] a, int valor)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = valor;

        }

        /// <Muestra el array>
        ///     Recorre el array con bucle For
        /// </Muestra el array>
        /// <param name="a">Nombre del array</param>
        static void MostraArray(int[] a)//Modificado en este ejemplo.
        {
            for (int i = 0; i < nDatos; i++)//Modificado , ya que ahora no llega hasta "Lenght" ahora  llega hasta "nDatos"
                Console.WriteLine("Pos[{0}] valor -> {1}", i, a[i]);

            Console.WriteLine("\n No hay mas datos a mostrar....");
            Console.ReadLine();

        }

        /// <Muestra el array con Foreach>
        ///     Recorre el array con bucle foreach
        /// </Muestra el array con Foreach>
        /// <param name="a">Nombre del array</param>
        static void MostraArrayConForeach(int[] a)
        {
            foreach (int numero in a)
                Console.Write("{0,3},", numero);

            Console.WriteLine("\n No hay mas datos a mostrar....");
            Console.ReadLine();

        }


        /// <Sobrecarga de Inicializar Array>
        /// Rellena el array con el valor indicado... o aleatorio segun si aleatorio vale verdad, si no no.
        /// </Sobrecarga de Inicializar Array>
        /// <param name="a">Nombre del array</param>
        /// <param name="valor">valor con el que queremos rellenar el array</param>
        /// <param name="aleatorio">si es true, lo rellena con valroes aleatorios</param>
        static void InicializaArray(int[] a, int valor, int limite, bool aleatorio)
        {

            //Inicializa el array 'a' aleatoriamente hasta limite -1
            if (aleatorio)
            {
                Random rnd = new Random();
                for (int i = 0; i < a.Length; i++)
                    a[i] = rnd.Next(limite);
            }
            else//Si es aleatorio es falso, inicializa el array al valor indicado.
                for (int i = 0; i < a.Length; i++)
                    a[i] = valor;


        }



        /// <Muestra el Array al reves>
        ///  Recorre el Array desde la ultima posicion "Length -1" hasta la primera "0"
        /// </Muestra el Array al reves>
        /// <param name="a">Nombre del array</param>
        static void MostraArrayAlreves(int[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
                Console.WriteLine("Pos[{0}] valor -> {1}", i, a[i]);



            Console.WriteLine("\n No hay mas datos a mostrar....");
            Console.ReadLine();


        }



        /// <Recorre Circularmente un array>
        ///     Da varias vueltas recorriendo un array de forma que no se salga de rango al llegar a la ultima posicion
        /// </Recorre Circularmente un array>
        /// <param name="a"> Nombre array</param>
        static void MuestraArrayCiclicamente(int[] a)//Usando la teoria del resto ( util en el juego de la vida) "i++%array.lenght
        {
            for (int i = 0; i < a.Length * 3; i++)//En este caso da 3 vueltas.
                Console.WriteLine("Pos[{0}] valor -> {1}", i, a[i % a.Length]);

            Console.ReadLine();
        }

        #endregion

        #endregion
    }
}
