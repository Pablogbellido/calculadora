namespace calculadora
{
    partial class Calculadora
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
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonMultiplica = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.textBoxOperador1 = new System.Windows.Forms.TextBox();
            this.textBoxOperador2 = new System.Windows.Forms.TextBox();
            this.labelOperador = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSuma
            // 
            this.buttonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuma.ForeColor = System.Drawing.Color.Black;
            this.buttonSuma.Location = new System.Drawing.Point(54, 249);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(40, 40);
            this.buttonSuma.TabIndex = 0;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSuma_MouseClick);
            // 
            // buttonResta
            // 
            this.buttonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonResta.Location = new System.Drawing.Point(100, 249);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(40, 40);
            this.buttonResta.TabIndex = 1;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonResta_MouseClick);
            // 
            // buttonMultiplica
            // 
            this.buttonMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplica.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonMultiplica.Location = new System.Drawing.Point(54, 295);
            this.buttonMultiplica.Name = "buttonMultiplica";
            this.buttonMultiplica.Size = new System.Drawing.Size(40, 40);
            this.buttonMultiplica.TabIndex = 2;
            this.buttonMultiplica.Text = "X";
            this.buttonMultiplica.UseVisualStyleBackColor = true;
            this.buttonMultiplica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonMultiplica_MouseClick);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDivision.Location = new System.Drawing.Point(100, 295);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(40, 40);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDivision_MouseClick);
            // 
            // textBoxOperador1
            // 
            this.textBoxOperador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOperador1.Location = new System.Drawing.Point(12, 12);
            this.textBoxOperador1.Name = "textBoxOperador1";
            this.textBoxOperador1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOperador1.Size = new System.Drawing.Size(170, 31);
            this.textBoxOperador1.TabIndex = 4;
            // 
            // textBoxOperador2
            // 
            this.textBoxOperador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOperador2.Location = new System.Drawing.Point(12, 86);
            this.textBoxOperador2.Name = "textBoxOperador2";
            this.textBoxOperador2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOperador2.Size = new System.Drawing.Size(170, 31);
            this.textBoxOperador2.TabIndex = 5;
            // 
            // labelOperador
            // 
            this.labelOperador.AutoSize = true;
            this.labelOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperador.Location = new System.Drawing.Point(46, 52);
            this.labelOperador.Name = "labelOperador";
            this.labelOperador.Size = new System.Drawing.Size(102, 25);
            this.labelOperador.TabIndex = 6;
            this.labelOperador.Text = "Operador";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(85, 126);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(24, 25);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "=";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultado.Location = new System.Drawing.Point(12, 160);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxResultado.Size = new System.Drawing.Size(170, 31);
            this.textBoxResultado.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(54, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(194, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelOperador);
            this.Controls.Add(this.textBoxOperador2);
            this.Controls.Add(this.textBoxOperador1);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplica);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonSuma);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonMultiplica;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.TextBox textBoxOperador1;
        private System.Windows.Forms.TextBox textBoxOperador2;
        private System.Windows.Forms.Label labelOperador;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button button1;
    }
}

