using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luchador
{
    public abstract class Fighter
    {

        #region Fields

        protected string _name;

        protected int _hp;

        protected int _tension;

        protected EstatePlayer _estate;

        protected List<Combo> _combos;

        protected List<Input> _moves;

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

        public EstatePlayer Estate
        {
            get
            {
                return this._estate;
            }

        }


        #endregion

        #region Methods

        #region Constructor

        public Fighter(string name, int hp, int tension)
        {

            this._name = name;
            this._hp = hp;
            this._tension = tension;

            this._combos = new List<Combo>();

            this._moves = new List<Input>();
                    
                    ///INPUTS\\\
            ///GROUND
            this._moves.Add(new Input("5P", "Punch", EstatePlayer.Ground));
            this._moves.Add( new Input("6P", "Forward Punch", EstatePlayer.Ground));
            this._moves.Add( new Input("5K", "Kick", EstatePlayer.Ground));
            this._moves.Add(new Input("c.S", "Close Slash", EstatePlayer.Ground));
            this._moves.Add(new Input("f.S", "Full Slah", EstatePlayer.Ground));
            this._moves.Add(new Input("5HS", "Heavy Slash", EstatePlayer.Ground));
            this._moves.Add(new Input("6HS(throw)", "Throw", EstatePlayer.Ground));
            this._moves.Add(new Input("6HS", "Forward Heavy Slash", EstatePlayer.Ground));
            this._moves.Add(new Input("D", "5Dust", EstatePlayer.Ground));
            this._moves.Add(new Input("4P+K", "Faultless Defense", EstatePlayer.Ground));
            this._moves.Add(new Input("S+HS", "Instant Block", EstatePlayer.Ground));
            this._moves.Add(new Input("P+K+S+SH", "InstantKill Mode", EstatePlayer.Ground));
            this._moves.Add(new Input("P+K+S", "Roman Cancel", EstatePlayer.Ground));

            ///CROUNCH
            this._moves.Add(new Input("2P", "Crounch Punch", EstatePlayer.Crounch));
            this._moves.Add(new Input("2K", "Crounch Kick", EstatePlayer.Crounch));
            this._moves.Add(new Input("2S", "Crounch Slash", EstatePlayer.Crounch));
            this._moves.Add(new Input("2HS", "crounch Heavy Slash", EstatePlayer.Crounch));
            this._moves.Add(new Input("2D", "Crounch Dust", EstatePlayer.Crounch));
            this._moves.Add(new Input("1P+K", "Crounch Faultless Defense", EstatePlayer.Crounch));

            ///AIR
            this._moves.Add(new Input("5j.P", "Jump Punch", EstatePlayer.Air));
            this._moves.Add(new Input("5j.K", "Jump Kick", EstatePlayer.Air));
            this._moves.Add(new Input("5j.S", "Jump Slash", EstatePlayer.Air));
            this._moves.Add(new Input("5j.HS","Jump Heavy Slash", EstatePlayer.Air));
            this._moves.Add(new Input("6j.H(throw)", "Air Throw", EstatePlayer.Air));
            this._moves.Add(new Input("5j.D", "Jump Dust", EstatePlayer.Air));


        }

        #endregion

        #endregion

        #region Operators


        #endregion


    }
}
