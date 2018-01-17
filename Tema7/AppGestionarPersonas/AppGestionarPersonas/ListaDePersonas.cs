using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionarPersonas
{
    class ListaDePersonas
    {
        List<Persona> _persona = null;
        int _id = 100;//empezamos en 100

        /// <ListaDePersonasInfo>
        /// Crea la lista de personas
        /// </ListaDePersonasInfo>
        public ListaDePersonas()
        {
            _persona = new List<Persona>();
        }

        /// <AnadirInfo>
        /// Añade una persona especificada
        /// </AnadirInfo>
        /// <param name="p">Persona a añadir</param>
        /// <returns>true si añadir la persona</returns>
        public bool Anadir(Persona p)
        {
            p.Id = _id++;
            _persona.Add(p);
            return true;
        }

        /// <AnadirPersonaAleatoriaInfo>
        /// Añade una persona de forma aleatoria
        /// </AnadirPersonaAleatoriaInfo>
        /// <returns> true si anadio la persona</returns>
        public bool AnadirUnaPersonaAleatoria()
        {
            Persona p = ObtenerPersonaAleatoria.Crear();
            p.Id = _id++;
            _persona.Add(p);
            return true;
        }

        /// <AnadirPersonasAleatoriaInfo>
        /// Añade varias personas del tiron
        /// </AnadirPersonasAleatoriaInfo>
        /// <param name="nPersonas">cantidad de personas que añadira</param>
        /// <returns></returns>
        public bool AnadirPersonasAleatoria(int nPersonas)
        {
            for (int i = 0; i < nPersonas; i++)
            {
                Persona p = ObtenerPersonaAleatoria.Crear();
                p.Id = _id++;
                _persona.Add(p);
            }
            
            return true;
        }

        /// <ListarInfo>
        /// Muestra el listado de personas
        /// </ListarInfo>
        public void Listar()
        {
            int anchoListado = 79;
            Console.WriteLine("\t\t L I S T A D O   D E  P E R S O N A");
            Console.WriteLine("=".PadRight(anchoListado, '='));
            foreach (Persona pTmp in _persona)
                Console.WriteLine(pTmp.ToString());

            Console.WriteLine("=".PadRight(anchoListado, '='));
            Console.WriteLine(" No hay mas personas a listar...");
            Console.ReadLine();
        }

        /// <ListarInfo>
        /// Sobrecarga del metodo Listar  a la cual podemos pasarle un titulo para que lo centre
        /// </ListarInfo>
        /// <param name="mensaje"> Titulo o encabezado a mostrar</param>
        public void Listar(string mensaje)
        {
            int anchoListado = 79;
            Console.CursorLeft = (anchoListado / 2) - (mensaje.Length/2);
            Console.WriteLine(mensaje);
            Console.WriteLine("=".PadRight(anchoListado, '='));
            foreach (Persona pTmp in _persona)
                Console.WriteLine(pTmp.ToString());

            Console.WriteLine("=".PadRight(anchoListado, '='));
            Console.WriteLine(" No hay mas personas a listar...");
            Console.ReadLine();
        }

        /// <CuantosInfo>
        /// Devuelve la cantidad total de personas en la lista
        /// </CuantosInfo>
        /// <returns></returns>
        public int Cuantos()
        {
            return _persona.Count;
        }
    }
}
