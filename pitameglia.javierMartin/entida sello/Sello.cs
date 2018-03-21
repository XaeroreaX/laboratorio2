using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entida_sello
{
    public class Sello
    {

        public static string mensaje;




        public static string ArmarFormatoMensaje()
        {
            string text = "";
            int i,len;
            bool flag;

            flag = Sello.TryParse(Sello.mensaje, out Sello.mensaje);


            if (flag == true)
            {
                len = Sello.mensaje.Length;

                text = "*";
                for (i = 0; i < len; i++)
                {
                    text += "*";
                }
                text += "*";
                text += "\n";
                text += "*";
                text += Sello.mensaje;
                text += "*";
                text += "\n";
                text += "*";
                for (i = 0; i < len; i++)
                {
                    text += "*";
                }
                text += "*";
                
            }
         

            return text;
        }


        private static bool TryParse(string mensaje, out string devuelveMensaje)
        {
            bool flag = true;

            devuelveMensaje = mensaje;

            if (mensaje == "")
            {
                flag = false;
            }
            

            return flag;
        }

        public static void imprimir(ConsoleColor paint)
        {

            bool flag;


            flag = Sello.TryParse(Sello.mensaje, out Sello.mensaje);


            if (flag == true)
            {
                Console.ForegroundColor = paint;

                Console.Write("{0}", Sello.mensaje);



                Console.ForegroundColor = ConsoleColor.White;

            }    

        }

        public static void borrar()
        {
            Console.Clear();
        }

        

    }
}
