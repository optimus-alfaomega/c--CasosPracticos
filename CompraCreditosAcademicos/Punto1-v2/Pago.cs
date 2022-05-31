using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
     class Pago
    {
        private double precioNeto;
        private double precio_con_descuento_aplicado;
        private double valor_descuento;
        private double procentaje_descuento;
        private ProgramaAcademico programaAcademico;
        private int cantidad_creditos;
        private string periodo_academico;
        private MedioPago medioPago;
        private Estudiante estudiante;
        private Regla reglaAcademica;

        public Pago()
        {
            this.medioPago = new MedioPago();
            this.reglaAcademica = new Regla();
        }

        public Pago(Regla regla)
        {
            this.medioPago = new MedioPago();
            this.reglaAcademica = regla;
        }



        public double Pagar(ProgramaAcademico programaAcademico, int cantidad_creditos, string periodo_academico, MedioPago medioPago, Estudiante estudiante)
        {
            double precioTotal = 0;
            this.periodo_academico = periodo_academico;
            this.programaAcademico = programaAcademico;

            Boolean CumpleCreditosPermitidos=this.ValidarNumeroCreditosPermitido(programaAcademico.getNombre(),cantidad_creditos);
            
            if (CumpleCreditosPermitidos)
            {
                precioTotal = calcularPago(cantidad_creditos, medioPago);
                this.estudiante = estudiante;
            }
            else {
                precioTotal = -1;
            }
            return precioTotal;
        }

        public double getPrecioNeto() {
            return this.precioNeto;
        }
        public double getPrecio_con_descuento_aplicado() {
            return this.precio_con_descuento_aplicado;
        }

        public double getValor_descuento() {
            return this.valor_descuento;
        }

        public double getProcentaje_descuento() {
            return this.procentaje_descuento;
        }


        public int getCantidadCreditos() {
            return this.cantidad_creditos;
        }

        public String getPeriodoAcademico() {
            return this.periodo_academico;
        }

        public Estudiante getEstudiante() {
            return this.estudiante;
        }

        private double calcularPago(int creditosAPagar,MedioPago medioPago) {

            this.medioPago = medioPago;
            MedioPago MedioPagoUtilizado = this.medioPago;
            String nombreProgramaAPagar=this.programaAcademico.getNombre();
            double precioUnitarioCredito = this.reglaAcademica.getPrecioUnitarioCreditoAcademico();
            int descuentoPrograma = this.reglaAcademica.getDescuento(nombreProgramaAPagar, MedioPagoUtilizado);
            double costoNeto = creditosAPagar * precioUnitarioCredito; 
            double porcentajeDescuento = (double)descuentoPrograma / 100;
            double descuentoFinal = (double) costoNeto * porcentajeDescuento;
            double precioConDescuento = costoNeto - descuentoFinal;             

            this.precioNeto = costoNeto;
            this.procentaje_descuento=descuentoPrograma;
            this.valor_descuento = descuentoFinal;
            this.precio_con_descuento_aplicado = precioConDescuento;

            imprimirResultado(nombreProgramaAPagar,precioUnitarioCredito,creditosAPagar,descuentoPrograma, costoNeto, porcentajeDescuento, precioConDescuento,medioPago.getTipo()?"efectivo":"en linea");

            


            return precioConDescuento;
        }

        private void imprimirResultado(string nombreProgramaAPagar, double precioUnitarioCredito, int creditosAPagar, int descuentoPrograma, double costoNeto, double porcentajeDescuento, double precioConDescuento, string medioPago)
        {

            Console.WriteLine("* Descuento del programa con el medio de pago " + medioPago + " : " + descuentoPrograma);
            Console.WriteLine("**nombre del programa: " + nombreProgramaAPagar);
            Console.WriteLine("**precio unitario del credito: " + precioUnitarioCredito);
            Console.WriteLine("**creditos a adquirir: " + creditosAPagar);
            Console.WriteLine("**costo Neto: " + costoNeto);
            Console.WriteLine("**porcentaje de descuento a aplicar: " + porcentajeDescuento);
            Console.WriteLine("**precio total " + precioConDescuento);


        }

 
        private Boolean ValidarNumeroCreditosPermitido(String nombrePrograma, int creditosAPagar) {
            
            int maxCreditosPermitidos=this.reglaAcademica.getLimiteCreditos(nombrePrograma);
            return creditosAPagar <= maxCreditosPermitidos;
         }
    }
}
