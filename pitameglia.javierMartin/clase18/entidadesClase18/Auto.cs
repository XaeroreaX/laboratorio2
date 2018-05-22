using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Auto : Vehiculo
    {

        #region Fields

        protected string _patente;

        #endregion


        #region Methods

        public virtual void mostrarPatente()
        {

            Console.WriteLine(this._patente);

        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }

        #region Constructor

        public Auto(double precio, string patente) : base(precio: precio) { this._patente = patente; }

        #endregion

        #endregion


    }

    public class Deportivo : Auto, IAFIP
    {

        #region Fields

        protected int _caballosFuerza;

        #endregion



        #region Methods

        double CalcularImpuesto()
        {

            return this._precio * 1.28;

        }

        #region Constructor

        public Deportivo(double precio, string patente, int caballoFuerza) : base(precio: precio, patente: patente) { this._caballosFuerza = caballoFuerza; }

        #endregion

        #endregion

        


    }

    public class Familiar : Auto
    {

        #region Fields

        protected int _cantAsientos;

        #endregion


        


        #region Constructor

       
        public Familiar(double precio, string patente, int cantAsiento) : base(precio: precio, patente: patente) { this._cantAsientos = cantAsiento; }


        #endregion

       

    }

}
