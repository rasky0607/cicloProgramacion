using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRecorrerClassConMismoInterface
{
    class Proveedor:Ipresentable
    {

        string _nombre;
        string _apellidos;
        int _nProveedor;

        public Proveedor(string n, string a, int np)
        {
            _nombre = n;
            _apellidos = a;
            _nProveedor = np;
        }        


         public void Presentable()
         {
             Console.WriteLine(" Nombre: {0}", _nombre);
             Console.WriteLine(" Apellidos: {0}", _apellidos);
             Console.WriteLine(" nProveerdor: {0}", _nProveedor);

         }
    }
}
