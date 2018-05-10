using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HITS
{


    public class IntHit
    {
        #region Fields

        private int _hits;

        private int _damage;

        #endregion


        #region Propeties

        public int Hits
        {

            get
            {
                return this._hits;
            }

        }

        public int Damage
        {
            get
            {
                return this._damage;
            }
        }

        #endregion

        #region Methods

        #region Constructor

        public IntHit(int damage, int hits)
        {
            this._damage = damage;
            this._hits = hits;

        }

        public IntHit() : this(0, 0) { }

        #endregion

        #endregion

        #region Operators

        


        #endregion



    }

    public class Input
    {

        #region Fields

        private string _input;

        private string _name;

        private List<int> _hits; // daño por golpe

        private EstatePlayer _estate;

        //private string _conectadoPor;
        //private List<string> _conecta;




        //private rectangulo _hitBox;


        #endregion


        #region Propeties



        #endregion

        #region Methods

        #region Constructor

        public Input(string input, string name, EstatePlayer estate)
        {
            this._input = input;
            this._name = name;
            this._estate = estate;

            this._hits = new List<int>();

        }

        public Input(string input, string name) : this(input: input, estate: EstatePlayer.Ground, name: name)
        { }


        #endregion

        #endregion

        #region Operators

        public static implicit operator string(Input input)
        {

            return input._input;
        }

        public static Input operator +(Input input, int hit)
        {
            if ((object)input != null) input._hits.Add(hit);

            return input;

        }

        public static bool operator ==(Fighter fighter, Input input)
        {
            bool returnAux = false;

            if ((object)fighter == null)
            {
                return returnAux;
            }
            else if ((object)input == null) return returnAux;

            if (fighter.Estate == input._estate) returnAux = true;


            return returnAux;

        }

        public static bool operator !=(Fighter fighter, Input input)
        {

            bool returnAux = false;

            if ((object)fighter == null)
            {
                return returnAux;
            }
            else if ((object)input == null) return returnAux;

            returnAux = !(fighter == input);

            return returnAux;

        }



        #endregion



    }

    public class Combo
    {

        #region Fields

        

        private List<Input> _combo;

        private IntHit _damage;

         


        #endregion

       
        
        


        #region Propeties

        public IntHit Damage
        {

            get
            {
                return this._damage;
            }

            set
            {
                this._damage = value;

            }
        }


        #endregion

        #region Methods

        #region Constructor

        #endregion

        #endregion

        #region Operators

        #endregion

    }
}
