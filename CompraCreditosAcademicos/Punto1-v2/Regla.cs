using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
    class Regla
    {
        private ProgramaAcademico[] programas;
        private CreditoAcademico credito;

        public Regla() {
 
            credito= new CreditoAcademico(200000);

            this.programas = new ProgramaAcademico[5];
            
            this.programas[0] = new ProgramaAcademico();
            this.programas[1] = new ProgramaAcademico();
            this.programas[2] = new ProgramaAcademico();
            this.programas[3] = new ProgramaAcademico();
            this.programas[4] = new ProgramaAcademico();


            programas[0].setNombre("Ingenieria de sistemas");
            programas[0].setTotalCreditosPorPeriodo(20);
            MedioPago[] medioPagoIng = new MedioPago[2];
            medioPagoIng[0] = new MedioPago();
            medioPagoIng[1] = new MedioPago();

            medioPagoIng[0].setTipo(true);
            medioPagoIng[0].setDescuento(18);
            medioPagoIng[1].setTipo(false);
            medioPagoIng[1].setDescuento(0);



            this.programas[0].setMediosPago(medioPagoIng);

            programas[1].setNombre("Psicologia");
            programas[1].setTotalCreditosPorPeriodo(16);
            MedioPago[] medioPagoPsi = new MedioPago[2];
            medioPagoPsi[0] = new MedioPago();
            medioPagoPsi[1] = new MedioPago();

            medioPagoPsi[0].setTipo(true);
            medioPagoPsi[0].setDescuento(12);
            medioPagoPsi[1].setTipo(false);
            medioPagoPsi[1].setDescuento(0);


            this.programas[1].setMediosPago(medioPagoPsi);

            programas[2].setNombre("Economía");
            programas[2].setTotalCreditosPorPeriodo(18);
            MedioPago[] medioPagoEco = new MedioPago[2];
            medioPagoEco[0] = new MedioPago();
            medioPagoEco[1] = new MedioPago();
            medioPagoEco[0].setTipo(true);
            medioPagoEco[0].setDescuento(10);
            medioPagoEco[1].setTipo(false);
            medioPagoEco[1].setDescuento(0);



            this.programas[2].setMediosPago(medioPagoEco);

            programas[3].setNombre("Comunicación Social");
            programas[3].setTotalCreditosPorPeriodo(18);
            MedioPago[] medioPagoCom = new MedioPago[2];
            medioPagoCom[0] = new MedioPago();
            medioPagoCom[1] = new MedioPago();

            medioPagoCom[0].setTipo(true);
            medioPagoCom[0].setDescuento(5);
            medioPagoCom[1].setTipo(false);
            medioPagoCom[1].setDescuento(0);




            this.programas[3].setMediosPago(medioPagoCom);

            programas[4].setNombre("Administración de Empresas");
            programas[4].setTotalCreditosPorPeriodo(20);
            MedioPago[] medioPagoAdmin = new MedioPago[2];
            medioPagoAdmin[0] = new MedioPago();
            medioPagoAdmin[1] = new MedioPago();

            medioPagoAdmin[0].setTipo(true);
            medioPagoAdmin[0].setDescuento(15);
            medioPagoAdmin[1].setTipo(false);
            medioPagoAdmin[1].setDescuento(0);

            this.programas[4].setMediosPago(medioPagoAdmin);


        }

        public int getDescuento(string nombrePrograma, MedioPago medio) {
            int descuento = 0;
            for (int a = 0; a < this.programas.Length; a++) {

                if (this.programas[a].getNombre().Equals(nombrePrograma)) {
                    descuento = this.programas[a].getMedioPago()[0].getTipo() == medio.getTipo() ? this.programas[a].getMedioPago()[0].getDescuento() : this.programas[a].getMedioPago()[1].getDescuento();

                }
            }
            return descuento;
        }

        public int getLimiteCreditos(string nombrePrograma) {

            int limiteCreditos = 0;

            for (int a = 0; a < this.programas.Length; a++)
            {

                if (this.programas[a].getNombre().Equals(nombrePrograma))
                {
                    limiteCreditos = this.programas[a].getTotalCreditosPorPeriodo();
                }
            }
            return limiteCreditos;
        }

     public ProgramaAcademico[] getProgramas() {
            return this.programas;
     }
     public double getPrecioUnitarioCreditoAcademico() {

            return this.credito.getPrecioUnitario();
     }

    }
}
