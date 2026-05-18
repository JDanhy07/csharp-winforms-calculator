using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string signo = "";
        private bool esperandoSegundoNumero = false;
        private bool errorActivo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_resultado.Text = "0";
            txt_resultado.ReadOnly = true;
            txt_resultado.TextAlign = HorizontalAlignment.Right;
        }

        // ─── Ingreso de dígitos ───

        private void IngresarDigito(string digito)
        {
            if (errorActivo) ResetearEstado();

            if (esperandoSegundoNumero)
            {
                txt_resultado.Text = digito;
                esperandoSegundoNumero = false;
            }
            else
            {
                txt_resultado.Text = (txt_resultado.Text == "0") ? digito : txt_resultado.Text + digito;
            }
        }

        private void btn_num0_Click(object sender, EventArgs e) => IngresarDigito("0");
        private void btn_num1_Click(object sender, EventArgs e) => IngresarDigito("1");
        private void btn_num2_Click(object sender, EventArgs e) => IngresarDigito("2");
        private void btn_num3_Click(object sender, EventArgs e) => IngresarDigito("3");
        private void btn_num4_Click(object sender, EventArgs e) => IngresarDigito("4");
        private void btn_num5_Click(object sender, EventArgs e) => IngresarDigito("5");
        private void btn_num6_Click(object sender, EventArgs e) => IngresarDigito("6");
        private void btn_num7_Click(object sender, EventArgs e) => IngresarDigito("7");
        private void btn_num8_Click(object sender, EventArgs e) => IngresarDigito("8");
        private void btn_num9_Click(object sender, EventArgs e) => IngresarDigito("9");

        private void btn_punto_Click(object sender, EventArgs e)
        {
            if (errorActivo) ResetearEstado();
            if (esperandoSegundoNumero) { txt_resultado.Text = "0."; esperandoSegundoNumero = false; return; }
            if (!txt_resultado.Text.Contains("."))
                txt_resultado.Text += ".";
        }

        // ─── Operaciones básicas ────

        private void SeleccionarOperacion(string operacion)
        {
            if (errorActivo) return;

            // Si ya hay una operación pendiente y el usuario ingresó el 2do número,
            // calculamos primero (encadenamiento de operaciones)
            if (!esperandoSegundoNumero && signo != "")
                EjecutarCalculo(encadenado: true);

            num1 = ObtenerNumeroActual();
            signo = operacion;
            lbl_expresion.Text = $"{FormatearNumero(num1)} {signo}";
            esperandoSegundoNumero = true;
        }

        private void btn_suma_Click(object sender, EventArgs e) => SeleccionarOperacion("+");
        private void btn_resta_Click(object sender, EventArgs e) => SeleccionarOperacion("−");
        private void btn_multiplicacion_Click(object sender, EventArgs e) => SeleccionarOperacion("×");
        private void btn_division_Click(object sender, EventArgs e) => SeleccionarOperacion("÷");

        // ─── Igual ───

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (signo == "" || esperandoSegundoNumero) return;
            EjecutarCalculo(encadenado: false);
        }

        private void EjecutarCalculo(bool encadenado)
        {
            num2 = ObtenerNumeroActual();
            double resultado = 0;
            bool valido = true;

            switch (signo)
            {
                case "+": resultado = num1 + num2; break;
                case "−": resultado = num1 - num2; break;
                case "×": resultado = num1 * num2; break;
                case "÷":
                    if (num2 == 0) { MostrarError("No se puede dividir entre 0"); valido = false; }
                    else resultado = num1 / num2;
                    break;
            }

            if (!valido) return;

            string expresion = $"{FormatearNumero(num1)} {signo} {FormatearNumero(num2)} =";
            if (!encadenado)
            {
                AgregarAlHistorial(expresion, resultado);
                lbl_expresion.Text = expresion;
            }

            txt_resultado.Text = FormatearNumero(resultado);
            num1 = resultado;
            esperandoSegundoNumero = encadenado;
            if (!encadenado) signo = "";
        }

        // ─── Operaciones avanzadas ───

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            double valor = ObtenerNumeroActual();
            if (valor < 0) { MostrarError("No existe raíz de número negativo"); return; }
            double resultado = Math.Sqrt(valor);
            string expresion = $"√({FormatearNumero(valor)})";
            AgregarAlHistorial(expresion, resultado);
            lbl_expresion.Text = expresion + " =";
            txt_resultado.Text = FormatearNumero(resultado);
            esperandoSegundoNumero = true;
            signo = "";
        }

        private void btn_cuadrado_Click(object sender, EventArgs e)
        {
            double valor = ObtenerNumeroActual();
            double resultado = valor * valor;
            string expresion = $"{FormatearNumero(valor)}²";
            AgregarAlHistorial(expresion, resultado);
            lbl_expresion.Text = expresion + " =";
            txt_resultado.Text = FormatearNumero(resultado);
            esperandoSegundoNumero = true;
            signo = "";
        }

        private void btn_inverso_Click(object sender, EventArgs e)
        {
            double valor = ObtenerNumeroActual();
            if (valor == 0) { MostrarError("No se puede dividir entre 0"); return; }
            double resultado = 1 / valor;
            string expresion = $"1/{FormatearNumero(valor)}";
            AgregarAlHistorial(expresion, resultado);
            lbl_expresion.Text = expresion + " =";
            txt_resultado.Text = FormatearNumero(resultado);
            esperandoSegundoNumero = true;
            signo = "";
        }

        private void btn_porcentaje_Click(object sender, EventArgs e)
        {
            double valor = ObtenerNumeroActual();
            double resultado = signo != "" ? num1 * valor / 100 : valor / 100;
            txt_resultado.Text = FormatearNumero(resultado);
            esperandoSegundoNumero = false;
        }

        private void btn_signo_Click(object sender, EventArgs e)
        {
            double valor = ObtenerNumeroActual();
            txt_resultado.Text = FormatearNumero(-valor);
        }

        // ─── Reset ───

        private void btn_reset_Click(object sender, EventArgs e) => ResetearEstado();

        private void ResetearEstado()
        {
            num1 = 0; num2 = 0; signo = "";
            esperandoSegundoNumero = false;
            errorActivo = false;
            txt_resultado.Text = "0";
            lbl_expresion.Text = "";
        }

        // ─── Historial ───

        private void AgregarAlHistorial(string expresion, double resultado)
        {
            string entrada = $"{expresion} = {FormatearNumero(resultado)}";
            lst_historial.Items.Insert(0, entrada);

            // Limitar el historial a 50 entradas
            if (lst_historial.Items.Count > 50)
                lst_historial.Items.RemoveAt(lst_historial.Items.Count - 1);
        }

        private void lst_historial_DoubleClick(object sender, EventArgs e)
        {
            if (lst_historial.SelectedItem == null) return;
            string entrada = lst_historial.SelectedItem.ToString();
            // Extrae el resultado que está después del último "= "
            int idx = entrada.LastIndexOf("= ");
            if (idx < 0) return;
            string valorStr = entrada.Substring(idx + 2).Trim();
            if (double.TryParse(valorStr, out double val))
            {
                txt_resultado.Text = FormatearNumero(val);
                esperandoSegundoNumero = false;
            }
        }

        private void btn_limpiarHistorial_Click(object sender, EventArgs e)
        {
            lst_historial.Items.Clear();
        }

        // ─── Helpers ───

        private double ObtenerNumeroActual()
        {
            return double.TryParse(txt_resultado.Text, out double v) ? v : 0;
        }

        private string FormatearNumero(double n)
        {
            // Evitar notación científica para números razonables y elimina ceros innecesarios
            return (n == Math.Floor(n) && Math.Abs(n) < 1e15)
                ? ((long)n).ToString()
                : n.ToString("G10");
        }

        private void MostrarError(string mensaje)
        {
            txt_resultado.Text = "Error";
            lbl_expresion.Text = mensaje;
            errorActivo = true;
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}