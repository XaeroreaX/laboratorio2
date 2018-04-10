namespace equipos.jugadore.wForm
{
    partial class frmEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantJug = new System.Windows.Forms.Label();
            this.txtCantJug = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbxJugadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCantJug
            // 
            this.lblCantJug.AutoSize = true;
            this.lblCantJug.Location = new System.Drawing.Point(31, 116);
            this.lblCantJug.Name = "lblCantJug";
            this.lblCantJug.Size = new System.Drawing.Size(113, 13);
            this.lblCantJug.TabIndex = 1;
            this.lblCantJug.Text = "Cantidad de jugadores";
            // 
            // txtCantJug
            // 
            this.txtCantJug.Location = new System.Drawing.Point(162, 116);
            this.txtCantJug.Name = "txtCantJug";
            this.txtCantJug.Size = new System.Drawing.Size(234, 20);
            this.txtCantJug.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(34, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(178, 83);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(218, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 83);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbxJugadores
            // 
            this.lbxJugadores.FormattingEnabled = true;
            this.lbxJugadores.Location = new System.Drawing.Point(34, 145);
            this.lbxJugadores.Name = "lbxJugadores";
            this.lbxJugadores.Size = new System.Drawing.Size(362, 147);
            this.lbxJugadores.TabIndex = 6;
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 397);
            this.Controls.Add(this.lbxJugadores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCantJug);
            this.Controls.Add(this.lblCantJug);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmEquipo";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantJug;
        private System.Windows.Forms.TextBox txtCantJug;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lbxJugadores;
    }
}