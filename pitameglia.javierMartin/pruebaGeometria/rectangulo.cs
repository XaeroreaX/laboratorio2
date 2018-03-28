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



            largo = this.vertice4.GetX() - this.vertice1.GetX();
            ancho = this.vertice2.GetY() - this.vertice1.GetY();

            this.area = (float) ancho * largo;
            return this.area;
        }

        public float Perimetro()
        {
            int largo;
            int ancho;

           

            largo = this.vertice4.GetX() - this.vertice1.GetX();
            ancho = this.vertice2.GetY() - this.vertice1.GetY();

            this.perimetro = 2 * (largo + ancho);

            return this.perimetro;
        }


        public rectangulo(punto Vertice1, punto Vertice3)
        {     
           

            this.vertice1 = Vertice1;
            this.vertice3 = Vertice3;


            this.vertice2 = new punto(this.vertice1.GetX(), this.vertice3.GetY());

            this.vertice4 = new punto(this.vertice3.GetX(), this.vertice1.GetY());


        }

    }
}
