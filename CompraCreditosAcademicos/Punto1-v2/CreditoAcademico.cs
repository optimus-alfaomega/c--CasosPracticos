using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
    class CreditoAcademico
    {
        private double precioUnitario;

        public CreditoAcademico() {
            this.precioUnitario = 200000;
        }

        public CreditoAcademico(double precioUnitario)
        {
            this.precioUnitario = precioUnitario;
        }

        public void setPrecioUnitario(double precio) {
            this.precioUnitario = precio;
        }
        public double getPrecioUnitario() { 
           return this.precioUnitario;
        }

    }
}
