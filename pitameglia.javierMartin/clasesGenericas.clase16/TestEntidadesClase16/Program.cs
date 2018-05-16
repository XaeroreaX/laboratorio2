using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DepositoGenerico;
using ItemsDeposito;

namespace TestEntidadesClase16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>();

            autos.Add(new Auto("rojo", "toyota"));
            autos.Add(new Auto("verde", "Zwei hander"));

            Deposito<Auto> DepsitoDeAutos = new Deposito<Auto>(5);

            DepsitoDeAutos.agregar(autos[0]);
            DepsitoDeAutos.agregar(autos[1]);

            Console.WriteLine(DepsitoDeAutos.ToString());

            Console.ReadKey();
        }
    }
}
