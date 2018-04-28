using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    class rectangulo
    {
        private float area;
        private float perimetro;

        private punto vertice1;
        private punto vertice2;
        private punto vertice3;
        private punto vertice4;

        public float Area()
        {

            int largo;
            int ancho;



            largo = this.vertice4.X - this.vertice1.X;
            ancho = this.vertice2.Y - this.vertice1.Y;

            this.area = (float) ancho * largo;
            return this.area;
        }

        public float Perimetro()
        {
            int largo;
            int ancho;

           

            largo = this.vertice4.X - this.vertice1.X;
            ancho = this.vertice2.Y - this.vertice1.Y;

            this.perimetro = 2 * (largo + ancho);

            return this.perimetro;
        }


        public rectangulo(punto Vertice1, punto Vertice3)
        {     
           

            this.vertice1 = Vertice1;
            this.vertice3 = Vertice3;


            this.vertice2 = new punto(this.vertice1.X, this.vertice3.Y);

            this.vertice4 = new punto(this.vertice3.X, this.vertice1.Y);


        }

    }
}
