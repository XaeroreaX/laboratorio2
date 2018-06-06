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

        public override string ToString()
        {

            string message = "nombre"+this._nombre+"\n";

            return message;
        }


        public Persona(string nombre, string apellido, int edad) : this(nombre, apellido, edad, 1) { }

        public bool Modificar()
        {

            bool returnAux = true;
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.connection);


                conexion.Open();

                SqlCommand command = new SqlCommand("UPDATE 'Personas' SET('nombre = '" + this._nombre + "', apellido = '" + this._apellido + "', edad = '" + this._edad + "') WHERE id = 3", conexion);

                conexion.Close();
            }

            catch (Exception miEx)
            {
                returnAux = false;

            }




            return returnAux;


        }

        public static bool Borrar(Persona persona)
        {

            bool returnAux = true;
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.connection);


                conexion.Open();

                SqlCommand command = new SqlCommand("Delete from 'Persona' where id 0" + persona._id, conexion);

                ///ExecutionNonQuery

                conexion.Close();
            }

            catch (Exception miEx)
            {
                returnAux = false;

            }


            

            return returnAux;
        }

        public bool Agregar()
        {

            bool returnAux = false;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.connection);


            conexion.Open();

            

            SqlCommand command = new SqlCommand("INSERT INTO tabla 'Persona'(nombre, apellido, edad)) Value('this._nombre', 'this._apellido', this._edad)", conexion);

            
            


            return returnAux;

        }

        public static List<Persona> TraerTodos()
        {

            int edad = 0, id = 0;

            List<Persona> Personas = new List<Persona>();
           
   
            SqlConnection sql = new SqlConnection(Properties.Settings.Default.connection);

            SqlCommand sqlc = new SqlCommand("SELECT [id], [nombre], [apellido], [edad] FROM Personas", sql);

              

            sql.Open();

            SqlDataReader reader = sqlc.ExecuteReader();

            while (reader.Read())
            {
                
                

                Console.WriteLine(reader[0].ToString());

                edad = int.Parse(reader[3].ToString());

                id = int.Parse(reader[0].ToString());

                Personas.Add(new Persona(reader[1].ToString(), reader[2].ToString(), edad, id));
                

            }

            sql.Close();

            return Personas;
        }

        public static Persona TraerTodos(int id)
        {

            int edad = 0, ids = 0;

        

            
            SqlConnection sql = new SqlConnection(Properties.Settings.Default.connection);

            SqlCommand sqlc = new SqlCommand("SELECT [id], [nombre], [apellido], [edad] FROM Personas WHERE id = 3", sql);



            sql.Open();

            SqlDataReader reader = sqlc.ExecuteReader();

            reader.Read();

            Console.WriteLine(reader[0].ToString());

            edad = int.Parse(reader[3].ToString());

            id = int.Parse(reader[0].ToString());

            Persona personita = new Persona(reader[1].ToString(), reader[2].ToString(), edad, id);

            sql.Close();

            return personita;

        }

        public static DataTable TraerTodosTabla()
        {


            List<Persona> Personas = new List<Persona>();

            DataTable table = new DataTable("Personas");

            SqlConnection sql = new SqlConnection(Properties.Settings.Default.connection);

            SqlCommand sqlc = new SqlCommand("SELECT [id], [nombre], [apellido], [edad] FROM Personas", sql);



            sql.Open();

            SqlDataReader reader = sqlc.ExecuteReader();

            

            table.Load(reader);

            

            sql.Close();

            return table;

        }

        

        

    
        public  string connection { get; set; }
        public static DataTable TraerTodosTable(int p)
        {
            throw new NotImplementedException();
        }
    }
}
