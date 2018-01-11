using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.AppConstructoresDestructores
{
    class Persona
    {
        #region Campos

        public static string quienSoy = "La clase";
        string _nombre;
        int _edad;
        string _nif;

        #endregion

        #region Constructores

        public Persona()
        {
            _nombre = "SIN NOMBRE";
            _edad = 0;
            _nif = "00000000-A";
        }

        public Persona(string n, int e, string nif)
        {
            _nombre = n;
            _edad = e;
            _nif = nif;
        }
        #endregion


        #region Destructor

        ~Persona()
        { 
            //Codigo adecuado para la circustancia...
        }

        #endregion
    }
    
}
