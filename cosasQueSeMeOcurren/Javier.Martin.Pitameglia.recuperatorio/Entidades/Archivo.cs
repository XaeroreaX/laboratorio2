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

    public delegate string SaveFileText<T>(T item);

    

    public class XMLfile<T>
    {

        public string Save(string path, T Element)
        {

            string message = "Save is succefull";

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
            string message = "Load is succefull";



            try
            {
                XmlTextReader Arch = new XmlTextReader(path);


                XmlSerializer serializador = new XmlSerializer(typeof(T));

                var = (T)serializador.Deserialize(Arch);

                Arch.Close();

            }




            catch (Exception miEx)
            {

                message = miEx.ToString();

                var = default(T);


            }

            return message;


        }


    }

    public static class TEXTFile
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

            string message = "OK";

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

        public static string EscribirItem<T>(T item, SaveFileText<T> Metodo, string archivo)
        {

            string message = "Save is succefull";


            try
            {

                StreamWriter file = new StreamWriter(archivo);

                file.WriteLine(Metodo.Invoke(item));

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