using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _07_string_verbatim {
        public void stringVerbatim() {
            string carta = @"A quien pueda interesar:
            Estimado cliente, le invitamos hacer su pago lo más pronto posible.

            Atte. Empresa
            ";
            Console.WriteLine(carta);

            string directorio = @"Directorio: C:\usuario\fersa";
            Console.WriteLine(directorio);

        }
    }
}
