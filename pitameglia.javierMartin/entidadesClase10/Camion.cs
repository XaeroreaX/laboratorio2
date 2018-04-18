using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase10
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(float tara, string patente, byte cantRuedas, EMarca marca) : base(patente, cantRuedas, marca) { this._tara = tara; }

        public override bool Equals(object obj)
        {
            bool miBool = false;

            if (obj is Camion)
            {
                if (this == (Vehiculo)obj) miBool = true;
            }

            return miBool;
        }

        public override string acelerar()
        {
            return "CAMION esta acelerado";
        }

        public override string ToString()
        {
            string mensage;
            mensage = "CAMION\n";
            mensage += base.show();
            mensage += "\nCantidad de tara:" + this._tara;


            return mensage;
        }
    }
}
