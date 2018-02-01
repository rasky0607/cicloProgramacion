using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIndizadores
{
    class ObtenerPersonaAleatoria
    {
        static string[] nombres = { "Juan", "Maria", "Lorenzo", "Alejandro", "Javier", "Elena", "Cristina", "Vanesa", "Lorena", "Marcos" };
        static string[] apellidos = { "Martinez", "Lopez", "Gonzalez", "Santana", "Gutierrez", "Aranda", "Jimenez", "Gutierrez", "Madrid", "Marquez" };
        static Random rnd = new Random();

        #region Metodos

        /// <CrearInfo>
        /// Crea una persona aleatoria automaticamente
        /// </CrearInfo>
        /// <returns> devuelve una persona aleatoria</returns>
        public static Persona Crear()
        {
            Persona p = new Persona(CrearNombre(), crearApellidos(), CrearFechaNacimiento(), CrearEstatura());
            return p;
        }

        /// <CrearNombreInfo>
        /// Coge un nombre aleatorio de el array de nombres
        /// </CrearNombreInfo>
        /// <returns> string con el nombre</returns>
        static string CrearNombre()
        {
            return nombres[rnd.Next(nombres.Length)];
        }

        /// <crearApellidosInfo>
        /// Genera dos apellidos aleatorios
        /// </crearApellidosInfo>
        /// <returns></returns>
        static string crearApellidos()
        {
            return apellidos[rnd.Next(apellidos.Length)] + " " + apellidos[rnd.Next(apellidos.Length)];
        }

        /// <CrearFechaNacimientoInfo>
        /// Genera una fecha en un rango de 10 años hasta la actual
        /// </CrearFechaNacimientoInfo>
        /// <returns> devuelve un datetime con dicha fecha</returns>
        static DateTime CrearFechaNacimiento()
        {
            //Fecha aleatoria de los ultimos 20 años(Estructura TimeSpan ->  que maneja operaciones con fechas)
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(1, 365 * 20));
            return fecha;
        }

        /// <CrearEstaturaInfo>
        /// Crea estatura entre 1.50 y 2.10 aproximadamente
        /// </CrearEstaturaInfo>
        /// <returns>devuelde un doble con la estatura</returns>
        static double CrearEstatura()
        {
            double estatura = rnd.Next(150, 211);
            estatura /= 100;
            return estatura;
        }
        #endregion

    }
}
