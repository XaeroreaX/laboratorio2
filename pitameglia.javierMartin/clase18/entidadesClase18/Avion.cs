using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Avion : Vehiculo, IAFIP
    {

        #region Fields

        protected double _velocidadMaxima;

        #endregion


        #region Methods

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 1.33;
        }

        public override void MostrarPrecio()
        {
            Console.Write(this._precio);
        }

        #region Constructor

        public Avion(double precio, double velMax) : base(precio) { this._velocidadMaxima = velMax; }

        #endregion

        #endregion
        
    }


    public class Privado : Avion
    {

        #region Fields

        protected int _valoracionServicioDeAbordado;

        #endregion

        #region Methods

        #region Constructor

        public Privado(double precio, double velocidad, int valoracion) : base(precio:precio, velMax: velocidad) { this._valoracionServicioDeAbordado = valoracion; }

        #endregion

        #endregion



    }


    public class Comercial : Avion
    {

        #region Fields

        protected int _capacidadDePasajeros;

        #endregion


        #region Methods

        #region Constructor


        public Comercial(double precio, double velocidad, int capacidadDePasajeros) : base(precio: precio, velMax: velocidad) { this._capacidadDePasajeros = capacidadDePasajeros; }

        #endregion

        #endregion



    }


}
