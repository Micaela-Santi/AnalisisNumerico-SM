using AnalisisNumerico.Entidades.Regresion;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI.Regresion
{
    public partial class Frm_MinimosCuadrados : Form
    {
        private IRegresion MetodoRegresion;

        public Frm_MinimosCuadrados(IRegresion regresion)
        {
            InitializeComponent();
            MetodoRegresion = regresion;
        }

        private TextBox[,] Matriz;

        private void Graficar()
        {

            int incognitas;

            Grilla_PuntosMC.Controls.Clear();

            if (!int.TryParse(txt_CantidadPuntos.Text, out incognitas))
            {
                MessageBox.Show("El numero de incognitas es nula.", "Error");

                return;
            }

            int Columna = 2;
            int Fila = incognitas;
            Matriz = new TextBox[Fila, Columna];
            int TamañoText = ((Grilla_PuntosMC.Width / Columna));

            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Matriz[x, y] = new TextBox();
                    Matriz[x, y].Text = string.Empty;
                    Matriz[x, y].Top = (x * Matriz[x, y].Height) + 20;
                    Matriz[x, y].Left = y * TamañoText;
                    Matriz[x, y].Width = TamañoText - 1;
                    Grilla_PuntosMC.Controls.Add(Matriz[x, y]);
                }
            }
        }

        private void btn_Graficar_Click_1(object sender, EventArgs e)
        {
            this.Graficar();
        }
        private void txt_NumeroIncognitas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Graficar();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Grilla_PuntosMC.Controls.Clear();
            txt_CantidadPuntos.Text = string.Empty;
            Grilla_Res.Controls.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posX = 0;
        int posY = 0;
        private TextBox[,] ResultadoMat;

        private void Frm_MinimosCuadrados_MouseMove(object sender, MouseEventArgs e)
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

        private void btn_RegresionLineal_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroRegresion parametro = new ParametroRegresion();
                for (int i = 0; i < Convert.ToInt16(txt_CantidadPuntos.Text); i++)
                {
                    parametro.ValoresX.Add(Convert.ToDouble(Matriz[i, 0].Text));
                    parametro.ValoresY.Add(Convert.ToDouble(Matriz[i, 1].Text));
                }

                var resultado = MetodoRegresion.MetodoRegresionLineal(parametro);
                MostrarResultado(resultado);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MostrarResultado(ResultadoRegresion resultado)
        {
            Grilla_Res.Controls.Clear();

            int Columna = 2;

            ResultadoMat = new TextBox[resultado.Resultado.Count, Columna];
            int TamañoText = Grilla_Res.Width / Columna;

            for (int y = 0; y < Columna; y++)
            {
                for (int x = 0; x < resultado.Resultado.Count; x++)
                {
                    ResultadoMat[x, y] = new TextBox();
                    if (y == 1 )
                    {
                        ResultadoMat[x, y].Text = resultado.Resultado[x].ToString("0.0000");
                    }
                    else
                    {
                        if (resultado.Resultado.Count == 1)
                        {
                            ResultadoMat[x, y].Text = "F(x)";
                        }
                        else
                        {
                            ResultadoMat[x, y].Text = "A" + x;
                        }
                    }
                    
                    ResultadoMat[x, y].Top = (x * Matriz[x, y].Height) + 20;
                    ResultadoMat[x, y].Left = y * TamañoText;
                    ResultadoMat[x, y].Width = TamañoText - 2;
                    Grilla_Res.Controls.Add(ResultadoMat[x, y]);
                }
            }

            txt_Coeficiente.Text = resultado.CoeficienteCorrelacion.ToString();
        }

        private void btn_RegresionPolinomial_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroRegresion parametro = new ParametroRegresion();
                for (int i = 0; i < Convert.ToInt16(txt_CantidadPuntos.Text); i++)
                {
                    parametro.ValoresX.Add(Convert.ToDouble(Matriz[i, 0].Text));
                    parametro.ValoresY.Add(Convert.ToDouble(Matriz[i, 1].Text));
                }

                var resultado = MetodoRegresion.MetodoPolinomial(parametro,Convert.ToInt32(Txt_Grado.Text));
                MostrarResultado(resultado);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_Lagrange_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroRegresion parametro = new ParametroRegresion();
                for (int i = 0; i < Convert.ToInt16(txt_CantidadPuntos.Text); i++)
                {
                    parametro.ValoresX.Add(Convert.ToDouble(Matriz[i, 0].Text));
                    parametro.ValoresY.Add(Convert.ToDouble(Matriz[i, 1].Text));
                }

                var resultado = MetodoRegresion.MetodoLagrange(parametro, Convert.ToInt32(txt_ValorX.Text));
                MostrarResultado(resultado);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
