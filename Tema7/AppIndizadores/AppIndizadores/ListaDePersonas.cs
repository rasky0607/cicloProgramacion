using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIndizadores
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
            Console.CursorLeft = (anchoListado / 2) - (mensaje.Length / 2);
            Console.WriteLine(mensaje);
            Console.WriteLine("=".PadRight(anchoListado, '='));
            foreach (Persona pTmp in _persona)
                Console.WriteLine(pTmp.ToString());

            Console.WriteLine("=".PadRight(anchoListado, '='));
            Console.WriteLine(" No hay mas personas a listar...");
            Console.ReadLine();
        }

        //Listado Paginado
        public void ListarPaginado(string tituloListado)
        {
            ConsoleKey salirListado = ConsoleKey.Escape;
            int nLineasPorPagina = 30;
            int nLineaActual = 0;
            int nPaginaActual = 1;
            int nPaginasDelListado= (int)Math.Ceiling((double)_persona.Count/(double)nLineasPorPagina); //calculo de cuantaspaginas vamos a necesitar de lo que vamos a listar
            int anchoListado = 79;  

            foreach (Persona pTmp in _persona)
            {
                //Muestra la cabecera
                if (nLineaActual == 0)
                { 
                    //centar el titulo en la cabecera
                    Console.Clear();

                    Console.CursorLeft = (anchoListado / 2) - (tituloListado.Length / 2);
                    Console.WriteLine(tituloListado);
                    Console.WriteLine("=".PadRight(anchoListado, '='));                    
                }
                //Mostrar cuerpo del listado
                Console.WriteLine(pTmp.ToString());
                nLineaActual++;

                //Mostrar el pie de pagina
                if (nLineasPorPagina == nLineaActual)
                {
                    Console.WriteLine("=".PadRight(anchoListado, '='));
                    Console.Write(" [Esc]Salir Listado.           Página:{0} de {1}...", nPaginaActual++, nPaginasDelListado);
                    nLineaActual = 0;
                    //Al pulsar Escape salir del listado
                    if (Console.ReadKey(true).Key == salirListado)                   
                        return;
                    
                }

                
            }

            //Útilma página
            Console.WriteLine("=".PadRight(anchoListado, '='));
            Console.Write("                                     Página:{0} de {1}...", nPaginaActual++, nPaginasDelListado);
            Console.Write("\n\t\t Fin del listado.");
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

        /// <SobrecargaDeOperador+>
        /// Sobrecargamos el operador mas, para que pueda añadir un objeto a una coleccion con el oeprador +
        /// </SobrecargaDeOperador>
        /// <param name="personas"> intancia de la clase ListaDePersonas</param>
        /// <param name="p"> instancia de la clase Persona</param>
        /// <returns>bool true si añadio false si no</returns>
        public static bool operator +(ListaDePersonas personas, Persona p)
        {
            return personas.Anadir(p);
        }

        #region Indizador
        //Dotar de Indizador a la clase
        //De esta forma podemos devolver una persona de una posicion o INDICE concreto de la listaDePersonas desde fuera, ya que de otra manera ahora mismo no podemos por que es privada a nuestra clase
        //  Perdona -> es el tipo de dato que devuelve. [int indice] tipo de dato que recibe. (la persona de la posicio[5]).
        /// <IndizadorListaPersonas>
        /// Dotamos nuestra clase de indizador, de forma que adquiere un manejo externo como el de un Array
        /// </IndizadorListaPersonas>
        /// <param name="indice">entero que representa la persona de u na posicion</param>
        /// <returns> devuelve una persona de una determian posicion</returns>
        public Persona this[int indice]
        {
            //Lectura
            get {
                return _persona[indice];
            }

            //Lectura
            set {
                _persona.Insert(indice, value);
            }
        }
        #endregion
    }
}
