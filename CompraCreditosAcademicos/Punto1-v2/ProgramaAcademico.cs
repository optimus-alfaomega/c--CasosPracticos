using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
    class ProgramaAcademico
    {
        private RegistroEstudiante registro;
        private string nombre;
        private int totalCreditosPorPeriodo;
        private MedioPago[] medioPago;
        private Pago[] pagosEfectuados;
        private const int MaxPagosParaRecibir = 1000;
        private int totalPagosRealizados;


        public ProgramaAcademico() { 
          this.registro= new RegistroEstudiante();
          this.medioPago = new MedioPago[2];
          this.pagosEfectuados = new Pago[MaxPagosParaRecibir];
          this.totalPagosRealizados = 0;

        }
        public ProgramaAcademico(string nombre, int totalCreditosPorPeriodo, MedioPago[] medioPago)
        {
            this.registro = new RegistroEstudiante();
            this.nombre = nombre;
            this.totalCreditosPorPeriodo = totalCreditosPorPeriodo;
            this.medioPago = medioPago;
            this.pagosEfectuados = new Pago[MaxPagosParaRecibir];
            this.totalPagosRealizados = 0;
        }

        public Boolean RegistrarPago(Pago pago) { 
            if(this.totalPagosRealizados<MaxPagosParaRecibir){
                this.pagosEfectuados[totalPagosRealizados] = pago;
                 totalPagosRealizados++;
                return true;
              }
            return false;
        }
        public Boolean RegistrarEstudiante(Estudiante estudiante) {

              return this.registro.registrar(estudiante);
        
        }
        public string getNombre() {
            return this.nombre;
        }
        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public double getCreditos() {
            return this.totalCreditosPorPeriodo;
        }
        public MedioPago[] getMedioPago() {
            return this.medioPago;
        }
        public Pago[] getPagosEfectuados() {
            return this.pagosEfectuados;
        }
        public int getTotalCreditosPorPeriodo() {
            return this.totalCreditosPorPeriodo;

        }

        public void setTotalCreditosPorPeriodo(int creditos) { 
           this.totalCreditosPorPeriodo = creditos;
        }

        public void setMediosPago(MedioPago[] medio) {
            this.medioPago = medio;
        }

    }
}
