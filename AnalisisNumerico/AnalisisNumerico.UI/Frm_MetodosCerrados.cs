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
    public partial class Frm_MetodosCerrados : Form
    {
        private IMetodosRaices MetodosRaices;
        public Frm_MetodosCerrados(IMetodosRaices metodosRaices)
        {
            InitializeComponent();
            MetodosRaices = metodosRaices;
            txt_Funcion.Text = "F(x)= ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posX = 0;
        int posY = 0;

        private void Frm_MetodosCerrados_MouseMove(object sender, MouseEventArgs e)
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
            ParametrosCerrados parametros = new ParametrosCerrados();
            parametros.Funcion = txt_Funcion.Text;
            parametros.Iteraciones = Convert.ToInt32(txt_Iteraciones.Text);
            parametros.Tolerancia = Convert.ToDouble(txt_Tolerancia.Text);
            parametros.Xi = Convert.ToDouble(txt_ValorXi.Text);
            parametros.Xd = Convert.ToDouble(txt_ValorXd.Text);
            if (lbl_NombreMetodo.Text == "Biseccion")
            {
                parametros.Biseccion = true;
            }
            else
            {
                parametros.Biseccion = false;
            }

            // .text para obtener valores, .tostring() para escribir sobre el txtbox
            try
            {
                var Resultado = this.MetodosRaices.MetodoBiseccion(parametros);
                txt_Raiz.Text = Resultado.Raiz.ToString();
                txt_IteracionesActual.Text = Resultado.Iteraciones.ToString();
                if (Resultado.ErrorRelativo != Double.MaxValue)
                {
                    txt_Error.Text = Resultado.ErrorRelativo.ToString();
                }
                else
                {
                    txt_Error.Text = "No es posible calcular";
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ingrese nuevos parametros");
                txt_ValorXd.Text = string.Empty;
                txt_ValorXi.Text = string.Empty;
            }
        }

        internal void Show(string metodo)
        {
            lbl_NombreMetodo.Text = metodo;
            this.Show();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Raiz.Text = string.Empty;
            txt_IteracionesActual.Text = string.Empty;
            txt_Error.Text = string.Empty;
            txt_Funcion.Text = string.Empty;
            txt_Iteraciones.Text = string.Empty;
            txt_Tolerancia.Text = string.Empty;
            txt_ValorXd.Text = string.Empty;
            txt_ValorXi.Text = string.Empty;
        }
    }
}
