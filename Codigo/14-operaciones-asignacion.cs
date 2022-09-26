using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _14_operaciones_asignacion {
        public void operacionesAsignacion() {
            var num = 16;
            var num2 = 25;

            Console.WriteLine($"Valor 1 Inicial: { num }");
            Console.WriteLine($"Valor 2 Inicial: { num2 }");

            num += num2;
            Console.WriteLine($"Valor 1 Actual: { num }");

            num2 += num;
            Console.WriteLine($"Valor 2 Actual: { num2 }");
        }
    }
}
