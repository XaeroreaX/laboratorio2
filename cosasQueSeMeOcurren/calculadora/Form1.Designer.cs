namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblRESULTADO = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(102, 58);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(100, 20);
            this.Numero1.TabIndex = 0;
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(102, 105);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(100, 20);
            this.Numero2.TabIndex = 1;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(52, 61);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(50, 13);
            this.lblNumero1.TabIndex = 2;
            this.lblNumero1.Text = "Numero1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(52, 108);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(50, 13);
            this.lblNumero2.TabIndex = 3;
            this.lblNumero2.Text = "Numero2";
            // 
            // lblRESULTADO
            // 
            this.lblRESULTADO.AutoSize = true;
            this.lblRESULTADO.Location = new System.Drawing.Point(23, 162);
            this.lblRESULTADO.Name = "lblRESULTADO";
            this.lblRESULTADO.Size = new System.Drawing.Size(73, 13);
            this.lblRESULTADO.TabIndex = 4;
            this.lblRESULTADO.Text = "RESULTADO";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(102, 159);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultado.TabIndex = 5;
            // 
            // buttonSuma
            // 
            this.buttonSuma.Location = new System.Drawing.Point(27, 247);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(75, 23);
            this.buttonSuma.TabIndex = 6;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Location = new System.Drawing.Point(118, 247);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(75, 23);
            this.buttonResta.TabIndex = 7;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(212, 247);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonDivision.TabIndex = 8;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.Location = new System.Drawing.Point(306, 247);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplicacion.TabIndex = 9;
            this.buttonMultiplicacion.Text = "X";
            this.buttonMultiplicacion.UseVisualStyleBackColor = true;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 282);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.lblRESULTADO);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblRESULTADO;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplicacion;
    }
}

