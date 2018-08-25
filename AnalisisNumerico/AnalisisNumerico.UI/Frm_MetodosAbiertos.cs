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
    public partial class Frm_MetodosAbiertos : Form
    {

        private IMetodosRaices MetodosRaices;

        public Frm_MetodosAbiertos(IMetodosRaices metodosRaices)
        {
            InitializeComponent();
            this.MetodosRaices = metodosRaices;
            txt_Funcion.Text = "F(x)=";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            ParametroSimple parametros = new ParametroSimple()
            {
                Xi = Convert.ToDouble(txt_ValorXi.Text),
                Tolerancia = Convert.ToDouble(txt_Tolerancia.Text),
                Iteraciones = Convert.ToInt32(txt_Iteraciones.Text),
                Funcion = txt_Funcion.Text
            };

            Resultado resultado;

            try
            {
                resultado = MetodosRaices.NewtonRaphson(parametros);
                txt_Error.Text = resultado.ErrorRelativo.ToString();
                txt_IteracionesActual.Text = resultado.Iteraciones.ToString();
                txt_Raiz.Text = resultado.Raiz.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("La recta TG no corta al eje X");
            }


        }

        int posX = 0;
        int posY = 0;

        private void Frm_MetodosAbiertos_MouseMove(object sender, MouseEventArgs e)
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
