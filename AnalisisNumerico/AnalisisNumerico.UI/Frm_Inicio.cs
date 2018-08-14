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

namespace AnalisisNumerico.UI
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
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

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { 

            Frm_MetodoBiseccion Abrir = new Frm_MetodoBiseccion();
            Abrir.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metodoDeLaBiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodoBiseccion>();
            form.Show();
        }

        private void metodoDeLaBiseccionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
