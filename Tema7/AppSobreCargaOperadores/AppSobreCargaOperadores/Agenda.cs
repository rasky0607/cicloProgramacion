using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSobreCargaOperadores
{
    class Agenda
    {
        const int NUMEROMAXENTRADAS = 100;
        string[] anotaciones = new string[NUMEROMAXENTRADAS];
        int contadorAnotaciones = 0;//numero de anotaciones realizadas en el array

        public void ListarAnotaciones()
        {
            for (int i = 0; i < contadorAnotaciones; i++)            
                Console.WriteLine(anotaciones[i]);

            Console.Write(" Fin anotaciones... ");
            Console.ReadLine();
        }

        //Para añadir  anotaciones vamos a sobrecargar el operador +
        public static bool operator +(Agenda unaAgenda, string unaAnotacion)
        {
            if (unaAgenda.contadorAnotaciones == NUMEROMAXENTRADAS)//Si no entra mas anotaciones
                return false;
            else
            {
                unaAgenda.anotaciones[unaAgenda.contadorAnotaciones++] = unaAnotacion;
                return true;
            }
        }
    }
}
