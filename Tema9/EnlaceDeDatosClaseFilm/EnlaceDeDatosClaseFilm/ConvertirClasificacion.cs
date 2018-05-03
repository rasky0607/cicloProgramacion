using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadido
using System.Windows.Data;


namespace pbl.EnlaceDeDatosClaseFilm
{
    /*Ejemplo de relacionar un dato con un interfaz grafico.
     como por ejemplo  el valor dela puntuacion sea mostrado en una barra segun el nivel de esta, 
     o en lugar de su valor se muestre dicho valor escrito con letra
     */
   public class ConvertirClasificacion:IValueConverter
    {
        /*value -> objeto origen o dato de origen
         * targetType tipo de dato de la popiedad de destino
         * los otros dos parametros no se sulen usa.. son informacion adicional
        */
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string[] valoresaLetras = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
            if (targetType == typeof(string) && value.GetType() == typeof(double))//Comprobamos que en el parametro targetType es de tipo String cuando se lo pasamos el parametro y si el de value es un double
            {
                //devolvemos el valor convertido
                return valoresaLetras[(int)Math.Round((double)value)];
            }
            else
            { 
                //No se ha podido convertir
                return value;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
