using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;






namespace ArchivosPity
{

    

    

    public class XMLfile<T>
    {

        public string _path;

        


        public XMLfile(string path)
        {
            this._path = path;           
            

        }

        public void Save(T Element, out string messageException)  
        { this.Save(Element, out messageException, false); }



        public bool Save(T Element, out string messageException, bool append)
        {

            messageException = "Save is successfully";
            bool returnAux = true;

            try
            {


                TextWriter tw = new StreamWriter(this._path, append);
                XmlSerializer objXml = new XmlSerializer(typeof(T));

                objXml.Serialize(tw, Element);
                tw.Close();
            }


            #region CatchException




            catch (ArgumentException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;
            }

            catch (UnauthorizedAccessException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();

                returnAux = false;
            }

            catch (DirectoryNotFoundException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;
            }

            catch (IOException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;
            }

            catch (InvalidOperationException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;
            }

            catch (Exception EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;
            }



            #endregion


            return returnAux;
        }



        public bool Load(out T element,out string messageException)
        {
            messageException = "Load is successfully";

            bool returnAux = true;

            element = default(T);

                   
            



            try
            {


                TextReader tr = new StreamReader(this._path);
                XmlSerializer objXml = new XmlSerializer(typeof(T));

                element = (T)objXml.Deserialize(tr);
                tr.Close();


            }



            #region CatchException


            catch (FileNotFoundException EX)
            {
                returnAux = false;

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

  
            catch (DirectoryNotFoundException EX)
            {
                returnAux = false;
                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (UriFormatException EX)
            {
                returnAux = false;
                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (InvalidOperationException EX)
            {
                returnAux = false;
                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (Exception EX)
            {
                returnAux = false;
                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }



            #endregion


            return returnAux;


        }


    }

    public static class TEXTFileExtender
    {

        public static string Save(this string texto, string archivo, bool noSobrescribir)
        {
            string message = "Save is succefull";


            try
            {

                StreamWriter file = new StreamWriter(archivo, noSobrescribir);

                file.WriteLine(texto);

                file.Close();
            }


            #region Catch

            catch (UnauthorizedAccessException EX)
            {
                message = EX.Message;

            }

            catch (ArgumentException EX)
            {
                message = EX.Message;
            }

            catch (DirectoryNotFoundException EX)
            {
                message = EX.Message;
            }

            catch (PathTooLongException EX)
            {
                message = EX.Message;
            }

            catch (IOException EX)
            {
                message = EX.Message;
            }

            catch (System.Security.SecurityException EX)
            {
                message = EX.Message;
            }

            catch (ObjectDisposedException EX)
            {
                message = EX.Message;
            }

            catch (Exception EX)
            {
                message = EX.Message;
            }
            #endregion


            return message;

        }

        public static string Load(this string texto, string archivo)
        {

            string message = default(string);

            try
            {
                StreamReader reader = new StreamReader(archivo);

                message = reader.ReadToEnd();

                reader.Close();
            }


            #region Catch

            

            catch (ArgumentException EX)
            {
                message = EX.Message;
            }

           

            catch (IOException EX)
            {
                message = EX.Message;
            }
                
            catch(OutOfMemoryException EX)
            {
                message = EX.Message;
            }

            catch (Exception EX)
            {
                message = EX.Message;
            }
            #endregion

            return message;
        }

      



    }


    public class BINARIFile<T>
    {

        public string _path;

        public BINARIFile(string path)
        {

            this._path = path;

        }

        public bool Save(out string messageException, T item)
        {

            messageException = "Save is successfully";

            bool returnAux = true;

            try
            {

                FileStream File = new FileStream(this._path, FileMode.Create);

                BinaryFormatter Serializador = new BinaryFormatter();

                Serializador.Serialize(File, item);

                File.Close();

            }

            #region Catch
                catch (ArgumentException EX)
                {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;
                }

                catch(NotSupportedException EX)
                {


                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;

                }
                
                catch(System.Security.SecurityException EX)
                {


                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;

                }

                catch(FileNotFoundException EX)
                {


                    messageException = EX.Message;

                    messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                    messageException += EX.ToString();
                    returnAux = false;

                }

                catch(IOException EX)
                {

                    messageException = EX.Message;

                    messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                    messageException += EX.ToString();
                    returnAux = false;

                }


                catch(Exception EX)
                {


                    messageException = EX.Message;

                    messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                    messageException += EX.ToString();
                    returnAux = false;

                }

            
            #endregion

            return returnAux;

        }

        public  bool Loadr(out string messageException, out T element)
        {

            element = default(T);

            messageException = "Load is successfully";

            bool returnAux = true;

            try
            { 
                FileStream File = new FileStream(this._path, FileMode.Open);

                BinaryFormatter deSerializador = new BinaryFormatter();

                element = (T)deSerializador.Deserialize(File);

                File.Close();
            }

            #region Catch
                catch (ArgumentException EX)
                {
                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;
            }

                catch (NotSupportedException EX)
                {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;

            }

                catch (System.Security.SecurityException EX)
                {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;

            }

                catch (FileNotFoundException EX)
                {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;

            }

                catch (IOException EX)
                {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;

            }


                catch (Exception EX)
                {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
                returnAux = false;

            }


                
            #endregion

            return returnAux;
        }

    }



}