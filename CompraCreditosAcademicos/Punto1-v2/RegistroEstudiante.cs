using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
    class RegistroEstudiante
    {
        private Estudiante[] estudiantes;
        private int cantidadRegistrados;
        private const int maxEstudiantes = 50;
        public RegistroEstudiante() {
            this.estudiantes = new Estudiante[maxEstudiantes];
            this.cantidadRegistrados = 0;
        }

        public Boolean registrar(Estudiante estudiante) {

            if (this.cantidadRegistrados < maxEstudiantes) { 
               this.estudiantes[this.cantidadRegistrados] = estudiante;
               this.cantidadRegistrados++;
               return true;
            }

            return false;
        }

    }
}
