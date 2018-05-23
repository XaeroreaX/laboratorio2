using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using entidades;

namespace GuardarJugador
{
    public enum EAdminArchivo { Guardar, Cargar}

    public partial class frmJugador : Form
    {

        private List<Jugador> _jugadores;


        private void actualizarListBoxJugadores()
        {
            this.lbxJugadores.Refresh();
            foreach (Jugador Element in this._jugadores)
            {
                this.lbxJugadores.Items.Add(Element.Nombre +"," + Element.Apellido +","+ Element.Puesto.ToString());

            }

        }

        private string Escribir(string path, string name, bool noSobrescribir)
        {
            string message = "se ha guardado con exito";


            try
            {
                
                StreamWriter file = new StreamWriter(path + name, noSobrescribir);
                

                for(int i = 0; i < this.lbxJugadores.Items.Count; i++)
                    file.WriteLine(this.lbxJugadores.Items[i].ToString());
                
                file.Close();
            }


            catch(Exception miEx)
            {

                message = miEx.ToString();

            }
            return message;

        }


        private string Leer(string path, string name)
        {
            EPuesto puesto = EPuesto.Arquero;

            string message = "se ha leido con exito", linea = "";

            char[] separadores = new char[2];

            separadores[0] = ',';
            separadores[1] = '\r';

            string[] campos = new string[3];

            try
            {
                StreamReader reader = new StreamReader(@"D:\VisualStudio\XaeroreaX\clase19\miArchivo");


                while ((linea = reader.ReadLine()) != null)
                {
                    if (linea != "")
                    {
                        campos = linea.Split(separator: separadores);


                        foreach (EPuesto item in Enum.GetValues(typeof(EPuesto)))
                        {

                            puesto = item;
                            if (item.ToString() == campos[2]) break;


                        }

                        this._jugadores.Add(new Jugador(nombre: campos[0], apellido: campos[1], puesto: puesto));

                    }

                }



                reader.Close();

            }

            catch (Exception miEx)
            {

                message = miEx.ToString();

            }

            return message;
        }

        private void AdministradorDeArchivos(EAdminArchivo hacer)
        {

            string message = "";

            switch(hacer)
            {

                case EAdminArchivo.Guardar:
                    message = Escribir(path: @"D:\VisualStudio\XaeroreaX\clase19\", name: @"miArchivo", noSobrescribir: false);
                    MessageBox.Show(message);
                    break;
                case EAdminArchivo.Cargar:
                    message = Leer(path: @"D:\VisualStudio\XaeroreaX\clase19\", name: @"miArchivo");
                    MessageBox.Show(message);
                    break;
            }
            

            


        }

        public frmJugador()
        {
            bool flag = false;

            InitializeComponent();

            this._jugadores = new List<Jugador>();

            foreach(EPuesto item in Enum.GetValues(typeof(EPuesto)))
            {
                this.cboPuesto.Items.Add(item);

                if(flag == false)
                {
                    this.cboPuesto.SelectedItem = item;
                    flag = true;

                }
                
            }
            this.cboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
 


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            AdministradorDeArchivos(EAdminArchivo.Guardar);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text, apellido = this.txtApellido.Text, textPuesto = this.cboPuesto.Text;

            

            foreach (EPuesto item in Enum.GetValues(typeof(EPuesto)))
            {

                if(textPuesto == item.ToString())
                {
                    this._jugadores.Add(new Jugador(nombre, apellido, item));
                }
            }

            actualizarListBoxJugadores();

        }
    }
}
