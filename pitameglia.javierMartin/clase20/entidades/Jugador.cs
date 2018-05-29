using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace entidades
{

    public enum EPuesto{ Arquero, Defensor, Delantero, ElDelMedio,}

    [Serializable]
    public class Jugador : ISerializableBinario, ISerializableXML
    {
        

        #region Fields

        private string _nombre;
        private string _apellido;
        private EPuesto _puesto;


        #endregion


        #region Propeties


        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }

        public EPuesto Puesto { get { return this._puesto; } set { this._puesto = value; } }

        #endregion

        #region Methods

        public override string ToString()
        {
            string toString = "DATOS DEL JUGADOR:\nNOMBRE:" + this._nombre+"\n";

            toString += "APELLIDO:"+this._apellido+"\n";

            toString += "PUESTO:"+this._puesto.ToString();

            return toString;
        }

        void ISerializableBinario.Serializar(string path)
        {
            FileStream File = new FileStream(@path, FileMode.Create);

            BinaryFormatter Serializador = new BinaryFormatter();

            Serializador.Serialize(File, this);

            File.Close();
        }


        List<Jugador> ISerializableBinario.Deserializar(string path)
        {

            List<Jugador> jugadorReturn = new List<Jugador>();

            FileStream File = new FileStream(@"D:\VisualStudio\clase20\GuardarJugador\bin\Debug\FileJugador.dat", FileMode.Open);

            BinaryFormatter deSerializador = new BinaryFormatter();


            jugadorReturn.Add((Jugador)deSerializador.Deserialize(File));

            File.Close();

            return jugadorReturn;
        }

        #region Constructor

        public Jugador() : this("tincho", "pity", EPuesto.Defensor) { }

        public Jugador(string nombre, string apellido, EPuesto puesto)
        {
            this._nombre = nombre;

            this._apellido = apellido;

            this._puesto = puesto;

        }

        #endregion

        #endregion


        void ISerializableXML.Serializar()
        {
            throw new NotImplementedException();
        }

        Jugador ISerializableXML.Deserializar()
        {
            throw new NotImplementedException();
        }
    }
}
