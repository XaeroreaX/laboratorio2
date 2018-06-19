using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        static SqlCommand _comando;

        static string _conexion;


        public static bool Insertar(Paquete p)
        {



            return false;
        }

        public static PaqueteDAO()
        {

            

           PaqueteDAO._conexion = Properties.Settings.Default.ConnectionString;

        }


        public static string conexion { get; set; }
    }
}
