using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class punto
    {

        private int _x;
        private int _y;


        public int Y
        {

            get
            {
                return this._y;

            }

            set
            {
                this._y = value;

            }

        }


        public int X
        {

            get
            {
                return this._x;

            }

            set
            {
                this._x = value;

            }

        }

        public punto(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

       

    }
}
