using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _11_operaciones_binarias {
        public void operacionesBinarias() {
            var num = 1996;
            var num2 = 2000;
            var resultado = num + num2;

            Console.WriteLine("La suma de " + num + " + " + num + " es " + resultado);

            var cantidad = 7.1m;
            var cantidad2 = 3.5m;
            var suma = cantidad + cantidad2;
            var resta = cantidad - cantidad2;
            var multiplicacion = cantidad * cantidad2;
            var division = cantidad / cantidad2;
            var residuo = cantidad % cantidad2;

            var msgSum = "La suma es: " + suma;
            Console.WriteLine(msgSum);

            var msgRes = "La resta es: " + resta;
            Console.WriteLine(msgRes);

            var msgMul = "La multiplicacion es: " + multiplicacion;
            Console.WriteLine(msgMul);

            var msgDiv = "La division es: " + division;
            Console.WriteLine(msgDiv);

            var msgResiduo = "El residuo es: " + residuo;
            Console.WriteLine(msgResiduo);
        }
    }
}
