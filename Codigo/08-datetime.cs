using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo {
    public class _08_datetime {
        public void datetime() {
            DateTime fechaAct = DateTime.Now;
            Console.WriteLine("Fecha Actual: " + fechaAct.DayOfWeek + " " + fechaAct);

            DateTime fechaNac = new DateTime(1996, 12, 16);
            Console.WriteLine("Fecha de Nacimiento: " + fechaNac);

            DateTime fechaMan = DateTime.Now.AddDays(1);
            Console.WriteLine("Mañana es: " + fechaMan.DayOfWeek + " " + fechaMan);

            DateTime fecha = new DateTime(2022, 5, 12, 10, 0, 0);
            Console.WriteLine(fecha);
        }
    }
}
