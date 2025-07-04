using System;
using System.Threading;
using System.Windows.Forms;

namespace VeW_Games_Tecnologia
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.Run(new MenuPrincipal());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(
                "Ocorreu um erro interno:\n" + e.Exception.Message,
                "Erro de Aplicação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
        }
    }
}
 