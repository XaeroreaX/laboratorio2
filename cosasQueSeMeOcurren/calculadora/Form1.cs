using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public static double n1, n2, resultado;

        private void buttonResta_Click(object sender, EventArgs e)
        {
            bool flag;
            string numero = Numero1.Text;

            flag = double.TryParse(numero, out Form1.n1);

            if (flag != false)
            {
                numero = Numero2.Text;


                flag = double.TryParse(numero, out Form1.n2);
                if (flag != false)
                {
                    Form1.resultado = Form1.n1 - Form1.n2;



                    textBoxResultado.Text = "" + Form1.resultado;
                }
            }

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            bool flag;
            string numero = Numero1.Text;

            flag = double.TryParse(numero, out Form1.n1);

            if (flag != false)
            {
                numero = Numero2.Text;


                flag = double.TryParse(numero, out Form1.n2);
                if (flag != false)
                {
                    Form1.resultado = Form1.n1 / Form1.n2;



                    textBoxResultado.Text = "" + Form1.resultado;
                }
            }

        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            bool flag;
            string numero = Numero1.Text;

            flag = double.TryParse(numero, out Form1.n1);

            if (flag != false)
            {
                numero = Numero2.Text;


                flag = double.TryParse(numero, out Form1.n2);
                if (flag != false)
                {
                    Form1.resultado = Form1.n1 * Form1.n2;



                    textBoxResultado.Text = "" + Form1.resultado;
                }
            }

        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            bool flag;
            string numero = Numero1.Text;

            flag = double.TryParse(numero, out Form1.n1);

            if(flag != false)
            {
                numero = Numero2.Text;


                flag = double.TryParse(numero, out Form1.n2);
                if(flag != false)
                {
                    Form1.resultado = Form1.n1 + Form1.n2;

                    

                    textBoxResultado.Text =  ""+Form1.resultado;
                }
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
