using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase20
{

    [Serializable]
    public abstract class Persona
    {

        protected string _nombre;
        protected string _apellido;
        protected int _dni;


        public Persona(string nombre, string apellido, int dni)
        {

            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;

        }

        public override string ToString()
        {
            return "Nombre:"+this._nombre+" "+this._apellido+"\n"+"DNI:"+this._dni;
        }


    }


    
}
