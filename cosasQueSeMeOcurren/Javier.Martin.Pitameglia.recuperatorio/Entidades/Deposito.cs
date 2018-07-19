using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using ArchivosPity;

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
        protected int _cantidad;

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


 
    public class DepositoHeredado : Deposito, ISerializar, Interface2
    {
        public Deposito deposito;

        

        public DepositoHeredado() : base()
        {
            this.deposito = new Deposito(this._cantidad);
            this.deposito.productos = this.productos;
        }

        public DepositoHeredado(int cantidad) : base(cantidad)
        {
            this.deposito = new Deposito(cantidad);
            this.deposito.productos = this.productos;
        }

        public bool guardar(string path)
        {
            bool returnAux = true;
            

            try
            {

                TextWriter tw = new StreamWriter(path, false);
                XmlSerializer objXml = new XmlSerializer(typeof(Deposito));

                objXml.Serialize(tw, this);
                tw.Close();

                // _XML.Save(@"C:\Users\jmpit\source\repos\Javier.Martin.Pitameglia.recuperatorio\" + name, this);
            }

            catch(Exception EX)
            {
                returnAux = false;
            }

            return returnAux;
        }

        bool Interface2.leer(string path, out Deposito _deposito)
        {
            bool returnAux = true;
            

            try
            {
                TextReader tr = new StreamReader(path);
                XmlSerializer objXml = new XmlSerializer(typeof(Deposito));

                _deposito = (Deposito)objXml.Deserialize(tr);
                tr.Close();

                base.productos = _deposito.productos;

                //_XML.Load(@"C:\Users\jmpit\source\repos\Javier.Martin.Pitameglia.recuperatorio\" + name, out deposito);
            }

            catch(Exception EX)
            {
                returnAux = false;
                _deposito = default(DepositoHeredado);
            }


            return returnAux;
        }
    }


    public interface ISerializar { bool guardar(string name); }

    public interface Interface2 { bool leer(string name, out Deposito deposito); }

}
