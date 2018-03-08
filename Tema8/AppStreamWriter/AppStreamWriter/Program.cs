/*
 Autor: Pablo Lopez
 Ejemplo consola:Ejemeplo de uso de la clase StreamWrite
 Fecha:08/03/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.IO;

namespace AppStreamWriter.pbl
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\texto.txt";
            string cadenaDeTexto = "Esta es mi cadena de texto blablabla";
            char[] array = { 'E', 's', 't', 'o', 'e', 's', 'u', 'n', 'a', 'r', 'r', 'a', 'y' };

            //Abrir el fichero:
            FileStream flujo = new FileStream(ruta, FileMode.Append, FileAccess.Write);//Flujo para abrrir el fichero(si no le indicamos el flujo del fichero a la hora de prepararlo) lo decidira el  al crear el flujo de escritura o lectura
           // StreamWriter escritor = new StreamWriter(ruta);
            StreamWriter escritor = new StreamWriter(flujo, Encoding.Default);//Flujo de escritura en el fichero
            for (int i = 0; i < 50; i++)
            {
                escritor.WriteLine("Linea_" +i.ToString("000"));

            }
            escritor.WriteLine(array);        
            escritor.Write(cadenaDeTexto);
            escritor.Close();

        }
    }
}
