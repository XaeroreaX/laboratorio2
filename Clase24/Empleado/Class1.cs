using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{

    public delegate void DelSueldoCero();

    public delegate void delClienteSueldo(double sueldo, Empleado enLaMira);

    public delegate void delClienteSueldoMejorado(Empleado enLaMira, EmpleadoEventArgs sueldo);


    public class Empleado
    {

        public string _nombre;
        public string _apellido;
        public int _dni;
        private double _sueldo;


        public event DelSueldoCero SueldoCero;

        public event delClienteSueldo muchaPlata;


        public event delClienteSueldoMejorado muchaPlataMejorado;



        public Empleado(string nombre, string apellido, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;

        }


        private void SeVaAForrar(double sueldo, Empleado miEmpleado)
        {

            Console.WriteLine("el empleado:\n" + miEmpleado.ToString() + "quiere cobrar:" + sueldo);

        }

        private void SeVaAForrarMejorado(Empleado enLaMira, EmpleadoEventArgs sueldo)
        {
            Console.WriteLine("el empleado:\n" + enLaMira.ToString() + "quiere cobrar:" + sueldo.ToString());

        }

        private void ManejadorEvento()
        {
            Console.WriteLine("entraste a el evento!!!");

        }

        public override string ToString()
        {

            string toString = "NAME: " + this._nombre + "\n";
            toString += "LAST NAME" + this._apellido + "\n";
            toString += "DNI:" + this._dni + "\n";
            

            return toString;
        }


        public double Sueldo 
        {
            get
            {

                return this._sueldo;
            }
            set
            {
                if (value < 0)
                {
                    throw new SueldoNegativoException();

                }
                else if(value == 0) 
                {
                    this.SueldoCero += new DelSueldoCero(ManejadorEvento);

                    this.SueldoCero.Invoke();

                }
                else if (value > 10000)
                {

                    muchaPlataMejorado += new delClienteSueldoMejorado(SeVaAForrarMejorado);

                    muchaPlataMejorado.Invoke(this, new EmpleadoEventArgs(value));

                }
                else this._sueldo = value;

            }
        }


        

        
    }


    public class EmpleadoEventArgs : EventArgs
    {

        public double Sueldo
        {
            get;
            set;

        }


        public EmpleadoEventArgs(double sueldo)
        {

            Sueldo = sueldo;

        }

        public override string ToString()
        {
            return Sueldo.ToString();
        }



    }


   

}
