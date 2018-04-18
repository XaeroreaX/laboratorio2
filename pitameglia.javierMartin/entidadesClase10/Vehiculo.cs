using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase10
{
    public abstract class Vehiculo
    {

        protected string _patente;
        protected byte _cantRuedas;
        protected EMarca _marca;

        protected virtual string show()
        {
            string miShow;

            miShow = "datos del vehiculo:\nPatente:" + this._patente + "\nCantidad de ruedas:" + this._cantRuedas + "\nMarca:";

            switch (this._marca)
            {
                case EMarca.Fiat:
                    miShow += "FIAT";
                    break;
                case EMarca.Ford:
                    miShow += "FORD";
                    break;
                case EMarca.Honda:
                    miShow += "HONDA";
                    break;
                case EMarca.Iveco:
                    miShow += "IVECO";
                    break;
                case EMarca.Scania:
                    miShow += "SCANIA";
                    break;
                case EMarca.Zanella:
                    miShow += "ZANELLA";
                    break;
            }

            return miShow;
        }

        public override string ToString()
        {
            return this.show();
        }


        public abstract string acelerar();

        public Vehiculo(string patente, byte cantRuedas, EMarca marca)
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        { 
            bool returnAux = false;
            if ((object)a == null || (object)b == null) return returnAux;
            
            if(a._patente == b._patente && a._marca == b._marca) returnAux = true;

            return returnAux;
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            bool returnAux = false;
            
            if((object)a == null || (object)b == null) return returnAux;

            returnAux = !(a == b);

            return returnAux;

            
        }


        public static bool operator <(Vehiculo a, Vehiculo b)
        {
            bool returnAux = false;

            if ((object)a == null || (object)b == null) return returnAux;

            if (a is Moto && b is Auto) returnAux = true;


            if (a is Moto && b is Camion)returnAux = true;

            if (a is Auto && b is Camion)returnAux = true;

            if (a is Moto && b is Moto)
            {
                if (a._patente.CompareTo(b._patente) == -1) returnAux = true;
            }
            if (a is Auto && b is Auto)
            {
                if (a._patente.CompareTo(b._patente) == -1) returnAux = true;
            }

            if (a is Camion && b is Camion)
            {
                if (a._patente.CompareTo(b._patente) == -1) returnAux = true;
            }
            

            return returnAux;

        }

        public static bool operator >(Vehiculo a, Vehiculo b)
        {
            bool returnAux = false;

            if ((object)a == null || (object)b == null) return returnAux;

            if (a is Auto && b is Moto)
                returnAux = true;
            if (a is Camion && b is Moto)
                returnAux = true;
            if (a is Camion && b is Auto)
                returnAux = true;
            if (a is Moto && b is Moto)
            {
                if (b._patente.CompareTo(a._patente) == -1) returnAux = true;
            }
            if (a is Auto && b is Auto)
            {
                if (b._patente.CompareTo(a._patente) == -1) returnAux = true;
            }
            if (a is Camion && b is Camion)
            {
                if (b._patente.CompareTo(a._patente) == -1) returnAux = true;
            }
            

            return returnAux;
        }

        public static int compareVehiculo(Vehiculo a, Vehiculo b)
        {
            int returnAux = 0;
            if ((object)a == null || (object)b == null) return returnAux;

            if ((Vehiculo)a < (Vehiculo)b) returnAux = -1;

            if ((Vehiculo)a > (Vehiculo)b) returnAux = 1;

            return returnAux;
        }
    }
}
