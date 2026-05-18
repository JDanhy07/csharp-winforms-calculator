namespace Calculadora
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            // ── Controles ───
            this.pnl_calc = new System.Windows.Forms.Panel();
            this.pnl_display = new System.Windows.Forms.Panel();
            this.lbl_expresion = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.pnl_botones = new System.Windows.Forms.Panel();

            // Fila AC / +- / % / ÷
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_signo = new System.Windows.Forms.Button();
            this.btn_porcentaje = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();

            // Fila √ / x² / 1/x / ×
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_cuadrado = new System.Windows.Forms.Button();
            this.btn_inverso = new System.Windows.Forms.Button();
            this.btn_multiplicacion = new System.Windows.Forms.Button();

            // Fila 7 / 8 / 9 / −
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();

            // Fila 4 / 5 / 6 / +
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();

            // Fila 1 / 2 / 3 / = (span 2 filas)
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();

            // Fila 0 (ancho doble) / .
            this.btn_num0 = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();

            // Panel historial
            this.pnl_historial = new System.Windows.Forms.Panel();
            this.lbl_historial_titulo = new System.Windows.Forms.Label();
            this.lst_historial = new System.Windows.Forms.ListBox();
            this.btn_limpiarHistorial = new System.Windows.Forms.Button();

            this.pnl_calc.SuspendLayout();
            this.pnl_display.SuspendLayout();
            this.pnl_botones.SuspendLayout();
            this.pnl_historial.SuspendLayout();
            this.SuspendLayout();

            // ── Colores comunes ───
            System.Drawing.Color bgCalc = System.Drawing.Color.FromArgb(30, 30, 46);
            System.Drawing.Color bgDisplay = System.Drawing.Color.FromArgb(19, 19, 31);
            System.Drawing.Color bgNum = System.Drawing.Color.FromArgb(42, 42, 62);
            System.Drawing.Color bgOp = System.Drawing.Color.FromArgb(58, 58, 92);
            System.Drawing.Color bgFn = System.Drawing.Color.FromArgb(35, 55, 40);
            System.Drawing.Color bgAC = System.Drawing.Color.FromArgb(90, 40, 40);
            System.Drawing.Color bgEq = System.Drawing.Color.FromArgb(92, 77, 177);
            System.Drawing.Color fgNum = System.Drawing.Color.FromArgb(224, 224, 255);
            System.Drawing.Color fgOp = System.Drawing.Color.FromArgb(160, 160, 255);
            System.Drawing.Color fgFn = System.Drawing.Color.FromArgb(126, 200, 126);
            System.Drawing.Color fgAC = System.Drawing.Color.FromArgb(255, 128, 128);

            System.Drawing.Font fontBtn = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular);
            System.Drawing.Font fontBtnSm = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            // ── Form1 ───
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Text = "Calculadora";
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 35);
            this.MinimumSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.pnl_calc);
            this.Controls.Add(this.pnl_historial);
            this.Load += new System.EventHandler(this.Form1_Load);

            // ── pnl_calc (panel izquierdo de la calculadora) ───
            this.pnl_calc.BackColor = bgCalc;
            this.pnl_calc.Location = new System.Drawing.Point(12, 12);
            this.pnl_calc.Size = new System.Drawing.Size(348, 496);
            this.pnl_calc.Controls.Add(this.pnl_display);
            this.pnl_calc.Controls.Add(this.pnl_botones);
            this.pnl_calc.Anchor = System.Windows.Forms.AnchorStyles.Top
                                 | System.Windows.Forms.AnchorStyles.Left
                                 | System.Windows.Forms.AnchorStyles.Bottom;

            // ── pnl_display ───
            this.pnl_display.BackColor = bgDisplay;
            this.pnl_display.Location = new System.Drawing.Point(10, 10);
            this.pnl_display.Size = new System.Drawing.Size(328, 90);
            this.pnl_display.Controls.Add(this.lbl_expresion);
            this.pnl_display.Controls.Add(this.txt_resultado);

            this.lbl_expresion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_expresion.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            this.lbl_expresion.Location = new System.Drawing.Point(8, 6);
            this.lbl_expresion.Size = new System.Drawing.Size(310, 20);
            this.lbl_expresion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_expresion.Name = "lbl_expresion";

            this.txt_resultado.BackColor = bgDisplay;
            this.txt_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_resultado.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular);
            this.txt_resultado.ForeColor = System.Drawing.Color.White;
            this.txt_resultado.Location = new System.Drawing.Point(6, 28);
            this.txt_resultado.Size = new System.Drawing.Size(316, 54);
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_resultado.Name = "txt_resultado";

            // ── pnl_botones ───
            this.pnl_botones.BackColor = bgCalc;
            this.pnl_botones.Location = new System.Drawing.Point(10, 108);
            this.pnl_botones.Size = new System.Drawing.Size(328, 380);
            // TableLayoutPanel sería ideal, aquí usamos posicionamiento manual
            // para mantener compatibilidad directa con el diseñador existente.

            int bw = 74, bh = 58, gap = 6, startX = 0, startY = 0;

            System.Action<System.Windows.Forms.Button, string, int, int, int, int,
                System.Drawing.Color, System.Drawing.Color, System.Drawing.Font,
                System.EventHandler> cfg = (btn, txt, col, row, colSpan, rowSpan,
                bg, fg, fnt, handler) =>
                {
                    btn.Text = txt;
                    btn.BackColor = bg;
                    btn.ForeColor = fg;
                    btn.Font = fnt;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Location = new System.Drawing.Point(startX + col * (bw + gap),
                                                             startY + row * (bh + gap));
                    btn.Size = new System.Drawing.Size(bw * colSpan + gap * (colSpan - 1),
                                                            bh * rowSpan + gap * (rowSpan - 1));
                    btn.Cursor = System.Windows.Forms.Cursors.Hand;
                    btn.Click += handler;
                    this.pnl_botones.Controls.Add(btn);
                };

            // Fila 0
            cfg(btn_reset, "AC", 0, 0, 1, 1, bgAC, fgAC, fontBtn, new System.EventHandler(this.btn_reset_Click));
            cfg(btn_signo, "+/−", 1, 0, 1, 1, bgFn, fgFn, fontBtnSm, new System.EventHandler(this.btn_signo_Click));
            cfg(btn_porcentaje, "%", 2, 0, 1, 1, bgFn, fgFn, fontBtn, new System.EventHandler(this.btn_porcentaje_Click));
            cfg(btn_division, "÷", 3, 0, 1, 1, bgOp, fgOp, fontBtn, new System.EventHandler(this.btn_division_Click));

            // Fila 1
            cfg(btn_raiz, "√x", 0, 1, 1, 1, bgFn, fgFn, fontBtnSm, new System.EventHandler(this.btn_raiz_Click));
            cfg(btn_cuadrado, "x²", 1, 1, 1, 1, bgFn, fgFn, fontBtnSm, new System.EventHandler(this.btn_cuadrado_Click));
            cfg(btn_inverso, "1/x", 2, 1, 1, 1, bgFn, fgFn, fontBtnSm, new System.EventHandler(this.btn_inverso_Click));
            cfg(btn_multiplicacion, "×", 3, 1, 1, 1, bgOp, fgOp, fontBtn, new System.EventHandler(this.btn_multiplicacion_Click));

            // Fila 2
            cfg(btn_num7, "7", 0, 2, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num7_Click));
            cfg(btn_num8, "8", 1, 2, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num8_Click));
            cfg(btn_num9, "9", 2, 2, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num9_Click));
            cfg(btn_resta, "−", 3, 2, 1, 1, bgOp, fgOp, fontBtn, new System.EventHandler(this.btn_resta_Click));

            // Fila 3
            cfg(btn_num4, "4", 0, 3, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num4_Click));
            cfg(btn_num5, "5", 1, 3, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num5_Click));
            cfg(btn_num6, "6", 2, 3, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num6_Click));
            cfg(btn_suma, "+", 3, 3, 1, 1, bgOp, fgOp, fontBtn, new System.EventHandler(this.btn_suma_Click));

            // Fila 4 — el "=" ocupa 2 filas
            cfg(btn_num1, "1", 0, 4, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num1_Click));
            cfg(btn_num2, "2", 1, 4, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num2_Click));
            cfg(btn_num3, "3", 2, 4, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num3_Click));
            cfg(btn_calcular, "=", 3, 4, 1, 2, bgEq, System.Drawing.Color.White, fontBtn, new System.EventHandler(this.btn_calcular_Click));

            // Fila 5
            cfg(btn_num0, "0", 0, 5, 2, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_num0_Click));
            cfg(btn_punto, ".", 2, 5, 1, 1, bgNum, fgNum, fontBtn, new System.EventHandler(this.btn_punto_Click));

            // ── pnl_historial ───
            this.pnl_historial.BackColor = System.Drawing.Color.FromArgb(26, 26, 40);
            this.pnl_historial.Location = new System.Drawing.Point(372, 12);
            this.pnl_historial.Size = new System.Drawing.Size(376, 496);
            this.pnl_historial.Anchor = System.Windows.Forms.AnchorStyles.Top
                                         | System.Windows.Forms.AnchorStyles.Right
                                         | System.Windows.Forms.AnchorStyles.Bottom;
            this.pnl_historial.Controls.Add(this.lbl_historial_titulo);
            this.pnl_historial.Controls.Add(this.btn_limpiarHistorial);
            this.pnl_historial.Controls.Add(this.lst_historial);

            this.lbl_historial_titulo.Text = "Historial";
            this.lbl_historial_titulo.ForeColor = System.Drawing.Color.FromArgb(180, 180, 220);
            this.lbl_historial_titulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_historial_titulo.Location = new System.Drawing.Point(12, 12);
            this.lbl_historial_titulo.Size = new System.Drawing.Size(200, 26);
            this.lbl_historial_titulo.Name = "lbl_historial_titulo";

            this.btn_limpiarHistorial.Text = "Limpiar";
            this.btn_limpiarHistorial.ForeColor = System.Drawing.Color.FromArgb(200, 100, 100);
            this.btn_limpiarHistorial.BackColor = System.Drawing.Color.FromArgb(60, 35, 35);
            this.btn_limpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarHistorial.FlatAppearance.BorderSize = 0;
            this.btn_limpiarHistorial.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btn_limpiarHistorial.Location = new System.Drawing.Point(290, 12);
            this.btn_limpiarHistorial.Size = new System.Drawing.Size(74, 26);
            this.btn_limpiarHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarHistorial.Name = "btn_limpiarHistorial";
            this.btn_limpiarHistorial.Click += new System.EventHandler(this.btn_limpiarHistorial_Click);

            this.lst_historial.BackColor = System.Drawing.Color.FromArgb(22, 22, 35);
            this.lst_historial.ForeColor = System.Drawing.Color.FromArgb(200, 200, 230);
            this.lst_historial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_historial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lst_historial.Location = new System.Drawing.Point(0, 46);
            this.lst_historial.Size = new System.Drawing.Size(376, 450);
            this.lst_historial.Name = "lst_historial";
            this.lst_historial.ScrollAlwaysVisible = false;
            this.lst_historial.DoubleClick += new System.EventHandler(this.lst_historial_DoubleClick);

            this.pnl_calc.ResumeLayout(false);
            this.pnl_display.ResumeLayout(false);
            this.pnl_botones.ResumeLayout(false);
            this.pnl_historial.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Declaraciones de controles ───
        private System.Windows.Forms.Panel pnl_calc;
        private System.Windows.Forms.Panel pnl_display;
        private System.Windows.Forms.Label lbl_expresion;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Panel pnl_botones;

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_signo;
        private System.Windows.Forms.Button btn_porcentaje;
        private System.Windows.Forms.Button btn_division;

        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.Button btn_cuadrado;
        private System.Windows.Forms.Button btn_inverso;
        private System.Windows.Forms.Button btn_multiplicacion;

        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_resta;

        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_suma;

        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_calcular;

        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Button btn_punto;

        private System.Windows.Forms.Panel pnl_historial;
        private System.Windows.Forms.Label lbl_historial_titulo;
        private System.Windows.Forms.ListBox lst_historial;
        private System.Windows.Forms.Button btn_limpiarHistorial;
    }
}