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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_multiplicacion = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_suma);
            this.panel1.Controls.Add(this.btn_calcular);
            this.panel1.Controls.Add(this.btn_resta);
            this.panel1.Controls.Add(this.btn_multiplicacion);
            this.panel1.Controls.Add(this.btn_division);
            this.panel1.Controls.Add(this.btn_num9);
            this.panel1.Controls.Add(this.btn_num6);
            this.panel1.Controls.Add(this.btn_num3);
            this.panel1.Controls.Add(this.btn_num8);
            this.panel1.Controls.Add(this.btn_num5);
            this.panel1.Controls.Add(this.btn_num2);
            this.panel1.Controls.Add(this.txt_resultado);
            this.panel1.Controls.Add(this.btn_num7);
            this.panel1.Controls.Add(this.btn_num4);
            this.panel1.Controls.Add(this.btn_num1);
            this.panel1.Controls.Add(this.btn_num0);
            this.panel1.Location = new System.Drawing.Point(252, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 399);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(250, 124);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(78, 46);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "AC";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(99, 321);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(130, 62);
            this.btn_calcular.TabIndex = 16;
            this.btn_calcular.Text = "=";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(250, 277);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(78, 48);
            this.btn_resta.TabIndex = 15;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_multiplicacion
            // 
            this.btn_multiplicacion.Location = new System.Drawing.Point(250, 228);
            this.btn_multiplicacion.Name = "btn_multiplicacion";
            this.btn_multiplicacion.Size = new System.Drawing.Size(78, 43);
            this.btn_multiplicacion.TabIndex = 14;
            this.btn_multiplicacion.Text = "X";
            this.btn_multiplicacion.UseVisualStyleBackColor = true;
            this.btn_multiplicacion.Click += new System.EventHandler(this.btn_multiplicacion_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(250, 176);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(78, 46);
            this.btn_division.TabIndex = 13;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_num9
            // 
            this.btn_num9.Location = new System.Drawing.Point(168, 120);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(61, 61);
            this.btn_num9.TabIndex = 12;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = true;
            this.btn_num9.Click += new System.EventHandler(this.btn_num9_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.Location = new System.Drawing.Point(168, 187);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(61, 60);
            this.btn_num6.TabIndex = 11;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = true;
            this.btn_num6.Click += new System.EventHandler(this.btn_num6_Click);
            // 
            // btn_num3
            // 
            this.btn_num3.Location = new System.Drawing.Point(167, 254);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(62, 61);
            this.btn_num3.TabIndex = 10;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = true;
            this.btn_num3.Click += new System.EventHandler(this.btn_num3_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(250, 331);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(78, 48);
            this.btn_suma.TabIndex = 9;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.Location = new System.Drawing.Point(99, 120);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(62, 61);
            this.btn_num8.TabIndex = 8;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = true;
            this.btn_num8.Click += new System.EventHandler(this.btn_num8_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.Location = new System.Drawing.Point(99, 187);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(62, 61);
            this.btn_num5.TabIndex = 7;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = true;
            this.btn_num5.Click += new System.EventHandler(this.btn_num5_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.Location = new System.Drawing.Point(99, 254);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(62, 61);
            this.btn_num2.TabIndex = 6;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = true;
            this.btn_num2.Click += new System.EventHandler(this.btn_num2_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(31, 15);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(297, 90);
            this.txt_resultado.TabIndex = 4;
            // 
            // btn_num7
            // 
            this.btn_num7.Location = new System.Drawing.Point(31, 120);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(62, 61);
            this.btn_num7.TabIndex = 3;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = true;
            this.btn_num7.Click += new System.EventHandler(this.btn_num7_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.Location = new System.Drawing.Point(31, 187);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(62, 61);
            this.btn_num4.TabIndex = 2;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = true;
            this.btn_num4.Click += new System.EventHandler(this.btn_num4_Click);
            // 
            // btn_num1
            // 
            this.btn_num1.Location = new System.Drawing.Point(31, 254);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(62, 61);
            this.btn_num1.TabIndex = 1;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = true;
            this.btn_num1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_num0
            // 
            this.btn_num0.Location = new System.Drawing.Point(31, 321);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(62, 61);
            this.btn_num0.TabIndex = 0;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = true;
            this.btn_num0.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_multiplicacion;
        private System.Windows.Forms.Button btn_reset;
    }
}

