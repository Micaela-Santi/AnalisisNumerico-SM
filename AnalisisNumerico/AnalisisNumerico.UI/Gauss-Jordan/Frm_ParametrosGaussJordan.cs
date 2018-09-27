using System;
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
        private TextBox[,] ResultadoMat;

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
            int TamañoText = ((Grilla_Mat.Width / Columna));

            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Matriz[x, y] = new TextBox();
                    Matriz[x, y].Text = string.Empty;
                    Matriz[x, y].Top = (x * Matriz[x, y].Height) + 20;
                    Matriz[x, y].Left = y * TamañoText;
                    Matriz[x, y].Width = TamañoText - 1;
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
            Grilla_Res.Controls.Clear();
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
            ParametroGaussJordan parametro = new ParametroGaussJordan(filas, columnas)
            {
                NumeroIncognitas = incognitas,
            };

            for (int i = 0; i < filas; i++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    parametro.Matriz[i, c] = Convert.ToDecimal(Matriz[i, c].Text);
                }
            }

            try
            {
                var resultado = MetodoEcuaciones.GaussJordan(parametro);
                MostrarResultado(resultado);
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void MostrarResultado(ResultadoEcuacionesGaussJordan resultado)
        {

            int Columna = resultado.Solucion.Count;

            ResultadoMat = new TextBox[2, Columna];

            int TamañoText = Grilla_Res.Width / Columna;


            for (int y = 0; y < ResultadoMat.GetLength(1); y++)
            {
                for (int x = 0; x < ResultadoMat.GetLength(0); x++)
                {
                    ResultadoMat[x, y] = new TextBox();

                    if (x == 0)
                    {
                        ResultadoMat[x, y].Text = resultado.Solucion[y].Nombre;
                    }
                    else
                    {
                        ResultadoMat[x, y].Text = resultado.Solucion[y].Valor.ToString("0.0000");
                    }

                    ResultadoMat[x, y].Top = (x * Matriz[x, y].Height) + 20;
                    ResultadoMat[x, y].Left = y * TamañoText;
                    ResultadoMat[x, y].Width = TamañoText - 2;
                    Grilla_Res.Controls.Add(ResultadoMat[x, y]);
                }

            }

        }

        int posX = 0;
        int posY = 0;

        private void Frm_ParametrosGaussJordan_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}

