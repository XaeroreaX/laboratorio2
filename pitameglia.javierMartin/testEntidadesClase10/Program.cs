using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidadesClase10;


namespace testEntidadesClase10
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero elLavadero;
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            Auto[] autos = new Auto[3];

            Camion[] camiones = new Camion[3];

            Moto[] motos = new Moto[3];



            autos[0] = new Auto(4, "rey-345", 4, EMarca.Fiat);
            autos[1] = new Auto(4, "zzz-785", 4, EMarca.Iveco);
            autos[2] = new Auto(2, "fds-354", 5, EMarca.Fiat);


            camiones[0] = new Camion(5, "fds-345", 4, EMarca.Scania);
            camiones[1] = new Camion(5, "fds-345", 4, EMarca.Scania);
            camiones[2] = new Camion(5, "fds-345", 4, EMarca.Scania);

            motos[0] = new Moto(5, "fds-345", 4, EMarca.Scania);
            motos[1] = new Moto(5, "fds-345", 4, EMarca.Scania);
            motos[2] = new Moto(5, "fds-344", 4, EMarca.Scania);

            bool miBool = motos[1].Equals(motos[2]);

            if (miBool == true) Console.WriteLine("ES TRUE!!!");

            vehiculos.Add(autos[1]);
            vehiculos.Add(camiones[2]);
            vehiculos.Add(autos[0]);
            vehiculos.Add(motos[0]);
            vehiculos.Add(motos[1]);
            vehiculos.Add(camiones[0]);
            vehiculos.Add(camiones[1]);
            vehiculos.Add(autos[2]);
            vehiculos.Add(motos[2]);

            elLavadero = new Lavadero(vehiculos, 4, 8, 2);

            Console.WriteLine(elLavadero.showLavadero);

            Console.ReadKey();

        }
    }
}
