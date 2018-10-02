using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class Frm_Determinante : Form
    {
        public Frm_Determinante()
        {
            InitializeComponent();
        }

        private TextBox[,] Matriz;
        private TextBox[,] ResultadoMat;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btn_Limpiar_Click(object sender, EventArgs e)
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

        int posX = 0;
        int posY = 0;

        private void Frm_Determinante_MouseMove(object sender, MouseEventArgs e)
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
