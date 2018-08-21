using System;
using System.Collections.Generic;
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
        internal static Container container;

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
            container = new Container();
            container.Register<IMetodosRaices,MetodosRaicesCerrados>();
            container.Register<Frm_Inicio>();
            container.Register<Frm_MetodosCerrados>();
        } 
    }
}
