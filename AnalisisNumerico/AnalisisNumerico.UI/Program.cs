using System;
using SimpleInjector;
using System.Windows.Forms;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using AnalisisNumerico.UI.Gauss_Jordan;
using AnalisisNumerico.UI.Gauss_Seidel;
using AnalisisNumerico.Entidades.Regresion;
using AnalisisNumerico.UI.Regresion;
using AnalisisNumerico.Entidades.Ecuaciones;
using AnalisisNumerico.Entidades.IntegracionNumerica;
using AnalisisNumerico.UI.Integracion_Numerica;

namespace AnalisisNumerico.UI
{
    static class Program
    {
        internal static Container container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<Frm_Inicio>());
        }

        private static void Bootstrap()
        {
            container = new Container();
            container.Register<IMetodosRaices, MetodosRaices>();
            container.Register<IEcuaciones, MetodosEcuaciones>();
            container.Register<IRegresion, MetodosRegresion>();
            container.Register<IIntegracionNumerica, MetodosIntegracionNumerica>();
            container.Register<IUtilidad, Utilidad>();
            container.Register<Frm_ParametrosGaussJordan>();
            container.Register<Frm_Inicio>();
            container.Register<Frm_MetodosCompuesto>();
            container.Register<Frm_MetodosSimple>();
            container.Register<Frm_ParametroGaussSeidel>();
            container.Register<Frm_MinimosCuadrados>();
            container.Register<Frm_IntegracionNumerica>();
        }
    }
}