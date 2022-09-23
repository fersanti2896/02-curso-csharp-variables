using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _09_valores_defecto {
        public void valoresXDefecto() {

            string apellido = default;
            Console.WriteLine("Valor por Defecto de un String: " + apellido);

            bool valor = default;
            Console.WriteLine("Valor por Defecto de un Bool: " + valor);

            DateTime fecha = default;
            Console.WriteLine("Valor por Defecto de una Fecha: " + fecha);

            decimal numero = default;
            Console.WriteLine("Valor por Defecto de una Decimal: " + numero);
        }
    }
}
