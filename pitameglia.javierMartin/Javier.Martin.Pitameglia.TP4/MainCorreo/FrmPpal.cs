using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {

        private Correo _correo;

        public FrmPpal()
        {

            InitializeComponent();

            this._correo = new Correo();

            this.rtbMostrar.Enabled = false;
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int trackingId;

            if(int.TryParse(this.mtxtTrackingID.Text, out trackingId) == true)
            {
                Paquete Paquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);

                this._correo += Paquete;
                

            }


        }

        private void mtxtTrackingID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
