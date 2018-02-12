using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRecorrerClassConMismoInterface
{
    class Triangulo:Ipresentable
    {
      /*Ejemplo2 -> Ejemplo para apuntarse al evento*/ 
        public event EventHandler OnPresentar;


        //--------------
        double _base;
        double _altura;
        public Triangulo(double _base, double _altura)
        {
            this._base = _base;
            this._altura = _altura;
        }

        public double Area {

            get { return _base * _altura / 2; }
        }
      

         public void Presentable()
         {
             if (OnPresentar != null)
                 OnPresentar(this, null);
             Console.WriteLine(" Base: {0}", _base);
             Console.WriteLine(" ALtura: {0}", _altura);
             Console.WriteLine(" Area: {0}", Area);
         }
    }
}
