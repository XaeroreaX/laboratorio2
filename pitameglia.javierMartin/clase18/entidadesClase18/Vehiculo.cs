using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {

        #region Fields

        protected double _precio;


        #endregion


        #region Methods

        public abstract void MostrarPrecio();

             #region Constructor

        public Vehiculo(double precio) { this._precio = precio; }


        #endregion

        #endregion

        

    }

    public class Carreta : Vehiculo
    {

        
        #region Methods

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }

        #region Constructor

        public Carreta(double precio) : base(precio: precio) { }

        #endregion

        #endregion

       

    }

    //clases de Auto y avion en sus respectiva carpetas

}
