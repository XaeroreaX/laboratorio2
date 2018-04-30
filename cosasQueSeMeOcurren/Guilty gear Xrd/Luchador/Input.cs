using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using geometria;

namespace Luchador
{
    public class Input
    {

        #region Fields

        private string _entrada;

        private string _name;

        private int _damage;

        private int _TotalHit;

                                                                                                                                                                                                        //private int _cantGolpes;

                                                                                                                                                                                                        //private string _conectadoPor;

                                                                                                                                                                                                        //private List<string> _conecta;

                                                                                                                                                                                                        //private bool _air;

                                                                                                                                                                                                        //private bool _crounch;

                                                                                                                                                                                                        //private rectangulo _hitBox;


        #endregion


        #region Propeties


        #endregion

        #region Methods

        #region Constructor

        public Input(string entrada, string name)
        {
            this._entrada = entrada;
            this._name = name;
            this._damage = 0;

        }

        #endregion

        #endregion

        #region Operators

        public static implicit operator string(Input input)
        {

            return input._entrada;
        }

        #endregion



    }
}
