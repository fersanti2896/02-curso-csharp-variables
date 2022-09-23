using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _10_tipos_referencia_no_nulos {
        public void tipoReferenciaNoNulos() {
            int? edad = null;
            Console.WriteLine("Tipo de Referecia: " + edad);

            string? nombre = "Fernando Nicolás";
            Console.WriteLine("Valor por Defecto String: " + nombre.ToUpper());
        }
    }
}
