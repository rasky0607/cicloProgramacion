using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConstructoresDestructores
{
    #region Ejemplo como se ejecutan todos los constructores de la herencia

    class Clase_C
    {
        #region Contructor de la clase "Distinto al de instancia" y estatico
        static Clase_C()
        {
            Console.WriteLine("Clase_C: Constructor de la CLASE (static)");
        }
        #endregion
        #region Constructor de Instancia "Para crear objetos"
        public Clase_C()
        {
            Console.WriteLine("Clase_C: Constructor de de (instancia)");
        }
        #endregion

        #region Destructor
        ~Clase_C()
        {
            Console.WriteLine("Clase_C: Destructor");
        }
        #endregion
    }

    class Clase_B:Clase_C
    {
        #region Contructor de la clase "Distinto al de instancia" y estatico

        static Clase_B()
        {
            Console.WriteLine("Clase_B: Constructor de la CLASE (static)");
        }

        #endregion

        #region Constructor de Instancia "Para crear objetos"

        public Clase_B()
        {
            Console.WriteLine("Clase_B: Constructor de de (instancia)");
        }

        #endregion

        #region Destructor

        ~Clase_B()
        {
            Console.WriteLine("Clase_B: Destructor");
        }

        #endregion

    }

    class Clase_A : Clase_B
    {
        #region Contructor de la clase "Distinto al de instancia" y estatico

        static Clase_A()
        {
            Console.WriteLine("Clase_A: Constructor de la CLASE (static)");
        }

        #endregion

        #region Constructor de Instancia "Para crear objetos"

        public Clase_A()
        {
            Console.WriteLine("Clase_A: Constructor de de (instancia)");
        }

        #endregion

        #region Destructor

        ~Clase_A()
        {
            Console.WriteLine("Clase_A: Destructor");
        }

        #endregion

    }

    #endregion
}
