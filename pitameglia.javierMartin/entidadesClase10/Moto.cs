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

        public string showMoto()
        {
            string mensage;

            mensage = base.show();
            mensage += "\nCantidad de cilindrada:" + this._cilindrada;


            return mensage;
        }
    }
}
