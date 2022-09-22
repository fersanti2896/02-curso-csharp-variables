using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _03_otros_numeros {
        public static void otrosNumeros() {
            byte numByte = 255;
            Console.WriteLine("Número Byte: " + numByte);

            sbyte numSbyte = 127;
            Console.WriteLine("Número SByte: " + numSbyte);

            short numShort = 32_767;
            Console.WriteLine("Número Short: " + numShort);

            int numInt = 25;
            Console.WriteLine("Número Int: " + numInt);

            long numLong = 9_223_372_036_854_775_807;
            Console.WriteLine("Número Long: " + numLong);
        }
    }
}
