using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace AppSerializar
{
    class GestionaPersona
    {
        string _fichero;

        #region Constructor
        public GestionaPersona(string fichero)
        {
            _fichero = fichero;
        }
        #endregion

        //Serializar
        public bool Anadir(Persona p)
        {
            if (!File.Exists(_fichero))//si el fichero no existe crea su flujo
            {              
                FileStream flujoTmp = File.Create(_fichero);//crea el fichero
                flujoTmp.Close();//cierra el flujo
            }

            IFormatter formato = new BinaryFormatter();//aplica formatoa los objetos serializados (No se puede crear un objeto del interface, pero si de la clase que implementa en este caso)
            using (FileStream flujo = new FileStream(_fichero,FileMode.Append,FileAccess.Write))//Esta instruccion cierra automaticamente el flujo al terminar
            {
                formato.Serialize(flujo, p);//Escribe en el flujo  el objeto serializado
            }
            return true;
        }

        //Descerializar
        public void Listar()
        { 
            if(!File.Exists(_fichero))
            {
                Console.WriteLine(" No existe el fichero...");
                Console.ReadLine();
                return;
            }

            Persona tmp = null;
            using (FileStream flujo = new FileStream(_fichero,FileMode.Open,FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();
               
                while (true)
                {
                    try
                    {
                        tmp =(Persona) formato.Deserialize(flujo);
                        //comprueba que no este borrado , para mostrar solo los que no estan borrados
                        if (tmp.Borrado)
                            continue;//vuelve a el while
                        Console.WriteLine(tmp.ToString());                                               
                    }
                    catch {
                        break;
                    }
                }

            }


        }
    }
}
