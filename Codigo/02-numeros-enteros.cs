using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _02_numeros_enteros {
        public static void numerosEnteros() {
            int age;
            age = 25;

            Console.WriteLine("Edad: " + age);

            int velocidadLuz = 6_000_000;
            Console.WriteLine("Velocidad de la Luz: " + velocidadLuz);

            int maximoNum = int.MaxValue;
            Console.WriteLine("Máximo Entero: " + maximoNum);

            int minimoNum = int.MinValue;
            Console.WriteLine("Mínimo Entero: " + minimoNum);
        }
    }
}
