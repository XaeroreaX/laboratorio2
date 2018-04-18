using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase10
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(float cilindrada, string patente, byte cantRuedas, EMarca marca) : base(patente, cantRuedas, marca) { this._cilindrada = cilindrada; }

        public override bool Equals(object obj)
        {
            bool miBool = false;

            if (obj is Moto)
            {
                if(this == (Vehiculo)obj) miBool = true;
            }
            return miBool;
        }


        public override string acelerar()
        {
            return "MOTO esta acelerado";
        }

        public override string ToString()
        {
            string mensage;
            mensage = "MOTO\n";

            mensage += base.show();
            mensage += "\nCantidad de cilindrada:" + this._cilindrada;


            return mensage;
        }
    }
}
