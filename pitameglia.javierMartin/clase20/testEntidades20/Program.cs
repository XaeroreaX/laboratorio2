using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidadesClase20;
using DepositoGenerico;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;


///investigar XmlInclude(Type T)


namespace testEntidades20
{

    public class XML<T>
    {

        public bool GuardarXML(string path, T Element)
        {

            bool miBool = true;

            try
            {

                XmlTextWriter Arch = new XmlTextWriter(path, Encoding.UTF8);


                XmlSerializer serializador = new XmlSerializer(typeof(T));

                serializador.Serialize(Arch, Element);

                Arch.Close();
            }

            catch (Exception miEx)
            {

                miBool = false;

            }

            return false;

        }



        public bool LeerXML(string path, out T var)
        {
            bool miBool = true;

            

                XmlTextReader Arch = new XmlTextReader(path);


                XmlSerializer serializador = new XmlSerializer(typeof(T));

                var = (T) serializador.Deserialize(Arch);

                Arch.Close();


            

            return miBool;


        }



    }



    class Program
    {
        static void Main(string[] args)
        {

            bool miBool = true;

            List<Alumno> Alumnos = new List<Alumno>();

            XML<List<Alumno>> miXML = new XML<List<Alumno>>();

            miBool = miXML.LeerXML(@"D:\VisualStudio\clase20\testEntidades20\miArch.Xml", out Alumnos);


            Deposito<Alumno> miDeposito = new Deposito<Alumno>(10);


            foreach(Alumno element in Alumnos)
            {

               miBool = miDeposito.agregar(element);
            }

            Console.WriteLine(miDeposito.ToString());



            /*
            Alumnos.Add(new Alumno());
            Alumnos.Add(new Alumno("cerdo", "deprabados", 4564845, 64546554));
            Alumnos.Add(new Alumno("php", "java", 454654, 7854894));

            Console.WriteLine(XML<List<Alumno>>.GuardarXML(@"D:\VisualStudio\clase20\testEntidades20\miArch.Xml", Alumnos));
            */

            Console.ReadKey();


        }


    }
}
