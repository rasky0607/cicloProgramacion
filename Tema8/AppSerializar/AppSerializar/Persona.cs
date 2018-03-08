using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSerializar
{
    [Serializable]
    class Persona
    {
        string _apellidos;
        string _nombre;
        float _sueldo;
        bool _borrado;//Si es falso es que noe sta borrado , si es verdad , esta marcado como borrado

        public bool Borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }

        public string Apellido
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public float Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public override string ToString()
        {
            return _apellidos.PadRight(30)+Nombre.PadRight(20)+_sueldo.ToString().PadRight(9);
        }

        public Persona(string a, string n, float s)
        {
            Apellido = a;
            Nombre = n;
            Sueldo = s;
            Borrado = false;
        }
    }
}
