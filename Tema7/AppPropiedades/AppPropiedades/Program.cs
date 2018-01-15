/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemplo de uso de las propiedades de lectura y escritura Get y Set
 Fecha: 15/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPropiedades.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Ficha f1 = new Ficha();
            f1.Nombre = "Pepe";
            f1.Edad = 22;
            f1.Nota= 5.8F;
            Console.WriteLine(f1.ToString());

            Ficha f2 = new Ficha();
            f2.Nombre = "Manolo";
            f2.Edad = 27;
            f2.Nota = 16.8F;
            Console.WriteLine(f2.ToString());
            Console.ReadLine();
        }
    }

    public class Ficha
    {
        #region Campos

        string _nombre;
        int _edad;
        float _nota;

        #endregion

        #region Propiedades

        public string Nombre
        {
            //Lectura
            get {return _nombre;}
            //Escritura
            set
            {
                #region Filtros
                if (value == string.Empty)
                    value = "SIN NOMBRE";
                           
                #endregion
                _nombre = value; 
                 }
        }

        public int Edad
        {
            //Lectura
            get { return _edad; }
            //Escritura
            set { _edad = value; }
        }

        public float Nota
        {
            //Lectura
            get { return _nota; }
            //Escritura
            set
            {
                #region Filtros
                if (value > 10)
                    value = 10;
                if (value < 0)
                    value = 0;
                #endregion
                _nota = value; }
        }

        #endregion

        #region Constructor

        public Ficha()
        {

        }
        public Ficha(string nombre, int edad, float nota)
        {
            _nombre = nombre;
            _edad = edad;
            _nota = nota;
        }

        #endregion

        #region Metodos

        //Palabra reservada "OVERRIDE" es utilidaza para sobreescribir metodos comoe ne ste caso ToString()
        public override string ToString()
        {
            return _nombre + ";" + _edad.ToString() + ";" + _nota;
        }

        #endregion
    }
}
