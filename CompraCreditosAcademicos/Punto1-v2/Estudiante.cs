using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1_v2
{
    class Estudiante
    {
        private string nombre;
        private string telefono;

        public Estudiante() { 
        
        }
        public Estudiante(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }
        public string getNombre() {
            return this.nombre;
        }
        public string getTelefono() {
            return this.telefono;
        }
        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public void setTelefono(string telefono) { 
          this.telefono= telefono;
        }

  }
}
