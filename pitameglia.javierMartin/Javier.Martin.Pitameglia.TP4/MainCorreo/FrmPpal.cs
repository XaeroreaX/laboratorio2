﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        public FrmPpal()
        {

            InitializeComponent();

            this.rtbMostrar.Enabled = false;
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void mtxtTrackingID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
