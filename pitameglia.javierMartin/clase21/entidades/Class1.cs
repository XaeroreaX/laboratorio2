using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace entidades
{
    public class Persona
    {

        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _id;


        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }

        public int Edad { get { return this._edad; } set { this._edad = value; } }

        public int Id { get { return this._id; } }


        public Persona(string nombre, string apellido, int edad, int id)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._id = id;
            

        }


        public Persona(string nombre, string apellido, int edad) : this(nombre, apellido, edad, 1) { }


        public List<Persona> TraerTodos()
        {

            List<Persona> Personas = new List<Persona>();
           
   
            SqlConnection sql = new SqlConnection(Properties.Settings.Default.connection);

            SqlCommand sqlc = new SqlCommand("SELECT [id], [nombre], [apellido], [edad] FROM Personas", sql);

              

            sql.Open();

            SqlDataReader reader = sqlc.ExecuteReader();

            while (reader.Read())
            {
                
                

                Console.WriteLine(reader[0].ToString());
                Personas.Add(new Persona(reader[1], reader[2], reader[3], reader[0]));
                

            }

            sql.Close();

            return null;
        }

        

    
        public  string connection { get; set; }}
}
