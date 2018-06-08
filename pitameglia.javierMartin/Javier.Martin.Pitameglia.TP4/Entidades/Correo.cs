using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum EEstado { Ingresado, EnViaje, Entregado }


    public class Paquete : IMostrar<Paquete>
    {


        #region Propeties

        public string DireccionDeEntrega
        {
            get; set;

        }

        public EEstado Estado
        {

            get; set;

        }

        public string TrackingID { get; set; }

        #endregion

        #region Methods


        public string MostrarDatos(IMostrar<Paquete> elemento)
        {

            Paquete algo =(Paquete) elemento;

            throw new NotImplementedException();
        }


        //public void Mock



        #region Constructor

        public Paquete(string direccionEntrega, string trackingID)
        {

            this.DireccionDeEntrega = direccionEntrega;
            this.TrackingID = trackingID;


        }

        





        #endregion

        #endregion

        #region Operators


        #endregion



    }
}



#region Fields



#endregion


#region Propeties


#endregion

#region Methods

#region Constructor

#endregion

#endregion

#region Operators


#endregion