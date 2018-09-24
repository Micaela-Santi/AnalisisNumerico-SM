using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Entidades.Ecuaciones;

namespace AnalisisNumerico.UI.Gauss_Jordan
{
    public partial class Frm_ParametrosGaussJordan : Form
    {
        private IEcuaciones MetodoEcuaciones;

        public Frm_ParametrosGaussJordan(IEcuaciones ecuaciones)
        {
            MetodoEcuaciones = ecuaciones;
            InitializeComponent();
        }
        private TextBox[,] Matriz;

        private void Graficar()
        {

            int incognitas;

            Grilla_Mat.Controls.Clear();

            if (!int.TryParse(txt_NumeroIncognitas.Text, out incognitas))
            {
                MessageBox.Show("El numero de incognitas es nula.", "Error");
                return;
            }

            int Columna = incognitas + 1;
            int Fila = incognitas;
            Matriz = new TextBox[Fila, Columna];
            int TamañoText = Grilla_Mat.Width / Columna;

            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {

                    Matriz[x, y] = new TextBox();
                    Matriz[x, y].Text = string.Empty;
                    Matriz[x, y].Top = (x * Matriz[x, y].Height) + 20;
                    Matriz[x, y].Left = y * TamañoText;
                    Matriz[x, y].Width = TamañoText + 6;
                    Grilla_Mat.Controls.Add(Matriz[x, y]);

                }
            }
        }

        private void btn_Graficar_Click(object sender, EventArgs e)
        {
            Graficar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Grilla_Mat.Controls.Clear();
            txt_NumeroIncognitas.Text = string.Empty;
        }

        private void txt_NumeroIncognitas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Graficar();
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            var incognitas = Convert.ToInt16(txt_NumeroIncognitas.Text);
            var filas = incognitas;
            var columnas = incognitas + 1;
            ParmetroGaussJordan parametro = new ParmetroGaussJordan(filas, columnas)
            {
                NumeroIncognitas = incognitas,
            };

            for (int i = 0; i < filas; i++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    parametro.Matriz[i, c] = Convert.ToDecimal(Matriz[i, c].Text);
                    Matriz[i, c].Text = string.Empty;
                }
            }

            var resultado = MetodoEcuaciones.GaussJordan(parametro);

            MostrarResultado(resultado);
        }

        private void MostrarResultado(ResultadoEcuaciones resultado)
        {
            int contador = 0;
            int Columnas = resultado.Solucion.Count;
            foreach (var item in resultado.Solucion)
            {
                Matriz[contador, contador].Text = "X" + (contador + 1);
                Matriz[contador, Columnas].Text = item.Valor.ToString("0.0000");
                contador += 1;
            }
        }
    }
}

