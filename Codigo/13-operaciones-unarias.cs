using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _13_operaciones_unarias {
        public void operacionesUnarias() {
            var num = 19;
            Console.WriteLine(-num);

            num++;
            Console.WriteLine($"Suma del valor: { num } ");

            num--;
            Console.WriteLine($"Resta del valor: { num } ");

            ++num;
            Console.WriteLine($"Suma del valor 2: { num }");

            --num;
            Console.WriteLine($"Resta del valor2: { num } ");
        }
    }
}
