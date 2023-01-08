namespace Calculadora
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
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonN7 = new System.Windows.Forms.Button();
            this.buttonN8 = new System.Windows.Forms.Button();
            this.buttonN9 = new System.Windows.Forms.Button();
            this.buttonN4 = new System.Windows.Forms.Button();
            this.buttonN5 = new System.Windows.Forms.Button();
            this.buttonN6 = new System.Windows.Forms.Button();
            this.buttonN1 = new System.Windows.Forms.Button();
            this.buttonN2 = new System.Windows.Forms.Button();
            this.buttonN3 = new System.Windows.Forms.Button();
            this.buttonN0 = new System.Windows.Forms.Button();
            this.buttonPunto = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Enabled = false;
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(13, 12);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(267, 38);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.Text = "0";
            // 
            // buttonSuma
            // 
            this.buttonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuma.Location = new System.Drawing.Point(12, 96);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(32, 30);
            this.buttonSuma.TabIndex = 1;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResta.Location = new System.Drawing.Point(56, 96);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(31, 30);
            this.buttonResta.TabIndex = 2;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicar.Location = new System.Drawing.Point(105, 96);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(32, 30);
            this.buttonMultiplicar.TabIndex = 3;
            this.buttonMultiplicar.Text = "x";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // buttonN7
            // 
            this.buttonN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN7.Location = new System.Drawing.Point(13, 132);
            this.buttonN7.Name = "buttonN7";
            this.buttonN7.Size = new System.Drawing.Size(75, 30);
            this.buttonN7.TabIndex = 4;
            this.buttonN7.Text = "7";
            this.buttonN7.UseVisualStyleBackColor = true;
            this.buttonN7.Click += new System.EventHandler(this.buttonN7_Click);
            // 
            // buttonN8
            // 
            this.buttonN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN8.Location = new System.Drawing.Point(105, 132);
            this.buttonN8.Name = "buttonN8";
            this.buttonN8.Size = new System.Drawing.Size(75, 30);
            this.buttonN8.TabIndex = 5;
            this.buttonN8.Text = "8";
            this.buttonN8.UseVisualStyleBackColor = true;
            this.buttonN8.Click += new System.EventHandler(this.buttonN8_Click);
            // 
            // buttonN9
            // 
            this.buttonN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN9.Location = new System.Drawing.Point(204, 132);
            this.buttonN9.Name = "buttonN9";
            this.buttonN9.Size = new System.Drawing.Size(75, 30);
            this.buttonN9.TabIndex = 6;
            this.buttonN9.Text = "9";
            this.buttonN9.UseVisualStyleBackColor = true;
            this.buttonN9.Click += new System.EventHandler(this.buttonN9_Click);
            // 
            // buttonN4
            // 
            this.buttonN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN4.Location = new System.Drawing.Point(13, 168);
            this.buttonN4.Name = "buttonN4";
            this.buttonN4.Size = new System.Drawing.Size(75, 30);
            this.buttonN4.TabIndex = 7;
            this.buttonN4.Text = "4";
            this.buttonN4.UseVisualStyleBackColor = true;
            this.buttonN4.Click += new System.EventHandler(this.buttonN4_Click);
            // 
            // buttonN5
            // 
            this.buttonN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN5.Location = new System.Drawing.Point(105, 168);
            this.buttonN5.Name = "buttonN5";
            this.buttonN5.Size = new System.Drawing.Size(75, 30);
            this.buttonN5.TabIndex = 8;
            this.buttonN5.Text = "5";
            this.buttonN5.UseVisualStyleBackColor = true;
            this.buttonN5.Click += new System.EventHandler(this.buttonN5_Click);
            // 
            // buttonN6
            // 
            this.buttonN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN6.Location = new System.Drawing.Point(204, 168);
            this.buttonN6.Name = "buttonN6";
            this.buttonN6.Size = new System.Drawing.Size(75, 30);
            this.buttonN6.TabIndex = 9;
            this.buttonN6.Text = "6";
            this.buttonN6.UseVisualStyleBackColor = true;
            this.buttonN6.Click += new System.EventHandler(this.buttonN6_Click);
            // 
            // buttonN1
            // 
            this.buttonN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN1.Location = new System.Drawing.Point(12, 204);
            this.buttonN1.Name = "buttonN1";
            this.buttonN1.Size = new System.Drawing.Size(75, 30);
            this.buttonN1.TabIndex = 10;
            this.buttonN1.Text = "1";
            this.buttonN1.UseVisualStyleBackColor = true;
            this.buttonN1.Click += new System.EventHandler(this.buttonN1_Click);
            // 
            // buttonN2
            // 
            this.buttonN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN2.Location = new System.Drawing.Point(104, 204);
            this.buttonN2.Name = "buttonN2";
            this.buttonN2.Size = new System.Drawing.Size(75, 30);
            this.buttonN2.TabIndex = 11;
            this.buttonN2.Text = "2";
            this.buttonN2.UseVisualStyleBackColor = true;
            this.buttonN2.Click += new System.EventHandler(this.buttonN2_Click);
            // 
            // buttonN3
            // 
            this.buttonN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN3.Location = new System.Drawing.Point(203, 204);
            this.buttonN3.Name = "buttonN3";
            this.buttonN3.Size = new System.Drawing.Size(75, 30);
            this.buttonN3.TabIndex = 12;
            this.buttonN3.Text = "3";
            this.buttonN3.UseVisualStyleBackColor = true;
            this.buttonN3.Click += new System.EventHandler(this.buttonN3_Click);
            // 
            // buttonN0
            // 
            this.buttonN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN0.Location = new System.Drawing.Point(104, 240);
            this.buttonN0.Name = "buttonN0";
            this.buttonN0.Size = new System.Drawing.Size(75, 30);
            this.buttonN0.TabIndex = 13;
            this.buttonN0.Text = "0";
            this.buttonN0.UseVisualStyleBackColor = true;
            this.buttonN0.Click += new System.EventHandler(this.buttonN0_Click);
            // 
            // buttonPunto
            // 
            this.buttonPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPunto.Location = new System.Drawing.Point(12, 240);
            this.buttonPunto.Name = "buttonPunto";
            this.buttonPunto.Size = new System.Drawing.Size(75, 30);
            this.buttonPunto.TabIndex = 14;
            this.buttonPunto.Text = ".";
            this.buttonPunto.UseVisualStyleBackColor = true;
            this.buttonPunto.Click += new System.EventHandler(this.buttonPunto_Click);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.Location = new System.Drawing.Point(203, 240);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(75, 30);
            this.buttonIgual.TabIndex = 15;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDividir.Location = new System.Drawing.Point(147, 96);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(32, 30);
            this.buttonDividir.TabIndex = 16;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(203, 96);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiar.TabIndex = 17;
            this.buttonLimpiar.Text = "CE";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 347);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonPunto);
            this.Controls.Add(this.buttonN0);
            this.Controls.Add(this.buttonN3);
            this.Controls.Add(this.buttonN2);
            this.Controls.Add(this.buttonN1);
            this.Controls.Add(this.buttonN6);
            this.Controls.Add(this.buttonN5);
            this.Controls.Add(this.buttonN4);
            this.Controls.Add(this.buttonN9);
            this.Controls.Add(this.buttonN8);
            this.Controls.Add(this.buttonN7);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonN7;
        private System.Windows.Forms.Button buttonN8;
        private System.Windows.Forms.Button buttonN9;
        private System.Windows.Forms.Button buttonN4;
        private System.Windows.Forms.Button buttonN5;
        private System.Windows.Forms.Button buttonN6;
        private System.Windows.Forms.Button buttonN1;
        private System.Windows.Forms.Button buttonN2;
        private System.Windows.Forms.Button buttonN3;
        private System.Windows.Forms.Button buttonN0;
        private System.Windows.Forms.Button buttonPunto;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

