using AnalisisNumerico.UI.Gauss_Jordan;
using AnalisisNumerico.UI.Gauss_Seidel;
using AnalisisNumerico.UI.Teoria;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metodoDeLaBiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodosCompuesto>();
            Frm_MetodosCompuesto.EMetodo metodo = Frm_MetodosCompuesto.EMetodo.Biseccion;
            form.Show(metodo);
        }

        private void reglaFalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodosCompuesto>();
            Frm_MetodosCompuesto.EMetodo metodo = Frm_MetodosCompuesto.EMetodo.ReglaFalsa;
            form.Show(metodo);
        }

        private void newtonRapshonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodosSimple>();
            form.Show();
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodosCompuesto>();
            Frm_MetodosCompuesto.EMetodo metodo = Frm_MetodosCompuesto.EMetodo.Secante;
            form.Show(metodo);
        }


        private void gaussJordanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_ParametrosGaussJordan>();
            form.Show();
        }

        int posX = 0;
        int posY = 0;

        private void Frm_Inicio_MouseMove(object sender, MouseEventArgs e)
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

        private void unidad1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var form = Program.container.GetInstance<Frm_Unidad1>();
            form.Show();
          
        }

        private void gaussSeidelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_ParametroGaussSeidel>();
            form.Show();
        }
    }
}
