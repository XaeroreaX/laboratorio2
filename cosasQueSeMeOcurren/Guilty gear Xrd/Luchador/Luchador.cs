using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luchador
{
    public abstract class Luchador
    {

        #region Fields

        protected string _name;



        //ground
        protected Input _punch;

        protected Input _kick;

        protected Input _closeSlash;

        protected Input _fullSlash;

        protected Input _heavySlash;

        protected Input _dust;



        //crounch
        protected Input _crounchPucnh;

        protected Input _crounchKick;

        protected Input _crounchSlash;

        protected Input _crounchHeavySlash;

        //air
        protected Input _jumpPucnh;

        protected Input _jumpKick;

        protected Input _jumpSlash;

        protected Input _jumpHeavySlash;



        protected Input _RomanCancel;


        #endregion


        #region Propeties


        #endregion

        #region Methods

        #region Constructor

        #endregion

        #endregion

        #region Operators


        #endregion


    }
}
