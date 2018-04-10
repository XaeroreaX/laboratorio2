using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidadesClase08;


namespace testEntidadesClase08
{
    class Program
    {
        static void Main(string[] args)
        {
            bool miBool;
            jugador []jugadores = new jugador[6];

           
           jugadores[0] = new jugador();
           jugadores[1] = new jugador(16458978,"nahuel",16, 32);
           jugadores[2] = new jugador(10654789, "atilio", 54,1110);
            jugadores[3] = new jugador(1065569, "atilio", 54, 1110);
            jugadores[4] = new jugador(10878789, "atilio", 54, 1110);
            jugadores[5] = new jugador(106987889, "atilio", 54, 1110);

            Equipo _equipo = new Equipo(5, "UNG");




            for(int i = 0; i < 6; i++)
            {
                miBool = _equipo + jugadores[i];

                Console.WriteLine(miBool);

            }


            List<jugador> miListaDeJugadores; new List<jugador>();

            miListaDeJugadores = _equipo.getJugadores();
            
            foreach(jugador element in miListaDeJugadores)
            {

                Console.WriteLine(element.showData());

            }


            Console.ReadKey();
        }
    }
}
