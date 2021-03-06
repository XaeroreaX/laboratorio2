﻿using System;
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
    public partial class frmJugador : Form
    {
        private jugador _jugador;



        public jugador getJugador()
        {
            return this._jugador;
        }

        public frmJugador()
        {
            InitializeComponent();
        }

        public frmJugador(jugador _jugador)
        {
            InitializeComponent();



            this.txtDni.Text = ""+_jugador.DNI;

            this.txtDni.Enabled = false;

            this.txtNombre.Text = _jugador.Nombre;

            this.txtPartidosJugados.Text = ""+_jugador.PartidasJugadas;

            this.txtGoles.Text = "" + _jugador.TotalGoles;


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validar;
            long dni;
            string nombre;
            int partidasJugadas, goles;

            validar = long.TryParse(this.txtDni.Text , out dni);

            nombre = this.txtNombre.Text;

            validar = int.TryParse(this.txtPartidosJugados.Text, out partidasJugadas);

            validar = int.TryParse(this.txtGoles.Text, out goles);

            this._jugador = new jugador(dni, nombre, partidasJugadas, goles);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //MessageBox.Show(this._jugador.showData());

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmJugador_Load(object sender, EventArgs e)
        {

        }
        
    }
}
