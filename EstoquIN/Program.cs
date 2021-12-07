using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoquIN.View;

namespace EstoquIN
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            //delegate the ThreadException event to a local method
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }
        //all the exception will be catched and handled in this delegated method.
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //log you error
            Console.WriteLine(e.Exception.Message);
        }
    }
}
