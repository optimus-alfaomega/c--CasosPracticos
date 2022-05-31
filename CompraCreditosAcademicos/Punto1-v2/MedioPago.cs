using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
    class MedioPago
    {
        private Boolean tipo;  // true: Efectivo - false: Virtual
        private int descuento;

        public MedioPago() { 
          
        }

        public MedioPago(bool tipo, int descuento)
        {
            this.tipo = tipo;
            this.descuento = descuento;
        }

        public void setTipo(Boolean tipo) { 
          this.tipo = tipo;
        }

        public void setDescuento(int descuento) {
            this.descuento = descuento;
        }
        public Boolean getTipo() {
            return this.tipo;
        }
        public int getDescuento() {
            return this.descuento;
        }


    }
}
