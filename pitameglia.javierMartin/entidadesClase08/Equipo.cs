using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase08
{
    public class Equipo
    {
        private short cantidadDeJugadores;

        private List<jugador> jugadores;

        private string nombre;

        //////////////////////////////////////////////////////////////////////////////////////////CONSTRUCTORES

        public Equipo(short cantidadMax, string Nombre)
        {
            jugadores = new List<jugador>();

            this.cantidadDeJugadores = cantidadMax;

            this.nombre = Nombre;
        }

        public Equipo() : this(5, "Equipo neutro") { }

        //////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////////////////////////////GETTERS

        public List<jugador> getJugadores()
        {
            return this.jugadores;
        }

        //////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////////////////////////////SOBRECARGA

        public static bool operator +(Equipo equipo, jugador jugador)
        {
            bool returnAux = false;
            


            if ((object)equipo == null || (object)jugador == null) return returnAux;

            if (equipo.jugadores.Count() == equipo.cantidadDeJugadores) return returnAux;

            foreach (jugador element in equipo.jugadores)
            {
                if (jugador == element) return returnAux;

            }

            returnAux = true;
            equipo.jugadores.Add(jugador);


           return returnAux;
        }


        //////////////////////////////////////////////////////////////////////////////////////////


    }
}
