using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Entidades._31_10_17
{
    public class ProveedorDeDatos
    {
        public static SqlConnection _miObjeto;
        public ProveedorDeDatos()
        {

            _miObjeto = new SqlConnection(Properties.Settings.Default.Connection);

        }

        public static List<Persona> ObtenerPersonasBD()
        {            
            SqlCommand sc = new SqlCommand();
            sc.Connection = _miObjeto;
            sc.CommandType = CommandType.Text;
            sc.CommandText= ("SELECT id, nombre, apellido, edad FROM Personas");
            _miObjeto.Open();
            SqlDataReader Dr = sc.ExecuteReader();// new SqlDataReader();
            
            //Dr = sc.ExecuteReader();//recorro y los elementos se eliminan, solo se puede avanza
            List<Persona> lista = new List<Persona>();
            while (Dr.Read())
            {
                //(Dr[0])//retorna un object. Tambien se puede usar (dr["nombre])
                 Persona persona = new Persona((int)(Dr[0]),Dr[0].ToString(),Dr[0].ToString(),(int)Dr[0]);
                 lista.Add(persona);
            }
            Dr.Close();
            _miObjeto.Close();
            return lista;
           //string cadena =("SELECT id, nombre, apellido, edad FROM Persona");

        }

        public Persona ObtenerPersonaPorIdBD(Persona persona)
        {
            List<Persona> lista = new List<Persona>();
            lista = ObtenerPersonasBD();
            foreach (Persona p in lista)
            {
                if (p.id == persona.id)
                {
                    return p;
                }
            }

            return null;

        }

        public bool AgregarPersonaBD(Persona persona)
        {
            //Insert into tabla (campos) pongo en campos listado de columnas a las cuales les voy a pasar valores
            // en campos todos menor ID (nombre, apellido, edad)
            // values('jose', 'garcia', 25)
            try
            {
                SqlCommand sc = new SqlCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = ("INSERT INTO Personas (nombre, apellido, edad) VALUES ('" + persona.nombre + "','" + persona.apellido + "'," + persona.edad + ")");
                sc.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EliminarPersonaBD(Persona persona)
        {
             try
            {
                SqlCommand sc = new SqlCommand();
                _miObjeto.Open();
                sc.Connection = _miObjeto;
                
                sc.CommandType = CommandType.Text;
                
                sc.CommandText = ("DELETE FROM Personas WHERE id="+persona.id);
                sc.ExecuteNonQuery();
                _miObjeto.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //objeto datatable replica una tabla de base de datos en memoria
        public DataTable ObtenerPersonasBD(bool bol)
        {
            DataTable data = new DataTable("Datatable Personas");
            SqlCommand sc = new SqlCommand();
            sc.Connection = _miObjeto;
            sc.CommandType = CommandType.Text;
            sc.CommandText = ("SELECT id, nombre, apellido, edad FROM Personas");
            _miObjeto.Open();

            SqlDataReader dataReader = sc.ExecuteReader();       
            data.Load(dataReader);
            _miObjeto.Close();
            dataReader.Close();
            return data;

        }
        public bool ModificarPersonaBD(Persona persona)
        {
            try
            {
                SqlCommand sc = new SqlCommand();

                sc.CommandType = CommandType.Text;
                sc.CommandText = ("UPDATE FROM Personas SET nombre='" + persona.nombre + ",apellido='" + persona.apellido + ",edad=" + persona.edad + " WHERE id=" + persona.id);//entre comillias simples campos string y date
                sc.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static List<Persona> ObtenerPersonasHC()
        {
            List<Persona> lista = new List<Persona>();
            Persona p1 = new Persona(0, "carlos", "Perez", 20);
            Persona p2 = new Persona(1, "jose", "marquez", 20);
            Persona p3 = new Persona(2, "pablo", "ruiz", 20);
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            return lista;

        }

        public static Persona ObtenerPorId(int id)
        {
            List<Persona> lista = new List<Persona>();
            lista = ObtenerPersonasHC();
            foreach (Persona p in lista)
            {
                if (p.id == id)
                {
                    return p;
                }
            }

            return null;
        }
        //DEVUELVE Un objeto de tipo person a y invoca a obeçtener persona y busca por id, si encuentra retorna objeto persona sino null

        public static bool AgregarPersona(Persona persona)
        {
            List<Persona> lista = new List<Persona>();
            lista = ObtenerPersonasHC();
            foreach (Persona p in lista)
            {
                if (p.id == persona.id)
                {
                    return false;
                }
            }

            lista.Add(persona);
            return true;
        }//llama a obtener persona Hc agrega un nuevo objeto en esa lista, true si lo pudo agregar sino false

        public static bool ModificarPersona(Persona persona)
        {
            List<Persona> lista = new List<Persona>();
            lista = ObtenerPersonasHC();
            int i = 0;
            foreach (Persona p in lista)
            {
                if (persona.id == p.id)
                {
                    lista[i] = persona;
                    return true;
                }
                i++;
            }

            return false;

        }

        public static bool EliminarPersona(Persona persona)
        {
            List<Persona> lista = new List<Persona>();
            lista = ObtenerPersonasHC();
            int i = 0;
            foreach (Persona p in lista)
            {
                if (persona == p)
                {
                    lista.RemoveAt(i);
                    return true;
                }
                i++;
            }

            return false;

        }
    }
}
