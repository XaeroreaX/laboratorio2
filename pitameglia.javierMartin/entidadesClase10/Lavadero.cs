using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase10
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero() { this._vehiculos = new List<Vehiculo>(); }

        public Lavadero(List<Vehiculo> vehiculos, float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._vehiculos = vehiculos;
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        public string showLavadero
        {
            get
            {
                string miString;

                miString = "----------------------------------\n";
                miString += "-------LISTA DE VEHICULOS--------\n";
                miString += "----------------------------------\n\n";

                foreach (Vehiculo element in this._vehiculos)
                {
                    if (element is Auto)
                    {
                        miString += ((Auto)element).showAuto() + "\n\n";
                        miString += "------------------------------------------------\n\n";
                    }

                    if (element is Camion)
                    {
                        miString += ((Camion)element).showCamion()+ "\n\n";
                        miString += "------------------------------------------------\n\n";
                    }

                    if (element is Moto)
                    {
                        miString += ((Moto)element).showMoto() + "\n\n";
                        miString += "------------------------------------------------\n\n";
                    }
                }

                miString += "precio por autos:"+this._precioAuto+"\n";
                miString += "precio por camiones:" + this._precioCamion + "\n";
                miString += "precio por Motos:" + this._precioMoto + "\n";
                miString += "precio totales de Auto:" + this.MostrarTotalFacturado(EVehiculos.auto) + "\n";
                miString += "precio totales de camion:" + this.MostrarTotalFacturado(EVehiculos.camion) + "\n";
                miString += "precio totales de motos:" + this.MostrarTotalFacturado(EVehiculos.moto) + "\n";
                miString += "ganacias:" + this.MostrarTotalFacturado() + "\n";

                return miString;
            }
        }

        public double MostrarTotalFacturado(EVehiculos tipo)
        {
            double ganancia = 0;
            int cantA = 0, cantC = 0, cantM = 0;

            foreach (Vehiculo element in this._vehiculos)
            {
                if (element is Auto) cantA++;


                if (element is Camion) cantC++;


                if (element is Moto) cantM++;
                
            }

            switch(tipo)
            {
                case EVehiculos.auto:
                    ganancia += this._precioAuto * cantA;
                    break;

                case EVehiculos.camion:
                    ganancia += this._precioCamion * cantC;
                    break;
                case EVehiculos.moto:
                    ganancia += this._precioMoto * cantM;
                    break;
            }

            


                return ganancia;
        }

        public double MostrarTotalFacturado()
        {
            return this.MostrarTotalFacturado(EVehiculos.auto) * this.MostrarTotalFacturado(EVehiculos.camion) * this.MostrarTotalFacturado(EVehiculos.moto);
        }


        public static bool operator ==(Lavadero a, Vehiculo b)
        {
            bool returnAux = false;

            if ((object)a == null || (object)b == null) return returnAux;

            returnAux = a._vehiculos.Contains(b);


            return returnAux;

        }


        public static bool operator !=(Lavadero a, Vehiculo v)
        {
            bool returnAux = false;

            if ((object)a == null || (object)v == null) return returnAux;

            returnAux = !(a == v);

            return returnAux;
        }

    }
}
