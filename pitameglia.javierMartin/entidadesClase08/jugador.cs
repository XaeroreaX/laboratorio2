using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClase08
{
    public class jugador
    {

        private long dni;
        private string nombre;
        private int partidasJugadas;
        private float promedioGoles;
        private int totalGoles;


        public long DNI { get { return this.dni; } set { this.dni = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int PartidasJugadas { get { return this.partidasJugadas; } set { this.partidasJugadas = value; } }
        public float PromedioGoles { get { return this.promedioGoles; } set { this.promedioGoles = value; } }
        public int TotalGoles { get { return this.totalGoles; } set { this.totalGoles = value; } }


        //////////////////////////////////////////////////////////////////////////////////////////CONSTRUCTORES

        

        public jugador(long DNI, string NOMBRE)
        {
            this.dni = DNI;
            this.nombre = NOMBRE;
            this.partidasJugadas = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;

        }


        public jugador(long DNI, string NOMBRE, int PARTIDASJUGADAS, int TOTALGOLES) : this(DNI, NOMBRE)
        {
            
            this.partidasJugadas = PARTIDASJUGADAS;
            this.totalGoles = TOTALGOLES;
            this.promedioGoles = this.getPromedioGoles();

        }

        public jugador() : this(1000000, "fulanito", 0, 0) { }

        //////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////////////////////////////METODOS

        public float getPromedioGoles()
        {
            float returnAux = 0;

            returnAux = (float)totalGoles/partidasJugadas;

            return returnAux;
        }

        public string showData()
        {
            return "Jugador: " + this.nombre + "\nDNI: " + this.dni + "\nPartidas Jugadas: " + this.partidasJugadas + "\nGoles Totales: "+this.totalGoles+"\nPronedio de goles por partida: "+this.promedioGoles;
        }


        //////////////////////////////////////////////////////////////////////////////////////////




        //////////////////////////////////////////////////////////////////////////////////////////SOBRECARGAS

        public static bool operator ==(jugador A, jugador B)
        {
            bool returnAux = false;
            if ((object)A == null || (object)B == null) return returnAux;


            if (A.dni == B.dni) returnAux = true;

            return returnAux;
        }


        public static bool operator !=(jugador A, jugador B)
        {
            if (!(A == B)) return true;

            return false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////
    }
}
