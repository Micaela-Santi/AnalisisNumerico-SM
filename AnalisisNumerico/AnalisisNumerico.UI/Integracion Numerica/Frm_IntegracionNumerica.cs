using AnalisisNumerico.Entidades.IntegracionNumerica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.UI.Integracion_Numerica
{
    public partial class Frm_IntegracionNumerica : Form
    {
        private readonly IIntegracionNumerica integracionNumerica;
        public Frm_IntegracionNumerica(IIntegracionNumerica integracionNumetica)
        {
            InitializeComponent();
            integracionNumerica = integracionNumetica;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TrapecioSimple_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroTrapecioSimple parametro = new ParametroTrapecioSimple
                {
                    Funcion = txt_Funcion.Text,
                    ValorA = Convert.ToDouble(txt_ValorA.Text),
                    ValorB = Convert.ToDouble(txt_ValorB.Text)
                };

                var resultado = integracionNumerica.MetodoDelTrapecioSimple(parametro);
                txt_Resultado.Text = resultado.Valor.ToString("0.000000");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);    
            }
        }

        private void btn_TrapercioMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroTrapecioMultiple parametro = new ParametroTrapecioMultiple
                {
                    Funcion = txt_Funcion.Text,
                    ValorA = Convert.ToDouble(txt_ValorA.Text),
                    ValorB = Convert.ToDouble(txt_ValorB.Text),
                    CantSubIntervalos = Convert.ToInt16(txt_CantIntervalos.Text)
                };

                var resultado = integracionNumerica.MetodoDelTrapecioMultiple(parametro);
                txt_Resultado.Text = resultado.Valor.ToString("0.000000");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_SimpsonUnTercio_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroSimpsonUnTercio parametro = new ParametroSimpsonUnTercio
                {
                    Funcion = txt_Funcion.Text,
                    ValorA = Convert.ToDouble(txt_ValorA.Text),
                    ValorB = Convert.ToDouble(txt_ValorB.Text)
                };
                var resultado = integracionNumerica.SimpsonUnTercio(parametro);
                txt_Resultado.Text = resultado.Valor.ToString("0.000000");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_SimpsonUnTercioMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                ParametroSimpsonUnTercioMultiple parametro = new ParametroSimpsonUnTercioMultiple
                {
                    Funcion = txt_Funcion.Text,
                    CantIntervalos = Convert.ToInt32(txt_CantIntervalos.Text),
                    ValorA = Convert.ToDouble(txt_ValorA.Text),
                    ValorB = Convert.ToDouble(txt_ValorB.Text)
                };
                var resultado = integracionNumerica.SimpsonUnTercioMultiple(parametro);
                txt_Resultado.Text = resultado.Valor.ToString("0.000000");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
