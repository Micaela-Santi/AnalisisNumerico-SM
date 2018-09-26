using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.UI.Gauss_Seidel
{
    public partial class Frm_ParametroGaussSeidel : Form
    {
        public Frm_ParametroGaussSeidel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Grilla_Mat.Controls.Clear();
            Grilla_Res.Controls.Clear();
            txt_NumeroIncognitas.Text = string.Empty;
        }

        int posX = 0;
        int posY = 0;

        private void Frm_ParametroGaussSeidel_MouseMove(object sender, MouseEventArgs e)
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
