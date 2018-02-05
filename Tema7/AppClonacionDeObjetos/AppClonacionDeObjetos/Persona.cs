using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionarPersonas
{
                    //Implementa el interfaz Icloneable
  public class Persona:ICloneable
    {
        #region Campos

        private int id;
        private string nombre;      
        private string apellidos;
        private DateTime fechaNacimiento;     
        private double estatura;

      

        #endregion
      
        #region Constructores
        /// <PersonaInfo>
        /// Constructor que un objeto persona con datos pro defecto
        /// </PersonaInfo>
        public Persona()
        {
            this.nombre = "IES";
            this.apellidos = "Portada Alta";
            this.fechaNacimiento = DateTime.Parse("01/01/2000");
            this.estatura = 0.0;
        }

      /// <PersonaInfo>
      /// Constructor que crea un objeto persona con datos concretos
      /// </PersonaInfo>
      /// <param name="nombre">string nombre de la persona</param>
        /// <param name="apellidos">string apellidos de la persona</param>
        /// <param name="fn">DateTime fecha nacimiento de la persona</param>
        /// <param name="estatura">double estatura de la persona</param>
        public Persona(string nombre, string apellidos, DateTime fn, double estatura)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fn;
            this.estatura = estatura;
        }

        #endregion

        #region Propiedades
     
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        #endregion

        #region Metodos

        /// <ToStringInfo>
        /// Sobreescribe el metodo ToString() para mostrar los datos con  un determiando formato
        /// </ToStringInfo>
        /// <returns> devuelve el string con dicho formato</returns>
        public override string ToString()//Rescribe el metodo ToString() (PadlLeft() y PadRight() es solo para darle una separacion maxima constante a cada campo que va mostrar 
        {
            return "|" + id.ToString().PadLeft(6, ' ') + " | " + apellidos.PadRight(30) + " | " + nombre.PadRight(15) + " | " + fechaNacimiento.ToShortDateString() + " | " + estatura.ToString();
        }



        #endregion

     //para que nos escriba la declaracion de este metodo (sin codificar(Boton derecho encima de Icloneable-> Implementar interface
        public object Clone()
        {
            //devuelve  un objeto Persona, con una copia Superficial
            return (Persona)this.MemberwiseClone();
        }
    }
}
