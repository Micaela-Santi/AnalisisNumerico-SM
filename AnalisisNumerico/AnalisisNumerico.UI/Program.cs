using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using SimpleInjector;


namespace AnalisisNumerico.UI
{
    static class Program
    {
        private static SimpleInjector.Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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
            container = new SimpleInjector.Container();
            container.Register<IMetodosRaices,MetodosRaices>();
            container.Register<Frm_Inicio>();
        }
        
    }
}
