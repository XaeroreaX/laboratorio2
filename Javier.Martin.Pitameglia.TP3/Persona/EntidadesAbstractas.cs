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

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }

        public int DNI {
            get { return this._dni; }

            set {

                this._dni = Persona.ValidarDni(value.ToString(), this._nacionalidad);
                
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

        protected virtual string MostrarDatos()
        {

            string message = base.ToString(); ;

            message += "\nLEGAJO"+this._legajo+"\n";

            return message;

        }

        protected abstract string ParticiparEnClase();

        #region Constructor


        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre: nombre, dni: dni, apellido: apellido, nacionalidad: nacionalidad) { this._legajo = legajo; }

        public Universitario() : this(1, "Unknow", "Unknow", "0", ENacionalidad.Argentino) { }

        #endregion

        #endregion

        #region Operators

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool returnAux = false;

            if((object) pg1 != null && (object) pg2 != null)
            {

                returnAux = pg1.Equals((object)pg2);


            }


            return returnAux;

        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            bool returnAux = false;

            if ((object)pg1 != null && (object)pg2 != null)
            {
                returnAux = !(pg1 == pg2);
            }

            return returnAux;
        }

        #endregion


    }



    public sealed class Alumno : Universitario
    {

        public enum EEstadoCuenta { AlDia, Deudor, Becado}

        public enum EClase { Programacion, Lavoratorio, Legislacion, SPD}


        #region Fields


        private EClase _claseQueToma;

        private EEstadoCuenta _estadoCuenta;


        #endregion


        #region Methods


        protected override string MostrarDatos()
        {
            string message = "Alumno:\n";

            message += base.MostrarDatos();

            message += "\nESTADO DE CUENTA" + this._estadoCuenta.ToString() + "\n";
            message += "TOMA CLASE DE" + this._claseQueToma.ToString()+"\n";

            return message;
        }

        protected override string ParticiparEnClase()
        {
            throw new NotImplementedException();
        }


        #region Constructor

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClase claseQueToma, EEstadoCuenta estadoCuenta) : base(legajo: id, nacionalidad:nacionalidad, apellido: apellido, nombre: nombre, dni: dni)
        {

            this._claseQueToma = claseQueToma;
            this._estadoCuenta = estadoCuenta;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClase claseQueToma) : this(nombre: nombre,apellido: apellido, nacionalidad: nacionalidad, dni: dni, id: id, claseQueToma: claseQueToma, estadoCuenta: EEstadoCuenta.AlDia) { }

        public Alumno() : this(id: 1, nombre: "Unknow", apellido: "Unknow", nacionalidad: ENacionalidad.Argentino, claseQueToma: EClase.Programacion, dni:"45") { }

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