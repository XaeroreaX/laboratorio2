using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;



namespace ClassLibrary1
{
    public class XML<T>
    {

        public string Save(string path, T Element)
        {

            string message = "Load is succefull";

            try
            {

                XmlTextWriter Arch = new XmlTextWriter(path, Encoding.UTF8);


                XmlSerializer serializador = new XmlSerializer(typeof(T));

                serializador.Serialize(Arch, Element);

                Arch.Close();
            }

            catch (Exception miEx)
            {

                message = miEx.ToString();

            }

            return message;

        }



        public string Load(string path, out T var)
        {
            string message = "Save is succefull";

            

            try
            {   XmlTextReader Arch = new XmlTextReader(path);


                XmlSerializer serializador = new XmlSerializer(typeof(T));

                var = (T)serializador.Deserialize(Arch);

                Arch.Close();

            }


            

            catch(Exception miEx)
            {
                
                message = miEx.ToString();

                var = new this();

            }

            return message;


        }

        
    }
}