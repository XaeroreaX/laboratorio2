using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string nombre;
        public int stock;

        public Producto(string _nombre, int _stock)
        {
            this.nombre = _nombre;
            this.stock = _stock;

        }

        public override bool Equals(object obj)
        {

            return (Producto)obj == this;
        }

        public static bool operator ==(Producto one, Producto two)
        {
            bool returnAux = false;

            if((object)one != null && (object)two != null)
                if (one.nombre == two.nombre) returnAux = true;

            return returnAux;

        }


        public static bool operator!=(Producto one, Producto two)
        {

            if ((object)one == null || (object)two == null) return false;


            return !(one == two);


        }

    }


    public class Deposito
    {
        private int _cantidad;

        public Producto[] productos;

        public Deposito(int cantidad)
        {
            this._cantidad = cantidad;

            this.productos = new Producto[cantidad];
        }

        public Deposito() : this(3) { }

        public static Producto[] operator +(Deposito one, Deposito two)
        {
            Producto[] aux = default(Producto[]);

            bool flag = false;

            if ((object)one != null && (object)two != null)
            {

                aux = new Producto[one.productos.Length + two.productos.Length];

                one.productos.CopyTo(aux, 0);
                for (int i = 0; i < two.productos.Length; i++)
                {
                    if (aux.Contains(two.productos[i]))
                    {
                        flag = true;
                        for (int j = 0; j < aux.Length; j++) if (aux[j] == two.productos[i]) aux[j].stock += two.productos[i].stock;
                    }

                    for(int j = 0; flag == false && j < aux.Length; j++)
                    {

                        if((object)aux[j] == null)
                        {
                            flag = true;

                            aux[j] = two.productos[i];

                        }

                    }

                    flag = false;

                }
                


            }


           return aux;
        }

    }
}
