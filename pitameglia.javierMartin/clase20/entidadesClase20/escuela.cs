using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase20
{
    public class Alumno : Persona
    {

        public int Legajo { get; set; }

        public override string ToString()
        {
            return base.ToString()+"\nLEGAJO:"+this.Legajo;
        }


        public Alumno() : this("martin", "pitameglia", 37948093, 106004) { }

        public Alumno(string nombre, string apellido, int dni, int legajo) : base(nombre, apellido, dni) { this.Legajo = legajo; }


    }

    public class Profesor : Persona
    {

        public string Titulo { get; set; }

        public override string ToString()
        {
            return base.ToString()+"\nTITULO:"+this.Titulo;
        }

        public Profesor(string nombre, string apellido, int dni, string titulo) : base(nombre, apellido, dni) { this.Titulo = titulo; }

        public Profesor() : this("arturo", "coronado", 6548474, "critico de anime") { }

    }

}
