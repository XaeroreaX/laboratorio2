using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Entidades;





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



        public void Save(T Element, out string messageException, bool append)
        {

            messageException = "Save is successfully";


            try
            {


                XmlSerializer serializer = new XmlSerializer(typeof(T));

                TextWriter Arch = new StreamWriter(this._path, append);



                serializer.Serialize(Arch, Element);

                Arch.Close();
            }


            #region CatchException




            catch (ArgumentException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (UnauthorizedAccessException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (DirectoryNotFoundException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (IOException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (InvalidOperationException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (Exception EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }



            #endregion

        }



        public T Load(out string messageException)
        {
            messageException = "Load is successfully";

            object asignador = new object();


            T var = (T)asignador;

                   
            



            try
            {


                XmlTextReader Arch = new XmlTextReader(this._path);


                XmlSerializer Deserializer = new XmlSerializer(typeof(T));


                var = (T)Deserializer.Deserialize(Arch);


                Arch.Close();

            }



            #region CatchException


            catch (FileNotFoundException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

  
            catch (DirectoryNotFoundException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (UriFormatException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (InvalidOperationException EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }

            catch (Exception EX)
            {

                messageException = EX.Message;

                messageException += "\n\n------------------------------------------------------------------------------------------------------------------\n\n";
                messageException += EX.ToString();
            }



            #endregion


            return var;


        }


    }

    public static class TEXTFileExtender
    {

        public static string Escribir(this string texto, string archivo, bool noSobrescribir)
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

        public static string Leer(this string texto, string archivo)
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


    public static class BINARIFile
    {

        public static bool Serializar<T>(string path, T item)
        {

            bool returnAux = true;

            try
            {

                FileStream File = new FileStream(@path, FileMode.Create);

                BinaryFormatter Serializador = new BinaryFormatter();

                Serializador.Serialize(File, item);

                File.Close();

            }

            #region Catch
                catch (ArgumentException e)
                {

                returnAux = false;
                throw e;
                }

                catch(NotSupportedException e)
                {


                returnAux = false;
                throw e;

                }
                
                catch(System.Security.SecurityException e)
                {


                returnAux = false;
                throw e;

                }

                catch(FileNotFoundException e)
                {


                returnAux = false;
                throw e;

                }

                catch(IOException e)
                {

                returnAux = false;
                throw e;

                }


                catch(Exception e)
                {


                returnAux = false;
                throw e;

                }

            
            #endregion

            return returnAux;

        }

        public static bool Deserializar<T>(string path, out T variable)
        {

            bool returnAux = true;

            try
            { 
                FileStream File = new FileStream(@path, FileMode.Open);

                BinaryFormatter deSerializador = new BinaryFormatter();

                variable = (T)deSerializador.Deserialize(File);

                File.Close();
            }

            #region Catch
                catch (ArgumentException e)
                {
                variable = default(T);
                returnAux = false;
                throw e;
                }

                catch (NotSupportedException e)
                {

                variable = default(T);
                returnAux = false;
                throw e;

                }

                catch (System.Security.SecurityException e)
                {

                variable = default(T);
                returnAux = false;
                throw e;

                }

                catch (FileNotFoundException e)
                {

                variable = default(T);
                returnAux = false;
                throw e;

                }

                catch (IOException e)
                {

                variable = default(T);
                returnAux = false;
                throw e;

                }


                catch (Exception e)
                {

                variable = default(T);
                returnAux = false;
                throw e;

                }


                
            #endregion

            return returnAux;
        }

    }



}