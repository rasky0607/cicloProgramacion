/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo aclarativo sobre el polimorfismo de herencia.
 *  ¿Que se pretende en este ejemplo?
     Pretendemos crear varias clases, que parten de una clase base;
    en este caso la clase "Vehiculo" de la que heredaran las clases"Moto" y "Coche"
    y de esta forma podremos aclarar como partiendo de  dicha clase"Vehiculo" a traves
    de la herencia podemos guardar objetos de las clase"Moto" y "Coche"
   en colecciones o datos de tipo "Vehiculo" aun que  lo que estamos guardando pertenezca a una
   de las otras dos clases.
 *  
 Fecha: 11/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.AppPolimorfismo
{
    class Program
    {

        static void Main(string[] args)
        {
          
          Moto moto1 = new Moto();
          Vehiculo[] arrayVehiculos = new Vehiculo[1];

            //Polimorfismo en todo su esplendor
          arrayVehiculos[0] = moto1;// <-- si nos fijamos estamos guadando un objeto moto en un array de tipo Vehiculo(la cual es otra clase distinta a moto)
      
        }
    }
}
