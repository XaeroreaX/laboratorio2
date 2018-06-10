using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum EEstado { Ingresado, EnViaje, Entregado }


    public delegate int DelegadoEstado(object sender, EventArgs e);
        


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


        public void MockCicloDeVida()
        {


        }


        public override string ToString()
        {
            return base.ToString();
        }



        #region Constructor

        public Paquete(string direccionEntrega, string trackingID)
        {

            this.DireccionDeEntrega = direccionEntrega;
            this.TrackingID = trackingID;


        }

        





        #endregion

        #endregion

        #region Operators

        public static bool operator ==(Paquete p1, Paquete p2)
        {

            return false;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {

            return false;
        }


        #endregion



    }


    public class Correo : IMostrar<List<Paquete>>
    {
        


        #region Propeties

        public List<Paquete> Paquetes
        {
            get; set;

        }



        #endregion

        #region Methods


        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            throw new NotImplementedException();
        }


        public void FinEntregas()
        {


        }

        #region Constructor

        public Correo()
        {
            this.Paquetes = new List<Paquete>();
       
        }

        #endregion

        #endregion

        #region Operators

        public static Correo operator +(Correo c, Paquete p)
        {


            return null;
        }

        #endregion


    }

    public class PaqueteDAO
    {

        public bool Insertar(Paquete p)
        {

            return false;
        }

        public PaqueteDAO()
        {


        }

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