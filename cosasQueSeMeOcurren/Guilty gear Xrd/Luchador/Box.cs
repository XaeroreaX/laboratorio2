using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class Box
    {
        #region Fields
        private float _area;
        private float _perimetro;

        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;

        #endregion        

        #region Propeties

        public Punto Vertice1 { get { return this._vertice1; } set { this._vertice1 = value; } }
        public Punto Vertice2 { get { return this._vertice2; } set { this._vertice2 = value; } }
        public Punto Vertice3 { get { return this._vertice3; } set { this._vertice3 = value; } }
        public Punto Vertice4 { get { return this._vertice4; } set { this._vertice4 = value; } }

        #endregion


        #region Methods
        public float Area()
        {

            int largo;
            int ancho;



            largo = this._vertice4.X - this._vertice1.X;
            ancho = this._vertice2.Y - this._vertice1.Y;

            this._area = (float) ancho * largo;
            return this._area;
        }

        public float Perimetro()
        {
            int largo;
            int ancho;

           

            largo = this._vertice4.X - this._vertice1.X;
            ancho = this._vertice2.Y - this._vertice1.Y;

            this._perimetro = 2 * (largo + ancho);

            return this._perimetro;
        }

        public void moveBox(Punto pocicion, DateTime time)
        {


        }

            #region Constructor
            public Box(Punto Vertice1, Punto Vertice3)
            {     
           

                this._vertice1 = Vertice1;
                this._vertice3 = Vertice3;


                this._vertice2 = new Punto(this._vertice1.X, this._vertice3.Y);

                this._vertice4 = new Punto(this._vertice3.X, this._vertice1.Y);


            }

        #endregion

        #endregion

        #region Operator

        public static Box operator +(Box box, Punto punto)
        {
            box.Vertice1 += punto;
            box.Vertice2 += punto;
            box.Vertice3 += punto;
            box.Vertice4 += punto;

            return box;

        }

        #endregion

    }
}
