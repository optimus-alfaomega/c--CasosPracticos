using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
     class Demo
    {
        static void Main(string[] args) {
             /*
                       // int descuento = reglaDescuentos.getDescuento("Psicologia", medio);
            //int descuento = reglaDescuentos.getDescuento("Economía", medio);
            //int descuento = reglaDescuentos.getDescuento("Comunicación Social", medio);
            //int descuento = reglaDescuentos.getDescuento("Administración de Empresas", medio);
            //int creditos= reglaDescuentos.getLimiteCreditos("Ingenieria de sistemas");
            //int creditos = reglaDescuentos.getLimiteCreditos("Psicologia");
            //int creditos = reglaDescuentos.getLimiteCreditos("Economía");
            //int creditos = reglaDescuentos.getLimiteCreditos("Comunicación Social");
             */

            Regla reglaDescuentos = new Regla();
            MedioPago medioUsado= new MedioPago(); medioUsado.setTipo(true);
            Estudiante estudiante = new Estudiante();
            estudiante.setNombre("Alexander");

            ProgramaAcademico isistemas=reglaDescuentos.getProgramas()[0];
            ProgramaAcademico psicol = reglaDescuentos.getProgramas()[1];
            ProgramaAcademico econom= reglaDescuentos.getProgramas()[2];
            ProgramaAcademico comun= reglaDescuentos.getProgramas()[3];
            ProgramaAcademico aempres= reglaDescuentos.getProgramas()[4];
            int cantidad_creditos_a_comprar = 20;
            string periodo_academico = "2020-3";



            Pago pago = new Pago(reglaDescuentos);
            double cobro=  pago.Pagar(isistemas, cantidad_creditos_a_comprar, periodo_academico, medioUsado, estudiante);
            


            //public double Pagar(ProgramaAcademico programaAcademico, int cantidad_creditos, string periodo_academico, MedioPago medioPago, Estudiante estudiante)


            //Console.WriteLine("el descuento es"+descuento + "creditos maximo "+ creditos+ " "+ reglaDescuentos.getPrecioUnitarioCreditoAcademico());   

        }
    }
}
