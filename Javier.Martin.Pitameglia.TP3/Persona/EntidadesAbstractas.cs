using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {

        public enum ENacionalidad { Argentino, Extreangero,}


        #region Fields

        private string _nombre;

        private string _apellido;

        private ENacionalidad _nacionalidad;

        private int _dni;


        #endregion


        #region Propeties

        public string Apellido { get { return this._apellido} set { this._apellido = value; } }

        public int DNI {
            get { return this._dni; }

            set {

                this._dni = Persona.ValidarDni(value, this._nacionalidad);
                
            }

        }

        public ENacionalidad Nacionalidad { get { return this._nacionalidad; } set { this._nacionalidad = value; } }

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public string StringToDni {

            set
            {
                bool miBool = false;

                int ElValue = 0;

                miBool = int.TryParse(value, out ElValue);

                if (miBool == true)
                {
                    this.DNI = ElValue;
                }
                

            }


        }


        #endregion

        #region Methods


        public override string ToString()
        {
            return "NOMBRE COMPLETO:" + this._nombre + " " + this._apellido + "\nNACIONALIDAD:" + this._nacionalidad.ToString() + "\n";
        }


        static private int ValidarDni(string dni, ENacionalidad nacionalidad)
        {
            Random random = new Random();

            int returnAux = random.Next(1, 89999999);

            int Dni;

            
            if(int.TryParse(dni,out Dni) == true)
            { 
                if (nacionalidad == ENacionalidad.Argentino && (Dni <= 89999999 && Dni >= 1))
                {
                    returnAux = Dni;

                }
            }
            return returnAux;

        }

        #region Constructor

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.Nacionalidad = nacionalidad;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.StringToDni = dni;
            

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, dni.ToString(), nacionalidad) { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this(nombre, apellido, "1", nacionalidad)
        {


            Random random = new Random();

            this.DNI = random.Next(1, 89999999);
            

        }

        public Persona() : this("Unknow", "Unknow", ENacionalidad.Extreangero)
        {
                
        }

        #endregion

        #endregion

        #region Operators


        #endregion


    }



    public abstract class Universitario : Persona
    {

        #region Fields

        private int _legajo;



        #endregion


        #region Propeties




        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            bool returnAux = false;

            if((Object) obj != null)
            { 

                if(this.GetType() == obj.GetType())
                {
                    if (this._legajo == ((Universitario)obj)._legajo) returnAux = true;
                }
            }


            return returnAux;
        }

        #region Constructor

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