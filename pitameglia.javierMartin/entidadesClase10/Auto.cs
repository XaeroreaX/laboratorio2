using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase10
{
    public class Auto : Vehiculo
    {
        protected int _cantAsientos;

        public Auto(int cantAsientos, string patente, byte cantRuedas, EMarca marca) : base(patente, cantRuedas, marca) { this._cantAsientos = cantAsientos; }

        public string showAuto()
        {
            string mensage;

            mensage = base.show();
            mensage += "\nCantidad de asientos:" + this._cantAsientos;


            return mensage;
        }

    }
}
