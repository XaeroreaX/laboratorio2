using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace clase23Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.txtBilletesDeCienPesos.Enabled = false;
            this.txtBilletesDeCincuentaPesos.Enabled = false;
            this.txtBilletesDeVeintePesos.Enabled = false;
            this.txtBilletesDeDiezPesos.Enabled = false;
            this.txtBilletesDeCincoPesos.Enabled = false;
            this.txtBilletesDeDosPesos.Enabled = false; 

        }

        private void Refrescar()
        {
            this.txtBilletesDeCienPesos.Text = "";
            this.txtBilletesDeCincuentaPesos.Text = "";
            this.txtBilletesDeVeintePesos.Text = "";
            this.txtBilletesDeDiezPesos.Text = "";
            this.txtBilletesDeCincoPesos.Text = "";
            this.txtBilletesDeDosPesos.Text = "";

        }


        private void Calcular(object sender, EventArgs e)
        {

            Refrescar();

            int cantidad;

            if (int.TryParse(this.txtCantidadARetirar.Text, out cantidad) == true)
            {
                if (cantidad >= 100)
                {

                    int billetesDeCien = cantidad / 100;

                    cantidad = cantidad % 100;

                    this.txtBilletesDeCienPesos.Text = billetesDeCien.ToString();

                }


                if (cantidad >= 50)
                {

                    int billetesDeCincuenta = cantidad / 50;

                    cantidad = cantidad % 50;

                    this.txtBilletesDeCincuentaPesos.Text = billetesDeCincuenta.ToString();

                }


                if (cantidad >= 20)
                {

                    int billetesDeVeinte = cantidad / 20;

                    cantidad = cantidad % 20;

                    this.txtBilletesDeVeintePesos.Text = billetesDeVeinte.ToString();

                }



                if (cantidad >= 10)
                {

                    int billetesDeDiez = cantidad / 10;

                    cantidad = cantidad % 10;

                    this.txtBilletesDeDiezPesos.Text = billetesDeDiez.ToString();

                }


                if (cantidad >= 5)
                {

                    int billetesDeCien = cantidad / 5;

                    cantidad = cantidad % 5;

                    this.txtBilletesDeCienPesos.Text = billetesDeCien.ToString();

                }

                if (cantidad >= 2)
                {

                    int billetesDeDos = cantidad / 2;

                    cantidad = cantidad % 2;

                    this.txtBilletesDeDosPesos.Text = billetesDeDos.ToString();

                }



                if (cantidad > 0)
                {

                    MessageBox.Show("sobro " + cantidad);

                }
            }



        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {

            

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(Calcular);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
