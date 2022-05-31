using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
    class RegistroAcademico
    {
        private Regla reglaDescuentos;
        private ProgramaAcademico[] programaAcademico;
        private double PagosSinDescuentoTotal;
        private double TotalDescuentosAplicados;
        private Pago[] pagos;

        public RegistroAcademico() { 
          this.reglaDescuentos=new Regla();
          this.programaAcademico=this.reglaDescuentos.getProgramas();


        }

    }
}
