using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _12_interpolacion_strings {
        public void interpolacionString() {
            var num = 32;
            var num2 = 64;

            Console.WriteLine($"Hay dos sistemas de bits { num } y { num2 } para SO!");

            var nombre = "Fernando";
            var apellido = "Nicolás";

            Console.WriteLine($"Mi nombre es { nombre } { apellido }");
        }
    }
}
