using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{

    public enum EPuesto{ Arquero, Defensor, Delantero, ElDelMedio,}

    public class Jugador
    {
        

        #region Fields

        private string _nombre;
        private string _apellido;
        private EPuesto _puesto;


        #endregion


        #region Propeties


        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }

        public EPuesto Puesto { get { return this._puesto; } set { this._puesto = value; } }

        #endregion

        #region Methods

        public override string ToString()
        {
            string toString = "DATOS DEL JUGADOR:\nNOMBRE:" + this._nombre+"\n";

            toString += "APELLIDO:"+this._apellido+"\n";

            toString += "PUESTO:"+this._puesto.ToString();

            return toString;
        }

        #region Constructor

        public Jugador(string nombre, string apellido, EPuesto puesto)
        {
            this._nombre = nombre;

            this._apellido = apellido;

            this._puesto = puesto;

        }

        #endregion

        #endregion

        


    }
}
