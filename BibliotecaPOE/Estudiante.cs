using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOE
{
    public class Estudiante : Persona
    {
        private string carrera;
        public string Carrera { get { return carrera; } set { carrera = value; } }
        public Estudiante(string cedula, string nombre, string apellido, string carrera) : base(cedula, nombre, apellido)
        {
            this.carrera = carrera;
        }
        public Estudiante()
        {
        }
    }


}
