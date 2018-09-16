using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.UI.Gauss_Jordan
{
    public partial class Frm_ParametrosGaussJordan : Form
    {
        public Frm_ParametrosGaussJordan()
        {
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

            incognitas = incognitas + 1;
            Matriz = new TextBox[incognitas, incognitas];
            int TamañoText = Grilla_Mat.Width / incognitas;

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
    }
}

