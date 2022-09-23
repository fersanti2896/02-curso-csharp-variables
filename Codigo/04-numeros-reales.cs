using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _04_numeros_reales {
        public void numerosReales() {
            float altura = 158.659832246f; /* Ocupa 4 bytes - Limita a 5 dígitos */
            Console.WriteLine("Altura: " + altura);

            double pi = 3.141652352984093523; /* Ocupa 8 bytes - Precisión de 15 a 17 dígitos */
            Console.WriteLine("PI: " + pi);

            decimal monto = 8021.99m; /* Ocupa 16 bytes - Precision de 28 a 29 dígitos */
            Console.WriteLine("Monto en el banco: " + monto);
        }
    }
}
