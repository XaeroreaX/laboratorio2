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

        protected int _hp;

        protected int _tension;

        protected List<Combo> _combos;

            #region Inputs
            //ground
            protected Input _punch;

            protected Input _forwardPunch;

            protected Input _kick;

            protected Input _closeSlash;

            protected Input _fullSlash;

            protected Input _heavySlash;

            protected Input _forwardHeavySlash;
            
            protected Input _dust;

            protected Input _throw;

            protected Input _faultlessDefense;

            protected Input _instantBlock;

            protected Input _instantBlockHold;

            protected Input _activeInstaKill;

            protected Input _RomanCancel;



            //crounch
            protected Input _crounchPucnh;

            protected Input _crounchKick;

            protected Input _crounchSlash;

            protected Input _crounchHeavySlash;

            protected Input _crounchDust;

            protected Input _crounchFaultlessDefense;

            //air
            protected Input _jumpPunch;

            protected Input _jumpKick;

            protected Input _jumpSlash;

            protected Input _jumpHeavySlash;

            protected Input _jumpDust;

            protected Input _jumpThrow;

            protected Input _jumpInstantBlock;

            protected Input _jumpFaultlessDefense;

            #endregion

        #endregion


        #region Propeties

        public int Tension
        {
            get { return this._tension; }


            set
            {
                this._tension = value;
                if(this._tension > 100)
                {
                    this._tension = 100;
                }
            }

        }


        #endregion

        #region Methods

        #region Constructor

        public Luchador(string name, int hp, int tension)
        {

            this._name = name;
            this._hp = hp;
            this._tension = tension;

            this._combos = new List<Combo>();
                    
                    ///INPUTS\\\
            ///GROUND
            this._punch = new Input("5P", "Punch");
            this._forwardPunch = new Input("6P", "Forward Punch");
            this._kick = new Input("5K", "Kick");
            this._closeSlash = new Input("c.S", "Close Slash");
            this._fullSlash = new Input("f.S", "Full Slah");
            this._heavySlash = new Input("5HS", "Heavy Slash");
            this._throw = new Input("6H(throw)", "Throw");
            this._forwardHeavySlash = new Input("6HS", "Forward Heavy Slash");
            this._dust = new Input("D", "5Dust");
            this._faultlessDefense = new Input("4P+K", "Faultless Defense");
            this._instantBlock = new Input("S+HS", "Instant Block");
            this._activeInstaKill = new Input("P+K+S+SH", "InstantKill Mode");
            this._RomanCancel = new Input("P+K+S", "Roman Cancel");

            ///CROUNCH
            this._crounchPucnh = new Input("2P", "Crounch Punch");
            this._crounchKick = new Input("2K", "Crounch Kick");
            this._crounchSlash = new Input("2S", "Crounch Slash");
            this._crounchHeavySlash = new Input("2HS", "crounch Heavy Slash");
            this._crounchDust = new Input("2D", "Crounch Dust");
            this._crounchFaultlessDefense = new Input("1P+K","Crounch Faultless Defense");

            ///AIR
            this._jumpPunch = new Input("5j.P", "Jump Punch");
            this._jumpKick = new Input("5j.K", "Jump Kick");
            this._jumpSlash = new Input("5j.S", "Jump Slash");
            this._jumpHeavySlash = new Input("5j.HS","Jump Heavy Slash");
            this._jumpThrow = new Input("6j.H(throw)", "Air Throw");
            this._jumpDust = new Input("5j.D", "Jump Dust");


        }

        #endregion

        #endregion

        #region Operators


        #endregion


    }
}
