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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posX = 0;
        int posY = 0;

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

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroRegresionLineal parametro = new ParametroRegresionLineal();
                for (int i = 0; i < Convert.ToInt16(txt_CantidadPuntos.Text); i++)
                {
                    parametro.ValoresX.Add(Convert.ToDecimal(Matriz[i,0].Text));
                    parametro.ValoresY.Add(Convert.ToDecimal(Matriz[i, 1].Text));
                }

                var resultado = MetodoRegresion.MetodoMinimosCuadrados(parametro);
                txt_Pendiente.Text = resultado[0].ToString("0.000000");
                txt_Ordenada.Text = resultado[1].ToString("0.000000");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
        } 
    }
}
