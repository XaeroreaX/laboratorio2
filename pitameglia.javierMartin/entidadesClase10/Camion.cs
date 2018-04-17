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

        public string showCamion()
        {
            string mensage;

            mensage = base.show();
            mensage += "\nCantidad de tara:" + this._tara;


            return mensage;
        }
    }
}
