using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace Persona
{
    public class Universidad
    {
    }

    public class Jornada
    {


        #region Fields

        private List<Alumno> _alumnos;

        private EClase _clase;

        private Profesor _instructor;


        #endregion


        #region Propeties

        public List<Alumno> Alumnos { get { return this._alumnos; } set { this._alumnos = value; } }

        public EClase Clase { get { return this._clase; } set { this._clase = value; } }

        public Profesor Instructor { get { return this._instructor; } set{ this._instructor = value; } }

        #endregion

        #region Methods

        #region Constructor

        #endregion

        #endregion

        #region Operators


        #endregion

    }

}
