using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidadesClase08;

namespace equipos.jugadore.wForm
{
    public partial class frmEquipo : Form
    {

        private Equipo _equipo;

        public frmEquipo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validar;
            string nombre;
            short cantMax;

            nombre = this.txtNombre.Text;

            validar = short.TryParse(this.txtCantJug.Text, out cantMax);

            this._equipo = new Equipo(cantMax, nombre);

            this.txtCantJug.Enabled = false;

            this.txtNombre.Enabled = false;



            this.btnAceptar.Visible = false;

            for (int i = 0; i < 1000; i++)
                this.lbxJugadores.Items.Add("que es lo peor que podria pasar?!!!\n");
        }
    }
}
