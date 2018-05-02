using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.Collections.ObjectModel;//Espacio de nombre para implementar "ObservableCollection"

namespace pbl.EnlaceADatosConDeContexoDeDatos
{
    //Interfaz que implementa un  conjunto de coleciones especialista en propagacion de datos "ObservableCollection"
    class ListaPersonas:ObservableCollection<Persona>
    {
        Random rnd = new Random();

        public ListaPersonas():base()//llamamos al constructor base del que heredamos por si acaso nos hace falta q ue prepare algo por si acaso
        {
            Add(new Persona("1.-Pepe", "Castaño", CrearFechaNacimientoAlea(), CreaEstaturaAlea()));
            Add(new Persona("2.-Hormiga", "Atomica", CrearFechaNacimientoAlea(), CreaEstaturaAlea()));
            Add(new Persona("3.-Max", "Turbado", CrearFechaNacimientoAlea(), CreaEstaturaAlea()));
            Add(new Persona("4.-Con", "Suelo", CrearFechaNacimientoAlea(), CreaEstaturaAlea()));
            Add(new Persona("5.-Don Limpio", "Detras de ti", CrearFechaNacimientoAlea(), CreaEstaturaAlea()));
        }

        private DateTime CrearFechaNacimientoAlea()
        { 
            //Crea una fechanaciemiento delos ultimos 20 años
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(1, 365 * 20));
            return fecha;
        }

        private double CreaEstaturaAlea()
        { 
            //Crea una estatura desde 1.50 a 2.10
            double estatura = rnd.Next(150, 211);
            estatura /= 100;
            return estatura;
        }


    }
}
