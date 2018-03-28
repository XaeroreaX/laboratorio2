using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class punto
    {

        private int x;
        private int y;

        public punto(int X, int Y)
        {
            this.SetX(X);
            this.SetY(Y);
        }

        // GETTERS
        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }


        // SETTERS
        public void SetX(int n)
        {
            this.x = n;
        }

        public void SetY(int n)
        {
            this.y = n;
        }


    }
}
