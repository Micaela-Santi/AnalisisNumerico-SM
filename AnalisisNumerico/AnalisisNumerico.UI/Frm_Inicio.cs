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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metodoDeLaBiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodosCerrados>();
            string metodo = "Biseccion";
            form.Show(metodo);
        }

        private void reglaFalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodosCerrados>();
            string metodo = "Regla Falsa";
            form.Show(metodo);
        }

        private void newtonRapshonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.container.GetInstance<Frm_MetodosAbiertos>();
            form.Show();
        }
    }
}
