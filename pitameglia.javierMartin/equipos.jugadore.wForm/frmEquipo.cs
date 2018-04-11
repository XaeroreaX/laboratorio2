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

        private void showEqupoInLBX()
        {
            List<jugador> _jugadores = this._equipo.getJugadores();

            this.lbxJugadores.Items.Clear();

            foreach (jugador element in _jugadores)
            {
                this.lbxJugadores.Items.Add(element.showData());
                
            }
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

            this.btnPlus.Enabled = true;

            this.btnRemove.Enabled = true;

            this.btnAceptar.Visible = false;

            //for (int i = 0; i < 1000; i++)
            //    this.lbxJugadores.Items.Add("que es lo peor que podria pasar?!!!\n");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {


            frmJugador ventaJugador = new frmJugador();

            ventaJugador.ShowDialog();

            if (ventaJugador.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                if (this._equipo + ventaJugador.getJugador() == true)
                {
                    //MessageBox.Show("se pudo agregar el jugador exitosamente!!");

                    this.showEqupoInLBX();

                    

                    
                }
                else
                {
                    MessageBox.Show("el jugador no se pudo ingresar");
                }
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lbxJugadores.SelectedIndex;

            bool miBool;


            if (index > -1)
            {
                List<jugador> jugadorList = this._equipo.getJugadores();

                jugador _jugador = jugadorList[index];

                if(MessageBox.Show(_jugador.showData(),"question",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    miBool = this._equipo - _jugador;

                this.showEqupoInLBX();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmJugador ventanaJugadorModif;

            int index = lbxJugadores.SelectedIndex;


            if (index > -1)
            {
                List<jugador> _jugadores;

                _jugadores = this._equipo.getJugadores();

                jugador _jugador = _jugadores[index];

                ventanaJugadorModif = new frmJugador(_jugador);

                ventanaJugadorModif.ShowDialog();

                _jugadores[index] = ventanaJugadorModif.getJugador();


                if (MessageBox.Show(_jugador.showData(), "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    this._equipo.Jugadores = _jugadores;

                showEqupoInLBX();
            }
        }
    }
}
