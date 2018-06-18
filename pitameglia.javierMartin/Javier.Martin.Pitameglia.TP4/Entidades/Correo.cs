using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;


namespace Entidades
{

    public delegate void DelegadoEstado(object sender, EventArgs e);

    public enum EEstado { Ingresado, EnViaje, Entregado }


    public class Paquete : IMostrar<Paquete>
    {

        #region Fields

        private string _direccionEntrega;

        private EEstado _estado;

        private string _TrackingId;

        

        #endregion

        #region Propeties

        public string DireccionDeEntrega
        {
            get
            {
                return this._direccionEntrega;
            }

            set { this._direccionEntrega = value; }

        }

        public EEstado Estado
        {

            get { return this._estado; }

            set { this._estado = value; }

        }

        public string TrackingID
        {
            get { return this._TrackingId; }
            set { this._TrackingId = value; }
        }

        #endregion

        #region Methods

        public event DelegadoEstado InformarEstado;


        public string MostrarDatos(IMostrar<Paquete> elemento)
        {

            Paquete algo =(Paquete) elemento;

            return String.Format("{0} para {1}", this.TrackingID, this.DireccionDeEntrega);
        }


        public void MockCicloDeVida()
        {
            while(this._estado != EEstado.Entregado)
            {
                Thread.Sleep(1000);

                if (this._estado == EEstado.Ingresado) this._estado = EEstado.EnViaje;

                if (this._estado == EEstado.EnViaje) this._estado = EEstado.Entregado;

            }


        }


        public override string ToString()
        {
            IMostrar<Paquete> This = this;

            return String.Format("{0} ({1})", this.MostrarDatos(This), this.Estado.ToString());
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
            bool returnAux = false;

            if((object)p1 != null && (object)p2 != null)
            {

                if (p1._TrackingId == p2._TrackingId) returnAux = true;

            }

            return returnAux;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {

            bool returnAux = false;

            if ((object)p1 != null && (object)p2 != null)
            {

                returnAux = !(p1 == p2);

            }

            return returnAux;
        }


        #endregion



    }


    public class Correo : IMostrar<List<Paquete>>
    {

        #region Fields

        private List<Paquete> _paquetes;

        private List<Thread> _mockPaquetes;

        #endregion


        #region Propeties

        public List<Paquete> Paquetes
        {
            get { return this._paquetes; }
            set { this._paquetes = value; }

        }



        #endregion

        #region Methods


        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            string MD = "";

            
            List<Paquete> elements = (List<Paquete>)elemento;
            
            foreach(Paquete element in elements)
            {
                MD += element.ToString();

            }


            return MD;
        }


        public void FinEntregas()
        {


        }

        #region Constructor

        public Correo()
        {
            this.Paquetes = new List<Paquete>();
            this._mockPaquetes = new List<Thread>();
       
        }

        #endregion

        #endregion

        #region Operators

        public static Correo operator +(Correo c, Paquete p)
        {
            if((object) c != null && (object) p != null)
            {

                bool flag = false;

                for(int i = 0; i < c._paquetes.Count; i++)
                {
                    if(p == c._paquetes[i])
                    {
                        flag = true;
                        c._paquetes[i] = (Paquete)p;
                        break;

                    }

                    if(flag == false)
                    {
                        c._paquetes.Add(p);
                    }
                }
            }

            return c;
        }

        #endregion


    }

    public class PaqueteDAO
    {
        private SqlCommand _comando;

        private string _conexion;


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