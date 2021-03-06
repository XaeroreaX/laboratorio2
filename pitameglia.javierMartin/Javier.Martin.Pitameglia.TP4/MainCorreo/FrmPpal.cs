﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {

        private Correo _correo;

        private Thread thread;

       // private ToolStripMenuItem mostrarToolStripMenuItem;

        public FrmPpal()
        {

            InitializeComponent();

            this.Text = "Javier Martin Pitameglia 2A";

            this._correo = new Correo();

            this.rtbMostrar.Enabled = false;


            //this.lstEstadoEntregado.ContextMenuStrip = new 

           // mostrarToolStripMenuItem = new ToolStripMenuItem();


           // this.lstEstadoIngresado.
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }


        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                DelegadoEstado d = new DelegadoEstado(paq_InformaEstado);

                this.Invoke(d, new object[] { sender, e });
            }
            else
            {

                this.ActualizarEstado(new object(), new EventArgs());


            } 

        }


        private void ActualizarEstado(object sender, EventArgs e)
        {

            this.lstEstadoIngresado.Items.Clear();

            this.lstEstadoEnViaje.Items.Clear();

            this.lstEstadoEntregado.Items.Clear();

            foreach(Paquete element in this._correo.Paquetes)
            {


                try
                {

                    IMostrar<Paquete> elSender = element;

                    if (element.Estado == EEstado.Ingresado) this.lstEstadoIngresado.Items.Add(element.MostrarDatos(elSender));

                    if (element.Estado == EEstado.EnViaje) this.lstEstadoEnViaje.Items.Add(element.MostrarDatos(elSender));

                    if (element.Estado == EEstado.Entregado) this.lstEstadoEntregado.Items.Add(element.MostrarDatos(elSender));

                }


                catch (ArgumentNullException EX)
                {

                    MessageBox.Show(EX.Message);
                }

                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }

            }

           


        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int trackingId;

            if(int.TryParse(this.mtxtTrackingID.Text, out trackingId) == true)
            {

                
                Paquete Paquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);


                Paquete.InformarEstado += paq_InformaEstado;

                try
                {
                    
                    this._correo += Paquete;
                }

                catch(TrackingIdRepetidoException EX)
                {
                    MessageBox.Show(EX.Message);
                }


                this.ActualizarEstado(new object(), new EventArgs());



            }


        }

        private void mtxtTrackingID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {

            IMostrar<List<Paquete>> elCorreo;

            elCorreo = this._correo;


            MostrarInformacion<List<Paquete>>(elCorreo);
            


        }


        private void MostrarInformacion<T>(IMostrar<T> element)
        {
            if(element != null)
                this.rtbMostrar.Text = element.MostrarDatos(element);

        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {

            string path = @"Desktop\salida";

            string message = GuardarString.Guardar(this._correo.MostrarDatos(this._correo), path);


            
        }


        
    }
}
