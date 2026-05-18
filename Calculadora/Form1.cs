using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1: Form
    {
        int num1 = 0; // primer numero que digita el usuario
        int num2 = 0; // segundo numero que digita el usuario 
        string signo = ""; // el signo que seleccionara el usuario para realizar una operacion
        bool igual = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // boton 1
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }

            txt_resultado.Text = txt_resultado.Text + "1";
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            // boton 0
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            signo = "";
            igual = false;
            txt_resultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            // boton 2
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "2";
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            // boton 3
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "3";
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "4";
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "5";
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "6";
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "7";
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "8";
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txt_resultado.Text = "";
                igual = false;
            }
            txt_resultado.Text = txt_resultado.Text + "9";
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            //boton de suma
            num1 = Convert.ToInt32(txt_resultado.Text);
            txt_resultado.Text = "";
            signo = "+";
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            // boton resta
            num1 = Convert.ToInt32(txt_resultado.Text);
            txt_resultado.Text = "";
            signo = "-";
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            // boton multiplicacion
            num1 = Convert.ToInt32(txt_resultado.Text);
            txt_resultado.Text = "";
            signo = "x";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            // boton division
            num1 = Convert.ToInt32(txt_resultado.Text);
            txt_resultado.Text = "";
            signo = "/";
        }

        public static int suma(int n1, int n2)
        {
            // metodo para hacer la suma
            int resultado = n1 + n2;
            return resultado;

        }

        public static int resta (int n1, int n2)
        {
            // metodo resta
            int resultado = n1 - n2;
            return resultado;
        }

        public static int division (int n1, int n2)
        {
            int resultado = 0;
            if(n2 == 0 || n1 == 0)
            {
                MessageBox.Show("No se puede dividir entre 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultado = n1 / n2;
            }

            return resultado;

        }

        public static int multiplicacion (int n1, int n2)
        {
            int resultado = n1 * n2;
            return resultado;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (num1.ToString() != "" && txt_resultado.Text != "")
            {
                num2 = Convert.ToInt32(txt_resultado.Text);
                igual = true;
                switch (signo)
                {
                    case "+":
                        txt_resultado.Text = suma(num1, num2).ToString();
                        break;

                    case "-":
                        txt_resultado.Text = resta(num1, num2).ToString();
                        break;

                    case "/":
                        txt_resultado.Text = division(num1, num2).ToString();
                        break;

                    case "x":
                        txt_resultado.Text = multiplicacion(num1, num2).ToString();
                        break;

                    default:
                        MessageBox.Show("Ha ocurrido un erorr", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            else MessageBox.Show("Tienes que digitar otro numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
