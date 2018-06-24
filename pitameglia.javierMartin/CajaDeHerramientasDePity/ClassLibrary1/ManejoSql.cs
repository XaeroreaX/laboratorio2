using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLpity
{

    public delegate T Constructor<T>(SqlDataReader oDr);

    public delegate string StringComanndSql<T>(T p);

    public class AccesoDatos<T>
    {
        #region Atributos
        private SqlConnection _conexion;
        private SqlCommand _comando;
        #endregion

        #region Constructores

        public AccesoDatos(string connection)
        {
            try
            {

            
                // CREO UN OBJETO SQLCONECTION
                this._conexion = new SqlConnection(connection);
                // CREO UN OBJETO SQLCOMMAND
                this._comando = new SqlCommand();
                // INDICO EL TIPO DE COMANDO
                this._comando.CommandType = System.Data.CommandType.Text;
                // ESTABLEZCO LA CONEXION
                this._comando.Connection = this._conexion;

            }

            catch(InvalidOperationException e)
            {

                this._conexion.Close();

                this._comando.Clone();


                throw e;
            }

            catch (Exception e)
            {

                this._conexion.Close();

                this._comando.Clone();

                throw e;
            }

        }
        #endregion

        #region Métodos

        #region Getters
        public List<T> ObtenerListaPersonas(Constructor<T> elConstructor, string comando)
        {
            bool TodoOk = false;
            List<T> lista = new List<T>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                _comando.CommandText = comando;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = _comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    lista.Add(elConstructor.Invoke(oDr));
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (TodoOk)
                    this._conexion.Close();
            }
            return lista;
        }

        public DataTable ObtenerTablaPersonas(string command)
        {
            bool TodoOk = false;
            DataTable tabla = new DataTable();

            try
            {
                // INDICO EL TIPO DE COMANDO
                this._comando.CommandType = System.Data.CommandType.Text;
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = command;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = this._comando.ExecuteReader();

                // CARGO LA TABLA CON REGISTROS...
                tabla.Load(oDr);

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    this._conexion.Close();
            }
            return tabla;
        }

        public T ObtenerPersonaPorID(Constructor<T> elConstructor, string command)
        {
            bool TodoOk = false;

            T p;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = command;
                // ESTABLESCO LA CONEXION
                this._comando.Connection = this._conexion;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = this._comando.ExecuteReader();

                // SI HAY REGISTROS...               
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    p = elConstructor.Invoke(oDr);
                }
                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception)
            {
                TodoOk = false;
            }
            finally
            {

                if (TodoOk)
                    this._conexion.Close();

            }

            return p;
        }
        #endregion

        #region Insertar Persona

        public bool InsertarPersona(T p, StringComanndSql<T> command)
        {
            bool todoOk = false;

            string sql = command.Invoke(p);

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND
                this._comando.ExecuteNonQuery();

                todoOk = true;

            }

            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    this._conexion.Close();
            }


            return todoOk;

        }
        #endregion

        #region Modificar Persona
        public bool ModificarPersona(T p, StringComanndSql<T> command)
        {
            bool todoOk = false;
            string sql = command.Invoke(p);

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND
                this._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    this._conexion.Close();
            }
            return todoOk;
        }
        #endregion

        #region Eliminar Persona
        public bool EliminarPersona(T p, StringComanndSql<T> command)
        {
            bool todoOk = false;

            string sql = command.Invoke(p);

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND
                this._comando.ExecuteNonQuery();

                todoOk = true;

            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    this._conexion.Close();
            }
            return todoOk;
        }
        #endregion

        #endregion
    }
}
