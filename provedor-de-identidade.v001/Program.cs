using provedor_de_identidade.v001.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace provedor_de_identidade.v001
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UILogin());
            // Application.Run(new UIAplicacao());
            //  Application.Run(new UIDashboard());
            //Application.Run(new UIPrincipal());

        }
    }
}
