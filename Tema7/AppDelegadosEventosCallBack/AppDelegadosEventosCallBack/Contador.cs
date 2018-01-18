using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido
using System.Threading;

namespace AppDelegadosEventosCallBack
{
    class Contador
    {
        #region Delegados

        //Declaracion del delegado
        public delegate void CambiaContador();

        #endregion

        #region Eventos
        //Sintaxys evento 1->Ambito palabra 2->reservada 3->nombre del delegado en el que esta basado el evento 4-> Nombre del evento
        public event CambiaContador cambioValor;

        public event CambiaContador cambioValor5;//Cuando sea multiplo de 5
        #endregion

        #region Campos

        int _contador;
        bool _iniciar;     
        int _fin;

        #endregion

        #region Propiedades

        public bool Iniciar
        {
            get { return _iniciar; }
            set { _iniciar = value; }
        }

        #endregion

        #region Constructor
        public Contador()
        {
            _contador = 0;
            _iniciar = false;
            _fin = 100;
        }
        #endregion

        #region Metodos

        public void VerContador()
        {
            if (!_iniciar)//Si vale falso, no hagas nada
                return;
            for (int i = 0; i < _fin; i++)
            {
                Thread.Sleep(500);//Para usar Thread añadimos el espacio de  nombre->using System.Threading;
                Console.SetCursorPosition(10, 10);
                Console.Write(_contador++);

                //Lanzamos el evento **(si no preguntamos si es distinto de null, el evento siempre estaria lanzandose..)**
                if (cambioValor != null)//si alguien se aputno al evento, fuera de esta clase
                    cambioValor();
                if (cambioValor5 != null && _contador % 5 == 0)//si alguien se aputno al evento, fuera de esta clase y el contador es multiplo de 5
                    cambioValor5();
            }
        }

        #endregion
    }
}
